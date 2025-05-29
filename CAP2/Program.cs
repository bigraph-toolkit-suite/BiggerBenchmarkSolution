using System;
using System.IO;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;
using de.unika.ipd.grGen.graphViewerAndSequenceDebugger;
using de.unika.ipd.grGen.Action_ruleset;
using de.unika.ipd.grGen.Model_metamodel_graph;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Linq;
using btsLib;

namespace MyApplication
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bigraph Rewriting with libGr");
            string basePath = AppContext.BaseDirectory;
            string statesPath = Path.Combine(basePath, "states");
            // Ensure the "states" directory exists
            Directory.CreateDirectory(statesPath);
            Console.WriteLine("Base directory = " + basePath);
            Console.WriteLine("States directory = " + statesPath);

            // Create the LibGr Search Plan backend we want to use
            LGSPBackend backend = LGSPBackend.Instance;
            // Grap processing environment (initial state + actions)
            LGSPGraphProcessingEnvironment procEnv;
            // Graph model
            LGSPNamedGraph graph = new LGSPNamedGraph(new metamodel_graphGraphModel(), new LGSPGlobalVariables(), 0);
            // Superclass of rulesetActions
            LGSPActions actions = new rulesetActions(graph);


            IActions actionsTmp; // is not used further but needed to import the graph
            INamedGraph importedNamedGraph = (INamedGraph)Porter.Import(basePath + "initial_graph.grs", backend, new metamodel_graphGraphModel(), out actionsTmp);

            // For Debugging. Inspect with: `ycomp initial_state.vcg` 
            using (VCGDumper dumper = new VCGDumper(basePath + "initial_state.vcg"))
                GraphDumper.Dump((INamedGraph)importedNamedGraph, dumper);

            // lgspgraph = new LGSPGraph((LGSPNamedGraph)importedNamedGraph, "unnamed"); // refer to GrGen.NET documentation wrt named-unnamed
            graph = (LGSPNamedGraph)importedNamedGraph;
            // Creating Graph Processing Environment with the imported graph
            procEnv = new LGSPGraphProcessingEnvironment(graph, actions);
            Console.WriteLine("LGSPGraphProcessingEnvironment created.");
            // Loading Rules from filesystem
            Console.WriteLine("Actions:");
            string[] allRules = new string[actions.Actions.Count()];
            int rIx = 0;
            foreach (IAction each in actions.Actions)
            {
                Console.WriteLine("- " + each.Name + " (" + each + ")");
                allRules[rIx++] = each.Name;
            }


            // GraphViewer graphViewer = new GraphViewer();
            // graphViewer.ShowGraph(importedNamedGraph, GraphViewerTypes.YComp, "Organic", null); // Let yComp observe any changes to the graph


            // ///////////////////////////////////////////////////////////////////////////////
            // Start time measurement
            procEnv.PerformanceInfo.Start();
            int gIx = 0;
            Queue<LGSPNamedGraph> workQueue = new Queue<LGSPNamedGraph>();
            // HashSet<LGSPNamedGraph> transitionSystem = new HashSet<LGSPNamedGraph>();
            // Add initial graph to work queue
            workQueue.Enqueue(graph);
            ReactionGraph reactionGraph = new ReactionGraph();
            exportGraphToVCG(graph, statesPath + "/state_" + gIx + ".vcg");
            gIx++;
            // reactionGraph.AddNode(graph);
            // Breadth-First Search (BFS) loop
            while (workQueue.Count > 0)
            {
                Console.WriteLine("workQueue = " + workQueue.Count);
                LGSPNamedGraph currentGraph = workQueue.Dequeue();
                LGSPNamedGraph currentGraphUntouched = (LGSPNamedGraph)currentGraph.CloneAndAssignNames();
                // exportGraphToVCG((LGSPNamedGraph)_procEnv.graph, statesPath + "/state_" + gIx + ".vcg");
                // gIx++;

                List<MatchResult> reactionResults = new List<MatchResult>();

                foreach (string ruleName in allRules)
                {
                    IAction currentRule = actions.GetAction(ruleName);
                    LGSPGraphProcessingEnvironment _procEnv = new LGSPGraphProcessingEnvironment(currentGraph, actions);


                    // (Variant A)
                    IMatches matches = _procEnv.Match(currentRule, new object[] {}, -1, false, new List<FilterCall>(), true);
                    Console.WriteLine("Matches Found (Rule = " + ruleName + "): " + matches.Count);
                    int mIX = 0;
                    foreach (IMatch match in matches)
                    {
                        LGSPNamedGraph currentGraphCopy = (LGSPNamedGraph)currentGraph.CloneAndAssignNames();
                        LGSPGraphProcessingEnvironment _procEnv0 = new LGSPGraphProcessingEnvironment(currentGraphCopy, actions);
                        IMatches matches0 = currentRule.Match(_procEnv0, matches.Count, null);
                        // matches0.ToList().RemoveAll(m => m != match);
                        // Console.WriteLine("matches0 = " + matches0.Count);
                        currentRule.Modify(_procEnv0, matches0.ToList()[mIX]);
                        LGSPNamedGraph newBigraph = (LGSPNamedGraph)_procEnv0.graph.CloneAndAssignNames();
                        // corresponds to: reactionResults.Add(new MatchResult(newBigraph, ruleName, match, newBigraph.Canonize()));
                        reactionResults.Add(new MatchResult(newBigraph, ruleName, matches0.ToList()[mIX], newBigraph.Canonize()));

                        mIX++;
                    }
                }
                Console.WriteLine("reactionResults = " + reactionResults.Count);
                foreach (MatchResult matchResult in reactionResults)
                {
                    // Step 4: Check if the new bigraph is already in the reaction graph
                    if (!reactionGraph.Contains(matchResult.CanonicalForm))
                    {
                        Console.WriteLine("Graph NOT exists");
                        // If it exists, add an edge from w to newBigraph with the label as match
                        // reactionGraph.AddNode(matchResult.RewrittenGraph);
                        reactionGraph.AddEdge(currentGraphUntouched, matchResult.RewrittenGraph, matchResult.Match, matchResult.ReactionRule);
                        workQueue.Enqueue((LGSPNamedGraph)matchResult.RewrittenGraph);
                        exportGraphToVCG((LGSPNamedGraph)matchResult.RewrittenGraph, statesPath + "/state_" + gIx + ".vcg");
                        Porter.Export((LGSPNamedGraph)matchResult.RewrittenGraph, new List<string>() { statesPath + "/state_" + gIx + ".grs" });
                        //Console.WriteLine("State written = " + gIx);
                        gIx++;
                    }
                    else
                    {
                        Console.WriteLine("Graph exists");
                        reactionGraph.AddEdge(currentGraphUntouched, matchResult.RewrittenGraph, matchResult.Match, matchResult.ReactionRule);
                        // exportGraphToVCG((LGSPNamedGraph)matchResult.RewrittenGraph, statesPath + "/state_" + gIx + ".vcg");
                        // gIx++;
                    }
                }
            }


            Console.WriteLine("Edges = " + reactionGraph.EdgeCount);
            Console.WriteLine("Nodes = " + reactionGraph.NodeCount);
            string dotGraph = reactionGraph.ToDot();
            //Console.WriteLine(dotGraph);
            // For rendering try:
            // $ dot -Tpng reaction_graph.dot -o reaction_graph.png
            // Open DOT file with Gephi
            System.IO.File.WriteAllText(basePath + "reaction_graph.dot", dotGraph);
            // ///////////////////////////////////////////////////////////////////////////////

        }

        /// Export
        /// VCG for yComp
        static void exportGraphToVCG(LGSPGraph finalGraph, string fileName)
        {

            using (VCGDumper dumper = new VCGDumper(fileName))
            {
                GraphDumper.Dump((de.unika.ipd.grGen.libGr.INamedGraph)finalGraph, dumper);
            }
        }
    }
}
