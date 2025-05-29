namespace btsLib;

using System;
using System.IO;
// using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;
// using de.unika.ipd.grGen.graphViewerAndSequenceDebugger;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Linq;

// ///////////////////////////////////////////////////////////////////////////////
// Data Structures for Model Checking Procedure
// ///////////////////////////////////////////////////////////////////////////////

public class ReactionGraph
{
    private Dictionary<string, IGraph> bigraphMap = new Dictionary<string, IGraph>();
    private List<Edge> edges = new List<Edge>();
    private List<IGraph> nodes = new List<IGraph>();
    private Dictionary<IGraph, string> labelMap = new Dictionary<IGraph, string>(); // Maps canonical forms to simple labels
    private int labelCounter = 0; // Counter for generating simple labels


    // Get the number of nodes in the reaction graph
    public int NodeCount
    {
        get { return bigraphMap.Count; }
    }

    // Get the number of edges in the reaction graph
    public int EdgeCount
    {
        get { return edges.Count; }
    }

    // public void AddNode(IGraph bigraph)
    // {
    //     nodes.Add(bigraph);
    // }

    // Add a state and associate it with the canonical form
    public void AddNode(IGraph bigraph)
    {
        string canonicalForm = bigraph.Canonize(); // Canonical string representation of the bigraph
                                                   // Add the canonical form and the corresponding bigraph to the map
        if (!StateExists(canonicalForm))
        {
            bigraphMap[canonicalForm] = bigraph;
            nodes.Add(bigraph);

            string simpleLabel = $"s_{labelCounter}";
            // if (!labelMap.ContainsKey(canonicalForm))
            // {
            labelMap[bigraph] = simpleLabel;
            labelCounter++;
            // }
        }
    }

    // public void AddEdge(IGraph from, IGraph to, IMatch match, string ruleName)
    // {

    //     edges.Add(new Edge(from, to, match, ruleName));
    // }

    public void AddEdge(IGraph from, IGraph to, IMatch match, string ruleName)
    {

        string sourceCanonical = from.Canonize();
        string targetCanonical = to.Canonize();

        IGraph sourceNode, targetNode;
        // edges.Add(new Edge(from, to, match, ruleName));

        // Handle the source node: check if it exists or create it
        if (StateExists(sourceCanonical))
        {
            sourceNode = GetBigraph(sourceCanonical);
        }
        else
        {
            AddNode(from);
            sourceNode = from;
        }

        if (StateExists(targetCanonical))
        {
            targetNode = GetBigraph(targetCanonical);
        }
        else
        {
            AddNode(to);
            targetNode = to;
        }

        Edge e = GetEdgeWithLabel(sourceNode, targetNode, ruleName);
        if (e == null)
        {
            //Console.WriteLine("ADD EDGE from");
            //Console.WriteLine("sourceNode = " + sourceNode);
            //Console.WriteLine("targetNode = " + targetNode);
            //Console.WriteLine(sourceNode.Equals(targetNode));
            // Add the edge between source and target
            edges.Add(new Edge(sourceNode, targetNode, match, ruleName));
        }
    }

    // Check if a state (bigraph) already exists
    private bool StateExists(string canonicalForm)
    {
        return bigraphMap.ContainsKey(canonicalForm);
    }

    // Method to get all edges between a given source and target node
    public List<Edge> GetAllEdges(IGraph sourceNode, IGraph targetNode)
    {
        // Use LINQ to find all edges between sourceNode and targetNode
        return edges.Where(edge => edge.From == sourceNode && edge.To == targetNode).ToList();
    }

    // Method to get the first edge between source and target with a specific label
    public Edge GetEdgeWithLabel(IGraph sourceNode, IGraph targetNode, string reactionLbl)
    {
        // Retrieve all edges between source and target nodes
        var allEdges = GetAllEdges(sourceNode, targetNode);

        // Use LINQ to filter edges by label and return the first match (or null if not found)
        return allEdges.FirstOrDefault(edge => edge.RuleName.Equals(reactionLbl));
    }

    public bool Contains(IGraph bigraph)
    {
        string canonicalForm = bigraph.Canonize(); // Canonize the bigraph to get its string form

        // Check if the canonical form exists in the dictionary
        return bigraphMap.ContainsKey(canonicalForm);
    }

    public bool Contains(string canonicalForm)
    {
        // Check if the canonical form exists in the dictionary
        return bigraphMap.ContainsKey(canonicalForm);
    }

    public IGraph GetBigraph(string canonicalForm)
    {
        // Retrieve the bigraph associated with a canonical form
        return Contains(canonicalForm) ? bigraphMap[canonicalForm] : null;
    }

    public string ToDot()
    {
        var dotBuilder = new System.Text.StringBuilder();
        dotBuilder.AppendLine("digraph ReactionGraph {");

        // Create nodes in DOT format with simple labels
        foreach (var kvp in labelMap)
        {
            IGraph g = kvp.Key;
            string simpleLabel = labelMap[g];
            dotBuilder.AppendLine($"    \"{simpleLabel}\" [label=\"{simpleLabel}\"];");
        }

        // Create edges in DOT format
        foreach (var edge in edges)
        {
            // if (labelMap.ContainsKey(edge.From.Canonize()) && labelMap.ContainsKey(edge.To.Canonize()))
            // {
            string fromLabel = labelMap[edge.From];
            string toLabel = labelMap[edge.To];
            // string fromLabel = edge.From.Canonize();
            // string toLabel = edge.To.Canonize();
            // string matchLabel = edge.Match.ToString();
            string matchLabel = edge.RuleName;
            dotBuilder.AppendLine($"    \"{fromLabel}\" -> \"{toLabel}\" [label=\"{matchLabel}\"];");
            // }

        }

        dotBuilder.AppendLine("}");
        return dotBuilder.ToString();
    }
}

public class Edge
{
    public IGraph From { get; }
    public IGraph To { get; }
    public IMatch Match { get; }

    public string RuleName { get; }

    public Edge(IGraph from, IGraph to, IMatch match, string ruleName)
    {
        From = from;
        To = to;
        Match = match;
        RuleName = ruleName;
    }
}

public class MatchResult
{
    public string ReactionRule { get; }
    public IGraph RewrittenGraph { get; }
    public IMatch Match { get; }

    public string CanonicalForm { get; }

    public MatchResult(IGraph rewrittenGraph, string reactionRule, IMatch eachMatch, string canonicalForm)
    {
        RewrittenGraph = rewrittenGraph;
        ReactionRule = reactionRule;
        Match = eachMatch;
        CanonicalForm = canonicalForm;
    }
}
