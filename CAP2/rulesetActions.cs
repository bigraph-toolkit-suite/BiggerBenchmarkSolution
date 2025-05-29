// This file has been generated automatically by GrGen (www.grgen.net)
// Do not modify this file! Any changes will be lost!
// Generated from "./foo/ruleset.grg" on Wed May 28 21:58:35 CEST 2025

//#pragma warning disable CS0219, CS0162
#pragma warning disable 219, 162

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading;
using System.Diagnostics;
using GRGEN_LIBGR = de.unika.ipd.grGen.libGr;
using GRGEN_LGSP = de.unika.ipd.grGen.lgsp;
using GRGEN_EXPR = de.unika.ipd.grGen.expression;
using GRGEN_MODEL = de.unika.ipd.grGen.Model_metamodel_graph;
using GRGEN_ACTIONS = de.unika.ipd.grGen.Action_ruleset;

namespace de.unika.ipd.grGen.Action_ruleset
{
	public class Pattern_nac_NodesWithoutSites : GRGEN_LGSP.LGSPMatchingPattern
	{
		private static Pattern_nac_NodesWithoutSites instance = null;
		public static Pattern_nac_NodesWithoutSites Instance { get { if(instance==null) { instance = new Pattern_nac_NodesWithoutSites(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] nac_NodesWithoutSites_node_src_AllowedTypes = null;
		public static bool[] nac_NodesWithoutSites_node_src_IsAllowedType = null;
		public enum nac_NodesWithoutSites_NodeNums { @src, };
		public enum nac_NodesWithoutSites_EdgeNums { };
		public enum nac_NodesWithoutSites_VariableNums { @validChildCount, };
		public enum nac_NodesWithoutSites_SubNums { };
		public enum nac_NodesWithoutSites_AltNums { };
		public enum nac_NodesWithoutSites_IterNums { };



		public GRGEN_LGSP.PatternGraph pat_nac_NodesWithoutSites;

		public enum nac_NodesWithoutSites_neg_0_NodeNums { @src, };
		public enum nac_NodesWithoutSites_neg_0_EdgeNums { };
		public enum nac_NodesWithoutSites_neg_0_VariableNums { @validChildCount, };
		public enum nac_NodesWithoutSites_neg_0_SubNums { };
		public enum nac_NodesWithoutSites_neg_0_AltNums { };
		public enum nac_NodesWithoutSites_neg_0_IterNums { };


		public GRGEN_LGSP.PatternGraph nac_NodesWithoutSites_neg_0;


		private Pattern_nac_NodesWithoutSites()
			: base("nac_NodesWithoutSites",
				new GRGEN_LIBGR.GrGenType[] { GRGEN_MODEL.NodeType_BNode.typeVar, GRGEN_LIBGR.VarType.GetVarType(typeof(int)), },
				new string[] { "nac_NodesWithoutSites_node_src", "nac_NodesWithoutSites_var_validChildCount", },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { }
			)
		{
		}
		private void initialize()
		{
			bool[,] nac_NodesWithoutSites_isNodeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[,] nac_NodesWithoutSites_isEdgeHomomorphicGlobal = new bool[0, 0];
			bool[] nac_NodesWithoutSites_isNodeTotallyHomomorphic = new bool[1] { false,  };
			bool[] nac_NodesWithoutSites_isEdgeTotallyHomomorphic = new bool[0];
			GRGEN_LGSP.PatternVariable nac_NodesWithoutSites_var_validChildCount = new GRGEN_LGSP.PatternVariable(GRGEN_LIBGR.VarType.GetVarType(typeof(int)), "nac_NodesWithoutSites_var_validChildCount", "validChildCount", 1, false,  null);
			GRGEN_LGSP.PatternNode nac_NodesWithoutSites_node_src = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@BNode, GRGEN_MODEL.NodeType_BNode.typeVar, "GRGEN_MODEL.IBNode", "nac_NodesWithoutSites_node_src", "src", nac_NodesWithoutSites_node_src_AllowedTypes, nac_NodesWithoutSites_node_src_IsAllowedType, 5.5F, 0, false, null, null, null, null, null, null, false, null);
			bool[,] nac_NodesWithoutSites_neg_0_isNodeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[,] nac_NodesWithoutSites_neg_0_isEdgeHomomorphicGlobal = new bool[0, 0];
			bool[] nac_NodesWithoutSites_neg_0_isNodeTotallyHomomorphic = new bool[1] { false,  };
			bool[] nac_NodesWithoutSites_neg_0_isEdgeTotallyHomomorphic = new bool[0];
			GRGEN_LGSP.PatternCondition nac_NodesWithoutSites_neg_0_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.NE(new GRGEN_EXPR.SetSize(new GRGEN_EXPR.AdjacentIncoming(new GRGEN_EXPR.GraphEntityExpression("nac_NodesWithoutSites_node_src"), new GRGEN_EXPR.Constant("GRGEN_MODEL.EdgeType_bPrnt.typeVar"), new GRGEN_EXPR.Constant("GRGEN_MODEL.NodeType_Node.typeVar"))), new GRGEN_EXPR.VariableExpression("nac_NodesWithoutSites_var_validChildCount")),
				new string[] { "nac_NodesWithoutSites_node_src" }, new string[] {  }, new string[] { "nac_NodesWithoutSites_var_validChildCount" },
				new GRGEN_LGSP.PatternNode[] { nac_NodesWithoutSites_node_src }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] { nac_NodesWithoutSites_var_validChildCount });
			nac_NodesWithoutSites_neg_0 = new GRGEN_LGSP.PatternGraph(
				"neg_0",
				"nac_NodesWithoutSites_",
				null, "neg_0",
				false, false,
				new GRGEN_LGSP.PatternNode[] { nac_NodesWithoutSites_node_src }, 
				new GRGEN_LGSP.PatternEdge[] {  }, 
				new GRGEN_LGSP.PatternVariable[] { nac_NodesWithoutSites_var_validChildCount }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { nac_NodesWithoutSites_neg_0_cond_0,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[1, 1] {
					{ true, },
				},
				new bool[0, 0] ,
				nac_NodesWithoutSites_neg_0_isNodeHomomorphicGlobal,
				nac_NodesWithoutSites_neg_0_isEdgeHomomorphicGlobal,
				nac_NodesWithoutSites_neg_0_isNodeTotallyHomomorphic,
				nac_NodesWithoutSites_neg_0_isEdgeTotallyHomomorphic
			);

			pat_nac_NodesWithoutSites = new GRGEN_LGSP.PatternGraph(
				"nac_NodesWithoutSites",
				"",
				null, "nac_NodesWithoutSites",
				false, false,
				new GRGEN_LGSP.PatternNode[] { nac_NodesWithoutSites_node_src }, 
				new GRGEN_LGSP.PatternEdge[] {  }, 
				new GRGEN_LGSP.PatternVariable[] { nac_NodesWithoutSites_var_validChildCount }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] { nac_NodesWithoutSites_neg_0,  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] {  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[1, 1] {
					{ true, },
				},
				new bool[0, 0] ,
				nac_NodesWithoutSites_isNodeHomomorphicGlobal,
				nac_NodesWithoutSites_isEdgeHomomorphicGlobal,
				nac_NodesWithoutSites_isNodeTotallyHomomorphic,
				nac_NodesWithoutSites_isEdgeTotallyHomomorphic
			);
			nac_NodesWithoutSites_neg_0.embeddingGraph = pat_nac_NodesWithoutSites;

			nac_NodesWithoutSites_var_validChildCount.pointOfDefinition = null;
			nac_NodesWithoutSites_node_src.pointOfDefinition = null;

			patternGraph = pat_nac_NodesWithoutSites;
		}


		public void nac_NodesWithoutSites_Delete(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, Match_nac_NodesWithoutSites curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
		}

		static Pattern_nac_NodesWithoutSites() {
		}

		public interface IMatch_nac_NodesWithoutSites : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IBNode node_src { get; set; }
			//Edges
			//Variables
			int @var_validChildCount { get; set; }
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public interface IMatch_nac_NodesWithoutSites_neg_0 : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IBNode node_src { get; set; }
			//Edges
			//Variables
			int @var_validChildCount { get; set; }
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_nac_NodesWithoutSites : GRGEN_LGSP.MatchListElement<Match_nac_NodesWithoutSites>, IMatch_nac_NodesWithoutSites
		{
			public GRGEN_MODEL.IBNode node_src { get { return (GRGEN_MODEL.IBNode)_node_src; } set { _node_src = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_src;
			public enum nac_NodesWithoutSites_NodeNums { @src, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 1; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)nac_NodesWithoutSites_NodeNums.@src: return _node_src;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "src": return _node_src;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "src": _node_src = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public enum nac_NodesWithoutSites_EdgeNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 0; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				default: break;
				}
			}

			public int var_validChildCount { get { return _var_validChildCount; } set { _var_validChildCount = value; } }
			public int _var_validChildCount;
			public enum nac_NodesWithoutSites_VariableNums { @validChildCount, END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 1; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				case (int)nac_NodesWithoutSites_VariableNums.@validChildCount: return _var_validChildCount;
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				case "validChildCount": return _var_validChildCount;
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				case "validChildCount": _var_validChildCount = (int)value; break;
				default: break;
				}
			}

			public enum nac_NodesWithoutSites_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum nac_NodesWithoutSites_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum nac_NodesWithoutSites_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum nac_NodesWithoutSites_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Pattern_nac_NodesWithoutSites.instance.pat_nac_NodesWithoutSites; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_nac_NodesWithoutSites(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_nac_NodesWithoutSites(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_nac_NodesWithoutSites nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_nac_NodesWithoutSites cur = this;
				while(cur != null) {
					Match_nac_NodesWithoutSites next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_nac_NodesWithoutSites that)
			{
				_node_src = that._node_src;
				_var_validChildCount = that._var_validChildCount;
			}

			public Match_nac_NodesWithoutSites(Match_nac_NodesWithoutSites that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_nac_NodesWithoutSites that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_src = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_src];
				_var_validChildCount = that._var_validChildCount;
			}

			public Match_nac_NodesWithoutSites(Match_nac_NodesWithoutSites that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_nac_NodesWithoutSites()
			{
			}

			public bool IsEqual(Match_nac_NodesWithoutSites that)
			{
				if(that==null) return false;
				if(_node_src != that._node_src) return false;
				if(_var_validChildCount != that._var_validChildCount) return false;
				return true;
			}
		}

		public class Match_nac_NodesWithoutSites_neg_0 : GRGEN_LGSP.MatchListElement<Match_nac_NodesWithoutSites_neg_0>, IMatch_nac_NodesWithoutSites_neg_0
		{
			public GRGEN_MODEL.IBNode node_src { get { return (GRGEN_MODEL.IBNode)_node_src; } set { _node_src = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_src;
			public enum nac_NodesWithoutSites_neg_0_NodeNums { @src, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 1; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)nac_NodesWithoutSites_neg_0_NodeNums.@src: return _node_src;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "src": return _node_src;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "src": _node_src = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public enum nac_NodesWithoutSites_neg_0_EdgeNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 0; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				default: break;
				}
			}

			public int var_validChildCount { get { return _var_validChildCount; } set { _var_validChildCount = value; } }
			public int _var_validChildCount;
			public enum nac_NodesWithoutSites_neg_0_VariableNums { @validChildCount, END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 1; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				case (int)nac_NodesWithoutSites_neg_0_VariableNums.@validChildCount: return _var_validChildCount;
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				case "validChildCount": return _var_validChildCount;
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				case "validChildCount": _var_validChildCount = (int)value; break;
				default: break;
				}
			}

			public enum nac_NodesWithoutSites_neg_0_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum nac_NodesWithoutSites_neg_0_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum nac_NodesWithoutSites_neg_0_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum nac_NodesWithoutSites_neg_0_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Pattern_nac_NodesWithoutSites.instance.nac_NodesWithoutSites_neg_0; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_nac_NodesWithoutSites_neg_0(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_nac_NodesWithoutSites_neg_0(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_nac_NodesWithoutSites_neg_0 nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_nac_NodesWithoutSites_neg_0 cur = this;
				while(cur != null) {
					Match_nac_NodesWithoutSites_neg_0 next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_nac_NodesWithoutSites_neg_0 that)
			{
				_node_src = that._node_src;
				_var_validChildCount = that._var_validChildCount;
			}

			public Match_nac_NodesWithoutSites_neg_0(Match_nac_NodesWithoutSites_neg_0 that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_nac_NodesWithoutSites_neg_0 that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_src = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_src];
				_var_validChildCount = that._var_validChildCount;
			}

			public Match_nac_NodesWithoutSites_neg_0(Match_nac_NodesWithoutSites_neg_0 that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_nac_NodesWithoutSites_neg_0()
			{
			}

			public bool IsEqual(Match_nac_NodesWithoutSites_neg_0 that)
			{
				if(that==null) return false;
				if(_node_src != that._node_src) return false;
				if(_var_validChildCount != that._var_validChildCount) return false;
				return true;
			}
		}

	}


	public class Rule_nextRule : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_nextRule instance = null;
		public static Rule_nextRule Instance { get { if(instance==null) { instance = new Rule_nextRule(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] nextRule_node_v0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_r0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_v2_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_v5_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_r1_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_v1_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_v3_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_v5_p0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_v6_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_v1_p0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_v4_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] nextRule_node_e0_AllowedTypes = null;
		public static bool[] nextRule_node_v0_IsAllowedType = null;
		public static bool[] nextRule_node_r0_IsAllowedType = null;
		public static bool[] nextRule_node_v2_IsAllowedType = null;
		public static bool[] nextRule_node_v5_IsAllowedType = null;
		public static bool[] nextRule_node_r1_IsAllowedType = null;
		public static bool[] nextRule_node_v1_IsAllowedType = null;
		public static bool[] nextRule_node_v3_IsAllowedType = null;
		public static bool[] nextRule_node_v5_p0_IsAllowedType = null;
		public static bool[] nextRule_node_v6_IsAllowedType = null;
		public static bool[] nextRule_node_v1_p0_IsAllowedType = null;
		public static bool[] nextRule_node_v4_IsAllowedType = null;
		public static bool[] nextRule_node_e0_IsAllowedType = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge_c0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge_c1_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge_c2_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge_c3_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge_c4_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge_c5_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge_c6_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge_c7_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge_c8_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge__edge0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] nextRule_edge__edge1_AllowedTypes = null;
		public static bool[] nextRule_edge_c0_IsAllowedType = null;
		public static bool[] nextRule_edge_c1_IsAllowedType = null;
		public static bool[] nextRule_edge_c2_IsAllowedType = null;
		public static bool[] nextRule_edge_c3_IsAllowedType = null;
		public static bool[] nextRule_edge_c4_IsAllowedType = null;
		public static bool[] nextRule_edge_c5_IsAllowedType = null;
		public static bool[] nextRule_edge_c6_IsAllowedType = null;
		public static bool[] nextRule_edge_c7_IsAllowedType = null;
		public static bool[] nextRule_edge_c8_IsAllowedType = null;
		public static bool[] nextRule_edge__edge0_IsAllowedType = null;
		public static bool[] nextRule_edge__edge1_IsAllowedType = null;
		public enum nextRule_NodeNums { @v0, @r0, @v2, @v5, @r1, @v1, @v3, @v5_p0, @v6, @v1_p0, @v4, @e0, };
		public enum nextRule_EdgeNums { @c0, @c1, @c2, @c3, @c4, @c5, @c6, @c7, @c8, @_edge0, @_edge1, };
		public enum nextRule_VariableNums { };
		public enum nextRule_SubNums { @pat0, @pat1, @pat2, };
		public enum nextRule_AltNums { };
		public enum nextRule_IterNums { };





		public static Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> fill_anonymous_set_5552(GRGEN_LIBGR.INode item0, GRGEN_LIBGR.INode item1, GRGEN_LIBGR.INode item2, GRGEN_LIBGR.INode item3, GRGEN_LIBGR.INode item4, GRGEN_LIBGR.INode item5, GRGEN_LIBGR.INode item6, GRGEN_LIBGR.INode item7, GRGEN_LIBGR.INode item8) {
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> anonymous_set_5552 = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>();
			anonymous_set_5552[item0] = null;
			anonymous_set_5552[item1] = null;
			anonymous_set_5552[item2] = null;
			anonymous_set_5552[item3] = null;
			anonymous_set_5552[item4] = null;
			anonymous_set_5552[item5] = null;
			anonymous_set_5552[item6] = null;
			anonymous_set_5552[item7] = null;
			anonymous_set_5552[item8] = null;
			return anonymous_set_5552;
		}
		public static Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode> fill_anonymous_map_5577(GRGEN_LIBGR.INode itemkey0,GRGEN_LIBGR.INode itemvalue0, GRGEN_LIBGR.INode itemkey1,GRGEN_LIBGR.INode itemvalue1, GRGEN_LIBGR.INode itemkey2,GRGEN_LIBGR.INode itemvalue2, GRGEN_LIBGR.INode itemkey3,GRGEN_LIBGR.INode itemvalue3) {
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode> anonymous_map_5577 = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode>();
			anonymous_map_5577[itemkey0] = itemvalue0;
			anonymous_map_5577[itemkey1] = itemvalue1;
			anonymous_map_5577[itemkey2] = itemvalue2;
			anonymous_map_5577[itemkey3] = itemvalue3;
			return anonymous_map_5577;
		}
		public static Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode> fill_anonymous_map_5582() {
			Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode> anonymous_map_5582 = new Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode>();
			return anonymous_map_5582;
		}

		public GRGEN_LGSP.PatternGraph pat_nextRule;


		private Rule_nextRule()
			: base("nextRule",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_ruleset.Rule_nextRule+IMatch_nextRule",
				"de.unika.ipd.grGen.Action_ruleset.Rule_nextRule+Match_nextRule"
			)
		{
		}
		private void initialize()
		{
			bool[,] nextRule_isNodeHomomorphicGlobal = new bool[12, 12] {
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, false, },
			};
			bool[,] nextRule_isEdgeHomomorphicGlobal = new bool[11, 11] {
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
			};
			bool[] nextRule_isNodeTotallyHomomorphic = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false,  };
			bool[] nextRule_isEdgeTotallyHomomorphic = new bool[11] { false, false, false, false, false, false, false, false, false, false, false,  };
			GRGEN_LGSP.PatternNode nextRule_node_v0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@this, GRGEN_MODEL.NodeType_this.typeVar, "GRGEN_MODEL.Ithis", "nextRule_node_v0", "v0", nextRule_node_v0_AllowedTypes, nextRule_node_v0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_r0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Node, GRGEN_MODEL.NodeType_Node.typeVar, "GRGEN_LIBGR.INode", "nextRule_node_r0", "r0", nextRule_node_r0_AllowedTypes, nextRule_node_r0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_v2 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@next, GRGEN_MODEL.NodeType_next.typeVar, "GRGEN_MODEL.Inext", "nextRule_node_v2", "v2", nextRule_node_v2_AllowedTypes, nextRule_node_v2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_v5 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@append, GRGEN_MODEL.NodeType_append.typeVar, "GRGEN_MODEL.Iappend", "nextRule_node_v5", "v5", nextRule_node_v5_AllowedTypes, nextRule_node_v5_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_r1 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Node, GRGEN_MODEL.NodeType_Node.typeVar, "GRGEN_LIBGR.INode", "nextRule_node_r1", "r1", nextRule_node_r1_AllowedTypes, nextRule_node_r1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_v1 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@thisRef, GRGEN_MODEL.NodeType_thisRef.typeVar, "GRGEN_MODEL.IthisRef", "nextRule_node_v1", "v1", nextRule_node_v1_AllowedTypes, nextRule_node_v1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_v3 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Cell, GRGEN_MODEL.NodeType_Cell.typeVar, "GRGEN_MODEL.ICell", "nextRule_node_v3", "v3", nextRule_node_v3_AllowedTypes, nextRule_node_v3_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_v5_p0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@BPort, GRGEN_MODEL.NodeType_BPort.typeVar, "GRGEN_MODEL.IBPort", "nextRule_node_v5_p0", "v5_p0", nextRule_node_v5_p0_AllowedTypes, nextRule_node_v5_p0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_v6 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@val, GRGEN_MODEL.NodeType_val.typeVar, "GRGEN_MODEL.Ival", "nextRule_node_v6", "v6", nextRule_node_v6_AllowedTypes, nextRule_node_v6_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_v1_p0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@BPort, GRGEN_MODEL.NodeType_BPort.typeVar, "GRGEN_MODEL.IBPort", "nextRule_node_v1_p0", "v1_p0", nextRule_node_v1_p0_AllowedTypes, nextRule_node_v1_p0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_v4 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@this, GRGEN_MODEL.NodeType_this.typeVar, "GRGEN_MODEL.Ithis", "nextRule_node_v4", "v4", nextRule_node_v4_AllowedTypes, nextRule_node_v4_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode nextRule_node_e0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@BEdge, GRGEN_MODEL.NodeType_BEdge.typeVar, "GRGEN_MODEL.IBEdge", "nextRule_node_e0", "e0", nextRule_node_e0_AllowedTypes, nextRule_node_e0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge_c0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "nextRule_edge_c0", "c0", nextRule_edge_c0_AllowedTypes, nextRule_edge_c0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge_c1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "nextRule_edge_c1", "c1", nextRule_edge_c1_AllowedTypes, nextRule_edge_c1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge_c2 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "nextRule_edge_c2", "c2", nextRule_edge_c2_AllowedTypes, nextRule_edge_c2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge_c3 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "nextRule_edge_c3", "c3", nextRule_edge_c3_AllowedTypes, nextRule_edge_c3_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge_c4 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "nextRule_edge_c4", "c4", nextRule_edge_c4_AllowedTypes, nextRule_edge_c4_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge_c5 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bNode, GRGEN_MODEL.EdgeType_bNode.typeVar, "GRGEN_MODEL.IbNode", "nextRule_edge_c5", "c5", nextRule_edge_c5_AllowedTypes, nextRule_edge_c5_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge_c6 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "nextRule_edge_c6", "c6", nextRule_edge_c6_AllowedTypes, nextRule_edge_c6_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge_c7 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bNode, GRGEN_MODEL.EdgeType_bNode.typeVar, "GRGEN_MODEL.IbNode", "nextRule_edge_c7", "c7", nextRule_edge_c7_AllowedTypes, nextRule_edge_c7_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge_c8 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "nextRule_edge_c8", "c8", nextRule_edge_c8_AllowedTypes, nextRule_edge_c8_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bLink, GRGEN_MODEL.EdgeType_bLink.typeVar, "GRGEN_MODEL.IbLink", "nextRule_edge__edge0", "_edge0", nextRule_edge__edge0_AllowedTypes, nextRule_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge nextRule_edge__edge1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bLink, GRGEN_MODEL.EdgeType_bLink.typeVar, "GRGEN_MODEL.IbLink", "nextRule_edge__edge1", "_edge1", nextRule_edge__edge1_AllowedTypes, nextRule_edge__edge1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternGraphEmbedding nextRule_pat0 = new GRGEN_LGSP.PatternGraphEmbedding("pat0", Pattern_nac_NodesWithoutSites.Instance, 
				new GRGEN_EXPR.Expression[] {
					new GRGEN_EXPR.GraphEntityExpression("nextRule_node_v1"),
					new GRGEN_EXPR.Constant("0"),
				}, 
				new string[] { }, new GRGEN_LGSP.PatternElement[] { }, new GRGEN_LGSP.PatternVariable[] { },
				new string[] { "nextRule_node_v1" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { nextRule_node_v1 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternGraphEmbedding nextRule_pat1 = new GRGEN_LGSP.PatternGraphEmbedding("pat1", Pattern_nac_NodesWithoutSites.Instance, 
				new GRGEN_EXPR.Expression[] {
					new GRGEN_EXPR.GraphEntityExpression("nextRule_node_v2"),
					new GRGEN_EXPR.Constant("1"),
				}, 
				new string[] { }, new GRGEN_LGSP.PatternElement[] { }, new GRGEN_LGSP.PatternVariable[] { },
				new string[] { "nextRule_node_v2" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { nextRule_node_v2 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternGraphEmbedding nextRule_pat2 = new GRGEN_LGSP.PatternGraphEmbedding("pat2", Pattern_nac_NodesWithoutSites.Instance, 
				new GRGEN_EXPR.Expression[] {
					new GRGEN_EXPR.GraphEntityExpression("nextRule_node_v5"),
					new GRGEN_EXPR.Constant("1"),
				}, 
				new string[] { }, new GRGEN_LGSP.PatternElement[] { }, new GRGEN_LGSP.PatternVariable[] { },
				new string[] { "nextRule_node_v5" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { nextRule_node_v5 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternCondition nextRule_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IBPort", true, "nextRule_node_v1_p0", "ix"), new GRGEN_EXPR.Constant("0")),
				new string[] { "nextRule_node_v1_p0" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { nextRule_node_v1_p0 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternCondition nextRule_cond_1 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IBPort", true, "nextRule_node_v5_p0", "ix"), new GRGEN_EXPR.Constant("0")),
				new string[] { "nextRule_node_v5_p0" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { nextRule_node_v5_p0 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			pat_nextRule = new GRGEN_LGSP.PatternGraph(
				"nextRule",
				"",
				null, "nextRule",
				false, false,
				new GRGEN_LGSP.PatternNode[] { nextRule_node_v0, nextRule_node_r0, nextRule_node_v2, nextRule_node_v5, nextRule_node_r1, nextRule_node_v1, nextRule_node_v3, nextRule_node_v5_p0, nextRule_node_v6, nextRule_node_v1_p0, nextRule_node_v4, nextRule_node_e0 }, 
				new GRGEN_LGSP.PatternEdge[] { nextRule_edge_c0, nextRule_edge_c1, nextRule_edge_c2, nextRule_edge_c3, nextRule_edge_c4, nextRule_edge_c5, nextRule_edge_c6, nextRule_edge_c7, nextRule_edge_c8, nextRule_edge__edge0, nextRule_edge__edge1 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] { nextRule_pat0, nextRule_pat1, nextRule_pat2 }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { nextRule_cond_0, nextRule_cond_1,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[12, 12] {
					{ true, false, false, false, false, false, false, false, false, false, false, false, },
					{ false, true, false, false, false, false, false, false, false, false, false, false, },
					{ false, false, true, false, false, false, false, false, false, false, false, false, },
					{ false, false, false, true, false, false, false, false, false, false, false, false, },
					{ false, false, false, false, true, false, false, false, false, false, false, false, },
					{ false, false, false, false, false, true, false, false, false, false, false, false, },
					{ false, false, false, false, false, false, true, false, false, false, false, false, },
					{ false, false, false, false, false, false, false, true, false, false, false, false, },
					{ false, false, false, false, false, false, false, false, true, false, false, false, },
					{ false, false, false, false, false, false, false, false, false, true, false, false, },
					{ false, false, false, false, false, false, false, false, false, false, true, false, },
					{ false, false, false, false, false, false, false, false, false, false, false, true, },
				},
				new bool[11, 11] {
					{ true, false, false, false, false, false, false, false, false, false, false, },
					{ false, true, false, false, false, false, false, false, false, false, false, },
					{ false, false, true, false, false, false, false, false, false, false, false, },
					{ false, false, false, true, false, false, false, false, false, false, false, },
					{ false, false, false, false, true, false, false, false, false, false, false, },
					{ false, false, false, false, false, true, false, false, false, false, false, },
					{ false, false, false, false, false, false, true, false, false, false, false, },
					{ false, false, false, false, false, false, false, true, false, false, false, },
					{ false, false, false, false, false, false, false, false, true, false, false, },
					{ false, false, false, false, false, false, false, false, false, true, false, },
					{ false, false, false, false, false, false, false, false, false, false, true, },
				},
				nextRule_isNodeHomomorphicGlobal,
				nextRule_isEdgeHomomorphicGlobal,
				nextRule_isNodeTotallyHomomorphic,
				nextRule_isEdgeTotallyHomomorphic
			);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge_c0, nextRule_node_v0);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge_c0, nextRule_node_r0);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge_c1, nextRule_node_v2);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge_c1, nextRule_node_r0);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge_c2, nextRule_node_v5);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge_c2, nextRule_node_r1);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge_c3, nextRule_node_v1);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge_c3, nextRule_node_v0);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge_c4, nextRule_node_v3);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge_c4, nextRule_node_v2);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge_c5, nextRule_node_v5_p0);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge_c5, nextRule_node_v5);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge_c6, nextRule_node_v6);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge_c6, nextRule_node_v5);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge_c7, nextRule_node_v1_p0);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge_c7, nextRule_node_v1);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge_c8, nextRule_node_v4);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge_c8, nextRule_node_v3);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge__edge0, nextRule_node_v5_p0);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge__edge0, nextRule_node_e0);
			pat_nextRule.edgeToSourceNode.Add(nextRule_edge__edge1, nextRule_node_v1_p0);
			pat_nextRule.edgeToTargetNode.Add(nextRule_edge__edge1, nextRule_node_e0);

			nextRule_node_v0.pointOfDefinition = pat_nextRule;
			nextRule_node_r0.pointOfDefinition = pat_nextRule;
			nextRule_node_v2.pointOfDefinition = pat_nextRule;
			nextRule_node_v5.pointOfDefinition = pat_nextRule;
			nextRule_node_r1.pointOfDefinition = pat_nextRule;
			nextRule_node_v1.pointOfDefinition = pat_nextRule;
			nextRule_node_v3.pointOfDefinition = pat_nextRule;
			nextRule_node_v5_p0.pointOfDefinition = pat_nextRule;
			nextRule_node_v6.pointOfDefinition = pat_nextRule;
			nextRule_node_v1_p0.pointOfDefinition = pat_nextRule;
			nextRule_node_v4.pointOfDefinition = pat_nextRule;
			nextRule_node_e0.pointOfDefinition = pat_nextRule;
			nextRule_edge_c0.pointOfDefinition = pat_nextRule;
			nextRule_edge_c1.pointOfDefinition = pat_nextRule;
			nextRule_edge_c2.pointOfDefinition = pat_nextRule;
			nextRule_edge_c3.pointOfDefinition = pat_nextRule;
			nextRule_edge_c4.pointOfDefinition = pat_nextRule;
			nextRule_edge_c5.pointOfDefinition = pat_nextRule;
			nextRule_edge_c6.pointOfDefinition = pat_nextRule;
			nextRule_edge_c7.pointOfDefinition = pat_nextRule;
			nextRule_edge_c8.pointOfDefinition = pat_nextRule;
			nextRule_edge__edge0.pointOfDefinition = pat_nextRule;
			nextRule_edge__edge1.pointOfDefinition = pat_nextRule;
			nextRule_pat0.PointOfDefinition = pat_nextRule;
			nextRule_pat1.PointOfDefinition = pat_nextRule;
			nextRule_pat2.PointOfDefinition = pat_nextRule;

			patternGraph = pat_nextRule;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_nextRule curMatch = (Match_nextRule)_curMatch;
			GRGEN_LGSP.LGSPNode node_v6 = curMatch._node_v6;
			GRGEN_LGSP.LGSPNode node_v0 = curMatch._node_v0;
			GRGEN_LGSP.LGSPNode node_v1 = curMatch._node_v1;
			GRGEN_LGSP.LGSPNode node_v2 = curMatch._node_v2;
			GRGEN_LGSP.LGSPNode node_v3 = curMatch._node_v3;
			GRGEN_LGSP.LGSPNode node_r0 = curMatch._node_r0;
			GRGEN_LGSP.LGSPNode node_v4 = curMatch._node_v4;
			GRGEN_LGSP.LGSPNode node_r1 = curMatch._node_r1;
			GRGEN_LGSP.LGSPNode node_v5 = curMatch._node_v5;
			GRGEN_LGSP.LGSPNode node_v5_p0 = curMatch._node_v5_p0;
			GRGEN_LGSP.LGSPNode node_e0 = curMatch._node_e0;
			GRGEN_LGSP.LGSPNode node_v1_p0 = curMatch._node_v1_p0;
			GRGEN_LGSP.LGSPEdge edge_c2 = curMatch._edge_c2;
			GRGEN_LGSP.LGSPEdge edge__edge0 = curMatch._edge__edge0;
			GRGEN_LGSP.LGSPEdge edge__edge1 = curMatch._edge__edge1;
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites subpattern_pat0 = curMatch.@_pat0;
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites subpattern_pat1 = curMatch.@_pat1;
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites subpattern_pat2 = curMatch.@_pat2;
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> var_allMatchedNodes = fill_anonymous_set_5552(((GRGEN_LIBGR.INode) node_v6), ((GRGEN_LIBGR.INode) node_v0), ((GRGEN_LIBGR.INode) node_v1), ((GRGEN_LIBGR.INode) node_v2), ((GRGEN_LIBGR.INode) node_v3), (GRGEN_LIBGR.INode)(node_r0), ((GRGEN_LIBGR.INode) node_v4), (GRGEN_LIBGR.INode)(node_r1), ((GRGEN_LIBGR.INode) node_v5));
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode> var_indexMap = fill_anonymous_map_5577(((GRGEN_LIBGR.INode) node_v6), ((GRGEN_LIBGR.INode) node_v6), ((GRGEN_LIBGR.INode) node_v0), ((GRGEN_LIBGR.INode) node_v0), ((GRGEN_LIBGR.INode) node_v3), ((GRGEN_LIBGR.INode) node_v3), ((GRGEN_LIBGR.INode) node_v4), ((GRGEN_LIBGR.INode) node_v4));
			Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode> var_tasks = fill_anonymous_map_5582();
			graph.SettingAddedNodeNames( nextRule_addedNodeNames );
			GRGEN_MODEL.@append node_v6_b006991 = GRGEN_MODEL.@append.CreateNode(graph);
			GRGEN_MODEL.@BPort node_v6_b006991_p0 = GRGEN_MODEL.@BPort.CreateNode(graph);
			GRGEN_MODEL.@thisRef node_v5_e435394 = GRGEN_MODEL.@thisRef.CreateNode(graph);
			GRGEN_MODEL.@BPort node_v5_e435394_p0 = GRGEN_MODEL.@BPort.CreateNode(graph);
			GRGEN_MODEL.@BEdge node_e1_1d1c66 = GRGEN_MODEL.@BEdge.CreateNode(graph);
			graph.SettingAddedEdgeNames( nextRule_addedEdgeNames );
			GRGEN_MODEL.@bPrnt edge__edge2 = GRGEN_MODEL.@bPrnt.CreateEdge(graph, node_v6_b006991, node_r1);
			GRGEN_MODEL.@bNode edge_c9 = GRGEN_MODEL.@bNode.CreateEdge(graph, node_v6_b006991_p0, node_v6_b006991);
			GRGEN_MODEL.@bPrnt edge__edge3 = GRGEN_MODEL.@bPrnt.CreateEdge(graph, node_v5, node_v6_b006991);
			GRGEN_MODEL.@bPrnt edge__edge4 = GRGEN_MODEL.@bPrnt.CreateEdge(graph, node_v5_e435394, node_v4);
			GRGEN_MODEL.@bNode edge_c10 = GRGEN_MODEL.@bNode.CreateEdge(graph, node_v5_e435394_p0, node_v5_e435394);
			GRGEN_MODEL.@bLink edge__edge5 = GRGEN_MODEL.@bLink.CreateEdge(graph, node_v5_p0, node_e1_1d1c66);
			GRGEN_MODEL.@bLink edge__edge6 = GRGEN_MODEL.@bLink.CreateEdge(graph, node_v5_e435394_p0, node_e1_1d1c66);
			GRGEN_MODEL.@bLink edge__edge7 = GRGEN_MODEL.@bLink.CreateEdge(graph, node_v6_b006991_p0, node_e0);
			GRGEN_MODEL.@bLink edge__edge8 = GRGEN_MODEL.@bLink.CreateEdge(graph, node_v1_p0, node_e0);
			{ // eval_0
				Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> var_nodesWithSites = (Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>)(GRGEN_LIBGR.ContainerHelper.Domain(var_indexMap));
				foreach(KeyValuePair<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> entry_0 in var_nodesWithSites)
				{
					GRGEN_LIBGR.INode var_cur = (GRGEN_LIBGR.INode)entry_0.Key;
					object emit_value_1;
					emit_value_1 = var_cur;
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = "->";
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = (var_indexMap[var_cur]);
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = " ";
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = GRGEN_LIBGR.GraphHelper.CountAdjacentIncoming(graph, var_cur, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar);
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = "\n";
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					if(((var_indexMap[var_cur]) == null)) {
						object emit_value_2;
						emit_value_2 = "Remove everything because there is no site mapping for the reactum";
						if(emit_value_2 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_2, graph, false, null, null, null));
						emit_value_2 = GRGEN_LIBGR.GraphHelper.AdjacentIncoming(var_cur, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar);
						if(emit_value_2 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_2, graph, false, null, null, null));
						emit_value_2 = "\n";
						if(emit_value_2 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_2, graph, false, null, null, null));
						GRGEN_LIBGR.INode node_3 = var_cur;
						foreach(GRGEN_LIBGR.IEdge edge_3 in node_3.GetCompatibleIncoming(GRGEN_MODEL.EdgeType_AEdge.typeVar))
						{
							if(!edge_3.Source.InstanceOf(GRGEN_MODEL.NodeType_Node.typeVar))
								continue;
							GRGEN_LIBGR.INode var_x__INTERN = (GRGEN_LIBGR.INode)edge_3.Source;
							if((((GRGEN_LGSP.LGSPNode)var_x__INTERN).lgspType != GRGEN_MODEL.NodeType_BPort.typeVar)) {
								graph.RemoveEdges((GRGEN_LIBGR.INode)var_x__INTERN);
								graph.Remove((GRGEN_LIBGR.INode)var_x__INTERN);
							}
						}
						continue;
					}
					if((var_cur != (var_indexMap[var_cur]))) {
						object emit_value_4;
						emit_value_4 = "Site mappings are different! Size of children: ";
						if(emit_value_4 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_4, graph, false, null, null, null));
						emit_value_4 = (GRGEN_LIBGR.GraphHelper.AdjacentIncoming(var_cur, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count;
						if(emit_value_4 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_4, graph, false, null, null, null));
						emit_value_4 = "\n";
						if(emit_value_4 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_4, graph, false, null, null, null));
						GRGEN_LIBGR.INode node_5 = var_cur;
						foreach(GRGEN_LIBGR.IEdge edge_5 in node_5.GetCompatibleIncoming(GRGEN_MODEL.EdgeType_AEdge.typeVar))
						{
							if(!edge_5.Source.InstanceOf(GRGEN_MODEL.NodeType_Node.typeVar))
								continue;
							GRGEN_LIBGR.INode var_x__INTERN = (GRGEN_LIBGR.INode)edge_5.Source;
							if(((((GRGEN_LGSP.LGSPNode)var_x__INTERN).lgspType != GRGEN_MODEL.NodeType_BPort.typeVar) && (! var_allMatchedNodes.ContainsKey(var_x__INTERN)))) {
								object emit_value_6;
								emit_value_6 = "\tchild = ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = var_x__INTERN;
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = " ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = ((GRGEN_LGSP.LGSPNode)var_x__INTERN).lgspType;
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = " ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = (var_indexMap[var_cur]);
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = " ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = GRGEN_LIBGR.GraphHelper.Outgoing(var_x__INTERN, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar);
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = "\n";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								GRGEN_LIBGR.INode node_7 = var_x__INTERN;
								foreach(GRGEN_LIBGR.IEdge edge_7 in node_7.GetCompatibleOutgoing(GRGEN_MODEL.EdgeType_AEdge.typeVar))
								{
									if(!edge_7.Target.InstanceOf(GRGEN_MODEL.NodeType_Node.typeVar))
										continue;
									GRGEN_LIBGR.IDEdge var_y = (GRGEN_LIBGR.IDEdge)edge_7;
									if((((GRGEN_LGSP.LGSPEdge)var_y).lgspType == GRGEN_MODEL.EdgeType_bPrnt.typeVar)) {
										object emit_value_8;
										emit_value_8 = "\ty";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = var_y;
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = " ";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = ((GRGEN_LGSP.LGSPEdge)var_y).lgspType;
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = " ";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = GRGEN_LIBGR.GraphHelper.Nameof(var_y, graph);
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = "\n";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										var_tasks[var_y] = (var_indexMap[var_cur]);
									}
								}
							}
						}
					}
				}
				Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.SetValueType> var_keyset = (Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.SetValueType>)(GRGEN_LIBGR.ContainerHelper.Domain(var_tasks));
				foreach(KeyValuePair<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.SetValueType> entry_9 in var_keyset)
				{
					GRGEN_LIBGR.IDEdge var_k = (GRGEN_LIBGR.IDEdge)entry_9.Key;
					((GRGEN_LGSP.LGSPNamedGraph)graph).RedirectTarget((GRGEN_LIBGR.IEdge)var_k, (GRGEN_LIBGR.INode)(var_tasks[var_k]));
				}
			}
			graph.Remove(edge_c2);
			graph.Remove(edge__edge0);
			graph.Remove(edge__edge1);
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.nac_NodesWithoutSites_Delete(actionEnv, subpattern_pat0);
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.nac_NodesWithoutSites_Delete(actionEnv, subpattern_pat1);
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.nac_NodesWithoutSites_Delete(actionEnv, subpattern_pat2);
			actionEnv.SelectedMatchRewritten();
			return;
		}
		private static string[] nextRule_addedNodeNames = new string[] { "v6_b006991", "v6_b006991_p0", "v5_e435394", "v5_e435394_p0", "e1_1d1c66" };
		private static string[] nextRule_addedEdgeNames = new string[] { "_edge2", "c9", "_edge3", "_edge4", "c10", "_edge5", "_edge6", "_edge7", "_edge8" };

		static Rule_nextRule() {
		}

		public interface IMatch_nextRule : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.Ithis node_v0 { get; set; }
			GRGEN_LIBGR.INode node_r0 { get; set; }
			GRGEN_MODEL.Inext node_v2 { get; set; }
			GRGEN_MODEL.Iappend node_v5 { get; set; }
			GRGEN_LIBGR.INode node_r1 { get; set; }
			GRGEN_MODEL.IthisRef node_v1 { get; set; }
			GRGEN_MODEL.ICell node_v3 { get; set; }
			GRGEN_MODEL.IBPort node_v5_p0 { get; set; }
			GRGEN_MODEL.Ival node_v6 { get; set; }
			GRGEN_MODEL.IBPort node_v1_p0 { get; set; }
			GRGEN_MODEL.Ithis node_v4 { get; set; }
			GRGEN_MODEL.IBEdge node_e0 { get; set; }
			//Edges
			GRGEN_MODEL.IbPrnt edge_c0 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c1 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c2 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c3 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c4 { get; set; }
			GRGEN_MODEL.IbNode edge_c5 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c6 { get; set; }
			GRGEN_MODEL.IbNode edge_c7 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c8 { get; set; }
			GRGEN_MODEL.IbLink edge__edge0 { get; set; }
			GRGEN_MODEL.IbLink edge__edge1 { get; set; }
			//Variables
			//EmbeddedGraphs
			@GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat0 { get; }
			@GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat1 { get; }
			@GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat2 { get; }
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_nextRule : GRGEN_LGSP.MatchListElement<Match_nextRule>, IMatch_nextRule
		{
			public GRGEN_MODEL.Ithis node_v0 { get { return (GRGEN_MODEL.Ithis)_node_v0; } set { _node_v0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LIBGR.INode node_r0 { get { return (GRGEN_LIBGR.INode)_node_r0; } set { _node_r0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.Inext node_v2 { get { return (GRGEN_MODEL.Inext)_node_v2; } set { _node_v2 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.Iappend node_v5 { get { return (GRGEN_MODEL.Iappend)_node_v5; } set { _node_v5 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LIBGR.INode node_r1 { get { return (GRGEN_LIBGR.INode)_node_r1; } set { _node_r1 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IthisRef node_v1 { get { return (GRGEN_MODEL.IthisRef)_node_v1; } set { _node_v1 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.ICell node_v3 { get { return (GRGEN_MODEL.ICell)_node_v3; } set { _node_v3 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IBPort node_v5_p0 { get { return (GRGEN_MODEL.IBPort)_node_v5_p0; } set { _node_v5_p0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.Ival node_v6 { get { return (GRGEN_MODEL.Ival)_node_v6; } set { _node_v6 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IBPort node_v1_p0 { get { return (GRGEN_MODEL.IBPort)_node_v1_p0; } set { _node_v1_p0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.Ithis node_v4 { get { return (GRGEN_MODEL.Ithis)_node_v4; } set { _node_v4 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IBEdge node_e0 { get { return (GRGEN_MODEL.IBEdge)_node_e0; } set { _node_e0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_v0;
			public GRGEN_LGSP.LGSPNode _node_r0;
			public GRGEN_LGSP.LGSPNode _node_v2;
			public GRGEN_LGSP.LGSPNode _node_v5;
			public GRGEN_LGSP.LGSPNode _node_r1;
			public GRGEN_LGSP.LGSPNode _node_v1;
			public GRGEN_LGSP.LGSPNode _node_v3;
			public GRGEN_LGSP.LGSPNode _node_v5_p0;
			public GRGEN_LGSP.LGSPNode _node_v6;
			public GRGEN_LGSP.LGSPNode _node_v1_p0;
			public GRGEN_LGSP.LGSPNode _node_v4;
			public GRGEN_LGSP.LGSPNode _node_e0;
			public enum nextRule_NodeNums { @v0, @r0, @v2, @v5, @r1, @v1, @v3, @v5_p0, @v6, @v1_p0, @v4, @e0, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 12; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)nextRule_NodeNums.@v0: return _node_v0;
				case (int)nextRule_NodeNums.@r0: return _node_r0;
				case (int)nextRule_NodeNums.@v2: return _node_v2;
				case (int)nextRule_NodeNums.@v5: return _node_v5;
				case (int)nextRule_NodeNums.@r1: return _node_r1;
				case (int)nextRule_NodeNums.@v1: return _node_v1;
				case (int)nextRule_NodeNums.@v3: return _node_v3;
				case (int)nextRule_NodeNums.@v5_p0: return _node_v5_p0;
				case (int)nextRule_NodeNums.@v6: return _node_v6;
				case (int)nextRule_NodeNums.@v1_p0: return _node_v1_p0;
				case (int)nextRule_NodeNums.@v4: return _node_v4;
				case (int)nextRule_NodeNums.@e0: return _node_e0;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "v0": return _node_v0;
				case "r0": return _node_r0;
				case "v2": return _node_v2;
				case "v5": return _node_v5;
				case "r1": return _node_r1;
				case "v1": return _node_v1;
				case "v3": return _node_v3;
				case "v5_p0": return _node_v5_p0;
				case "v6": return _node_v6;
				case "v1_p0": return _node_v1_p0;
				case "v4": return _node_v4;
				case "e0": return _node_e0;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "v0": _node_v0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "r0": _node_r0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v2": _node_v2 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v5": _node_v5 = (GRGEN_LGSP.LGSPNode)value; break;
				case "r1": _node_r1 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v1": _node_v1 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v3": _node_v3 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v5_p0": _node_v5_p0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v6": _node_v6 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v1_p0": _node_v1_p0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v4": _node_v4 = (GRGEN_LGSP.LGSPNode)value; break;
				case "e0": _node_e0 = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public GRGEN_MODEL.IbPrnt edge_c0 { get { return (GRGEN_MODEL.IbPrnt)_edge_c0; } set { _edge_c0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c1 { get { return (GRGEN_MODEL.IbPrnt)_edge_c1; } set { _edge_c1 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c2 { get { return (GRGEN_MODEL.IbPrnt)_edge_c2; } set { _edge_c2 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c3 { get { return (GRGEN_MODEL.IbPrnt)_edge_c3; } set { _edge_c3 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c4 { get { return (GRGEN_MODEL.IbPrnt)_edge_c4; } set { _edge_c4 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbNode edge_c5 { get { return (GRGEN_MODEL.IbNode)_edge_c5; } set { _edge_c5 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c6 { get { return (GRGEN_MODEL.IbPrnt)_edge_c6; } set { _edge_c6 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbNode edge_c7 { get { return (GRGEN_MODEL.IbNode)_edge_c7; } set { _edge_c7 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c8 { get { return (GRGEN_MODEL.IbPrnt)_edge_c8; } set { _edge_c8 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbLink edge__edge0 { get { return (GRGEN_MODEL.IbLink)_edge__edge0; } set { _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbLink edge__edge1 { get { return (GRGEN_MODEL.IbLink)_edge__edge1; } set { _edge__edge1 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_LGSP.LGSPEdge _edge_c0;
			public GRGEN_LGSP.LGSPEdge _edge_c1;
			public GRGEN_LGSP.LGSPEdge _edge_c2;
			public GRGEN_LGSP.LGSPEdge _edge_c3;
			public GRGEN_LGSP.LGSPEdge _edge_c4;
			public GRGEN_LGSP.LGSPEdge _edge_c5;
			public GRGEN_LGSP.LGSPEdge _edge_c6;
			public GRGEN_LGSP.LGSPEdge _edge_c7;
			public GRGEN_LGSP.LGSPEdge _edge_c8;
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public GRGEN_LGSP.LGSPEdge _edge__edge1;
			public enum nextRule_EdgeNums { @c0, @c1, @c2, @c3, @c4, @c5, @c6, @c7, @c8, @_edge0, @_edge1, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 11; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)nextRule_EdgeNums.@c0: return _edge_c0;
				case (int)nextRule_EdgeNums.@c1: return _edge_c1;
				case (int)nextRule_EdgeNums.@c2: return _edge_c2;
				case (int)nextRule_EdgeNums.@c3: return _edge_c3;
				case (int)nextRule_EdgeNums.@c4: return _edge_c4;
				case (int)nextRule_EdgeNums.@c5: return _edge_c5;
				case (int)nextRule_EdgeNums.@c6: return _edge_c6;
				case (int)nextRule_EdgeNums.@c7: return _edge_c7;
				case (int)nextRule_EdgeNums.@c8: return _edge_c8;
				case (int)nextRule_EdgeNums.@_edge0: return _edge__edge0;
				case (int)nextRule_EdgeNums.@_edge1: return _edge__edge1;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				case "c0": return _edge_c0;
				case "c1": return _edge_c1;
				case "c2": return _edge_c2;
				case "c3": return _edge_c3;
				case "c4": return _edge_c4;
				case "c5": return _edge_c5;
				case "c6": return _edge_c6;
				case "c7": return _edge_c7;
				case "c8": return _edge_c8;
				case "_edge0": return _edge__edge0;
				case "_edge1": return _edge__edge1;
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				case "c0": _edge_c0 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c1": _edge_c1 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c2": _edge_c2 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c3": _edge_c3 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c4": _edge_c4 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c5": _edge_c5 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c6": _edge_c6 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c7": _edge_c7 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c8": _edge_c8 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "_edge0": _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "_edge1": _edge__edge1 = (GRGEN_LGSP.LGSPEdge)value; break;
				default: break;
				}
			}

			public enum nextRule_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat0 { get { return @_pat0; } }
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat1 { get { return @_pat1; } }
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat2 { get { return @_pat2; } }
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @_pat0;
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @_pat1;
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @_pat2;
			public enum nextRule_SubNums { @pat0, @pat1, @pat2, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 3; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				case (int)nextRule_SubNums.@pat0: return _pat0;
				case (int)nextRule_SubNums.@pat1: return _pat1;
				case (int)nextRule_SubNums.@pat2: return _pat2;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				case "pat0": return _pat0;
				case "pat1": return _pat1;
				case "pat2": return _pat2;
				default: return null;
				}
			}

			public enum nextRule_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum nextRule_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum nextRule_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_nextRule.instance.pat_nextRule; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_nextRule(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_nextRule(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_nextRule nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_nextRule cur = this;
				while(cur != null) {
					Match_nextRule next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_nextRule that)
			{
				_node_v0 = that._node_v0;
				_node_r0 = that._node_r0;
				_node_v2 = that._node_v2;
				_node_v5 = that._node_v5;
				_node_r1 = that._node_r1;
				_node_v1 = that._node_v1;
				_node_v3 = that._node_v3;
				_node_v5_p0 = that._node_v5_p0;
				_node_v6 = that._node_v6;
				_node_v1_p0 = that._node_v1_p0;
				_node_v4 = that._node_v4;
				_node_e0 = that._node_e0;
				_edge_c0 = that._edge_c0;
				_edge_c1 = that._edge_c1;
				_edge_c2 = that._edge_c2;
				_edge_c3 = that._edge_c3;
				_edge_c4 = that._edge_c4;
				_edge_c5 = that._edge_c5;
				_edge_c6 = that._edge_c6;
				_edge_c7 = that._edge_c7;
				_edge_c8 = that._edge_c8;
				_edge__edge0 = that._edge__edge0;
				_edge__edge1 = that._edge__edge1;
				@_pat0 = that.@_pat0;
				@_pat1 = that.@_pat1;
				@_pat2 = that.@_pat2;
			}

			public Match_nextRule(Match_nextRule that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_nextRule that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_v0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v0];
				_node_r0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_r0];
				_node_v2 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v2];
				_node_v5 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v5];
				_node_r1 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_r1];
				_node_v1 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v1];
				_node_v3 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v3];
				_node_v5_p0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v5_p0];
				_node_v6 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v6];
				_node_v1_p0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v1_p0];
				_node_v4 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v4];
				_node_e0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_e0];
				_edge_c0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c0];
				_edge_c1 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c1];
				_edge_c2 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c2];
				_edge_c3 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c3];
				_edge_c4 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c4];
				_edge_c5 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c5];
				_edge_c6 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c6];
				_edge_c7 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c7];
				_edge_c8 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c8];
				_edge__edge0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge0];
				_edge__edge1 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge1];
				@_pat0 = new GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites(that.@_pat0, oldToNewMap);
				@_pat1 = new GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites(that.@_pat1, oldToNewMap);
				@_pat2 = new GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites(that.@_pat2, oldToNewMap);
			}

			public Match_nextRule(Match_nextRule that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_nextRule()
			{
			}

			public bool IsEqual(Match_nextRule that)
			{
				if(that==null) return false;
				if(_node_v0 != that._node_v0) return false;
				if(_node_r0 != that._node_r0) return false;
				if(_node_v2 != that._node_v2) return false;
				if(_node_v5 != that._node_v5) return false;
				if(_node_r1 != that._node_r1) return false;
				if(_node_v1 != that._node_v1) return false;
				if(_node_v3 != that._node_v3) return false;
				if(_node_v5_p0 != that._node_v5_p0) return false;
				if(_node_v6 != that._node_v6) return false;
				if(_node_v1_p0 != that._node_v1_p0) return false;
				if(_node_v4 != that._node_v4) return false;
				if(_node_e0 != that._node_e0) return false;
				if(_edge_c0 != that._edge_c0) return false;
				if(_edge_c1 != that._edge_c1) return false;
				if(_edge_c2 != that._edge_c2) return false;
				if(_edge_c3 != that._edge_c3) return false;
				if(_edge_c4 != that._edge_c4) return false;
				if(_edge_c5 != that._edge_c5) return false;
				if(_edge_c6 != that._edge_c6) return false;
				if(_edge_c7 != that._edge_c7) return false;
				if(_edge_c8 != that._edge_c8) return false;
				if(_edge__edge0 != that._edge__edge0) return false;
				if(_edge__edge1 != that._edge__edge1) return false;
				if(!@_pat0.IsEqual(that.@_pat0)) return false;
				if(!@_pat1.IsEqual(that.@_pat1)) return false;
				if(!@_pat2.IsEqual(that.@_pat2)) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.Ithis> Extract_v0(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.Ithis> resultList = new List<GRGEN_MODEL.Ithis>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_v0);
				return resultList;
			}
			public static List<GRGEN_LIBGR.INode> Extract_r0(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_LIBGR.INode> resultList = new List<GRGEN_LIBGR.INode>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_r0);
				return resultList;
			}
			public static List<GRGEN_MODEL.Inext> Extract_v2(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.Inext> resultList = new List<GRGEN_MODEL.Inext>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_v2);
				return resultList;
			}
			public static List<GRGEN_MODEL.Iappend> Extract_v5(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.Iappend> resultList = new List<GRGEN_MODEL.Iappend>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_v5);
				return resultList;
			}
			public static List<GRGEN_LIBGR.INode> Extract_r1(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_LIBGR.INode> resultList = new List<GRGEN_LIBGR.INode>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_r1);
				return resultList;
			}
			public static List<GRGEN_MODEL.IthisRef> Extract_v1(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IthisRef> resultList = new List<GRGEN_MODEL.IthisRef>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_v1);
				return resultList;
			}
			public static List<GRGEN_MODEL.ICell> Extract_v3(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.ICell> resultList = new List<GRGEN_MODEL.ICell>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_v3);
				return resultList;
			}
			public static List<GRGEN_MODEL.IBPort> Extract_v5_p0(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IBPort> resultList = new List<GRGEN_MODEL.IBPort>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_v5_p0);
				return resultList;
			}
			public static List<GRGEN_MODEL.Ival> Extract_v6(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.Ival> resultList = new List<GRGEN_MODEL.Ival>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_v6);
				return resultList;
			}
			public static List<GRGEN_MODEL.IBPort> Extract_v1_p0(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IBPort> resultList = new List<GRGEN_MODEL.IBPort>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_v1_p0);
				return resultList;
			}
			public static List<GRGEN_MODEL.Ithis> Extract_v4(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.Ithis> resultList = new List<GRGEN_MODEL.Ithis>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_v4);
				return resultList;
			}
			public static List<GRGEN_MODEL.IBEdge> Extract_e0(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IBEdge> resultList = new List<GRGEN_MODEL.IBEdge>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.node_e0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c0(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge_c0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c1(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge_c1);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c2(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge_c2);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c3(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge_c3);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c4(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge_c4);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbNode> Extract_c5(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbNode> resultList = new List<GRGEN_MODEL.IbNode>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge_c5);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c6(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge_c6);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbNode> Extract_c7(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbNode> resultList = new List<GRGEN_MODEL.IbNode>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge_c7);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c8(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge_c8);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbLink> Extract__edge0(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbLink> resultList = new List<GRGEN_MODEL.IbLink>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge__edge0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbLink> Extract__edge1(List<IMatch_nextRule> matchList)
			{
				List<GRGEN_MODEL.IbLink> resultList = new List<GRGEN_MODEL.IbLink>(matchList.Count);
				foreach(IMatch_nextRule match in matchList)
					resultList.Add(match.edge__edge1);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>)
				return ((List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule instanceBearingAttributeForSearch_nextRule = new GRGEN_ACTIONS.Rule_nextRule.Match_nextRule();
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_v0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.Ithis, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.Ithis, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v0)) {
					seenValues[list[pos].@node_v0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_v0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.Ithis, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Ithis, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v0, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_v0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ithis entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_v0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ithis entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ithis entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ithis entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_r0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_r0)) {
					seenValues[list[pos].@node_r0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_r0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_r0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_r0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_r0, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_r0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_r0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_r0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_r0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_v2(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.Inext, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.Inext, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v2)) {
					seenValues[list[pos].@node_v2].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v2, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_v2(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.Inext, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Inext, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v2)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v2, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_v2(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Inext entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_v2(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Inext entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v2(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Inext entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v2(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Inext entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_v5(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.Iappend, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.Iappend, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v5)) {
					seenValues[list[pos].@node_v5].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v5, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_v5(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.Iappend, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Iappend, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v5)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v5, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_v5(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Iappend entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_v5(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Iappend entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v5(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Iappend entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v5(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Iappend entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v5.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_r1(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_r1)) {
					seenValues[list[pos].@node_r1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_r1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_r1(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_r1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_r1, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_r1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_r1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_r1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_r1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_v1(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IthisRef, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IthisRef, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v1)) {
					seenValues[list[pos].@node_v1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_v1(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IthisRef, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IthisRef, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v1, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_v1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IthisRef entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_v1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IthisRef entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IthisRef entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IthisRef entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_v3(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.ICell, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.ICell, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v3)) {
					seenValues[list[pos].@node_v3].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v3, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_v3(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.ICell, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.ICell, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v3)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v3, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_v3(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.ICell entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_v3(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.ICell entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v3(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.ICell entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v3(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.ICell entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_v5_p0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v5_p0)) {
					seenValues[list[pos].@node_v5_p0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v5_p0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_v5_p0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v5_p0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v5_p0, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_v5_p0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v5_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_v5_p0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v5_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v5_p0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v5_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v5_p0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v5_p0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_v6(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.Ival, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.Ival, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v6)) {
					seenValues[list[pos].@node_v6].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v6, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_v6(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.Ival, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Ival, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v6)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v6, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_v6(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ival entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v6.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_v6(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ival entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v6.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v6(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ival entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v6.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v6(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ival entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v6.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_v1_p0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v1_p0)) {
					seenValues[list[pos].@node_v1_p0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v1_p0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_v1_p0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v1_p0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v1_p0, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_v1_p0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v1_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_v1_p0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v1_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v1_p0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v1_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v1_p0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v1_p0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_v4(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.Ithis, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.Ithis, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v4)) {
					seenValues[list[pos].@node_v4].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v4, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_v4(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.Ithis, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Ithis, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v4)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v4, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_v4(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ithis entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_v4(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ithis entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v4(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ithis entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_v4(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.Ithis entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v4.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_e0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IBEdge, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IBEdge, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_e0)) {
					seenValues[list[pos].@node_e0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_e0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_e0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IBEdge, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IBEdge, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_e0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_e0, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_e0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBEdge entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_e0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBEdge entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_e0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBEdge entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_e0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IBEdge entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_c0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c0)) {
					seenValues[list[pos].@edge_c0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_c0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c0, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_c0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_c0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_c1(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c1)) {
					seenValues[list[pos].@edge_c1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_c1(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c1, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_c1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_c1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_c2(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c2)) {
					seenValues[list[pos].@edge_c2].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c2, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_c2(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c2)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c2, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_c2(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_c2(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c2(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c2(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_c3(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c3)) {
					seenValues[list[pos].@edge_c3].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c3, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_c3(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c3)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c3, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_c3(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_c3(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c3(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c3(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_c4(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c4)) {
					seenValues[list[pos].@edge_c4].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c4, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_c4(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c4)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c4, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_c4(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_c4(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c4(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c4(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_c5(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c5)) {
					seenValues[list[pos].@edge_c5].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c5, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_c5(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c5)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c5, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_c5(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_c5(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c5(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c5(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_c6(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c6)) {
					seenValues[list[pos].@edge_c6].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c6, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_c6(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c6)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c6, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_c6(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c6.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_c6(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c6.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c6(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c6.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c6(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c6.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_c7(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c7)) {
					seenValues[list[pos].@edge_c7].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c7, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_c7(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c7)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c7, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_c7(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c7.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_c7(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c7.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c7(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c7.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c7(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c7.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy_c8(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c8)) {
					seenValues[list[pos].@edge_c8].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c8, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy_c8(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c8)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c8, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy_c8(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c8.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy_c8(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c8.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c8(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c8.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy_c8(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c8.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy__edge0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge0)) {
					seenValues[list[pos].@edge__edge0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy__edge0(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge0, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_groupBy__edge1(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>> seenValues = new Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge1)) {
					seenValues[list[pos].@edge__edge1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> tempList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			foreach(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> Array_nextRule_keepOneForEachBy__edge1(List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list)
		{
			List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> newList = new List<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule>();
			Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge1, null);
				}
			}
			return newList;
		}
		public static int Array_nextRule_indexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_indexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_nextRule_lastIndexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_nextRule.IMatch_nextRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Rule_appendRule : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_appendRule instance = null;
		public static Rule_appendRule Instance { get { if(instance==null) { instance = new Rule_appendRule(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] appendRule_node_v0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] appendRule_node_r0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] appendRule_node_v4_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] appendRule_node_r1_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] appendRule_node_v1_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] appendRule_node_v3_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] appendRule_node_v4_p0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] appendRule_node_v5_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] appendRule_node_v2_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] appendRule_node_v2_p0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] appendRule_node_e0_AllowedTypes = null;
		public static bool[] appendRule_node_v0_IsAllowedType = null;
		public static bool[] appendRule_node_r0_IsAllowedType = null;
		public static bool[] appendRule_node_v4_IsAllowedType = null;
		public static bool[] appendRule_node_r1_IsAllowedType = null;
		public static bool[] appendRule_node_v1_IsAllowedType = null;
		public static bool[] appendRule_node_v3_IsAllowedType = null;
		public static bool[] appendRule_node_v4_p0_IsAllowedType = null;
		public static bool[] appendRule_node_v5_IsAllowedType = null;
		public static bool[] appendRule_node_v2_IsAllowedType = null;
		public static bool[] appendRule_node_v2_p0_IsAllowedType = null;
		public static bool[] appendRule_node_e0_IsAllowedType = null;
		public static GRGEN_LIBGR.EdgeType[] appendRule_edge_c0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] appendRule_edge_c1_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] appendRule_edge_c2_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] appendRule_edge_c3_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] appendRule_edge_c4_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] appendRule_edge_c5_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] appendRule_edge_c6_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] appendRule_edge_c7_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] appendRule_edge__edge0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] appendRule_edge__edge1_AllowedTypes = null;
		public static bool[] appendRule_edge_c0_IsAllowedType = null;
		public static bool[] appendRule_edge_c1_IsAllowedType = null;
		public static bool[] appendRule_edge_c2_IsAllowedType = null;
		public static bool[] appendRule_edge_c3_IsAllowedType = null;
		public static bool[] appendRule_edge_c4_IsAllowedType = null;
		public static bool[] appendRule_edge_c5_IsAllowedType = null;
		public static bool[] appendRule_edge_c6_IsAllowedType = null;
		public static bool[] appendRule_edge_c7_IsAllowedType = null;
		public static bool[] appendRule_edge__edge0_IsAllowedType = null;
		public static bool[] appendRule_edge__edge1_IsAllowedType = null;
		public enum appendRule_NodeNums { @v0, @r0, @v4, @r1, @v1, @v3, @v4_p0, @v5, @v2, @v2_p0, @e0, };
		public enum appendRule_EdgeNums { @c0, @c1, @c2, @c3, @c4, @c5, @c6, @c7, @_edge0, @_edge1, };
		public enum appendRule_VariableNums { };
		public enum appendRule_SubNums { @pat0, @pat1, @pat2, };
		public enum appendRule_AltNums { };
		public enum appendRule_IterNums { };





		public static Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> fill_anonymous_set_5882(GRGEN_LIBGR.INode item0, GRGEN_LIBGR.INode item1, GRGEN_LIBGR.INode item2, GRGEN_LIBGR.INode item3, GRGEN_LIBGR.INode item4, GRGEN_LIBGR.INode item5, GRGEN_LIBGR.INode item6, GRGEN_LIBGR.INode item7) {
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> anonymous_set_5882 = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>();
			anonymous_set_5882[item0] = null;
			anonymous_set_5882[item1] = null;
			anonymous_set_5882[item2] = null;
			anonymous_set_5882[item3] = null;
			anonymous_set_5882[item4] = null;
			anonymous_set_5882[item5] = null;
			anonymous_set_5882[item6] = null;
			anonymous_set_5882[item7] = null;
			return anonymous_set_5882;
		}
		public static Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode> fill_anonymous_map_5902(GRGEN_LIBGR.INode itemkey0,GRGEN_LIBGR.INode itemvalue0, GRGEN_LIBGR.INode itemkey1,GRGEN_LIBGR.INode itemvalue1, GRGEN_LIBGR.INode itemkey2,GRGEN_LIBGR.INode itemvalue2) {
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode> anonymous_map_5902 = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode>();
			anonymous_map_5902[itemkey0] = itemvalue0;
			anonymous_map_5902[itemkey1] = itemvalue1;
			anonymous_map_5902[itemkey2] = itemvalue2;
			return anonymous_map_5902;
		}
		public static Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode> fill_anonymous_map_5907() {
			Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode> anonymous_map_5907 = new Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode>();
			return anonymous_map_5907;
		}

		public GRGEN_LGSP.PatternGraph pat_appendRule;


		private Rule_appendRule()
			: base("appendRule",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_ruleset.Rule_appendRule+IMatch_appendRule",
				"de.unika.ipd.grGen.Action_ruleset.Rule_appendRule+Match_appendRule"
			)
		{
		}
		private void initialize()
		{
			bool[,] appendRule_isNodeHomomorphicGlobal = new bool[11, 11] {
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, false, },
			};
			bool[,] appendRule_isEdgeHomomorphicGlobal = new bool[10, 10] {
				{ false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, false, },
			};
			bool[] appendRule_isNodeTotallyHomomorphic = new bool[11] { false, false, false, false, false, false, false, false, false, false, false,  };
			bool[] appendRule_isEdgeTotallyHomomorphic = new bool[10] { false, false, false, false, false, false, false, false, false, false,  };
			GRGEN_LGSP.PatternNode appendRule_node_v0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Cell, GRGEN_MODEL.NodeType_Cell.typeVar, "GRGEN_MODEL.ICell", "appendRule_node_v0", "v0", appendRule_node_v0_AllowedTypes, appendRule_node_v0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode appendRule_node_r0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Node, GRGEN_MODEL.NodeType_Node.typeVar, "GRGEN_LIBGR.INode", "appendRule_node_r0", "r0", appendRule_node_r0_AllowedTypes, appendRule_node_r0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode appendRule_node_v4 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@append, GRGEN_MODEL.NodeType_append.typeVar, "GRGEN_MODEL.Iappend", "appendRule_node_v4", "v4", appendRule_node_v4_AllowedTypes, appendRule_node_v4_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode appendRule_node_r1 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Node, GRGEN_MODEL.NodeType_Node.typeVar, "GRGEN_LIBGR.INode", "appendRule_node_r1", "r1", appendRule_node_r1_AllowedTypes, appendRule_node_r1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode appendRule_node_v1 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@this, GRGEN_MODEL.NodeType_this.typeVar, "GRGEN_MODEL.Ithis", "appendRule_node_v1", "v1", appendRule_node_v1_AllowedTypes, appendRule_node_v1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode appendRule_node_v3 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@val, GRGEN_MODEL.NodeType_val.typeVar, "GRGEN_MODEL.Ival", "appendRule_node_v3", "v3", appendRule_node_v3_AllowedTypes, appendRule_node_v3_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode appendRule_node_v4_p0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@BPort, GRGEN_MODEL.NodeType_BPort.typeVar, "GRGEN_MODEL.IBPort", "appendRule_node_v4_p0", "v4_p0", appendRule_node_v4_p0_AllowedTypes, appendRule_node_v4_p0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode appendRule_node_v5 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@val, GRGEN_MODEL.NodeType_val.typeVar, "GRGEN_MODEL.Ival", "appendRule_node_v5", "v5", appendRule_node_v5_AllowedTypes, appendRule_node_v5_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode appendRule_node_v2 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@thisRef, GRGEN_MODEL.NodeType_thisRef.typeVar, "GRGEN_MODEL.IthisRef", "appendRule_node_v2", "v2", appendRule_node_v2_AllowedTypes, appendRule_node_v2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode appendRule_node_v2_p0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@BPort, GRGEN_MODEL.NodeType_BPort.typeVar, "GRGEN_MODEL.IBPort", "appendRule_node_v2_p0", "v2_p0", appendRule_node_v2_p0_AllowedTypes, appendRule_node_v2_p0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode appendRule_node_e0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@BEdge, GRGEN_MODEL.NodeType_BEdge.typeVar, "GRGEN_MODEL.IBEdge", "appendRule_node_e0", "e0", appendRule_node_e0_AllowedTypes, appendRule_node_e0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge appendRule_edge_c0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "appendRule_edge_c0", "c0", appendRule_edge_c0_AllowedTypes, appendRule_edge_c0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge appendRule_edge_c1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "appendRule_edge_c1", "c1", appendRule_edge_c1_AllowedTypes, appendRule_edge_c1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge appendRule_edge_c2 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "appendRule_edge_c2", "c2", appendRule_edge_c2_AllowedTypes, appendRule_edge_c2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge appendRule_edge_c3 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "appendRule_edge_c3", "c3", appendRule_edge_c3_AllowedTypes, appendRule_edge_c3_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge appendRule_edge_c4 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bNode, GRGEN_MODEL.EdgeType_bNode.typeVar, "GRGEN_MODEL.IbNode", "appendRule_edge_c4", "c4", appendRule_edge_c4_AllowedTypes, appendRule_edge_c4_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge appendRule_edge_c5 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "appendRule_edge_c5", "c5", appendRule_edge_c5_AllowedTypes, appendRule_edge_c5_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge appendRule_edge_c6 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "appendRule_edge_c6", "c6", appendRule_edge_c6_AllowedTypes, appendRule_edge_c6_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge appendRule_edge_c7 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bNode, GRGEN_MODEL.EdgeType_bNode.typeVar, "GRGEN_MODEL.IbNode", "appendRule_edge_c7", "c7", appendRule_edge_c7_AllowedTypes, appendRule_edge_c7_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge appendRule_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bLink, GRGEN_MODEL.EdgeType_bLink.typeVar, "GRGEN_MODEL.IbLink", "appendRule_edge__edge0", "_edge0", appendRule_edge__edge0_AllowedTypes, appendRule_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge appendRule_edge__edge1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bLink, GRGEN_MODEL.EdgeType_bLink.typeVar, "GRGEN_MODEL.IbLink", "appendRule_edge__edge1", "_edge1", appendRule_edge__edge1_AllowedTypes, appendRule_edge__edge1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternGraphEmbedding appendRule_pat0 = new GRGEN_LGSP.PatternGraphEmbedding("pat0", Pattern_nac_NodesWithoutSites.Instance, 
				new GRGEN_EXPR.Expression[] {
					new GRGEN_EXPR.GraphEntityExpression("appendRule_node_v0"),
					new GRGEN_EXPR.Constant("2"),
				}, 
				new string[] { }, new GRGEN_LGSP.PatternElement[] { }, new GRGEN_LGSP.PatternVariable[] { },
				new string[] { "appendRule_node_v0" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { appendRule_node_v0 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternGraphEmbedding appendRule_pat1 = new GRGEN_LGSP.PatternGraphEmbedding("pat1", Pattern_nac_NodesWithoutSites.Instance, 
				new GRGEN_EXPR.Expression[] {
					new GRGEN_EXPR.GraphEntityExpression("appendRule_node_v2"),
					new GRGEN_EXPR.Constant("0"),
				}, 
				new string[] { }, new GRGEN_LGSP.PatternElement[] { }, new GRGEN_LGSP.PatternVariable[] { },
				new string[] { "appendRule_node_v2" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { appendRule_node_v2 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternGraphEmbedding appendRule_pat2 = new GRGEN_LGSP.PatternGraphEmbedding("pat2", Pattern_nac_NodesWithoutSites.Instance, 
				new GRGEN_EXPR.Expression[] {
					new GRGEN_EXPR.GraphEntityExpression("appendRule_node_v4"),
					new GRGEN_EXPR.Constant("1"),
				}, 
				new string[] { }, new GRGEN_LGSP.PatternElement[] { }, new GRGEN_LGSP.PatternVariable[] { },
				new string[] { "appendRule_node_v4" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { appendRule_node_v4 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternCondition appendRule_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IBPort", true, "appendRule_node_v2_p0", "ix"), new GRGEN_EXPR.Constant("0")),
				new string[] { "appendRule_node_v2_p0" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { appendRule_node_v2_p0 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternCondition appendRule_cond_1 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IBPort", true, "appendRule_node_v4_p0", "ix"), new GRGEN_EXPR.Constant("0")),
				new string[] { "appendRule_node_v4_p0" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { appendRule_node_v4_p0 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			pat_appendRule = new GRGEN_LGSP.PatternGraph(
				"appendRule",
				"",
				null, "appendRule",
				false, false,
				new GRGEN_LGSP.PatternNode[] { appendRule_node_v0, appendRule_node_r0, appendRule_node_v4, appendRule_node_r1, appendRule_node_v1, appendRule_node_v3, appendRule_node_v4_p0, appendRule_node_v5, appendRule_node_v2, appendRule_node_v2_p0, appendRule_node_e0 }, 
				new GRGEN_LGSP.PatternEdge[] { appendRule_edge_c0, appendRule_edge_c1, appendRule_edge_c2, appendRule_edge_c3, appendRule_edge_c4, appendRule_edge_c5, appendRule_edge_c6, appendRule_edge_c7, appendRule_edge__edge0, appendRule_edge__edge1 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] { appendRule_pat0, appendRule_pat1, appendRule_pat2 }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { appendRule_cond_0, appendRule_cond_1,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[11, 11] {
					{ true, false, false, false, false, false, false, false, false, false, false, },
					{ false, true, false, false, false, false, false, false, false, false, false, },
					{ false, false, true, false, false, false, false, false, false, false, false, },
					{ false, false, false, true, false, false, false, false, false, false, false, },
					{ false, false, false, false, true, false, false, false, false, false, false, },
					{ false, false, false, false, false, true, false, false, false, false, false, },
					{ false, false, false, false, false, false, true, false, false, false, false, },
					{ false, false, false, false, false, false, false, true, false, false, false, },
					{ false, false, false, false, false, false, false, false, true, false, false, },
					{ false, false, false, false, false, false, false, false, false, true, false, },
					{ false, false, false, false, false, false, false, false, false, false, true, },
				},
				new bool[10, 10] {
					{ true, false, false, false, false, false, false, false, false, false, },
					{ false, true, false, false, false, false, false, false, false, false, },
					{ false, false, true, false, false, false, false, false, false, false, },
					{ false, false, false, true, false, false, false, false, false, false, },
					{ false, false, false, false, true, false, false, false, false, false, },
					{ false, false, false, false, false, true, false, false, false, false, },
					{ false, false, false, false, false, false, true, false, false, false, },
					{ false, false, false, false, false, false, false, true, false, false, },
					{ false, false, false, false, false, false, false, false, true, false, },
					{ false, false, false, false, false, false, false, false, false, true, },
				},
				appendRule_isNodeHomomorphicGlobal,
				appendRule_isEdgeHomomorphicGlobal,
				appendRule_isNodeTotallyHomomorphic,
				appendRule_isEdgeTotallyHomomorphic
			);
			pat_appendRule.edgeToSourceNode.Add(appendRule_edge_c0, appendRule_node_v0);
			pat_appendRule.edgeToTargetNode.Add(appendRule_edge_c0, appendRule_node_r0);
			pat_appendRule.edgeToSourceNode.Add(appendRule_edge_c1, appendRule_node_v4);
			pat_appendRule.edgeToTargetNode.Add(appendRule_edge_c1, appendRule_node_r1);
			pat_appendRule.edgeToSourceNode.Add(appendRule_edge_c2, appendRule_node_v1);
			pat_appendRule.edgeToTargetNode.Add(appendRule_edge_c2, appendRule_node_v0);
			pat_appendRule.edgeToSourceNode.Add(appendRule_edge_c3, appendRule_node_v3);
			pat_appendRule.edgeToTargetNode.Add(appendRule_edge_c3, appendRule_node_v0);
			pat_appendRule.edgeToSourceNode.Add(appendRule_edge_c4, appendRule_node_v4_p0);
			pat_appendRule.edgeToTargetNode.Add(appendRule_edge_c4, appendRule_node_v4);
			pat_appendRule.edgeToSourceNode.Add(appendRule_edge_c5, appendRule_node_v5);
			pat_appendRule.edgeToTargetNode.Add(appendRule_edge_c5, appendRule_node_v4);
			pat_appendRule.edgeToSourceNode.Add(appendRule_edge_c6, appendRule_node_v2);
			pat_appendRule.edgeToTargetNode.Add(appendRule_edge_c6, appendRule_node_v1);
			pat_appendRule.edgeToSourceNode.Add(appendRule_edge_c7, appendRule_node_v2_p0);
			pat_appendRule.edgeToTargetNode.Add(appendRule_edge_c7, appendRule_node_v2);
			pat_appendRule.edgeToSourceNode.Add(appendRule_edge__edge0, appendRule_node_v4_p0);
			pat_appendRule.edgeToTargetNode.Add(appendRule_edge__edge0, appendRule_node_e0);
			pat_appendRule.edgeToSourceNode.Add(appendRule_edge__edge1, appendRule_node_v2_p0);
			pat_appendRule.edgeToTargetNode.Add(appendRule_edge__edge1, appendRule_node_e0);

			appendRule_node_v0.pointOfDefinition = pat_appendRule;
			appendRule_node_r0.pointOfDefinition = pat_appendRule;
			appendRule_node_v4.pointOfDefinition = pat_appendRule;
			appendRule_node_r1.pointOfDefinition = pat_appendRule;
			appendRule_node_v1.pointOfDefinition = pat_appendRule;
			appendRule_node_v3.pointOfDefinition = pat_appendRule;
			appendRule_node_v4_p0.pointOfDefinition = pat_appendRule;
			appendRule_node_v5.pointOfDefinition = pat_appendRule;
			appendRule_node_v2.pointOfDefinition = pat_appendRule;
			appendRule_node_v2_p0.pointOfDefinition = pat_appendRule;
			appendRule_node_e0.pointOfDefinition = pat_appendRule;
			appendRule_edge_c0.pointOfDefinition = pat_appendRule;
			appendRule_edge_c1.pointOfDefinition = pat_appendRule;
			appendRule_edge_c2.pointOfDefinition = pat_appendRule;
			appendRule_edge_c3.pointOfDefinition = pat_appendRule;
			appendRule_edge_c4.pointOfDefinition = pat_appendRule;
			appendRule_edge_c5.pointOfDefinition = pat_appendRule;
			appendRule_edge_c6.pointOfDefinition = pat_appendRule;
			appendRule_edge_c7.pointOfDefinition = pat_appendRule;
			appendRule_edge__edge0.pointOfDefinition = pat_appendRule;
			appendRule_edge__edge1.pointOfDefinition = pat_appendRule;
			appendRule_pat0.PointOfDefinition = pat_appendRule;
			appendRule_pat1.PointOfDefinition = pat_appendRule;
			appendRule_pat2.PointOfDefinition = pat_appendRule;

			patternGraph = pat_appendRule;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_appendRule curMatch = (Match_appendRule)_curMatch;
			GRGEN_LGSP.LGSPNode node_v0 = curMatch._node_v0;
			GRGEN_LGSP.LGSPNode node_v1 = curMatch._node_v1;
			GRGEN_LGSP.LGSPNode node_v2 = curMatch._node_v2;
			GRGEN_LGSP.LGSPNode node_v3 = curMatch._node_v3;
			GRGEN_LGSP.LGSPNode node_r0 = curMatch._node_r0;
			GRGEN_LGSP.LGSPNode node_v4 = curMatch._node_v4;
			GRGEN_LGSP.LGSPNode node_r1 = curMatch._node_r1;
			GRGEN_LGSP.LGSPNode node_v5 = curMatch._node_v5;
			GRGEN_LGSP.LGSPNode node_v4_p0 = curMatch._node_v4_p0;
			GRGEN_LGSP.LGSPNode node_v2_p0 = curMatch._node_v2_p0;
			GRGEN_LGSP.LGSPNode node_e0 = curMatch._node_e0;
			GRGEN_LGSP.LGSPEdge edge_c1 = curMatch._edge_c1;
			GRGEN_LGSP.LGSPEdge edge_c4 = curMatch._edge_c4;
			GRGEN_LGSP.LGSPEdge edge_c5 = curMatch._edge_c5;
			GRGEN_LGSP.LGSPEdge edge_c6 = curMatch._edge_c6;
			GRGEN_LGSP.LGSPEdge edge_c7 = curMatch._edge_c7;
			GRGEN_LGSP.LGSPEdge edge__edge0 = curMatch._edge__edge0;
			GRGEN_LGSP.LGSPEdge edge__edge1 = curMatch._edge__edge1;
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites subpattern_pat0 = curMatch.@_pat0;
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites subpattern_pat1 = curMatch.@_pat1;
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites subpattern_pat2 = curMatch.@_pat2;
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> var_allMatchedNodes = fill_anonymous_set_5882(((GRGEN_LIBGR.INode) node_v0), ((GRGEN_LIBGR.INode) node_v1), ((GRGEN_LIBGR.INode) node_v2), ((GRGEN_LIBGR.INode) node_v3), (GRGEN_LIBGR.INode)(node_r0), ((GRGEN_LIBGR.INode) node_v4), (GRGEN_LIBGR.INode)(node_r1), ((GRGEN_LIBGR.INode) node_v5));
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode> var_indexMap = fill_anonymous_map_5902(((GRGEN_LIBGR.INode) node_v1), ((GRGEN_LIBGR.INode) node_v1), ((GRGEN_LIBGR.INode) node_v3), ((GRGEN_LIBGR.INode) node_v3), ((GRGEN_LIBGR.INode) node_v5), ((GRGEN_LIBGR.INode) node_v5));
			Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode> var_tasks = fill_anonymous_map_5907();
			graph.SettingAddedNodeNames( appendRule_addedNodeNames );
			GRGEN_MODEL.@Cell node_v4_0658772 = GRGEN_MODEL.@Cell.CreateNode(graph);
			GRGEN_MODEL.@Void node_v7_085d921 = GRGEN_MODEL.@Void.CreateNode(graph);
			GRGEN_MODEL.@next node_v3_99a1941 = GRGEN_MODEL.@next.CreateNode(graph);
			GRGEN_MODEL.@this node_v5_5274933 = GRGEN_MODEL.@this.CreateNode(graph);
			graph.SettingAddedEdgeNames( appendRule_addedEdgeNames );
			GRGEN_MODEL.@bPrnt edge__edge2 = GRGEN_MODEL.@bPrnt.CreateEdge(graph, node_v5, node_v4_0658772);
			GRGEN_MODEL.@bPrnt edge__edge3 = GRGEN_MODEL.@bPrnt.CreateEdge(graph, node_v7_085d921, node_r1);
			GRGEN_MODEL.@bPrnt edge__edge4 = GRGEN_MODEL.@bPrnt.CreateEdge(graph, node_v3_99a1941, node_v0);
			GRGEN_MODEL.@bPrnt edge__edge5 = GRGEN_MODEL.@bPrnt.CreateEdge(graph, node_v4_0658772, node_v3_99a1941);
			GRGEN_MODEL.@bPrnt edge__edge6 = GRGEN_MODEL.@bPrnt.CreateEdge(graph, node_v5_5274933, node_v4_0658772);
			{ // eval_0
				Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> var_nodesWithSites = (Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>)(GRGEN_LIBGR.ContainerHelper.Domain(var_indexMap));
				foreach(KeyValuePair<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> entry_0 in var_nodesWithSites)
				{
					GRGEN_LIBGR.INode var_cur = (GRGEN_LIBGR.INode)entry_0.Key;
					object emit_value_1;
					emit_value_1 = var_cur;
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = "->";
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = (var_indexMap[var_cur]);
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = " ";
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = GRGEN_LIBGR.GraphHelper.CountAdjacentIncoming(graph, var_cur, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar);
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = "\n";
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					if(((var_indexMap[var_cur]) == null)) {
						object emit_value_2;
						emit_value_2 = "Remove everything because there is no site mapping for the reactum";
						if(emit_value_2 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_2, graph, false, null, null, null));
						emit_value_2 = GRGEN_LIBGR.GraphHelper.AdjacentIncoming(var_cur, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar);
						if(emit_value_2 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_2, graph, false, null, null, null));
						emit_value_2 = "\n";
						if(emit_value_2 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_2, graph, false, null, null, null));
						GRGEN_LIBGR.INode node_3 = var_cur;
						foreach(GRGEN_LIBGR.IEdge edge_3 in node_3.GetCompatibleIncoming(GRGEN_MODEL.EdgeType_AEdge.typeVar))
						{
							if(!edge_3.Source.InstanceOf(GRGEN_MODEL.NodeType_Node.typeVar))
								continue;
							GRGEN_LIBGR.INode var_x__INTERN = (GRGEN_LIBGR.INode)edge_3.Source;
							if((((GRGEN_LGSP.LGSPNode)var_x__INTERN).lgspType != GRGEN_MODEL.NodeType_BPort.typeVar)) {
								graph.RemoveEdges((GRGEN_LIBGR.INode)var_x__INTERN);
								graph.Remove((GRGEN_LIBGR.INode)var_x__INTERN);
							}
						}
						continue;
					}
					if((var_cur != (var_indexMap[var_cur]))) {
						object emit_value_4;
						emit_value_4 = "Site mappings are different! Size of children: ";
						if(emit_value_4 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_4, graph, false, null, null, null));
						emit_value_4 = (GRGEN_LIBGR.GraphHelper.AdjacentIncoming(var_cur, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count;
						if(emit_value_4 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_4, graph, false, null, null, null));
						emit_value_4 = "\n";
						if(emit_value_4 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_4, graph, false, null, null, null));
						GRGEN_LIBGR.INode node_5 = var_cur;
						foreach(GRGEN_LIBGR.IEdge edge_5 in node_5.GetCompatibleIncoming(GRGEN_MODEL.EdgeType_AEdge.typeVar))
						{
							if(!edge_5.Source.InstanceOf(GRGEN_MODEL.NodeType_Node.typeVar))
								continue;
							GRGEN_LIBGR.INode var_x__INTERN = (GRGEN_LIBGR.INode)edge_5.Source;
							if(((((GRGEN_LGSP.LGSPNode)var_x__INTERN).lgspType != GRGEN_MODEL.NodeType_BPort.typeVar) && (! var_allMatchedNodes.ContainsKey(var_x__INTERN)))) {
								object emit_value_6;
								emit_value_6 = "\tchild = ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = var_x__INTERN;
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = " ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = ((GRGEN_LGSP.LGSPNode)var_x__INTERN).lgspType;
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = " ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = (var_indexMap[var_cur]);
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = " ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = GRGEN_LIBGR.GraphHelper.Outgoing(var_x__INTERN, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar);
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = "\n";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								GRGEN_LIBGR.INode node_7 = var_x__INTERN;
								foreach(GRGEN_LIBGR.IEdge edge_7 in node_7.GetCompatibleOutgoing(GRGEN_MODEL.EdgeType_AEdge.typeVar))
								{
									if(!edge_7.Target.InstanceOf(GRGEN_MODEL.NodeType_Node.typeVar))
										continue;
									GRGEN_LIBGR.IDEdge var_y = (GRGEN_LIBGR.IDEdge)edge_7;
									if((((GRGEN_LGSP.LGSPEdge)var_y).lgspType == GRGEN_MODEL.EdgeType_bPrnt.typeVar)) {
										object emit_value_8;
										emit_value_8 = "\ty";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = var_y;
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = " ";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = ((GRGEN_LGSP.LGSPEdge)var_y).lgspType;
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = " ";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = GRGEN_LIBGR.GraphHelper.Nameof(var_y, graph);
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = "\n";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										var_tasks[var_y] = (var_indexMap[var_cur]);
									}
								}
							}
						}
					}
				}
				Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.SetValueType> var_keyset = (Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.SetValueType>)(GRGEN_LIBGR.ContainerHelper.Domain(var_tasks));
				foreach(KeyValuePair<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.SetValueType> entry_9 in var_keyset)
				{
					GRGEN_LIBGR.IDEdge var_k = (GRGEN_LIBGR.IDEdge)entry_9.Key;
					((GRGEN_LGSP.LGSPNamedGraph)graph).RedirectTarget((GRGEN_LIBGR.IEdge)var_k, (GRGEN_LIBGR.INode)(var_tasks[var_k]));
				}
			}
			graph.Remove(edge_c1);
			graph.Remove(edge_c4);
			graph.Remove(edge_c5);
			graph.Remove(edge_c6);
			graph.Remove(edge_c7);
			graph.Remove(edge__edge0);
			graph.Remove(edge__edge1);
			graph.RemoveEdges(node_v4);
			graph.Remove(node_v4);
			graph.RemoveEdges(node_v4_p0);
			graph.Remove(node_v4_p0);
			graph.RemoveEdges(node_v2);
			graph.Remove(node_v2);
			graph.RemoveEdges(node_v2_p0);
			graph.Remove(node_v2_p0);
			graph.RemoveEdges(node_e0);
			graph.Remove(node_e0);
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.nac_NodesWithoutSites_Delete(actionEnv, subpattern_pat0);
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.nac_NodesWithoutSites_Delete(actionEnv, subpattern_pat1);
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.nac_NodesWithoutSites_Delete(actionEnv, subpattern_pat2);
			actionEnv.SelectedMatchRewritten();
			return;
		}
		private static string[] appendRule_addedNodeNames = new string[] { "v4_0658772", "v7_085d921", "v3_99a1941", "v5_5274933" };
		private static string[] appendRule_addedEdgeNames = new string[] { "_edge2", "_edge3", "_edge4", "_edge5", "_edge6" };

		static Rule_appendRule() {
		}

		public interface IMatch_appendRule : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.ICell node_v0 { get; set; }
			GRGEN_LIBGR.INode node_r0 { get; set; }
			GRGEN_MODEL.Iappend node_v4 { get; set; }
			GRGEN_LIBGR.INode node_r1 { get; set; }
			GRGEN_MODEL.Ithis node_v1 { get; set; }
			GRGEN_MODEL.Ival node_v3 { get; set; }
			GRGEN_MODEL.IBPort node_v4_p0 { get; set; }
			GRGEN_MODEL.Ival node_v5 { get; set; }
			GRGEN_MODEL.IthisRef node_v2 { get; set; }
			GRGEN_MODEL.IBPort node_v2_p0 { get; set; }
			GRGEN_MODEL.IBEdge node_e0 { get; set; }
			//Edges
			GRGEN_MODEL.IbPrnt edge_c0 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c1 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c2 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c3 { get; set; }
			GRGEN_MODEL.IbNode edge_c4 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c5 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c6 { get; set; }
			GRGEN_MODEL.IbNode edge_c7 { get; set; }
			GRGEN_MODEL.IbLink edge__edge0 { get; set; }
			GRGEN_MODEL.IbLink edge__edge1 { get; set; }
			//Variables
			//EmbeddedGraphs
			@GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat0 { get; }
			@GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat1 { get; }
			@GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat2 { get; }
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_appendRule : GRGEN_LGSP.MatchListElement<Match_appendRule>, IMatch_appendRule
		{
			public GRGEN_MODEL.ICell node_v0 { get { return (GRGEN_MODEL.ICell)_node_v0; } set { _node_v0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LIBGR.INode node_r0 { get { return (GRGEN_LIBGR.INode)_node_r0; } set { _node_r0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.Iappend node_v4 { get { return (GRGEN_MODEL.Iappend)_node_v4; } set { _node_v4 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LIBGR.INode node_r1 { get { return (GRGEN_LIBGR.INode)_node_r1; } set { _node_r1 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.Ithis node_v1 { get { return (GRGEN_MODEL.Ithis)_node_v1; } set { _node_v1 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.Ival node_v3 { get { return (GRGEN_MODEL.Ival)_node_v3; } set { _node_v3 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IBPort node_v4_p0 { get { return (GRGEN_MODEL.IBPort)_node_v4_p0; } set { _node_v4_p0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.Ival node_v5 { get { return (GRGEN_MODEL.Ival)_node_v5; } set { _node_v5 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IthisRef node_v2 { get { return (GRGEN_MODEL.IthisRef)_node_v2; } set { _node_v2 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IBPort node_v2_p0 { get { return (GRGEN_MODEL.IBPort)_node_v2_p0; } set { _node_v2_p0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IBEdge node_e0 { get { return (GRGEN_MODEL.IBEdge)_node_e0; } set { _node_e0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_v0;
			public GRGEN_LGSP.LGSPNode _node_r0;
			public GRGEN_LGSP.LGSPNode _node_v4;
			public GRGEN_LGSP.LGSPNode _node_r1;
			public GRGEN_LGSP.LGSPNode _node_v1;
			public GRGEN_LGSP.LGSPNode _node_v3;
			public GRGEN_LGSP.LGSPNode _node_v4_p0;
			public GRGEN_LGSP.LGSPNode _node_v5;
			public GRGEN_LGSP.LGSPNode _node_v2;
			public GRGEN_LGSP.LGSPNode _node_v2_p0;
			public GRGEN_LGSP.LGSPNode _node_e0;
			public enum appendRule_NodeNums { @v0, @r0, @v4, @r1, @v1, @v3, @v4_p0, @v5, @v2, @v2_p0, @e0, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 11; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)appendRule_NodeNums.@v0: return _node_v0;
				case (int)appendRule_NodeNums.@r0: return _node_r0;
				case (int)appendRule_NodeNums.@v4: return _node_v4;
				case (int)appendRule_NodeNums.@r1: return _node_r1;
				case (int)appendRule_NodeNums.@v1: return _node_v1;
				case (int)appendRule_NodeNums.@v3: return _node_v3;
				case (int)appendRule_NodeNums.@v4_p0: return _node_v4_p0;
				case (int)appendRule_NodeNums.@v5: return _node_v5;
				case (int)appendRule_NodeNums.@v2: return _node_v2;
				case (int)appendRule_NodeNums.@v2_p0: return _node_v2_p0;
				case (int)appendRule_NodeNums.@e0: return _node_e0;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "v0": return _node_v0;
				case "r0": return _node_r0;
				case "v4": return _node_v4;
				case "r1": return _node_r1;
				case "v1": return _node_v1;
				case "v3": return _node_v3;
				case "v4_p0": return _node_v4_p0;
				case "v5": return _node_v5;
				case "v2": return _node_v2;
				case "v2_p0": return _node_v2_p0;
				case "e0": return _node_e0;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "v0": _node_v0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "r0": _node_r0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v4": _node_v4 = (GRGEN_LGSP.LGSPNode)value; break;
				case "r1": _node_r1 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v1": _node_v1 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v3": _node_v3 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v4_p0": _node_v4_p0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v5": _node_v5 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v2": _node_v2 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v2_p0": _node_v2_p0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "e0": _node_e0 = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public GRGEN_MODEL.IbPrnt edge_c0 { get { return (GRGEN_MODEL.IbPrnt)_edge_c0; } set { _edge_c0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c1 { get { return (GRGEN_MODEL.IbPrnt)_edge_c1; } set { _edge_c1 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c2 { get { return (GRGEN_MODEL.IbPrnt)_edge_c2; } set { _edge_c2 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c3 { get { return (GRGEN_MODEL.IbPrnt)_edge_c3; } set { _edge_c3 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbNode edge_c4 { get { return (GRGEN_MODEL.IbNode)_edge_c4; } set { _edge_c4 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c5 { get { return (GRGEN_MODEL.IbPrnt)_edge_c5; } set { _edge_c5 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c6 { get { return (GRGEN_MODEL.IbPrnt)_edge_c6; } set { _edge_c6 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbNode edge_c7 { get { return (GRGEN_MODEL.IbNode)_edge_c7; } set { _edge_c7 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbLink edge__edge0 { get { return (GRGEN_MODEL.IbLink)_edge__edge0; } set { _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbLink edge__edge1 { get { return (GRGEN_MODEL.IbLink)_edge__edge1; } set { _edge__edge1 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_LGSP.LGSPEdge _edge_c0;
			public GRGEN_LGSP.LGSPEdge _edge_c1;
			public GRGEN_LGSP.LGSPEdge _edge_c2;
			public GRGEN_LGSP.LGSPEdge _edge_c3;
			public GRGEN_LGSP.LGSPEdge _edge_c4;
			public GRGEN_LGSP.LGSPEdge _edge_c5;
			public GRGEN_LGSP.LGSPEdge _edge_c6;
			public GRGEN_LGSP.LGSPEdge _edge_c7;
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public GRGEN_LGSP.LGSPEdge _edge__edge1;
			public enum appendRule_EdgeNums { @c0, @c1, @c2, @c3, @c4, @c5, @c6, @c7, @_edge0, @_edge1, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 10; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)appendRule_EdgeNums.@c0: return _edge_c0;
				case (int)appendRule_EdgeNums.@c1: return _edge_c1;
				case (int)appendRule_EdgeNums.@c2: return _edge_c2;
				case (int)appendRule_EdgeNums.@c3: return _edge_c3;
				case (int)appendRule_EdgeNums.@c4: return _edge_c4;
				case (int)appendRule_EdgeNums.@c5: return _edge_c5;
				case (int)appendRule_EdgeNums.@c6: return _edge_c6;
				case (int)appendRule_EdgeNums.@c7: return _edge_c7;
				case (int)appendRule_EdgeNums.@_edge0: return _edge__edge0;
				case (int)appendRule_EdgeNums.@_edge1: return _edge__edge1;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				case "c0": return _edge_c0;
				case "c1": return _edge_c1;
				case "c2": return _edge_c2;
				case "c3": return _edge_c3;
				case "c4": return _edge_c4;
				case "c5": return _edge_c5;
				case "c6": return _edge_c6;
				case "c7": return _edge_c7;
				case "_edge0": return _edge__edge0;
				case "_edge1": return _edge__edge1;
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				case "c0": _edge_c0 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c1": _edge_c1 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c2": _edge_c2 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c3": _edge_c3 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c4": _edge_c4 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c5": _edge_c5 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c6": _edge_c6 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c7": _edge_c7 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "_edge0": _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "_edge1": _edge__edge1 = (GRGEN_LGSP.LGSPEdge)value; break;
				default: break;
				}
			}

			public enum appendRule_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat0 { get { return @_pat0; } }
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat1 { get { return @_pat1; } }
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat2 { get { return @_pat2; } }
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @_pat0;
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @_pat1;
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @_pat2;
			public enum appendRule_SubNums { @pat0, @pat1, @pat2, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 3; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				case (int)appendRule_SubNums.@pat0: return _pat0;
				case (int)appendRule_SubNums.@pat1: return _pat1;
				case (int)appendRule_SubNums.@pat2: return _pat2;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				case "pat0": return _pat0;
				case "pat1": return _pat1;
				case "pat2": return _pat2;
				default: return null;
				}
			}

			public enum appendRule_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum appendRule_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum appendRule_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_appendRule.instance.pat_appendRule; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_appendRule(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_appendRule(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_appendRule nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_appendRule cur = this;
				while(cur != null) {
					Match_appendRule next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_appendRule that)
			{
				_node_v0 = that._node_v0;
				_node_r0 = that._node_r0;
				_node_v4 = that._node_v4;
				_node_r1 = that._node_r1;
				_node_v1 = that._node_v1;
				_node_v3 = that._node_v3;
				_node_v4_p0 = that._node_v4_p0;
				_node_v5 = that._node_v5;
				_node_v2 = that._node_v2;
				_node_v2_p0 = that._node_v2_p0;
				_node_e0 = that._node_e0;
				_edge_c0 = that._edge_c0;
				_edge_c1 = that._edge_c1;
				_edge_c2 = that._edge_c2;
				_edge_c3 = that._edge_c3;
				_edge_c4 = that._edge_c4;
				_edge_c5 = that._edge_c5;
				_edge_c6 = that._edge_c6;
				_edge_c7 = that._edge_c7;
				_edge__edge0 = that._edge__edge0;
				_edge__edge1 = that._edge__edge1;
				@_pat0 = that.@_pat0;
				@_pat1 = that.@_pat1;
				@_pat2 = that.@_pat2;
			}

			public Match_appendRule(Match_appendRule that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_appendRule that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_v0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v0];
				_node_r0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_r0];
				_node_v4 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v4];
				_node_r1 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_r1];
				_node_v1 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v1];
				_node_v3 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v3];
				_node_v4_p0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v4_p0];
				_node_v5 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v5];
				_node_v2 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v2];
				_node_v2_p0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v2_p0];
				_node_e0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_e0];
				_edge_c0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c0];
				_edge_c1 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c1];
				_edge_c2 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c2];
				_edge_c3 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c3];
				_edge_c4 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c4];
				_edge_c5 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c5];
				_edge_c6 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c6];
				_edge_c7 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c7];
				_edge__edge0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge0];
				_edge__edge1 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge1];
				@_pat0 = new GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites(that.@_pat0, oldToNewMap);
				@_pat1 = new GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites(that.@_pat1, oldToNewMap);
				@_pat2 = new GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites(that.@_pat2, oldToNewMap);
			}

			public Match_appendRule(Match_appendRule that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_appendRule()
			{
			}

			public bool IsEqual(Match_appendRule that)
			{
				if(that==null) return false;
				if(_node_v0 != that._node_v0) return false;
				if(_node_r0 != that._node_r0) return false;
				if(_node_v4 != that._node_v4) return false;
				if(_node_r1 != that._node_r1) return false;
				if(_node_v1 != that._node_v1) return false;
				if(_node_v3 != that._node_v3) return false;
				if(_node_v4_p0 != that._node_v4_p0) return false;
				if(_node_v5 != that._node_v5) return false;
				if(_node_v2 != that._node_v2) return false;
				if(_node_v2_p0 != that._node_v2_p0) return false;
				if(_node_e0 != that._node_e0) return false;
				if(_edge_c0 != that._edge_c0) return false;
				if(_edge_c1 != that._edge_c1) return false;
				if(_edge_c2 != that._edge_c2) return false;
				if(_edge_c3 != that._edge_c3) return false;
				if(_edge_c4 != that._edge_c4) return false;
				if(_edge_c5 != that._edge_c5) return false;
				if(_edge_c6 != that._edge_c6) return false;
				if(_edge_c7 != that._edge_c7) return false;
				if(_edge__edge0 != that._edge__edge0) return false;
				if(_edge__edge1 != that._edge__edge1) return false;
				if(!@_pat0.IsEqual(that.@_pat0)) return false;
				if(!@_pat1.IsEqual(that.@_pat1)) return false;
				if(!@_pat2.IsEqual(that.@_pat2)) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.ICell> Extract_v0(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.ICell> resultList = new List<GRGEN_MODEL.ICell>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_v0);
				return resultList;
			}
			public static List<GRGEN_LIBGR.INode> Extract_r0(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_LIBGR.INode> resultList = new List<GRGEN_LIBGR.INode>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_r0);
				return resultList;
			}
			public static List<GRGEN_MODEL.Iappend> Extract_v4(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.Iappend> resultList = new List<GRGEN_MODEL.Iappend>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_v4);
				return resultList;
			}
			public static List<GRGEN_LIBGR.INode> Extract_r1(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_LIBGR.INode> resultList = new List<GRGEN_LIBGR.INode>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_r1);
				return resultList;
			}
			public static List<GRGEN_MODEL.Ithis> Extract_v1(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.Ithis> resultList = new List<GRGEN_MODEL.Ithis>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_v1);
				return resultList;
			}
			public static List<GRGEN_MODEL.Ival> Extract_v3(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.Ival> resultList = new List<GRGEN_MODEL.Ival>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_v3);
				return resultList;
			}
			public static List<GRGEN_MODEL.IBPort> Extract_v4_p0(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IBPort> resultList = new List<GRGEN_MODEL.IBPort>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_v4_p0);
				return resultList;
			}
			public static List<GRGEN_MODEL.Ival> Extract_v5(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.Ival> resultList = new List<GRGEN_MODEL.Ival>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_v5);
				return resultList;
			}
			public static List<GRGEN_MODEL.IthisRef> Extract_v2(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IthisRef> resultList = new List<GRGEN_MODEL.IthisRef>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_v2);
				return resultList;
			}
			public static List<GRGEN_MODEL.IBPort> Extract_v2_p0(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IBPort> resultList = new List<GRGEN_MODEL.IBPort>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_v2_p0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IBEdge> Extract_e0(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IBEdge> resultList = new List<GRGEN_MODEL.IBEdge>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.node_e0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c0(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.edge_c0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c1(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.edge_c1);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c2(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.edge_c2);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c3(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.edge_c3);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbNode> Extract_c4(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IbNode> resultList = new List<GRGEN_MODEL.IbNode>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.edge_c4);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c5(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.edge_c5);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c6(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.edge_c6);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbNode> Extract_c7(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IbNode> resultList = new List<GRGEN_MODEL.IbNode>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.edge_c7);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbLink> Extract__edge0(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IbLink> resultList = new List<GRGEN_MODEL.IbLink>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.edge__edge0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbLink> Extract__edge1(List<IMatch_appendRule> matchList)
			{
				List<GRGEN_MODEL.IbLink> resultList = new List<GRGEN_MODEL.IbLink>(matchList.Count);
				foreach(IMatch_appendRule match in matchList)
					resultList.Add(match.edge__edge1);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>)
				return ((List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule instanceBearingAttributeForSearch_appendRule = new GRGEN_ACTIONS.Rule_appendRule.Match_appendRule();
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_v0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.ICell, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.ICell, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v0)) {
					seenValues[list[pos].@node_v0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_v0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.ICell, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.ICell, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v0, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_v0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.ICell entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_v0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.ICell entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.ICell entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.ICell entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_r0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_r0)) {
					seenValues[list[pos].@node_r0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_r0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_r0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_r0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_r0, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_r0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_r0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_r0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_r0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_v4(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.Iappend, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.Iappend, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v4)) {
					seenValues[list[pos].@node_v4].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v4, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_v4(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.Iappend, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Iappend, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v4)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v4, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_v4(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Iappend entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_v4(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Iappend entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v4(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Iappend entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v4(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Iappend entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v4.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_r1(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_r1)) {
					seenValues[list[pos].@node_r1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_r1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_r1(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_r1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_r1, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_r1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_r1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_r1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_r1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_v1(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.Ithis, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.Ithis, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v1)) {
					seenValues[list[pos].@node_v1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_v1(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.Ithis, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Ithis, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v1, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_v1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ithis entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_v1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ithis entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ithis entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ithis entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_v3(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.Ival, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.Ival, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v3)) {
					seenValues[list[pos].@node_v3].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v3, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_v3(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.Ival, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Ival, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v3)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v3, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_v3(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ival entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_v3(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ival entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v3(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ival entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v3(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ival entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_v4_p0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v4_p0)) {
					seenValues[list[pos].@node_v4_p0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v4_p0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_v4_p0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v4_p0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v4_p0, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_v4_p0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v4_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_v4_p0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v4_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v4_p0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v4_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v4_p0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v4_p0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_v5(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.Ival, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.Ival, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v5)) {
					seenValues[list[pos].@node_v5].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v5, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_v5(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.Ival, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Ival, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v5)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v5, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_v5(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ival entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_v5(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ival entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v5(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ival entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v5(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.Ival entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v5.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_v2(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IthisRef, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IthisRef, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v2)) {
					seenValues[list[pos].@node_v2].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v2, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_v2(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IthisRef, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IthisRef, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v2)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v2, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_v2(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IthisRef entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_v2(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IthisRef entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v2(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IthisRef entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v2(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IthisRef entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_v2_p0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v2_p0)) {
					seenValues[list[pos].@node_v2_p0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v2_p0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_v2_p0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v2_p0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v2_p0, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_v2_p0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v2_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_v2_p0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v2_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v2_p0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v2_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_v2_p0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v2_p0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_e0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IBEdge, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IBEdge, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_e0)) {
					seenValues[list[pos].@node_e0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_e0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_e0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IBEdge, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IBEdge, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_e0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_e0, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_e0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBEdge entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_e0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBEdge entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_e0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBEdge entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_e0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IBEdge entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_c0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c0)) {
					seenValues[list[pos].@edge_c0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_c0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c0, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_c0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_c0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_c1(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c1)) {
					seenValues[list[pos].@edge_c1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_c1(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c1, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_c1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_c1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_c2(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c2)) {
					seenValues[list[pos].@edge_c2].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c2, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_c2(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c2)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c2, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_c2(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_c2(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c2(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c2(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_c3(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c3)) {
					seenValues[list[pos].@edge_c3].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c3, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_c3(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c3)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c3, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_c3(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_c3(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c3(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c3(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_c4(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c4)) {
					seenValues[list[pos].@edge_c4].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c4, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_c4(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c4)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c4, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_c4(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_c4(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c4(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c4(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_c5(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c5)) {
					seenValues[list[pos].@edge_c5].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c5, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_c5(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c5)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c5, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_c5(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_c5(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c5(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c5(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_c6(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c6)) {
					seenValues[list[pos].@edge_c6].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c6, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_c6(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c6)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c6, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_c6(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c6.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_c6(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c6.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c6(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c6.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c6(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c6.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy_c7(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c7)) {
					seenValues[list[pos].@edge_c7].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c7, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy_c7(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c7)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c7, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy_c7(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c7.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy_c7(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c7.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c7(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c7.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy_c7(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c7.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy__edge0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge0)) {
					seenValues[list[pos].@edge__edge0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy__edge0(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge0, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_groupBy__edge1(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>> seenValues = new Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge1)) {
					seenValues[list[pos].@edge__edge1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> tempList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			foreach(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> Array_appendRule_keepOneForEachBy__edge1(List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list)
		{
			List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> newList = new List<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule>();
			Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge1, null);
				}
			}
			return newList;
		}
		public static int Array_appendRule_indexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_indexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_appendRule_lastIndexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_appendRule.IMatch_appendRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Rule_returnRule : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_returnRule instance = null;
		public static Rule_returnRule Instance { get { if(instance==null) { instance = new Rule_returnRule(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] returnRule_node_v0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] returnRule_node_r0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] returnRule_node_v2_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] returnRule_node_r1_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] returnRule_node_v1_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] returnRule_node_v2_p0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] returnRule_node_v3_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] returnRule_node_v1_p0_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] returnRule_node_e0_AllowedTypes = null;
		public static bool[] returnRule_node_v0_IsAllowedType = null;
		public static bool[] returnRule_node_r0_IsAllowedType = null;
		public static bool[] returnRule_node_v2_IsAllowedType = null;
		public static bool[] returnRule_node_r1_IsAllowedType = null;
		public static bool[] returnRule_node_v1_IsAllowedType = null;
		public static bool[] returnRule_node_v2_p0_IsAllowedType = null;
		public static bool[] returnRule_node_v3_IsAllowedType = null;
		public static bool[] returnRule_node_v1_p0_IsAllowedType = null;
		public static bool[] returnRule_node_e0_IsAllowedType = null;
		public static GRGEN_LIBGR.EdgeType[] returnRule_edge_c0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] returnRule_edge_c1_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] returnRule_edge_c2_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] returnRule_edge_c3_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] returnRule_edge_c4_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] returnRule_edge_c5_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] returnRule_edge__edge0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] returnRule_edge__edge1_AllowedTypes = null;
		public static bool[] returnRule_edge_c0_IsAllowedType = null;
		public static bool[] returnRule_edge_c1_IsAllowedType = null;
		public static bool[] returnRule_edge_c2_IsAllowedType = null;
		public static bool[] returnRule_edge_c3_IsAllowedType = null;
		public static bool[] returnRule_edge_c4_IsAllowedType = null;
		public static bool[] returnRule_edge_c5_IsAllowedType = null;
		public static bool[] returnRule_edge__edge0_IsAllowedType = null;
		public static bool[] returnRule_edge__edge1_IsAllowedType = null;
		public enum returnRule_NodeNums { @v0, @r0, @v2, @r1, @v1, @v2_p0, @v3, @v1_p0, @e0, };
		public enum returnRule_EdgeNums { @c0, @c1, @c2, @c3, @c4, @c5, @_edge0, @_edge1, };
		public enum returnRule_VariableNums { };
		public enum returnRule_SubNums { @pat0, @pat1, @pat2, };
		public enum returnRule_AltNums { };
		public enum returnRule_IterNums { };





		public static Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> fill_anonymous_set_6163(GRGEN_LIBGR.INode item0, GRGEN_LIBGR.INode item1, GRGEN_LIBGR.INode item2, GRGEN_LIBGR.INode item3, GRGEN_LIBGR.INode item4, GRGEN_LIBGR.INode item5) {
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> anonymous_set_6163 = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>();
			anonymous_set_6163[item0] = null;
			anonymous_set_6163[item1] = null;
			anonymous_set_6163[item2] = null;
			anonymous_set_6163[item3] = null;
			anonymous_set_6163[item4] = null;
			anonymous_set_6163[item5] = null;
			return anonymous_set_6163;
		}
		public static Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode> fill_anonymous_map_6173(GRGEN_LIBGR.INode itemkey0,GRGEN_LIBGR.INode itemvalue0) {
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode> anonymous_map_6173 = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode>();
			anonymous_map_6173[itemkey0] = itemvalue0;
			return anonymous_map_6173;
		}
		public static Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode> fill_anonymous_map_6178() {
			Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode> anonymous_map_6178 = new Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode>();
			return anonymous_map_6178;
		}

		public GRGEN_LGSP.PatternGraph pat_returnRule;


		private Rule_returnRule()
			: base("returnRule",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_ruleset.Rule_returnRule+IMatch_returnRule",
				"de.unika.ipd.grGen.Action_ruleset.Rule_returnRule+Match_returnRule"
			)
		{
		}
		private void initialize()
		{
			bool[,] returnRule_isNodeHomomorphicGlobal = new bool[9, 9] {
				{ false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, false, },
			};
			bool[,] returnRule_isEdgeHomomorphicGlobal = new bool[8, 8] {
				{ false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, },
				{ false, false, false, false, false, false, false, false, },
			};
			bool[] returnRule_isNodeTotallyHomomorphic = new bool[9] { false, false, false, false, false, false, false, false, false,  };
			bool[] returnRule_isEdgeTotallyHomomorphic = new bool[8] { false, false, false, false, false, false, false, false,  };
			GRGEN_LGSP.PatternNode returnRule_node_v0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@this, GRGEN_MODEL.NodeType_this.typeVar, "GRGEN_MODEL.Ithis", "returnRule_node_v0", "v0", returnRule_node_v0_AllowedTypes, returnRule_node_v0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode returnRule_node_r0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Node, GRGEN_MODEL.NodeType_Node.typeVar, "GRGEN_LIBGR.INode", "returnRule_node_r0", "r0", returnRule_node_r0_AllowedTypes, returnRule_node_r0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode returnRule_node_v2 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@append, GRGEN_MODEL.NodeType_append.typeVar, "GRGEN_MODEL.Iappend", "returnRule_node_v2", "v2", returnRule_node_v2_AllowedTypes, returnRule_node_v2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode returnRule_node_r1 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Node, GRGEN_MODEL.NodeType_Node.typeVar, "GRGEN_LIBGR.INode", "returnRule_node_r1", "r1", returnRule_node_r1_AllowedTypes, returnRule_node_r1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode returnRule_node_v1 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@thisRef, GRGEN_MODEL.NodeType_thisRef.typeVar, "GRGEN_MODEL.IthisRef", "returnRule_node_v1", "v1", returnRule_node_v1_AllowedTypes, returnRule_node_v1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode returnRule_node_v2_p0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@BPort, GRGEN_MODEL.NodeType_BPort.typeVar, "GRGEN_MODEL.IBPort", "returnRule_node_v2_p0", "v2_p0", returnRule_node_v2_p0_AllowedTypes, returnRule_node_v2_p0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode returnRule_node_v3 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Void, GRGEN_MODEL.NodeType_Void.typeVar, "GRGEN_MODEL.IVoid", "returnRule_node_v3", "v3", returnRule_node_v3_AllowedTypes, returnRule_node_v3_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode returnRule_node_v1_p0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@BPort, GRGEN_MODEL.NodeType_BPort.typeVar, "GRGEN_MODEL.IBPort", "returnRule_node_v1_p0", "v1_p0", returnRule_node_v1_p0_AllowedTypes, returnRule_node_v1_p0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode returnRule_node_e0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@BEdge, GRGEN_MODEL.NodeType_BEdge.typeVar, "GRGEN_MODEL.IBEdge", "returnRule_node_e0", "e0", returnRule_node_e0_AllowedTypes, returnRule_node_e0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge returnRule_edge_c0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "returnRule_edge_c0", "c0", returnRule_edge_c0_AllowedTypes, returnRule_edge_c0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge returnRule_edge_c1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "returnRule_edge_c1", "c1", returnRule_edge_c1_AllowedTypes, returnRule_edge_c1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge returnRule_edge_c2 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "returnRule_edge_c2", "c2", returnRule_edge_c2_AllowedTypes, returnRule_edge_c2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge returnRule_edge_c3 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bNode, GRGEN_MODEL.EdgeType_bNode.typeVar, "GRGEN_MODEL.IbNode", "returnRule_edge_c3", "c3", returnRule_edge_c3_AllowedTypes, returnRule_edge_c3_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge returnRule_edge_c4 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bPrnt, GRGEN_MODEL.EdgeType_bPrnt.typeVar, "GRGEN_MODEL.IbPrnt", "returnRule_edge_c4", "c4", returnRule_edge_c4_AllowedTypes, returnRule_edge_c4_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge returnRule_edge_c5 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bNode, GRGEN_MODEL.EdgeType_bNode.typeVar, "GRGEN_MODEL.IbNode", "returnRule_edge_c5", "c5", returnRule_edge_c5_AllowedTypes, returnRule_edge_c5_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge returnRule_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bLink, GRGEN_MODEL.EdgeType_bLink.typeVar, "GRGEN_MODEL.IbLink", "returnRule_edge__edge0", "_edge0", returnRule_edge__edge0_AllowedTypes, returnRule_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge returnRule_edge__edge1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@bLink, GRGEN_MODEL.EdgeType_bLink.typeVar, "GRGEN_MODEL.IbLink", "returnRule_edge__edge1", "_edge1", returnRule_edge__edge1_AllowedTypes, returnRule_edge__edge1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternGraphEmbedding returnRule_pat0 = new GRGEN_LGSP.PatternGraphEmbedding("pat0", Pattern_nac_NodesWithoutSites.Instance, 
				new GRGEN_EXPR.Expression[] {
					new GRGEN_EXPR.GraphEntityExpression("returnRule_node_v1"),
					new GRGEN_EXPR.Constant("0"),
				}, 
				new string[] { }, new GRGEN_LGSP.PatternElement[] { }, new GRGEN_LGSP.PatternVariable[] { },
				new string[] { "returnRule_node_v1" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { returnRule_node_v1 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternGraphEmbedding returnRule_pat1 = new GRGEN_LGSP.PatternGraphEmbedding("pat1", Pattern_nac_NodesWithoutSites.Instance, 
				new GRGEN_EXPR.Expression[] {
					new GRGEN_EXPR.GraphEntityExpression("returnRule_node_v2"),
					new GRGEN_EXPR.Constant("1"),
				}, 
				new string[] { }, new GRGEN_LGSP.PatternElement[] { }, new GRGEN_LGSP.PatternVariable[] { },
				new string[] { "returnRule_node_v2" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { returnRule_node_v2 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternGraphEmbedding returnRule_pat2 = new GRGEN_LGSP.PatternGraphEmbedding("pat2", Pattern_nac_NodesWithoutSites.Instance, 
				new GRGEN_EXPR.Expression[] {
					new GRGEN_EXPR.GraphEntityExpression("returnRule_node_v3"),
					new GRGEN_EXPR.Constant("0"),
				}, 
				new string[] { }, new GRGEN_LGSP.PatternElement[] { }, new GRGEN_LGSP.PatternVariable[] { },
				new string[] { "returnRule_node_v3" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { returnRule_node_v3 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternCondition returnRule_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IBPort", true, "returnRule_node_v1_p0", "ix"), new GRGEN_EXPR.Constant("0")),
				new string[] { "returnRule_node_v1_p0" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { returnRule_node_v1_p0 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			GRGEN_LGSP.PatternCondition returnRule_cond_1 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IBPort", true, "returnRule_node_v2_p0", "ix"), new GRGEN_EXPR.Constant("0")),
				new string[] { "returnRule_node_v2_p0" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { returnRule_node_v2_p0 }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			pat_returnRule = new GRGEN_LGSP.PatternGraph(
				"returnRule",
				"",
				null, "returnRule",
				false, false,
				new GRGEN_LGSP.PatternNode[] { returnRule_node_v0, returnRule_node_r0, returnRule_node_v2, returnRule_node_r1, returnRule_node_v1, returnRule_node_v2_p0, returnRule_node_v3, returnRule_node_v1_p0, returnRule_node_e0 }, 
				new GRGEN_LGSP.PatternEdge[] { returnRule_edge_c0, returnRule_edge_c1, returnRule_edge_c2, returnRule_edge_c3, returnRule_edge_c4, returnRule_edge_c5, returnRule_edge__edge0, returnRule_edge__edge1 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] { returnRule_pat0, returnRule_pat1, returnRule_pat2 }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { returnRule_cond_0, returnRule_cond_1,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[9, 9] {
					{ true, false, false, false, false, false, false, false, false, },
					{ false, true, false, false, false, false, false, false, false, },
					{ false, false, true, false, false, false, false, false, false, },
					{ false, false, false, true, false, false, false, false, false, },
					{ false, false, false, false, true, false, false, false, false, },
					{ false, false, false, false, false, true, false, false, false, },
					{ false, false, false, false, false, false, true, false, false, },
					{ false, false, false, false, false, false, false, true, false, },
					{ false, false, false, false, false, false, false, false, true, },
				},
				new bool[8, 8] {
					{ true, false, false, false, false, false, false, false, },
					{ false, true, false, false, false, false, false, false, },
					{ false, false, true, false, false, false, false, false, },
					{ false, false, false, true, false, false, false, false, },
					{ false, false, false, false, true, false, false, false, },
					{ false, false, false, false, false, true, false, false, },
					{ false, false, false, false, false, false, true, false, },
					{ false, false, false, false, false, false, false, true, },
				},
				returnRule_isNodeHomomorphicGlobal,
				returnRule_isEdgeHomomorphicGlobal,
				returnRule_isNodeTotallyHomomorphic,
				returnRule_isEdgeTotallyHomomorphic
			);
			pat_returnRule.edgeToSourceNode.Add(returnRule_edge_c0, returnRule_node_v0);
			pat_returnRule.edgeToTargetNode.Add(returnRule_edge_c0, returnRule_node_r0);
			pat_returnRule.edgeToSourceNode.Add(returnRule_edge_c1, returnRule_node_v2);
			pat_returnRule.edgeToTargetNode.Add(returnRule_edge_c1, returnRule_node_r1);
			pat_returnRule.edgeToSourceNode.Add(returnRule_edge_c2, returnRule_node_v1);
			pat_returnRule.edgeToTargetNode.Add(returnRule_edge_c2, returnRule_node_v0);
			pat_returnRule.edgeToSourceNode.Add(returnRule_edge_c3, returnRule_node_v2_p0);
			pat_returnRule.edgeToTargetNode.Add(returnRule_edge_c3, returnRule_node_v2);
			pat_returnRule.edgeToSourceNode.Add(returnRule_edge_c4, returnRule_node_v3);
			pat_returnRule.edgeToTargetNode.Add(returnRule_edge_c4, returnRule_node_v2);
			pat_returnRule.edgeToSourceNode.Add(returnRule_edge_c5, returnRule_node_v1_p0);
			pat_returnRule.edgeToTargetNode.Add(returnRule_edge_c5, returnRule_node_v1);
			pat_returnRule.edgeToSourceNode.Add(returnRule_edge__edge0, returnRule_node_v2_p0);
			pat_returnRule.edgeToTargetNode.Add(returnRule_edge__edge0, returnRule_node_e0);
			pat_returnRule.edgeToSourceNode.Add(returnRule_edge__edge1, returnRule_node_v1_p0);
			pat_returnRule.edgeToTargetNode.Add(returnRule_edge__edge1, returnRule_node_e0);

			returnRule_node_v0.pointOfDefinition = pat_returnRule;
			returnRule_node_r0.pointOfDefinition = pat_returnRule;
			returnRule_node_v2.pointOfDefinition = pat_returnRule;
			returnRule_node_r1.pointOfDefinition = pat_returnRule;
			returnRule_node_v1.pointOfDefinition = pat_returnRule;
			returnRule_node_v2_p0.pointOfDefinition = pat_returnRule;
			returnRule_node_v3.pointOfDefinition = pat_returnRule;
			returnRule_node_v1_p0.pointOfDefinition = pat_returnRule;
			returnRule_node_e0.pointOfDefinition = pat_returnRule;
			returnRule_edge_c0.pointOfDefinition = pat_returnRule;
			returnRule_edge_c1.pointOfDefinition = pat_returnRule;
			returnRule_edge_c2.pointOfDefinition = pat_returnRule;
			returnRule_edge_c3.pointOfDefinition = pat_returnRule;
			returnRule_edge_c4.pointOfDefinition = pat_returnRule;
			returnRule_edge_c5.pointOfDefinition = pat_returnRule;
			returnRule_edge__edge0.pointOfDefinition = pat_returnRule;
			returnRule_edge__edge1.pointOfDefinition = pat_returnRule;
			returnRule_pat0.PointOfDefinition = pat_returnRule;
			returnRule_pat1.PointOfDefinition = pat_returnRule;
			returnRule_pat2.PointOfDefinition = pat_returnRule;

			patternGraph = pat_returnRule;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_returnRule curMatch = (Match_returnRule)_curMatch;
			GRGEN_LGSP.LGSPNode node_v0 = curMatch._node_v0;
			GRGEN_LGSP.LGSPNode node_v1 = curMatch._node_v1;
			GRGEN_LGSP.LGSPNode node_v2 = curMatch._node_v2;
			GRGEN_LGSP.LGSPNode node_v3 = curMatch._node_v3;
			GRGEN_LGSP.LGSPNode node_r0 = curMatch._node_r0;
			GRGEN_LGSP.LGSPNode node_r1 = curMatch._node_r1;
			GRGEN_LGSP.LGSPNode node_v2_p0 = curMatch._node_v2_p0;
			GRGEN_LGSP.LGSPNode node_v1_p0 = curMatch._node_v1_p0;
			GRGEN_LGSP.LGSPNode node_e0 = curMatch._node_e0;
			GRGEN_LGSP.LGSPEdge edge_c1 = curMatch._edge_c1;
			GRGEN_LGSP.LGSPEdge edge_c2 = curMatch._edge_c2;
			GRGEN_LGSP.LGSPEdge edge_c3 = curMatch._edge_c3;
			GRGEN_LGSP.LGSPEdge edge_c4 = curMatch._edge_c4;
			GRGEN_LGSP.LGSPEdge edge_c5 = curMatch._edge_c5;
			GRGEN_LGSP.LGSPEdge edge__edge0 = curMatch._edge__edge0;
			GRGEN_LGSP.LGSPEdge edge__edge1 = curMatch._edge__edge1;
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites subpattern_pat0 = curMatch.@_pat0;
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites subpattern_pat1 = curMatch.@_pat1;
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites subpattern_pat2 = curMatch.@_pat2;
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> var_allMatchedNodes = fill_anonymous_set_6163(((GRGEN_LIBGR.INode) node_v0), ((GRGEN_LIBGR.INode) node_v1), ((GRGEN_LIBGR.INode) node_v2), ((GRGEN_LIBGR.INode) node_v3), (GRGEN_LIBGR.INode)(node_r0), (GRGEN_LIBGR.INode)(node_r1));
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.INode> var_indexMap = fill_anonymous_map_6173(((GRGEN_LIBGR.INode) node_v0), ((GRGEN_LIBGR.INode) node_v0));
			Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.INode> var_tasks = fill_anonymous_map_6178();
			graph.SettingAddedNodeNames( returnRule_addedNodeNames );
			graph.SettingAddedEdgeNames( returnRule_addedEdgeNames );
			GRGEN_MODEL.@bPrnt edge__edge2 = GRGEN_MODEL.@bPrnt.CreateEdge(graph, node_v3, node_r1);
			{ // eval_0
				Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> var_nodesWithSites = (Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>)(GRGEN_LIBGR.ContainerHelper.Domain(var_indexMap));
				foreach(KeyValuePair<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> entry_0 in var_nodesWithSites)
				{
					GRGEN_LIBGR.INode var_cur = (GRGEN_LIBGR.INode)entry_0.Key;
					object emit_value_1;
					emit_value_1 = var_cur;
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = "->";
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = (var_indexMap[var_cur]);
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = " ";
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = GRGEN_LIBGR.GraphHelper.CountAdjacentIncoming(graph, var_cur, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar);
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					emit_value_1 = "\n";
					if(emit_value_1 != null)
						((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_1, graph, false, null, null, null));
					if(((var_indexMap[var_cur]) == null)) {
						object emit_value_2;
						emit_value_2 = "Remove everything because there is no site mapping for the reactum";
						if(emit_value_2 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_2, graph, false, null, null, null));
						emit_value_2 = GRGEN_LIBGR.GraphHelper.AdjacentIncoming(var_cur, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar);
						if(emit_value_2 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_2, graph, false, null, null, null));
						emit_value_2 = "\n";
						if(emit_value_2 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_2, graph, false, null, null, null));
						GRGEN_LIBGR.INode node_3 = var_cur;
						foreach(GRGEN_LIBGR.IEdge edge_3 in node_3.GetCompatibleIncoming(GRGEN_MODEL.EdgeType_AEdge.typeVar))
						{
							if(!edge_3.Source.InstanceOf(GRGEN_MODEL.NodeType_Node.typeVar))
								continue;
							GRGEN_LIBGR.INode var_x__INTERN = (GRGEN_LIBGR.INode)edge_3.Source;
							if((((GRGEN_LGSP.LGSPNode)var_x__INTERN).lgspType != GRGEN_MODEL.NodeType_BPort.typeVar)) {
								graph.RemoveEdges((GRGEN_LIBGR.INode)var_x__INTERN);
								graph.Remove((GRGEN_LIBGR.INode)var_x__INTERN);
							}
						}
						continue;
					}
					if((var_cur != (var_indexMap[var_cur]))) {
						object emit_value_4;
						emit_value_4 = "Site mappings are different! Size of children: ";
						if(emit_value_4 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_4, graph, false, null, null, null));
						emit_value_4 = (GRGEN_LIBGR.GraphHelper.AdjacentIncoming(var_cur, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count;
						if(emit_value_4 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_4, graph, false, null, null, null));
						emit_value_4 = "\n";
						if(emit_value_4 != null)
							((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_4, graph, false, null, null, null));
						GRGEN_LIBGR.INode node_5 = var_cur;
						foreach(GRGEN_LIBGR.IEdge edge_5 in node_5.GetCompatibleIncoming(GRGEN_MODEL.EdgeType_AEdge.typeVar))
						{
							if(!edge_5.Source.InstanceOf(GRGEN_MODEL.NodeType_Node.typeVar))
								continue;
							GRGEN_LIBGR.INode var_x__INTERN = (GRGEN_LIBGR.INode)edge_5.Source;
							if(((((GRGEN_LGSP.LGSPNode)var_x__INTERN).lgspType != GRGEN_MODEL.NodeType_BPort.typeVar) && (! var_allMatchedNodes.ContainsKey(var_x__INTERN)))) {
								object emit_value_6;
								emit_value_6 = "\tchild = ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = var_x__INTERN;
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = " ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = ((GRGEN_LGSP.LGSPNode)var_x__INTERN).lgspType;
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = " ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = (var_indexMap[var_cur]);
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = " ";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = GRGEN_LIBGR.GraphHelper.Outgoing(var_x__INTERN, GRGEN_MODEL.EdgeType_AEdge.typeVar, GRGEN_MODEL.NodeType_Node.typeVar);
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								emit_value_6 = "\n";
								if(emit_value_6 != null)
									((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_6, graph, false, null, null, null));
								GRGEN_LIBGR.INode node_7 = var_x__INTERN;
								foreach(GRGEN_LIBGR.IEdge edge_7 in node_7.GetCompatibleOutgoing(GRGEN_MODEL.EdgeType_AEdge.typeVar))
								{
									if(!edge_7.Target.InstanceOf(GRGEN_MODEL.NodeType_Node.typeVar))
										continue;
									GRGEN_LIBGR.IDEdge var_y = (GRGEN_LIBGR.IDEdge)edge_7;
									if((((GRGEN_LGSP.LGSPEdge)var_y).lgspType == GRGEN_MODEL.EdgeType_bPrnt.typeVar)) {
										object emit_value_8;
										emit_value_8 = "\ty";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = var_y;
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = " ";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = ((GRGEN_LGSP.LGSPEdge)var_y).lgspType;
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = " ";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = GRGEN_LIBGR.GraphHelper.Nameof(var_y, graph);
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										emit_value_8 = "\n";
										if(emit_value_8 != null)
											((GRGEN_LGSP.LGSPGraphProcessingEnvironment)actionEnv).EmitWriter.Write(GRGEN_LIBGR.EmitHelper.ToStringNonNull(emit_value_8, graph, false, null, null, null));
										var_tasks[var_y] = (var_indexMap[var_cur]);
									}
								}
							}
						}
					}
				}
				Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.SetValueType> var_keyset = (Dictionary<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.SetValueType>)(GRGEN_LIBGR.ContainerHelper.Domain(var_tasks));
				foreach(KeyValuePair<GRGEN_LIBGR.IDEdge, GRGEN_LIBGR.SetValueType> entry_9 in var_keyset)
				{
					GRGEN_LIBGR.IDEdge var_k = (GRGEN_LIBGR.IDEdge)entry_9.Key;
					((GRGEN_LGSP.LGSPNamedGraph)graph).RedirectTarget((GRGEN_LIBGR.IEdge)var_k, (GRGEN_LIBGR.INode)(var_tasks[var_k]));
				}
			}
			graph.Remove(edge_c1);
			graph.Remove(edge_c2);
			graph.Remove(edge_c3);
			graph.Remove(edge_c4);
			graph.Remove(edge_c5);
			graph.Remove(edge__edge0);
			graph.Remove(edge__edge1);
			graph.RemoveEdges(node_v2);
			graph.Remove(node_v2);
			graph.RemoveEdges(node_v1);
			graph.Remove(node_v1);
			graph.RemoveEdges(node_v2_p0);
			graph.Remove(node_v2_p0);
			graph.RemoveEdges(node_v1_p0);
			graph.Remove(node_v1_p0);
			graph.RemoveEdges(node_e0);
			graph.Remove(node_e0);
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.nac_NodesWithoutSites_Delete(actionEnv, subpattern_pat0);
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.nac_NodesWithoutSites_Delete(actionEnv, subpattern_pat1);
			GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.nac_NodesWithoutSites_Delete(actionEnv, subpattern_pat2);
			actionEnv.SelectedMatchRewritten();
			return;
		}
		private static string[] returnRule_addedNodeNames = new string[] {  };
		private static string[] returnRule_addedEdgeNames = new string[] { "_edge2" };

		static Rule_returnRule() {
		}

		public interface IMatch_returnRule : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.Ithis node_v0 { get; set; }
			GRGEN_LIBGR.INode node_r0 { get; set; }
			GRGEN_MODEL.Iappend node_v2 { get; set; }
			GRGEN_LIBGR.INode node_r1 { get; set; }
			GRGEN_MODEL.IthisRef node_v1 { get; set; }
			GRGEN_MODEL.IBPort node_v2_p0 { get; set; }
			GRGEN_MODEL.IVoid node_v3 { get; set; }
			GRGEN_MODEL.IBPort node_v1_p0 { get; set; }
			GRGEN_MODEL.IBEdge node_e0 { get; set; }
			//Edges
			GRGEN_MODEL.IbPrnt edge_c0 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c1 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c2 { get; set; }
			GRGEN_MODEL.IbNode edge_c3 { get; set; }
			GRGEN_MODEL.IbPrnt edge_c4 { get; set; }
			GRGEN_MODEL.IbNode edge_c5 { get; set; }
			GRGEN_MODEL.IbLink edge__edge0 { get; set; }
			GRGEN_MODEL.IbLink edge__edge1 { get; set; }
			//Variables
			//EmbeddedGraphs
			@GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat0 { get; }
			@GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat1 { get; }
			@GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat2 { get; }
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_returnRule : GRGEN_LGSP.MatchListElement<Match_returnRule>, IMatch_returnRule
		{
			public GRGEN_MODEL.Ithis node_v0 { get { return (GRGEN_MODEL.Ithis)_node_v0; } set { _node_v0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LIBGR.INode node_r0 { get { return (GRGEN_LIBGR.INode)_node_r0; } set { _node_r0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.Iappend node_v2 { get { return (GRGEN_MODEL.Iappend)_node_v2; } set { _node_v2 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LIBGR.INode node_r1 { get { return (GRGEN_LIBGR.INode)_node_r1; } set { _node_r1 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IthisRef node_v1 { get { return (GRGEN_MODEL.IthisRef)_node_v1; } set { _node_v1 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IBPort node_v2_p0 { get { return (GRGEN_MODEL.IBPort)_node_v2_p0; } set { _node_v2_p0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IVoid node_v3 { get { return (GRGEN_MODEL.IVoid)_node_v3; } set { _node_v3 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IBPort node_v1_p0 { get { return (GRGEN_MODEL.IBPort)_node_v1_p0; } set { _node_v1_p0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IBEdge node_e0 { get { return (GRGEN_MODEL.IBEdge)_node_e0; } set { _node_e0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_v0;
			public GRGEN_LGSP.LGSPNode _node_r0;
			public GRGEN_LGSP.LGSPNode _node_v2;
			public GRGEN_LGSP.LGSPNode _node_r1;
			public GRGEN_LGSP.LGSPNode _node_v1;
			public GRGEN_LGSP.LGSPNode _node_v2_p0;
			public GRGEN_LGSP.LGSPNode _node_v3;
			public GRGEN_LGSP.LGSPNode _node_v1_p0;
			public GRGEN_LGSP.LGSPNode _node_e0;
			public enum returnRule_NodeNums { @v0, @r0, @v2, @r1, @v1, @v2_p0, @v3, @v1_p0, @e0, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 9; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)returnRule_NodeNums.@v0: return _node_v0;
				case (int)returnRule_NodeNums.@r0: return _node_r0;
				case (int)returnRule_NodeNums.@v2: return _node_v2;
				case (int)returnRule_NodeNums.@r1: return _node_r1;
				case (int)returnRule_NodeNums.@v1: return _node_v1;
				case (int)returnRule_NodeNums.@v2_p0: return _node_v2_p0;
				case (int)returnRule_NodeNums.@v3: return _node_v3;
				case (int)returnRule_NodeNums.@v1_p0: return _node_v1_p0;
				case (int)returnRule_NodeNums.@e0: return _node_e0;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "v0": return _node_v0;
				case "r0": return _node_r0;
				case "v2": return _node_v2;
				case "r1": return _node_r1;
				case "v1": return _node_v1;
				case "v2_p0": return _node_v2_p0;
				case "v3": return _node_v3;
				case "v1_p0": return _node_v1_p0;
				case "e0": return _node_e0;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "v0": _node_v0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "r0": _node_r0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v2": _node_v2 = (GRGEN_LGSP.LGSPNode)value; break;
				case "r1": _node_r1 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v1": _node_v1 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v2_p0": _node_v2_p0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v3": _node_v3 = (GRGEN_LGSP.LGSPNode)value; break;
				case "v1_p0": _node_v1_p0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "e0": _node_e0 = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public GRGEN_MODEL.IbPrnt edge_c0 { get { return (GRGEN_MODEL.IbPrnt)_edge_c0; } set { _edge_c0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c1 { get { return (GRGEN_MODEL.IbPrnt)_edge_c1; } set { _edge_c1 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c2 { get { return (GRGEN_MODEL.IbPrnt)_edge_c2; } set { _edge_c2 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbNode edge_c3 { get { return (GRGEN_MODEL.IbNode)_edge_c3; } set { _edge_c3 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbPrnt edge_c4 { get { return (GRGEN_MODEL.IbPrnt)_edge_c4; } set { _edge_c4 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbNode edge_c5 { get { return (GRGEN_MODEL.IbNode)_edge_c5; } set { _edge_c5 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbLink edge__edge0 { get { return (GRGEN_MODEL.IbLink)_edge__edge0; } set { _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.IbLink edge__edge1 { get { return (GRGEN_MODEL.IbLink)_edge__edge1; } set { _edge__edge1 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_LGSP.LGSPEdge _edge_c0;
			public GRGEN_LGSP.LGSPEdge _edge_c1;
			public GRGEN_LGSP.LGSPEdge _edge_c2;
			public GRGEN_LGSP.LGSPEdge _edge_c3;
			public GRGEN_LGSP.LGSPEdge _edge_c4;
			public GRGEN_LGSP.LGSPEdge _edge_c5;
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public GRGEN_LGSP.LGSPEdge _edge__edge1;
			public enum returnRule_EdgeNums { @c0, @c1, @c2, @c3, @c4, @c5, @_edge0, @_edge1, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 8; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)returnRule_EdgeNums.@c0: return _edge_c0;
				case (int)returnRule_EdgeNums.@c1: return _edge_c1;
				case (int)returnRule_EdgeNums.@c2: return _edge_c2;
				case (int)returnRule_EdgeNums.@c3: return _edge_c3;
				case (int)returnRule_EdgeNums.@c4: return _edge_c4;
				case (int)returnRule_EdgeNums.@c5: return _edge_c5;
				case (int)returnRule_EdgeNums.@_edge0: return _edge__edge0;
				case (int)returnRule_EdgeNums.@_edge1: return _edge__edge1;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				case "c0": return _edge_c0;
				case "c1": return _edge_c1;
				case "c2": return _edge_c2;
				case "c3": return _edge_c3;
				case "c4": return _edge_c4;
				case "c5": return _edge_c5;
				case "_edge0": return _edge__edge0;
				case "_edge1": return _edge__edge1;
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				case "c0": _edge_c0 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c1": _edge_c1 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c2": _edge_c2 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c3": _edge_c3 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c4": _edge_c4 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "c5": _edge_c5 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "_edge0": _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "_edge1": _edge__edge1 = (GRGEN_LGSP.LGSPEdge)value; break;
				default: break;
				}
			}

			public enum returnRule_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat0 { get { return @_pat0; } }
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat1 { get { return @_pat1; } }
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @pat2 { get { return @_pat2; } }
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @_pat0;
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @_pat1;
			public @GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites @_pat2;
			public enum returnRule_SubNums { @pat0, @pat1, @pat2, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 3; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				case (int)returnRule_SubNums.@pat0: return _pat0;
				case (int)returnRule_SubNums.@pat1: return _pat1;
				case (int)returnRule_SubNums.@pat2: return _pat2;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				case "pat0": return _pat0;
				case "pat1": return _pat1;
				case "pat2": return _pat2;
				default: return null;
				}
			}

			public enum returnRule_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum returnRule_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum returnRule_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_returnRule.instance.pat_returnRule; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_returnRule(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_returnRule(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_returnRule nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_returnRule cur = this;
				while(cur != null) {
					Match_returnRule next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_returnRule that)
			{
				_node_v0 = that._node_v0;
				_node_r0 = that._node_r0;
				_node_v2 = that._node_v2;
				_node_r1 = that._node_r1;
				_node_v1 = that._node_v1;
				_node_v2_p0 = that._node_v2_p0;
				_node_v3 = that._node_v3;
				_node_v1_p0 = that._node_v1_p0;
				_node_e0 = that._node_e0;
				_edge_c0 = that._edge_c0;
				_edge_c1 = that._edge_c1;
				_edge_c2 = that._edge_c2;
				_edge_c3 = that._edge_c3;
				_edge_c4 = that._edge_c4;
				_edge_c5 = that._edge_c5;
				_edge__edge0 = that._edge__edge0;
				_edge__edge1 = that._edge__edge1;
				@_pat0 = that.@_pat0;
				@_pat1 = that.@_pat1;
				@_pat2 = that.@_pat2;
			}

			public Match_returnRule(Match_returnRule that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_returnRule that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_v0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v0];
				_node_r0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_r0];
				_node_v2 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v2];
				_node_r1 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_r1];
				_node_v1 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v1];
				_node_v2_p0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v2_p0];
				_node_v3 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v3];
				_node_v1_p0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_v1_p0];
				_node_e0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_e0];
				_edge_c0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c0];
				_edge_c1 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c1];
				_edge_c2 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c2];
				_edge_c3 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c3];
				_edge_c4 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c4];
				_edge_c5 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge_c5];
				_edge__edge0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge0];
				_edge__edge1 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge1];
				@_pat0 = new GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites(that.@_pat0, oldToNewMap);
				@_pat1 = new GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites(that.@_pat1, oldToNewMap);
				@_pat2 = new GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites(that.@_pat2, oldToNewMap);
			}

			public Match_returnRule(Match_returnRule that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_returnRule()
			{
			}

			public bool IsEqual(Match_returnRule that)
			{
				if(that==null) return false;
				if(_node_v0 != that._node_v0) return false;
				if(_node_r0 != that._node_r0) return false;
				if(_node_v2 != that._node_v2) return false;
				if(_node_r1 != that._node_r1) return false;
				if(_node_v1 != that._node_v1) return false;
				if(_node_v2_p0 != that._node_v2_p0) return false;
				if(_node_v3 != that._node_v3) return false;
				if(_node_v1_p0 != that._node_v1_p0) return false;
				if(_node_e0 != that._node_e0) return false;
				if(_edge_c0 != that._edge_c0) return false;
				if(_edge_c1 != that._edge_c1) return false;
				if(_edge_c2 != that._edge_c2) return false;
				if(_edge_c3 != that._edge_c3) return false;
				if(_edge_c4 != that._edge_c4) return false;
				if(_edge_c5 != that._edge_c5) return false;
				if(_edge__edge0 != that._edge__edge0) return false;
				if(_edge__edge1 != that._edge__edge1) return false;
				if(!@_pat0.IsEqual(that.@_pat0)) return false;
				if(!@_pat1.IsEqual(that.@_pat1)) return false;
				if(!@_pat2.IsEqual(that.@_pat2)) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.Ithis> Extract_v0(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.Ithis> resultList = new List<GRGEN_MODEL.Ithis>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.node_v0);
				return resultList;
			}
			public static List<GRGEN_LIBGR.INode> Extract_r0(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_LIBGR.INode> resultList = new List<GRGEN_LIBGR.INode>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.node_r0);
				return resultList;
			}
			public static List<GRGEN_MODEL.Iappend> Extract_v2(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.Iappend> resultList = new List<GRGEN_MODEL.Iappend>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.node_v2);
				return resultList;
			}
			public static List<GRGEN_LIBGR.INode> Extract_r1(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_LIBGR.INode> resultList = new List<GRGEN_LIBGR.INode>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.node_r1);
				return resultList;
			}
			public static List<GRGEN_MODEL.IthisRef> Extract_v1(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IthisRef> resultList = new List<GRGEN_MODEL.IthisRef>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.node_v1);
				return resultList;
			}
			public static List<GRGEN_MODEL.IBPort> Extract_v2_p0(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IBPort> resultList = new List<GRGEN_MODEL.IBPort>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.node_v2_p0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IVoid> Extract_v3(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IVoid> resultList = new List<GRGEN_MODEL.IVoid>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.node_v3);
				return resultList;
			}
			public static List<GRGEN_MODEL.IBPort> Extract_v1_p0(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IBPort> resultList = new List<GRGEN_MODEL.IBPort>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.node_v1_p0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IBEdge> Extract_e0(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IBEdge> resultList = new List<GRGEN_MODEL.IBEdge>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.node_e0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c0(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.edge_c0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c1(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.edge_c1);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c2(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.edge_c2);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbNode> Extract_c3(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IbNode> resultList = new List<GRGEN_MODEL.IbNode>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.edge_c3);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbPrnt> Extract_c4(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IbPrnt> resultList = new List<GRGEN_MODEL.IbPrnt>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.edge_c4);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbNode> Extract_c5(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IbNode> resultList = new List<GRGEN_MODEL.IbNode>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.edge_c5);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbLink> Extract__edge0(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IbLink> resultList = new List<GRGEN_MODEL.IbLink>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.edge__edge0);
				return resultList;
			}
			public static List<GRGEN_MODEL.IbLink> Extract__edge1(List<IMatch_returnRule> matchList)
			{
				List<GRGEN_MODEL.IbLink> resultList = new List<GRGEN_MODEL.IbLink>(matchList.Count);
				foreach(IMatch_returnRule match in matchList)
					resultList.Add(match.edge__edge1);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>)
				return ((List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule instanceBearingAttributeForSearch_returnRule = new GRGEN_ACTIONS.Rule_returnRule.Match_returnRule();
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_v0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.Ithis, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.Ithis, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v0)) {
					seenValues[list[pos].@node_v0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_v0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.Ithis, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Ithis, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v0, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_v0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.Ithis entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_v0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.Ithis entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.Ithis entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.Ithis entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_r0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_r0)) {
					seenValues[list[pos].@node_r0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_r0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_r0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_r0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_r0, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_r0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_r0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_r0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_r0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_r0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_v2(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.Iappend, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.Iappend, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v2)) {
					seenValues[list[pos].@node_v2].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v2, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_v2(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.Iappend, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Iappend, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v2)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v2, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_v2(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.Iappend entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_v2(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.Iappend entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v2(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.Iappend entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v2(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.Iappend entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v2.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_r1(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_LIBGR.INode, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_r1)) {
					seenValues[list[pos].@node_r1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_r1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_r1(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_LIBGR.INode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_r1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_r1, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_r1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_r1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_r1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_LIBGR.INode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_r1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_LIBGR.INode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_r1.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_v1(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IthisRef, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IthisRef, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v1)) {
					seenValues[list[pos].@node_v1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_v1(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IthisRef, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IthisRef, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v1, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_v1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IthisRef entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_v1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IthisRef entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IthisRef entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IthisRef entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v1.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_v2_p0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v2_p0)) {
					seenValues[list[pos].@node_v2_p0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v2_p0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_v2_p0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v2_p0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v2_p0, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_v2_p0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v2_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_v2_p0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v2_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v2_p0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v2_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v2_p0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v2_p0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_v3(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IVoid, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IVoid, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v3)) {
					seenValues[list[pos].@node_v3].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v3, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_v3(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IVoid, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IVoid, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v3)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v3, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_v3(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IVoid entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_v3(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IVoid entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v3(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IVoid entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v3(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IVoid entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v3.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_v1_p0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IBPort, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_v1_p0)) {
					seenValues[list[pos].@node_v1_p0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_v1_p0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_v1_p0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IBPort, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_v1_p0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_v1_p0, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_v1_p0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_v1_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_v1_p0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_v1_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v1_p0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBPort entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_v1_p0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_v1_p0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBPort entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_v1_p0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_e0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IBEdge, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IBEdge, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_e0)) {
					seenValues[list[pos].@node_e0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_e0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_e0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IBEdge, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IBEdge, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_e0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_e0, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_e0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBEdge entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_e0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBEdge entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_e0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBEdge entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_e0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IBEdge entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_e0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_c0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c0)) {
					seenValues[list[pos].@edge_c0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_c0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c0, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_c0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_c0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_c1(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c1)) {
					seenValues[list[pos].@edge_c1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_c1(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c1, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_c1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_c1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c1.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_c2(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c2)) {
					seenValues[list[pos].@edge_c2].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c2, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_c2(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c2)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c2, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_c2(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_c2(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c2(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c2(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c2.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_c3(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c3)) {
					seenValues[list[pos].@edge_c3].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c3, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_c3(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c3)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c3, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_c3(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_c3(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c3(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c3(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c3.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_c4(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IbPrnt, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c4)) {
					seenValues[list[pos].@edge_c4].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c4, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_c4(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbPrnt, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c4)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c4, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_c4(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_c4(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c4(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c4(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbPrnt entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c4.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy_c5(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IbNode, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge_c5)) {
					seenValues[list[pos].@edge_c5].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge_c5, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy_c5(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge_c5)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge_c5, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy_c5(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy_c5(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c5(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy_c5(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge_c5.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy__edge0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge0)) {
					seenValues[list[pos].@edge__edge0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy__edge0(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge0, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_groupBy__edge1(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>> seenValues = new Dictionary<GRGEN_MODEL.IbLink, List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge1)) {
					seenValues[list[pos].@edge__edge1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> tempList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			foreach(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> Array_returnRule_keepOneForEachBy__edge1(List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list)
		{
			List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> newList = new List<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule>();
			Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IbLink, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge1, null);
				}
			}
			return newList;
		}
		public static int Array_returnRule_indexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_indexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbLink entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_returnRule_lastIndexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_returnRule.IMatch_returnRule> list, GRGEN_MODEL.IbLink entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Functions
	{

		static Functions() {
		}

	}

	public class Procedures
	{

		static Procedures() {
		}

	}

	public partial class MatchFilters
	{

		static MatchFilters() {
		}

	}

	public partial class MatchClassFilters
	{

		static MatchClassFilters() {
		}

	}



	//-----------------------------------------------------------

	public class ruleset_RuleAndMatchingPatterns : GRGEN_LGSP.LGSPRuleAndMatchingPatterns
	{
		public ruleset_RuleAndMatchingPatterns()
		{
			subpatterns = new GRGEN_LGSP.LGSPMatchingPattern[1];
			rules = new GRGEN_LGSP.LGSPRulePattern[3];
			rulesAndSubpatterns = new GRGEN_LGSP.LGSPMatchingPattern[1+3];
			definedSequences = new GRGEN_LIBGR.DefinedSequenceInfo[0];
			functions = new GRGEN_LIBGR.FunctionInfo[0+0];
			procedures = new GRGEN_LIBGR.ProcedureInfo[0+0];
			matchClasses = new GRGEN_LIBGR.MatchClassInfo[0];
			packages = new string[0];
			subpatterns[0] = Pattern_nac_NodesWithoutSites.Instance;
			rulesAndSubpatterns[0] = Pattern_nac_NodesWithoutSites.Instance;
			rules[0] = Rule_nextRule.Instance;
			rulesAndSubpatterns[1+0] = Rule_nextRule.Instance;
			rules[1] = Rule_appendRule.Instance;
			rulesAndSubpatterns[1+1] = Rule_appendRule.Instance;
			rules[2] = Rule_returnRule.Instance;
			rulesAndSubpatterns[1+2] = Rule_returnRule.Instance;
		}
		public override GRGEN_LGSP.LGSPRulePattern[] Rules { get { return rules; } }
		private GRGEN_LGSP.LGSPRulePattern[] rules;
		public override GRGEN_LGSP.LGSPMatchingPattern[] Subpatterns { get { return subpatterns; } }
		private GRGEN_LGSP.LGSPMatchingPattern[] subpatterns;
		public override GRGEN_LGSP.LGSPMatchingPattern[] RulesAndSubpatterns { get { return rulesAndSubpatterns; } }
		private GRGEN_LGSP.LGSPMatchingPattern[] rulesAndSubpatterns;
		public override GRGEN_LIBGR.DefinedSequenceInfo[] DefinedSequences { get { return definedSequences; } }
		private GRGEN_LIBGR.DefinedSequenceInfo[] definedSequences;
		public override GRGEN_LIBGR.FunctionInfo[] Functions { get { return functions; } }
		private GRGEN_LIBGR.FunctionInfo[] functions;
		public override GRGEN_LIBGR.ProcedureInfo[] Procedures { get { return procedures; } }
		private GRGEN_LIBGR.ProcedureInfo[] procedures;
		public override GRGEN_LIBGR.MatchClassInfo[] MatchClasses { get { return matchClasses; } }
		private GRGEN_LIBGR.MatchClassInfo[] matchClasses;
		public override string[] Packages { get { return packages; } }
		private string[] packages;
	}


    public class PatternAction_nac_NodesWithoutSites : GRGEN_LGSP.LGSPSubpatternAction
    {
        private PatternAction_nac_NodesWithoutSites(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv_, Stack<GRGEN_LGSP.LGSPSubpatternAction> openTasks_)
            : base(null)
        {
            actionEnv = actionEnv_; openTasks = openTasks_;
            patternGraph = Pattern_nac_NodesWithoutSites.Instance.patternGraph;
        }

        public static PatternAction_nac_NodesWithoutSites getNewTask(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv_, Stack<GRGEN_LGSP.LGSPSubpatternAction> openTasks_) {
            PatternAction_nac_NodesWithoutSites newTask;
            if(numFreeTasks>0) {
                newTask = freeListHead;
                newTask.actionEnv = actionEnv_; newTask.openTasks = openTasks_;
                freeListHead = newTask.next;
                newTask.next = null;
                --numFreeTasks;
            } else {
                newTask = new PatternAction_nac_NodesWithoutSites(actionEnv_, openTasks_);
            }
            return newTask;
        }

        public static void releaseTask(PatternAction_nac_NodesWithoutSites oldTask) {
            if(numFreeTasks<MAX_NUM_FREE_TASKS) {
                oldTask.next = freeListHead;
                oldTask.actionEnv = null; oldTask.openTasks = null;
                freeListHead = oldTask;
                ++numFreeTasks;
            }
        }

        private static PatternAction_nac_NodesWithoutSites freeListHead = null;
        private static int numFreeTasks = 0;
        private const int MAX_NUM_FREE_TASKS = 100;

        private PatternAction_nac_NodesWithoutSites next = null;

        public GRGEN_LGSP.LGSPNode nac_NodesWithoutSites_node_src;
        public System.Int32 nac_NodesWithoutSites_var_validChildCount;
        
        public override void myMatch(List<Stack<GRGEN_LIBGR.IMatch>> foundPartialMatches, int maxMatches, int isoSpace)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            System.Int32 var_nac_NodesWithoutSites_var_validChildCount = (System.Int32)nac_NodesWithoutSites_var_validChildCount;
            openTasks.Pop();
            List<Stack<GRGEN_LIBGR.IMatch>> matchesList = foundPartialMatches;
            if(matchesList.Count!=0) throw new ApplicationException(); //debug assert
            // SubPreset nac_NodesWithoutSites_node_src 
            GRGEN_LGSP.LGSPNode candidate_nac_NodesWithoutSites_node_src = nac_NodesWithoutSites_node_src;
            // NegativePattern 
            {
                ++isoSpace;
                // Condition 
                if(!(((GRGEN_LIBGR.GraphHelper.AdjacentIncoming((GRGEN_LIBGR.INode)candidate_nac_NodesWithoutSites_node_src, GRGEN_MODEL.EdgeType_bPrnt.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count != var_nac_NodesWithoutSites_var_validChildCount))) {
                    --isoSpace;
                    goto label0;
                }
                // negative pattern found
                --isoSpace;
                openTasks.Push(this);
                return;
                --isoSpace;
            }
label0: ;
            // Check whether there are subpattern matching tasks left to execute
            if(openTasks.Count==0)
            {
                Stack<GRGEN_LIBGR.IMatch> currentFoundPartialMatch = new Stack<GRGEN_LIBGR.IMatch>();
                foundPartialMatches.Add(currentFoundPartialMatch);
                Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                match._node_src = candidate_nac_NodesWithoutSites_node_src;
                match._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount;
                currentFoundPartialMatch.Push(match);
                // if enough matches were found, we leave
                if(maxMatches > 0 && foundPartialMatches.Count >= maxMatches)
                {
                    openTasks.Push(this);
                    return;
                }
                openTasks.Push(this);
                return;
            }
            // Match subpatterns 
            openTasks.Peek().myMatch(matchesList, maxMatches - foundPartialMatches.Count, isoSpace);
            // Check whether subpatterns were found 
            if(matchesList.Count>0) {
                // subpatterns/alternatives were found, extend the partial matches by our local match object
                foreach(Stack<GRGEN_LIBGR.IMatch> currentFoundPartialMatch in matchesList)
                {
                    Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                    match._node_src = candidate_nac_NodesWithoutSites_node_src;
                    match._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount;
                    currentFoundPartialMatch.Push(match);
                }
                if(matchesList==foundPartialMatches) {
                    matchesList = new List<Stack<GRGEN_LIBGR.IMatch>>();
                } else {
                    foreach(Stack<GRGEN_LIBGR.IMatch> match in matchesList) {
                        foundPartialMatches.Add(match);
                    }
                    matchesList.Clear();
                }
                // if enough matches were found, we leave
                if(maxMatches > 0 && foundPartialMatches.Count >= maxMatches)
                {
                    openTasks.Push(this);
                    return;
                }
                openTasks.Push(this);
                return;
            }
            openTasks.Push(this);
            return;
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_nextRule
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_nextRule.IMatch_nextRule match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_nextRule : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_nextRule
    {
        public Action_nextRule()
            : base(Rule_nextRule.Instance.patternGraph)
        {
            _rulePattern = Rule_nextRule.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_nextRule _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "nextRule"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_nextRule.Match_nextRule, Rule_nextRule.IMatch_nextRule> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_nextRule Instance { get { return instance; } set { instance = value; } }
        private static Action_nextRule instance = new Action_nextRule();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_nextRule.Match_nextRule, Rule_nextRule.IMatch_nextRule>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            Stack<GRGEN_LGSP.LGSPSubpatternAction> openTasks = new Stack<GRGEN_LGSP.LGSPSubpatternAction>();
            List<Stack<GRGEN_LIBGR.IMatch>> foundPartialMatches = new List<Stack<GRGEN_LIBGR.IMatch>>();
            List<Stack<GRGEN_LIBGR.IMatch>> matchesList = foundPartialMatches;
            // Lookup nextRule_edge_c2 
            int type_id_candidate_nextRule_edge_c2 = 3;
            for(GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge_c2 = graph.edgesByTypeHeads[type_id_candidate_nextRule_edge_c2], candidate_nextRule_edge_c2 = head_candidate_nextRule_edge_c2.lgspTypeNext; candidate_nextRule_edge_c2 != head_candidate_nextRule_edge_c2; candidate_nextRule_edge_c2 = candidate_nextRule_edge_c2.lgspTypeNext)
            {
                uint prev__candidate_nextRule_edge_c2;
                prev__candidate_nextRule_edge_c2 = candidate_nextRule_edge_c2.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_nextRule_edge_c2.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Implicit Source nextRule_node_v5 from nextRule_edge_c2 
                GRGEN_LGSP.LGSPNode candidate_nextRule_node_v5 = candidate_nextRule_edge_c2.lgspSource;
                if(candidate_nextRule_node_v5.lgspType.TypeID!=11) {
                    candidate_nextRule_edge_c2.lgspFlags = candidate_nextRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c2;
                    continue;
                }
                uint prev__candidate_nextRule_node_v5;
                prev__candidate_nextRule_node_v5 = candidate_nextRule_node_v5.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_nextRule_node_v5.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Variable nac_NodesWithoutSites_var_validChildCount_inlined_pat2_2 assigned from expression 1 
                System.Int32 var_nac_NodesWithoutSites_var_validChildCount_inlined_pat2_2 = (System.Int32)1;
                // Implicit Target nextRule_node_r1 from nextRule_edge_c2 
                GRGEN_LGSP.LGSPNode candidate_nextRule_node_r1 = candidate_nextRule_edge_c2.lgspTarget;
                if((candidate_nextRule_node_r1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                {
                    candidate_nextRule_node_v5.lgspFlags = candidate_nextRule_node_v5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v5;
                    candidate_nextRule_edge_c2.lgspFlags = candidate_nextRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c2;
                    continue;
                }
                uint prev__candidate_nextRule_node_r1;
                prev__candidate_nextRule_node_r1 = candidate_nextRule_node_r1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_nextRule_node_r1.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Element nac_NodesWithoutSites_node_src_inlined_pat2_2 assigned from other element nextRule_node_v5 
                GRGEN_LGSP.LGSPNode candidate_nac_NodesWithoutSites_node_src_inlined_pat2_2 = candidate_nextRule_node_v5;
                if(!GRGEN_MODEL.NodeType_BNode.isMyType[candidate_nac_NodesWithoutSites_node_src_inlined_pat2_2.lgspType.TypeID]) {
                    candidate_nextRule_node_r1.lgspFlags = candidate_nextRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_r1;
                    candidate_nextRule_node_v5.lgspFlags = candidate_nextRule_node_v5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v5;
                    candidate_nextRule_edge_c2.lgspFlags = candidate_nextRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c2;
                    continue;
                }
                // NegativePattern 
                {
                    ++isoSpace;
                    // Condition 
                    if(!(((GRGEN_LIBGR.GraphHelper.AdjacentIncoming((GRGEN_LIBGR.INode)candidate_nac_NodesWithoutSites_node_src_inlined_pat2_2, GRGEN_MODEL.EdgeType_bPrnt.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count != var_nac_NodesWithoutSites_var_validChildCount_inlined_pat2_2))) {
                        --isoSpace;
                        goto label1;
                    }
                    // negative pattern found
                    --isoSpace;
                    candidate_nextRule_node_r1.lgspFlags = candidate_nextRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_r1;
                    candidate_nextRule_node_v5.lgspFlags = candidate_nextRule_node_v5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v5;
                    candidate_nextRule_edge_c2.lgspFlags = candidate_nextRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c2;
                    goto label2;
                    --isoSpace;
                }
label1: ;
                // Extend Incoming nextRule_edge_c5 from nextRule_node_v5 
                GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge_c5 = candidate_nextRule_node_v5.lgspInhead;
                if(head_candidate_nextRule_edge_c5 != null)
                {
                    GRGEN_LGSP.LGSPEdge candidate_nextRule_edge_c5 = head_candidate_nextRule_edge_c5;
                    do
                    {
                        if(candidate_nextRule_edge_c5.lgspType.TypeID!=5) {
                            continue;
                        }
                        uint prev__candidate_nextRule_edge_c5;
                        prev__candidate_nextRule_edge_c5 = candidate_nextRule_edge_c5.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        candidate_nextRule_edge_c5.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        // Implicit Source nextRule_node_v5_p0 from nextRule_edge_c5 
                        GRGEN_LGSP.LGSPNode candidate_nextRule_node_v5_p0 = candidate_nextRule_edge_c5.lgspSource;
                        if(candidate_nextRule_node_v5_p0.lgspType.TypeID!=7) {
                            candidate_nextRule_edge_c5.lgspFlags = candidate_nextRule_edge_c5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c5;
                            continue;
                        }
                        if((candidate_nextRule_node_v5_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                        {
                            candidate_nextRule_edge_c5.lgspFlags = candidate_nextRule_edge_c5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c5;
                            continue;
                        }
                        uint prev__candidate_nextRule_node_v5_p0;
                        prev__candidate_nextRule_node_v5_p0 = candidate_nextRule_node_v5_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        candidate_nextRule_node_v5_p0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        // Condition 
                        if(!((((GRGEN_MODEL.IBPort)candidate_nextRule_node_v5_p0).@ix == 0))) {
                            candidate_nextRule_node_v5_p0.lgspFlags = candidate_nextRule_node_v5_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v5_p0;
                            candidate_nextRule_edge_c5.lgspFlags = candidate_nextRule_edge_c5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c5;
                            continue;
                        }
                        // Extend Incoming nextRule_edge_c6 from nextRule_node_v5 
                        GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge_c6 = candidate_nextRule_node_v5.lgspInhead;
                        if(head_candidate_nextRule_edge_c6 != null)
                        {
                            GRGEN_LGSP.LGSPEdge candidate_nextRule_edge_c6 = head_candidate_nextRule_edge_c6;
                            do
                            {
                                if(candidate_nextRule_edge_c6.lgspType.TypeID!=3) {
                                    continue;
                                }
                                if((candidate_nextRule_edge_c6.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                {
                                    continue;
                                }
                                uint prev__candidate_nextRule_edge_c6;
                                prev__candidate_nextRule_edge_c6 = candidate_nextRule_edge_c6.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                candidate_nextRule_edge_c6.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                // Implicit Source nextRule_node_v6 from nextRule_edge_c6 
                                GRGEN_LGSP.LGSPNode candidate_nextRule_node_v6 = candidate_nextRule_edge_c6.lgspSource;
                                if(candidate_nextRule_node_v6.lgspType.TypeID!=18) {
                                    candidate_nextRule_edge_c6.lgspFlags = candidate_nextRule_edge_c6.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c6;
                                    continue;
                                }
                                if((candidate_nextRule_node_v6.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                {
                                    candidate_nextRule_edge_c6.lgspFlags = candidate_nextRule_edge_c6.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c6;
                                    continue;
                                }
                                uint prev__candidate_nextRule_node_v6;
                                prev__candidate_nextRule_node_v6 = candidate_nextRule_node_v6.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                candidate_nextRule_node_v6.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                // Extend Outgoing nextRule_edge__edge0 from nextRule_node_v5_p0 
                                GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge__edge0 = candidate_nextRule_node_v5_p0.lgspOuthead;
                                if(head_candidate_nextRule_edge__edge0 != null)
                                {
                                    GRGEN_LGSP.LGSPEdge candidate_nextRule_edge__edge0 = head_candidate_nextRule_edge__edge0;
                                    do
                                    {
                                        if(candidate_nextRule_edge__edge0.lgspType.TypeID!=7) {
                                            continue;
                                        }
                                        uint prev__candidate_nextRule_edge__edge0;
                                        prev__candidate_nextRule_edge__edge0 = candidate_nextRule_edge__edge0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        candidate_nextRule_edge__edge0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        // Implicit Target nextRule_node_e0 from nextRule_edge__edge0 
                                        GRGEN_LGSP.LGSPNode candidate_nextRule_node_e0 = candidate_nextRule_edge__edge0.lgspTarget;
                                        if(candidate_nextRule_node_e0.lgspType.TypeID!=9) {
                                            candidate_nextRule_edge__edge0.lgspFlags = candidate_nextRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge__edge0;
                                            continue;
                                        }
                                        if((candidate_nextRule_node_e0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                        {
                                            candidate_nextRule_edge__edge0.lgspFlags = candidate_nextRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge__edge0;
                                            continue;
                                        }
                                        uint prev__candidate_nextRule_node_e0;
                                        prev__candidate_nextRule_node_e0 = candidate_nextRule_node_e0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        candidate_nextRule_node_e0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        // Extend Incoming nextRule_edge__edge1 from nextRule_node_e0 
                                        GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge__edge1 = candidate_nextRule_node_e0.lgspInhead;
                                        if(head_candidate_nextRule_edge__edge1 != null)
                                        {
                                            GRGEN_LGSP.LGSPEdge candidate_nextRule_edge__edge1 = head_candidate_nextRule_edge__edge1;
                                            do
                                            {
                                                if(candidate_nextRule_edge__edge1.lgspType.TypeID!=7) {
                                                    continue;
                                                }
                                                if((candidate_nextRule_edge__edge1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                {
                                                    continue;
                                                }
                                                // Implicit Source nextRule_node_v1_p0 from nextRule_edge__edge1 
                                                GRGEN_LGSP.LGSPNode candidate_nextRule_node_v1_p0 = candidate_nextRule_edge__edge1.lgspSource;
                                                if(candidate_nextRule_node_v1_p0.lgspType.TypeID!=7) {
                                                    continue;
                                                }
                                                if((candidate_nextRule_node_v1_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                {
                                                    continue;
                                                }
                                                uint prev__candidate_nextRule_node_v1_p0;
                                                prev__candidate_nextRule_node_v1_p0 = candidate_nextRule_node_v1_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                candidate_nextRule_node_v1_p0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                // Condition 
                                                if(!((((GRGEN_MODEL.IBPort)candidate_nextRule_node_v1_p0).@ix == 0))) {
                                                    candidate_nextRule_node_v1_p0.lgspFlags = candidate_nextRule_node_v1_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v1_p0;
                                                    continue;
                                                }
                                                // Extend Outgoing nextRule_edge_c7 from nextRule_node_v1_p0 
                                                GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge_c7 = candidate_nextRule_node_v1_p0.lgspOuthead;
                                                if(head_candidate_nextRule_edge_c7 != null)
                                                {
                                                    GRGEN_LGSP.LGSPEdge candidate_nextRule_edge_c7 = head_candidate_nextRule_edge_c7;
                                                    do
                                                    {
                                                        if(candidate_nextRule_edge_c7.lgspType.TypeID!=5) {
                                                            continue;
                                                        }
                                                        if((candidate_nextRule_edge_c7.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                        {
                                                            continue;
                                                        }
                                                        // Implicit Target nextRule_node_v1 from nextRule_edge_c7 
                                                        GRGEN_LGSP.LGSPNode candidate_nextRule_node_v1 = candidate_nextRule_edge_c7.lgspTarget;
                                                        if(candidate_nextRule_node_v1.lgspType.TypeID!=15) {
                                                            continue;
                                                        }
                                                        if((candidate_nextRule_node_v1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                        {
                                                            continue;
                                                        }
                                                        uint prev__candidate_nextRule_node_v1;
                                                        prev__candidate_nextRule_node_v1 = candidate_nextRule_node_v1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                        candidate_nextRule_node_v1.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                        // Variable nac_NodesWithoutSites_var_validChildCount_inlined_pat0_0 assigned from expression 0 
                                                        System.Int32 var_nac_NodesWithoutSites_var_validChildCount_inlined_pat0_0 = (System.Int32)0;
                                                        // Element nac_NodesWithoutSites_node_src_inlined_pat0_0 assigned from other element nextRule_node_v1 
                                                        GRGEN_LGSP.LGSPNode candidate_nac_NodesWithoutSites_node_src_inlined_pat0_0 = candidate_nextRule_node_v1;
                                                        if(!GRGEN_MODEL.NodeType_BNode.isMyType[candidate_nac_NodesWithoutSites_node_src_inlined_pat0_0.lgspType.TypeID]) {
                                                            candidate_nextRule_node_v1.lgspFlags = candidate_nextRule_node_v1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v1;
                                                            continue;
                                                        }
                                                        // NegativePattern 
                                                        {
                                                            ++isoSpace;
                                                            // Condition 
                                                            if(!(((GRGEN_LIBGR.GraphHelper.AdjacentIncoming((GRGEN_LIBGR.INode)candidate_nac_NodesWithoutSites_node_src_inlined_pat0_0, GRGEN_MODEL.EdgeType_bPrnt.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count != var_nac_NodesWithoutSites_var_validChildCount_inlined_pat0_0))) {
                                                                --isoSpace;
                                                                goto label3;
                                                            }
                                                            // negative pattern found
                                                            --isoSpace;
                                                            candidate_nextRule_node_v1.lgspFlags = candidate_nextRule_node_v1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v1;
                                                            goto label4;
                                                            --isoSpace;
                                                        }
label3: ;
                                                        // Extend Outgoing nextRule_edge_c3 from nextRule_node_v1 
                                                        GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge_c3 = candidate_nextRule_node_v1.lgspOuthead;
                                                        if(head_candidate_nextRule_edge_c3 != null)
                                                        {
                                                            GRGEN_LGSP.LGSPEdge candidate_nextRule_edge_c3 = head_candidate_nextRule_edge_c3;
                                                            do
                                                            {
                                                                if(candidate_nextRule_edge_c3.lgspType.TypeID!=3) {
                                                                    continue;
                                                                }
                                                                if((candidate_nextRule_edge_c3.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                {
                                                                    continue;
                                                                }
                                                                uint prev__candidate_nextRule_edge_c3;
                                                                prev__candidate_nextRule_edge_c3 = candidate_nextRule_edge_c3.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                candidate_nextRule_edge_c3.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                // Implicit Target nextRule_node_v0 from nextRule_edge_c3 
                                                                GRGEN_LGSP.LGSPNode candidate_nextRule_node_v0 = candidate_nextRule_edge_c3.lgspTarget;
                                                                if(candidate_nextRule_node_v0.lgspType.TypeID!=14) {
                                                                    candidate_nextRule_edge_c3.lgspFlags = candidate_nextRule_edge_c3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c3;
                                                                    continue;
                                                                }
                                                                if((candidate_nextRule_node_v0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                {
                                                                    candidate_nextRule_edge_c3.lgspFlags = candidate_nextRule_edge_c3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c3;
                                                                    continue;
                                                                }
                                                                uint prev__candidate_nextRule_node_v0;
                                                                prev__candidate_nextRule_node_v0 = candidate_nextRule_node_v0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                candidate_nextRule_node_v0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                // Extend Outgoing nextRule_edge_c0 from nextRule_node_v0 
                                                                GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge_c0 = candidate_nextRule_node_v0.lgspOuthead;
                                                                if(head_candidate_nextRule_edge_c0 != null)
                                                                {
                                                                    GRGEN_LGSP.LGSPEdge candidate_nextRule_edge_c0 = head_candidate_nextRule_edge_c0;
                                                                    do
                                                                    {
                                                                        if(candidate_nextRule_edge_c0.lgspType.TypeID!=3) {
                                                                            continue;
                                                                        }
                                                                        if((candidate_nextRule_edge_c0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                        {
                                                                            continue;
                                                                        }
                                                                        uint prev__candidate_nextRule_edge_c0;
                                                                        prev__candidate_nextRule_edge_c0 = candidate_nextRule_edge_c0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                        candidate_nextRule_edge_c0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                        // Implicit Target nextRule_node_r0 from nextRule_edge_c0 
                                                                        GRGEN_LGSP.LGSPNode candidate_nextRule_node_r0 = candidate_nextRule_edge_c0.lgspTarget;
                                                                        if((candidate_nextRule_node_r0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                        {
                                                                            candidate_nextRule_edge_c0.lgspFlags = candidate_nextRule_edge_c0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c0;
                                                                            continue;
                                                                        }
                                                                        uint prev__candidate_nextRule_node_r0;
                                                                        prev__candidate_nextRule_node_r0 = candidate_nextRule_node_r0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                        candidate_nextRule_node_r0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                        // Extend Incoming nextRule_edge_c1 from nextRule_node_r0 
                                                                        GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge_c1 = candidate_nextRule_node_r0.lgspInhead;
                                                                        if(head_candidate_nextRule_edge_c1 != null)
                                                                        {
                                                                            GRGEN_LGSP.LGSPEdge candidate_nextRule_edge_c1 = head_candidate_nextRule_edge_c1;
                                                                            do
                                                                            {
                                                                                if(candidate_nextRule_edge_c1.lgspType.TypeID!=3) {
                                                                                    continue;
                                                                                }
                                                                                if((candidate_nextRule_edge_c1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                                {
                                                                                    continue;
                                                                                }
                                                                                uint prev__candidate_nextRule_edge_c1;
                                                                                prev__candidate_nextRule_edge_c1 = candidate_nextRule_edge_c1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                                candidate_nextRule_edge_c1.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                                // Implicit Source nextRule_node_v2 from nextRule_edge_c1 
                                                                                GRGEN_LGSP.LGSPNode candidate_nextRule_node_v2 = candidate_nextRule_edge_c1.lgspSource;
                                                                                if(candidate_nextRule_node_v2.lgspType.TypeID!=25) {
                                                                                    candidate_nextRule_edge_c1.lgspFlags = candidate_nextRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c1;
                                                                                    continue;
                                                                                }
                                                                                if((candidate_nextRule_node_v2.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                                {
                                                                                    candidate_nextRule_edge_c1.lgspFlags = candidate_nextRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c1;
                                                                                    continue;
                                                                                }
                                                                                // Variable nac_NodesWithoutSites_var_validChildCount_inlined_pat1_1 assigned from expression 1 
                                                                                System.Int32 var_nac_NodesWithoutSites_var_validChildCount_inlined_pat1_1 = (System.Int32)1;
                                                                                // Element nac_NodesWithoutSites_node_src_inlined_pat1_1 assigned from other element nextRule_node_v2 
                                                                                GRGEN_LGSP.LGSPNode candidate_nac_NodesWithoutSites_node_src_inlined_pat1_1 = candidate_nextRule_node_v2;
                                                                                if(!GRGEN_MODEL.NodeType_BNode.isMyType[candidate_nac_NodesWithoutSites_node_src_inlined_pat1_1.lgspType.TypeID]) {
                                                                                    candidate_nextRule_edge_c1.lgspFlags = candidate_nextRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c1;
                                                                                    continue;
                                                                                }
                                                                                // NegativePattern 
                                                                                {
                                                                                    ++isoSpace;
                                                                                    // Condition 
                                                                                    if(!(((GRGEN_LIBGR.GraphHelper.AdjacentIncoming((GRGEN_LIBGR.INode)candidate_nac_NodesWithoutSites_node_src_inlined_pat1_1, GRGEN_MODEL.EdgeType_bPrnt.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count != var_nac_NodesWithoutSites_var_validChildCount_inlined_pat1_1))) {
                                                                                        --isoSpace;
                                                                                        goto label5;
                                                                                    }
                                                                                    // negative pattern found
                                                                                    --isoSpace;
                                                                                    candidate_nextRule_edge_c1.lgspFlags = candidate_nextRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c1;
                                                                                    goto label6;
                                                                                    --isoSpace;
                                                                                }
label5: ;
                                                                                // Extend Incoming nextRule_edge_c4 from nextRule_node_v2 
                                                                                GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge_c4 = candidate_nextRule_node_v2.lgspInhead;
                                                                                if(head_candidate_nextRule_edge_c4 != null)
                                                                                {
                                                                                    GRGEN_LGSP.LGSPEdge candidate_nextRule_edge_c4 = head_candidate_nextRule_edge_c4;
                                                                                    do
                                                                                    {
                                                                                        if(candidate_nextRule_edge_c4.lgspType.TypeID!=3) {
                                                                                            continue;
                                                                                        }
                                                                                        if((candidate_nextRule_edge_c4.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                                        {
                                                                                            continue;
                                                                                        }
                                                                                        uint prev__candidate_nextRule_edge_c4;
                                                                                        prev__candidate_nextRule_edge_c4 = candidate_nextRule_edge_c4.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                                        candidate_nextRule_edge_c4.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                                        // Implicit Source nextRule_node_v3 from nextRule_edge_c4 
                                                                                        GRGEN_LGSP.LGSPNode candidate_nextRule_node_v3 = candidate_nextRule_edge_c4.lgspSource;
                                                                                        if(candidate_nextRule_node_v3.lgspType.TypeID!=16) {
                                                                                            candidate_nextRule_edge_c4.lgspFlags = candidate_nextRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c4;
                                                                                            continue;
                                                                                        }
                                                                                        if((candidate_nextRule_node_v3.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                                        {
                                                                                            candidate_nextRule_edge_c4.lgspFlags = candidate_nextRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c4;
                                                                                            continue;
                                                                                        }
                                                                                        // Extend Incoming nextRule_edge_c8 from nextRule_node_v3 
                                                                                        GRGEN_LGSP.LGSPEdge head_candidate_nextRule_edge_c8 = candidate_nextRule_node_v3.lgspInhead;
                                                                                        if(head_candidate_nextRule_edge_c8 != null)
                                                                                        {
                                                                                            GRGEN_LGSP.LGSPEdge candidate_nextRule_edge_c8 = head_candidate_nextRule_edge_c8;
                                                                                            do
                                                                                            {
                                                                                                if(candidate_nextRule_edge_c8.lgspType.TypeID!=3) {
                                                                                                    continue;
                                                                                                }
                                                                                                if((candidate_nextRule_edge_c8.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                                                {
                                                                                                    continue;
                                                                                                }
                                                                                                // Implicit Source nextRule_node_v4 from nextRule_edge_c8 
                                                                                                GRGEN_LGSP.LGSPNode candidate_nextRule_node_v4 = candidate_nextRule_edge_c8.lgspSource;
                                                                                                if(candidate_nextRule_node_v4.lgspType.TypeID!=14) {
                                                                                                    continue;
                                                                                                }
                                                                                                if((candidate_nextRule_node_v4.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                                                {
                                                                                                    continue;
                                                                                                }
                                                                                                Rule_nextRule.Match_nextRule match = matches.GetNextUnfilledPosition();
                                                                                                Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match_pat0 = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                                                                                                match_pat0.SetMatchOfEnclosingPattern(match);
                                                                                                Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match_pat1 = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                                                                                                match_pat1.SetMatchOfEnclosingPattern(match);
                                                                                                Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match_pat2 = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                                                                                                match_pat2.SetMatchOfEnclosingPattern(match);
                                                                                                match._node_v0 = candidate_nextRule_node_v0;
                                                                                                match._node_r0 = candidate_nextRule_node_r0;
                                                                                                match._node_v2 = candidate_nextRule_node_v2;
                                                                                                match._node_v5 = candidate_nextRule_node_v5;
                                                                                                match._node_r1 = candidate_nextRule_node_r1;
                                                                                                match._node_v1 = candidate_nextRule_node_v1;
                                                                                                match._node_v3 = candidate_nextRule_node_v3;
                                                                                                match._node_v5_p0 = candidate_nextRule_node_v5_p0;
                                                                                                match._node_v6 = candidate_nextRule_node_v6;
                                                                                                match._node_v1_p0 = candidate_nextRule_node_v1_p0;
                                                                                                match._node_v4 = candidate_nextRule_node_v4;
                                                                                                match._node_e0 = candidate_nextRule_node_e0;
                                                                                                match_pat0._node_src = candidate_nac_NodesWithoutSites_node_src_inlined_pat0_0;
                                                                                                match_pat1._node_src = candidate_nac_NodesWithoutSites_node_src_inlined_pat1_1;
                                                                                                match_pat2._node_src = candidate_nac_NodesWithoutSites_node_src_inlined_pat2_2;
                                                                                                match._edge_c0 = candidate_nextRule_edge_c0;
                                                                                                match._edge_c1 = candidate_nextRule_edge_c1;
                                                                                                match._edge_c2 = candidate_nextRule_edge_c2;
                                                                                                match._edge_c3 = candidate_nextRule_edge_c3;
                                                                                                match._edge_c4 = candidate_nextRule_edge_c4;
                                                                                                match._edge_c5 = candidate_nextRule_edge_c5;
                                                                                                match._edge_c6 = candidate_nextRule_edge_c6;
                                                                                                match._edge_c7 = candidate_nextRule_edge_c7;
                                                                                                match._edge_c8 = candidate_nextRule_edge_c8;
                                                                                                match._edge__edge0 = candidate_nextRule_edge__edge0;
                                                                                                match._edge__edge1 = candidate_nextRule_edge__edge1;
                                                                                                match_pat0._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount_inlined_pat0_0;
                                                                                                match_pat1._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount_inlined_pat1_1;
                                                                                                match_pat2._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount_inlined_pat2_2;
                                                                                                match._pat0 = match_pat0;
                                                                                                match._pat1 = match_pat1;
                                                                                                match._pat2 = match_pat2;
                                                                                                matches.PositionWasFilledFixIt();
                                                                                                // if enough matches were found, we leave
                                                                                                if(maxMatches > 0 && matches.Count >= maxMatches)
                                                                                                {
                                                                                                    candidate_nextRule_node_v3.MoveInHeadAfter(candidate_nextRule_edge_c8);
                                                                                                    candidate_nextRule_node_v2.MoveInHeadAfter(candidate_nextRule_edge_c4);
                                                                                                    candidate_nextRule_node_r0.MoveInHeadAfter(candidate_nextRule_edge_c1);
                                                                                                    candidate_nextRule_node_v0.MoveOutHeadAfter(candidate_nextRule_edge_c0);
                                                                                                    candidate_nextRule_node_v1.MoveOutHeadAfter(candidate_nextRule_edge_c3);
                                                                                                    candidate_nextRule_node_v1_p0.MoveOutHeadAfter(candidate_nextRule_edge_c7);
                                                                                                    candidate_nextRule_node_e0.MoveInHeadAfter(candidate_nextRule_edge__edge1);
                                                                                                    candidate_nextRule_node_v5_p0.MoveOutHeadAfter(candidate_nextRule_edge__edge0);
                                                                                                    candidate_nextRule_node_v5.MoveInHeadAfter(candidate_nextRule_edge_c6);
                                                                                                    candidate_nextRule_node_v5.MoveInHeadAfter(candidate_nextRule_edge_c5);
                                                                                                    graph.MoveHeadAfter(candidate_nextRule_edge_c2);
                                                                                                    candidate_nextRule_edge_c4.lgspFlags = candidate_nextRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c4;
                                                                                                    candidate_nextRule_edge_c1.lgspFlags = candidate_nextRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c1;
                                                                                                    candidate_nextRule_node_r0.lgspFlags = candidate_nextRule_node_r0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_r0;
                                                                                                    candidate_nextRule_edge_c0.lgspFlags = candidate_nextRule_edge_c0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c0;
                                                                                                    candidate_nextRule_node_v0.lgspFlags = candidate_nextRule_node_v0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v0;
                                                                                                    candidate_nextRule_edge_c3.lgspFlags = candidate_nextRule_edge_c3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c3;
                                                                                                    candidate_nextRule_node_v1.lgspFlags = candidate_nextRule_node_v1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v1;
                                                                                                    candidate_nextRule_node_v1_p0.lgspFlags = candidate_nextRule_node_v1_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v1_p0;
                                                                                                    candidate_nextRule_node_e0.lgspFlags = candidate_nextRule_node_e0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_e0;
                                                                                                    candidate_nextRule_edge__edge0.lgspFlags = candidate_nextRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge__edge0;
                                                                                                    candidate_nextRule_node_v6.lgspFlags = candidate_nextRule_node_v6.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v6;
                                                                                                    candidate_nextRule_edge_c6.lgspFlags = candidate_nextRule_edge_c6.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c6;
                                                                                                    candidate_nextRule_node_v5_p0.lgspFlags = candidate_nextRule_node_v5_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v5_p0;
                                                                                                    candidate_nextRule_edge_c5.lgspFlags = candidate_nextRule_edge_c5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c5;
                                                                                                    candidate_nextRule_node_r1.lgspFlags = candidate_nextRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_r1;
                                                                                                    candidate_nextRule_node_v5.lgspFlags = candidate_nextRule_node_v5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v5;
                                                                                                    candidate_nextRule_edge_c2.lgspFlags = candidate_nextRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c2;
                                                                                                    return matches;
                                                                                                }
                                                                                            }
                                                                                            while( (candidate_nextRule_edge_c8 = candidate_nextRule_edge_c8.lgspInNext) != head_candidate_nextRule_edge_c8 );
                                                                                        }
                                                                                        candidate_nextRule_edge_c4.lgspFlags = candidate_nextRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c4;
                                                                                    }
                                                                                    while( (candidate_nextRule_edge_c4 = candidate_nextRule_edge_c4.lgspInNext) != head_candidate_nextRule_edge_c4 );
                                                                                }
                                                                                candidate_nextRule_edge_c1.lgspFlags = candidate_nextRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c1;
label6: ;
                                                                            }
                                                                            while( (candidate_nextRule_edge_c1 = candidate_nextRule_edge_c1.lgspInNext) != head_candidate_nextRule_edge_c1 );
                                                                        }
                                                                        candidate_nextRule_node_r0.lgspFlags = candidate_nextRule_node_r0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_r0;
                                                                        candidate_nextRule_edge_c0.lgspFlags = candidate_nextRule_edge_c0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c0;
                                                                    }
                                                                    while( (candidate_nextRule_edge_c0 = candidate_nextRule_edge_c0.lgspOutNext) != head_candidate_nextRule_edge_c0 );
                                                                }
                                                                candidate_nextRule_node_v0.lgspFlags = candidate_nextRule_node_v0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v0;
                                                                candidate_nextRule_edge_c3.lgspFlags = candidate_nextRule_edge_c3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c3;
                                                            }
                                                            while( (candidate_nextRule_edge_c3 = candidate_nextRule_edge_c3.lgspOutNext) != head_candidate_nextRule_edge_c3 );
                                                        }
                                                        candidate_nextRule_node_v1.lgspFlags = candidate_nextRule_node_v1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v1;
label4: ;
                                                    }
                                                    while( (candidate_nextRule_edge_c7 = candidate_nextRule_edge_c7.lgspOutNext) != head_candidate_nextRule_edge_c7 );
                                                }
                                                candidate_nextRule_node_v1_p0.lgspFlags = candidate_nextRule_node_v1_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v1_p0;
                                            }
                                            while( (candidate_nextRule_edge__edge1 = candidate_nextRule_edge__edge1.lgspInNext) != head_candidate_nextRule_edge__edge1 );
                                        }
                                        candidate_nextRule_node_e0.lgspFlags = candidate_nextRule_node_e0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_e0;
                                        candidate_nextRule_edge__edge0.lgspFlags = candidate_nextRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge__edge0;
                                    }
                                    while( (candidate_nextRule_edge__edge0 = candidate_nextRule_edge__edge0.lgspOutNext) != head_candidate_nextRule_edge__edge0 );
                                }
                                candidate_nextRule_node_v6.lgspFlags = candidate_nextRule_node_v6.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v6;
                                candidate_nextRule_edge_c6.lgspFlags = candidate_nextRule_edge_c6.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c6;
                            }
                            while( (candidate_nextRule_edge_c6 = candidate_nextRule_edge_c6.lgspInNext) != head_candidate_nextRule_edge_c6 );
                        }
                        candidate_nextRule_node_v5_p0.lgspFlags = candidate_nextRule_node_v5_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v5_p0;
                        candidate_nextRule_edge_c5.lgspFlags = candidate_nextRule_edge_c5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c5;
                    }
                    while( (candidate_nextRule_edge_c5 = candidate_nextRule_edge_c5.lgspInNext) != head_candidate_nextRule_edge_c5 );
                }
                candidate_nextRule_node_r1.lgspFlags = candidate_nextRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_r1;
                candidate_nextRule_node_v5.lgspFlags = candidate_nextRule_node_v5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_node_v5;
                candidate_nextRule_edge_c2.lgspFlags = candidate_nextRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_nextRule_edge_c2;
label2: ;
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_nextRule.IMatch_nextRule match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> matches)
        {
            foreach(Rule_nextRule.IMatch_nextRule match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_nextRule.IMatch_nextRule match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_nextRule.IMatch_nextRule)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_nextRule.IMatch_nextRule>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_appendRule
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_appendRule.IMatch_appendRule match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_appendRule : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_appendRule
    {
        public Action_appendRule()
            : base(Rule_appendRule.Instance.patternGraph)
        {
            _rulePattern = Rule_appendRule.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_appendRule _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "appendRule"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_appendRule.Match_appendRule, Rule_appendRule.IMatch_appendRule> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_appendRule Instance { get { return instance; } set { instance = value; } }
        private static Action_appendRule instance = new Action_appendRule();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_appendRule.Match_appendRule, Rule_appendRule.IMatch_appendRule>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            Stack<GRGEN_LGSP.LGSPSubpatternAction> openTasks = new Stack<GRGEN_LGSP.LGSPSubpatternAction>();
            List<Stack<GRGEN_LIBGR.IMatch>> foundPartialMatches = new List<Stack<GRGEN_LIBGR.IMatch>>();
            List<Stack<GRGEN_LIBGR.IMatch>> matchesList = foundPartialMatches;
            // Lookup appendRule_edge_c1 
            int type_id_candidate_appendRule_edge_c1 = 3;
            for(GRGEN_LGSP.LGSPEdge head_candidate_appendRule_edge_c1 = graph.edgesByTypeHeads[type_id_candidate_appendRule_edge_c1], candidate_appendRule_edge_c1 = head_candidate_appendRule_edge_c1.lgspTypeNext; candidate_appendRule_edge_c1 != head_candidate_appendRule_edge_c1; candidate_appendRule_edge_c1 = candidate_appendRule_edge_c1.lgspTypeNext)
            {
                uint prev__candidate_appendRule_edge_c1;
                prev__candidate_appendRule_edge_c1 = candidate_appendRule_edge_c1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_appendRule_edge_c1.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Implicit Source appendRule_node_v4 from appendRule_edge_c1 
                GRGEN_LGSP.LGSPNode candidate_appendRule_node_v4 = candidate_appendRule_edge_c1.lgspSource;
                if(candidate_appendRule_node_v4.lgspType.TypeID!=11) {
                    candidate_appendRule_edge_c1.lgspFlags = candidate_appendRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c1;
                    continue;
                }
                uint prev__candidate_appendRule_node_v4;
                prev__candidate_appendRule_node_v4 = candidate_appendRule_node_v4.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_appendRule_node_v4.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Variable nac_NodesWithoutSites_var_validChildCount_inlined_pat2_5 assigned from expression 1 
                System.Int32 var_nac_NodesWithoutSites_var_validChildCount_inlined_pat2_5 = (System.Int32)1;
                // Implicit Target appendRule_node_r1 from appendRule_edge_c1 
                GRGEN_LGSP.LGSPNode candidate_appendRule_node_r1 = candidate_appendRule_edge_c1.lgspTarget;
                if((candidate_appendRule_node_r1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                {
                    candidate_appendRule_node_v4.lgspFlags = candidate_appendRule_node_v4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v4;
                    candidate_appendRule_edge_c1.lgspFlags = candidate_appendRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c1;
                    continue;
                }
                uint prev__candidate_appendRule_node_r1;
                prev__candidate_appendRule_node_r1 = candidate_appendRule_node_r1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_appendRule_node_r1.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Element nac_NodesWithoutSites_node_src_inlined_pat2_5 assigned from other element appendRule_node_v4 
                GRGEN_LGSP.LGSPNode candidate_nac_NodesWithoutSites_node_src_inlined_pat2_5 = candidate_appendRule_node_v4;
                if(!GRGEN_MODEL.NodeType_BNode.isMyType[candidate_nac_NodesWithoutSites_node_src_inlined_pat2_5.lgspType.TypeID]) {
                    candidate_appendRule_node_r1.lgspFlags = candidate_appendRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_r1;
                    candidate_appendRule_node_v4.lgspFlags = candidate_appendRule_node_v4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v4;
                    candidate_appendRule_edge_c1.lgspFlags = candidate_appendRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c1;
                    continue;
                }
                // NegativePattern 
                {
                    ++isoSpace;
                    // Condition 
                    if(!(((GRGEN_LIBGR.GraphHelper.AdjacentIncoming((GRGEN_LIBGR.INode)candidate_nac_NodesWithoutSites_node_src_inlined_pat2_5, GRGEN_MODEL.EdgeType_bPrnt.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count != var_nac_NodesWithoutSites_var_validChildCount_inlined_pat2_5))) {
                        --isoSpace;
                        goto label7;
                    }
                    // negative pattern found
                    --isoSpace;
                    candidate_appendRule_node_r1.lgspFlags = candidate_appendRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_r1;
                    candidate_appendRule_node_v4.lgspFlags = candidate_appendRule_node_v4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v4;
                    candidate_appendRule_edge_c1.lgspFlags = candidate_appendRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c1;
                    goto label8;
                    --isoSpace;
                }
label7: ;
                // Extend Incoming appendRule_edge_c4 from appendRule_node_v4 
                GRGEN_LGSP.LGSPEdge head_candidate_appendRule_edge_c4 = candidate_appendRule_node_v4.lgspInhead;
                if(head_candidate_appendRule_edge_c4 != null)
                {
                    GRGEN_LGSP.LGSPEdge candidate_appendRule_edge_c4 = head_candidate_appendRule_edge_c4;
                    do
                    {
                        if(candidate_appendRule_edge_c4.lgspType.TypeID!=5) {
                            continue;
                        }
                        uint prev__candidate_appendRule_edge_c4;
                        prev__candidate_appendRule_edge_c4 = candidate_appendRule_edge_c4.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        candidate_appendRule_edge_c4.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        // Implicit Source appendRule_node_v4_p0 from appendRule_edge_c4 
                        GRGEN_LGSP.LGSPNode candidate_appendRule_node_v4_p0 = candidate_appendRule_edge_c4.lgspSource;
                        if(candidate_appendRule_node_v4_p0.lgspType.TypeID!=7) {
                            candidate_appendRule_edge_c4.lgspFlags = candidate_appendRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c4;
                            continue;
                        }
                        if((candidate_appendRule_node_v4_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                        {
                            candidate_appendRule_edge_c4.lgspFlags = candidate_appendRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c4;
                            continue;
                        }
                        uint prev__candidate_appendRule_node_v4_p0;
                        prev__candidate_appendRule_node_v4_p0 = candidate_appendRule_node_v4_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        candidate_appendRule_node_v4_p0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        // Condition 
                        if(!((((GRGEN_MODEL.IBPort)candidate_appendRule_node_v4_p0).@ix == 0))) {
                            candidate_appendRule_node_v4_p0.lgspFlags = candidate_appendRule_node_v4_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v4_p0;
                            candidate_appendRule_edge_c4.lgspFlags = candidate_appendRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c4;
                            continue;
                        }
                        // Extend Incoming appendRule_edge_c5 from appendRule_node_v4 
                        GRGEN_LGSP.LGSPEdge head_candidate_appendRule_edge_c5 = candidate_appendRule_node_v4.lgspInhead;
                        if(head_candidate_appendRule_edge_c5 != null)
                        {
                            GRGEN_LGSP.LGSPEdge candidate_appendRule_edge_c5 = head_candidate_appendRule_edge_c5;
                            do
                            {
                                if(candidate_appendRule_edge_c5.lgspType.TypeID!=3) {
                                    continue;
                                }
                                if((candidate_appendRule_edge_c5.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                {
                                    continue;
                                }
                                uint prev__candidate_appendRule_edge_c5;
                                prev__candidate_appendRule_edge_c5 = candidate_appendRule_edge_c5.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                candidate_appendRule_edge_c5.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                // Implicit Source appendRule_node_v5 from appendRule_edge_c5 
                                GRGEN_LGSP.LGSPNode candidate_appendRule_node_v5 = candidate_appendRule_edge_c5.lgspSource;
                                if(candidate_appendRule_node_v5.lgspType.TypeID!=18) {
                                    candidate_appendRule_edge_c5.lgspFlags = candidate_appendRule_edge_c5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c5;
                                    continue;
                                }
                                if((candidate_appendRule_node_v5.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                {
                                    candidate_appendRule_edge_c5.lgspFlags = candidate_appendRule_edge_c5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c5;
                                    continue;
                                }
                                uint prev__candidate_appendRule_node_v5;
                                prev__candidate_appendRule_node_v5 = candidate_appendRule_node_v5.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                candidate_appendRule_node_v5.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                // Extend Outgoing appendRule_edge__edge0 from appendRule_node_v4_p0 
                                GRGEN_LGSP.LGSPEdge head_candidate_appendRule_edge__edge0 = candidate_appendRule_node_v4_p0.lgspOuthead;
                                if(head_candidate_appendRule_edge__edge0 != null)
                                {
                                    GRGEN_LGSP.LGSPEdge candidate_appendRule_edge__edge0 = head_candidate_appendRule_edge__edge0;
                                    do
                                    {
                                        if(candidate_appendRule_edge__edge0.lgspType.TypeID!=7) {
                                            continue;
                                        }
                                        uint prev__candidate_appendRule_edge__edge0;
                                        prev__candidate_appendRule_edge__edge0 = candidate_appendRule_edge__edge0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        candidate_appendRule_edge__edge0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        // Implicit Target appendRule_node_e0 from appendRule_edge__edge0 
                                        GRGEN_LGSP.LGSPNode candidate_appendRule_node_e0 = candidate_appendRule_edge__edge0.lgspTarget;
                                        if(candidate_appendRule_node_e0.lgspType.TypeID!=9) {
                                            candidate_appendRule_edge__edge0.lgspFlags = candidate_appendRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge__edge0;
                                            continue;
                                        }
                                        if((candidate_appendRule_node_e0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                        {
                                            candidate_appendRule_edge__edge0.lgspFlags = candidate_appendRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge__edge0;
                                            continue;
                                        }
                                        uint prev__candidate_appendRule_node_e0;
                                        prev__candidate_appendRule_node_e0 = candidate_appendRule_node_e0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        candidate_appendRule_node_e0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        // Extend Incoming appendRule_edge__edge1 from appendRule_node_e0 
                                        GRGEN_LGSP.LGSPEdge head_candidate_appendRule_edge__edge1 = candidate_appendRule_node_e0.lgspInhead;
                                        if(head_candidate_appendRule_edge__edge1 != null)
                                        {
                                            GRGEN_LGSP.LGSPEdge candidate_appendRule_edge__edge1 = head_candidate_appendRule_edge__edge1;
                                            do
                                            {
                                                if(candidate_appendRule_edge__edge1.lgspType.TypeID!=7) {
                                                    continue;
                                                }
                                                if((candidate_appendRule_edge__edge1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                {
                                                    continue;
                                                }
                                                // Implicit Source appendRule_node_v2_p0 from appendRule_edge__edge1 
                                                GRGEN_LGSP.LGSPNode candidate_appendRule_node_v2_p0 = candidate_appendRule_edge__edge1.lgspSource;
                                                if(candidate_appendRule_node_v2_p0.lgspType.TypeID!=7) {
                                                    continue;
                                                }
                                                if((candidate_appendRule_node_v2_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                {
                                                    continue;
                                                }
                                                uint prev__candidate_appendRule_node_v2_p0;
                                                prev__candidate_appendRule_node_v2_p0 = candidate_appendRule_node_v2_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                candidate_appendRule_node_v2_p0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                // Condition 
                                                if(!((((GRGEN_MODEL.IBPort)candidate_appendRule_node_v2_p0).@ix == 0))) {
                                                    candidate_appendRule_node_v2_p0.lgspFlags = candidate_appendRule_node_v2_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v2_p0;
                                                    continue;
                                                }
                                                // Extend Outgoing appendRule_edge_c7 from appendRule_node_v2_p0 
                                                GRGEN_LGSP.LGSPEdge head_candidate_appendRule_edge_c7 = candidate_appendRule_node_v2_p0.lgspOuthead;
                                                if(head_candidate_appendRule_edge_c7 != null)
                                                {
                                                    GRGEN_LGSP.LGSPEdge candidate_appendRule_edge_c7 = head_candidate_appendRule_edge_c7;
                                                    do
                                                    {
                                                        if(candidate_appendRule_edge_c7.lgspType.TypeID!=5) {
                                                            continue;
                                                        }
                                                        if((candidate_appendRule_edge_c7.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                        {
                                                            continue;
                                                        }
                                                        // Implicit Target appendRule_node_v2 from appendRule_edge_c7 
                                                        GRGEN_LGSP.LGSPNode candidate_appendRule_node_v2 = candidate_appendRule_edge_c7.lgspTarget;
                                                        if(candidate_appendRule_node_v2.lgspType.TypeID!=15) {
                                                            continue;
                                                        }
                                                        if((candidate_appendRule_node_v2.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                        {
                                                            continue;
                                                        }
                                                        uint prev__candidate_appendRule_node_v2;
                                                        prev__candidate_appendRule_node_v2 = candidate_appendRule_node_v2.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                        candidate_appendRule_node_v2.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                        // Variable nac_NodesWithoutSites_var_validChildCount_inlined_pat1_4 assigned from expression 0 
                                                        System.Int32 var_nac_NodesWithoutSites_var_validChildCount_inlined_pat1_4 = (System.Int32)0;
                                                        // Element nac_NodesWithoutSites_node_src_inlined_pat1_4 assigned from other element appendRule_node_v2 
                                                        GRGEN_LGSP.LGSPNode candidate_nac_NodesWithoutSites_node_src_inlined_pat1_4 = candidate_appendRule_node_v2;
                                                        if(!GRGEN_MODEL.NodeType_BNode.isMyType[candidate_nac_NodesWithoutSites_node_src_inlined_pat1_4.lgspType.TypeID]) {
                                                            candidate_appendRule_node_v2.lgspFlags = candidate_appendRule_node_v2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v2;
                                                            continue;
                                                        }
                                                        // NegativePattern 
                                                        {
                                                            ++isoSpace;
                                                            // Condition 
                                                            if(!(((GRGEN_LIBGR.GraphHelper.AdjacentIncoming((GRGEN_LIBGR.INode)candidate_nac_NodesWithoutSites_node_src_inlined_pat1_4, GRGEN_MODEL.EdgeType_bPrnt.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count != var_nac_NodesWithoutSites_var_validChildCount_inlined_pat1_4))) {
                                                                --isoSpace;
                                                                goto label9;
                                                            }
                                                            // negative pattern found
                                                            --isoSpace;
                                                            candidate_appendRule_node_v2.lgspFlags = candidate_appendRule_node_v2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v2;
                                                            goto label10;
                                                            --isoSpace;
                                                        }
label9: ;
                                                        // Extend Outgoing appendRule_edge_c6 from appendRule_node_v2 
                                                        GRGEN_LGSP.LGSPEdge head_candidate_appendRule_edge_c6 = candidate_appendRule_node_v2.lgspOuthead;
                                                        if(head_candidate_appendRule_edge_c6 != null)
                                                        {
                                                            GRGEN_LGSP.LGSPEdge candidate_appendRule_edge_c6 = head_candidate_appendRule_edge_c6;
                                                            do
                                                            {
                                                                if(candidate_appendRule_edge_c6.lgspType.TypeID!=3) {
                                                                    continue;
                                                                }
                                                                if((candidate_appendRule_edge_c6.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                {
                                                                    continue;
                                                                }
                                                                uint prev__candidate_appendRule_edge_c6;
                                                                prev__candidate_appendRule_edge_c6 = candidate_appendRule_edge_c6.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                candidate_appendRule_edge_c6.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                // Implicit Target appendRule_node_v1 from appendRule_edge_c6 
                                                                GRGEN_LGSP.LGSPNode candidate_appendRule_node_v1 = candidate_appendRule_edge_c6.lgspTarget;
                                                                if(candidate_appendRule_node_v1.lgspType.TypeID!=14) {
                                                                    candidate_appendRule_edge_c6.lgspFlags = candidate_appendRule_edge_c6.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c6;
                                                                    continue;
                                                                }
                                                                if((candidate_appendRule_node_v1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                {
                                                                    candidate_appendRule_edge_c6.lgspFlags = candidate_appendRule_edge_c6.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c6;
                                                                    continue;
                                                                }
                                                                uint prev__candidate_appendRule_node_v1;
                                                                prev__candidate_appendRule_node_v1 = candidate_appendRule_node_v1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                candidate_appendRule_node_v1.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                // Extend Outgoing appendRule_edge_c2 from appendRule_node_v1 
                                                                GRGEN_LGSP.LGSPEdge head_candidate_appendRule_edge_c2 = candidate_appendRule_node_v1.lgspOuthead;
                                                                if(head_candidate_appendRule_edge_c2 != null)
                                                                {
                                                                    GRGEN_LGSP.LGSPEdge candidate_appendRule_edge_c2 = head_candidate_appendRule_edge_c2;
                                                                    do
                                                                    {
                                                                        if(candidate_appendRule_edge_c2.lgspType.TypeID!=3) {
                                                                            continue;
                                                                        }
                                                                        if((candidate_appendRule_edge_c2.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                        {
                                                                            continue;
                                                                        }
                                                                        uint prev__candidate_appendRule_edge_c2;
                                                                        prev__candidate_appendRule_edge_c2 = candidate_appendRule_edge_c2.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                        candidate_appendRule_edge_c2.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                        // Implicit Target appendRule_node_v0 from appendRule_edge_c2 
                                                                        GRGEN_LGSP.LGSPNode candidate_appendRule_node_v0 = candidate_appendRule_edge_c2.lgspTarget;
                                                                        if(candidate_appendRule_node_v0.lgspType.TypeID!=16) {
                                                                            candidate_appendRule_edge_c2.lgspFlags = candidate_appendRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c2;
                                                                            continue;
                                                                        }
                                                                        if((candidate_appendRule_node_v0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                        {
                                                                            candidate_appendRule_edge_c2.lgspFlags = candidate_appendRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c2;
                                                                            continue;
                                                                        }
                                                                        uint prev__candidate_appendRule_node_v0;
                                                                        prev__candidate_appendRule_node_v0 = candidate_appendRule_node_v0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                        candidate_appendRule_node_v0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                        // Variable nac_NodesWithoutSites_var_validChildCount_inlined_pat0_3 assigned from expression 2 
                                                                        System.Int32 var_nac_NodesWithoutSites_var_validChildCount_inlined_pat0_3 = (System.Int32)2;
                                                                        // Element nac_NodesWithoutSites_node_src_inlined_pat0_3 assigned from other element appendRule_node_v0 
                                                                        GRGEN_LGSP.LGSPNode candidate_nac_NodesWithoutSites_node_src_inlined_pat0_3 = candidate_appendRule_node_v0;
                                                                        if(!GRGEN_MODEL.NodeType_BNode.isMyType[candidate_nac_NodesWithoutSites_node_src_inlined_pat0_3.lgspType.TypeID]) {
                                                                            candidate_appendRule_node_v0.lgspFlags = candidate_appendRule_node_v0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v0;
                                                                            candidate_appendRule_edge_c2.lgspFlags = candidate_appendRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c2;
                                                                            continue;
                                                                        }
                                                                        // NegativePattern 
                                                                        {
                                                                            ++isoSpace;
                                                                            // Condition 
                                                                            if(!(((GRGEN_LIBGR.GraphHelper.AdjacentIncoming((GRGEN_LIBGR.INode)candidate_nac_NodesWithoutSites_node_src_inlined_pat0_3, GRGEN_MODEL.EdgeType_bPrnt.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count != var_nac_NodesWithoutSites_var_validChildCount_inlined_pat0_3))) {
                                                                                --isoSpace;
                                                                                goto label11;
                                                                            }
                                                                            // negative pattern found
                                                                            --isoSpace;
                                                                            candidate_appendRule_node_v0.lgspFlags = candidate_appendRule_node_v0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v0;
                                                                            candidate_appendRule_edge_c2.lgspFlags = candidate_appendRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c2;
                                                                            goto label12;
                                                                            --isoSpace;
                                                                        }
label11: ;
                                                                        // Extend Outgoing appendRule_edge_c0 from appendRule_node_v0 
                                                                        GRGEN_LGSP.LGSPEdge head_candidate_appendRule_edge_c0 = candidate_appendRule_node_v0.lgspOuthead;
                                                                        if(head_candidate_appendRule_edge_c0 != null)
                                                                        {
                                                                            GRGEN_LGSP.LGSPEdge candidate_appendRule_edge_c0 = head_candidate_appendRule_edge_c0;
                                                                            do
                                                                            {
                                                                                if(candidate_appendRule_edge_c0.lgspType.TypeID!=3) {
                                                                                    continue;
                                                                                }
                                                                                if((candidate_appendRule_edge_c0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                                {
                                                                                    continue;
                                                                                }
                                                                                uint prev__candidate_appendRule_edge_c0;
                                                                                prev__candidate_appendRule_edge_c0 = candidate_appendRule_edge_c0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                                candidate_appendRule_edge_c0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                                // Implicit Target appendRule_node_r0 from appendRule_edge_c0 
                                                                                GRGEN_LGSP.LGSPNode candidate_appendRule_node_r0 = candidate_appendRule_edge_c0.lgspTarget;
                                                                                if((candidate_appendRule_node_r0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                                {
                                                                                    candidate_appendRule_edge_c0.lgspFlags = candidate_appendRule_edge_c0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c0;
                                                                                    continue;
                                                                                }
                                                                                uint prev__candidate_appendRule_node_r0;
                                                                                prev__candidate_appendRule_node_r0 = candidate_appendRule_node_r0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                                candidate_appendRule_node_r0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                                // Extend Incoming appendRule_edge_c3 from appendRule_node_v0 
                                                                                GRGEN_LGSP.LGSPEdge head_candidate_appendRule_edge_c3 = candidate_appendRule_node_v0.lgspInhead;
                                                                                if(head_candidate_appendRule_edge_c3 != null)
                                                                                {
                                                                                    GRGEN_LGSP.LGSPEdge candidate_appendRule_edge_c3 = head_candidate_appendRule_edge_c3;
                                                                                    do
                                                                                    {
                                                                                        if(candidate_appendRule_edge_c3.lgspType.TypeID!=3) {
                                                                                            continue;
                                                                                        }
                                                                                        if((candidate_appendRule_edge_c3.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                                        {
                                                                                            continue;
                                                                                        }
                                                                                        // Implicit Source appendRule_node_v3 from appendRule_edge_c3 
                                                                                        GRGEN_LGSP.LGSPNode candidate_appendRule_node_v3 = candidate_appendRule_edge_c3.lgspSource;
                                                                                        if(candidate_appendRule_node_v3.lgspType.TypeID!=18) {
                                                                                            continue;
                                                                                        }
                                                                                        if((candidate_appendRule_node_v3.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                                        {
                                                                                            continue;
                                                                                        }
                                                                                        Rule_appendRule.Match_appendRule match = matches.GetNextUnfilledPosition();
                                                                                        Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match_pat0 = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                                                                                        match_pat0.SetMatchOfEnclosingPattern(match);
                                                                                        Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match_pat1 = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                                                                                        match_pat1.SetMatchOfEnclosingPattern(match);
                                                                                        Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match_pat2 = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                                                                                        match_pat2.SetMatchOfEnclosingPattern(match);
                                                                                        match._node_v0 = candidate_appendRule_node_v0;
                                                                                        match._node_r0 = candidate_appendRule_node_r0;
                                                                                        match._node_v4 = candidate_appendRule_node_v4;
                                                                                        match._node_r1 = candidate_appendRule_node_r1;
                                                                                        match._node_v1 = candidate_appendRule_node_v1;
                                                                                        match._node_v3 = candidate_appendRule_node_v3;
                                                                                        match._node_v4_p0 = candidate_appendRule_node_v4_p0;
                                                                                        match._node_v5 = candidate_appendRule_node_v5;
                                                                                        match._node_v2 = candidate_appendRule_node_v2;
                                                                                        match._node_v2_p0 = candidate_appendRule_node_v2_p0;
                                                                                        match._node_e0 = candidate_appendRule_node_e0;
                                                                                        match_pat0._node_src = candidate_nac_NodesWithoutSites_node_src_inlined_pat0_3;
                                                                                        match_pat1._node_src = candidate_nac_NodesWithoutSites_node_src_inlined_pat1_4;
                                                                                        match_pat2._node_src = candidate_nac_NodesWithoutSites_node_src_inlined_pat2_5;
                                                                                        match._edge_c0 = candidate_appendRule_edge_c0;
                                                                                        match._edge_c1 = candidate_appendRule_edge_c1;
                                                                                        match._edge_c2 = candidate_appendRule_edge_c2;
                                                                                        match._edge_c3 = candidate_appendRule_edge_c3;
                                                                                        match._edge_c4 = candidate_appendRule_edge_c4;
                                                                                        match._edge_c5 = candidate_appendRule_edge_c5;
                                                                                        match._edge_c6 = candidate_appendRule_edge_c6;
                                                                                        match._edge_c7 = candidate_appendRule_edge_c7;
                                                                                        match._edge__edge0 = candidate_appendRule_edge__edge0;
                                                                                        match._edge__edge1 = candidate_appendRule_edge__edge1;
                                                                                        match_pat0._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount_inlined_pat0_3;
                                                                                        match_pat1._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount_inlined_pat1_4;
                                                                                        match_pat2._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount_inlined_pat2_5;
                                                                                        match._pat0 = match_pat0;
                                                                                        match._pat1 = match_pat1;
                                                                                        match._pat2 = match_pat2;
                                                                                        matches.PositionWasFilledFixIt();
                                                                                        // if enough matches were found, we leave
                                                                                        if(maxMatches > 0 && matches.Count >= maxMatches)
                                                                                        {
                                                                                            candidate_appendRule_node_v0.MoveInHeadAfter(candidate_appendRule_edge_c3);
                                                                                            candidate_appendRule_node_v0.MoveOutHeadAfter(candidate_appendRule_edge_c0);
                                                                                            candidate_appendRule_node_v1.MoveOutHeadAfter(candidate_appendRule_edge_c2);
                                                                                            candidate_appendRule_node_v2.MoveOutHeadAfter(candidate_appendRule_edge_c6);
                                                                                            candidate_appendRule_node_v2_p0.MoveOutHeadAfter(candidate_appendRule_edge_c7);
                                                                                            candidate_appendRule_node_e0.MoveInHeadAfter(candidate_appendRule_edge__edge1);
                                                                                            candidate_appendRule_node_v4_p0.MoveOutHeadAfter(candidate_appendRule_edge__edge0);
                                                                                            candidate_appendRule_node_v4.MoveInHeadAfter(candidate_appendRule_edge_c5);
                                                                                            candidate_appendRule_node_v4.MoveInHeadAfter(candidate_appendRule_edge_c4);
                                                                                            graph.MoveHeadAfter(candidate_appendRule_edge_c1);
                                                                                            candidate_appendRule_node_r0.lgspFlags = candidate_appendRule_node_r0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_r0;
                                                                                            candidate_appendRule_edge_c0.lgspFlags = candidate_appendRule_edge_c0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c0;
                                                                                            candidate_appendRule_node_v0.lgspFlags = candidate_appendRule_node_v0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v0;
                                                                                            candidate_appendRule_edge_c2.lgspFlags = candidate_appendRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c2;
                                                                                            candidate_appendRule_node_v1.lgspFlags = candidate_appendRule_node_v1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v1;
                                                                                            candidate_appendRule_edge_c6.lgspFlags = candidate_appendRule_edge_c6.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c6;
                                                                                            candidate_appendRule_node_v2.lgspFlags = candidate_appendRule_node_v2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v2;
                                                                                            candidate_appendRule_node_v2_p0.lgspFlags = candidate_appendRule_node_v2_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v2_p0;
                                                                                            candidate_appendRule_node_e0.lgspFlags = candidate_appendRule_node_e0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_e0;
                                                                                            candidate_appendRule_edge__edge0.lgspFlags = candidate_appendRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge__edge0;
                                                                                            candidate_appendRule_node_v5.lgspFlags = candidate_appendRule_node_v5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v5;
                                                                                            candidate_appendRule_edge_c5.lgspFlags = candidate_appendRule_edge_c5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c5;
                                                                                            candidate_appendRule_node_v4_p0.lgspFlags = candidate_appendRule_node_v4_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v4_p0;
                                                                                            candidate_appendRule_edge_c4.lgspFlags = candidate_appendRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c4;
                                                                                            candidate_appendRule_node_r1.lgspFlags = candidate_appendRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_r1;
                                                                                            candidate_appendRule_node_v4.lgspFlags = candidate_appendRule_node_v4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v4;
                                                                                            candidate_appendRule_edge_c1.lgspFlags = candidate_appendRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c1;
                                                                                            return matches;
                                                                                        }
                                                                                    }
                                                                                    while( (candidate_appendRule_edge_c3 = candidate_appendRule_edge_c3.lgspInNext) != head_candidate_appendRule_edge_c3 );
                                                                                }
                                                                                candidate_appendRule_node_r0.lgspFlags = candidate_appendRule_node_r0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_r0;
                                                                                candidate_appendRule_edge_c0.lgspFlags = candidate_appendRule_edge_c0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c0;
                                                                            }
                                                                            while( (candidate_appendRule_edge_c0 = candidate_appendRule_edge_c0.lgspOutNext) != head_candidate_appendRule_edge_c0 );
                                                                        }
                                                                        candidate_appendRule_node_v0.lgspFlags = candidate_appendRule_node_v0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v0;
                                                                        candidate_appendRule_edge_c2.lgspFlags = candidate_appendRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c2;
label12: ;
                                                                    }
                                                                    while( (candidate_appendRule_edge_c2 = candidate_appendRule_edge_c2.lgspOutNext) != head_candidate_appendRule_edge_c2 );
                                                                }
                                                                candidate_appendRule_node_v1.lgspFlags = candidate_appendRule_node_v1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v1;
                                                                candidate_appendRule_edge_c6.lgspFlags = candidate_appendRule_edge_c6.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c6;
                                                            }
                                                            while( (candidate_appendRule_edge_c6 = candidate_appendRule_edge_c6.lgspOutNext) != head_candidate_appendRule_edge_c6 );
                                                        }
                                                        candidate_appendRule_node_v2.lgspFlags = candidate_appendRule_node_v2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v2;
label10: ;
                                                    }
                                                    while( (candidate_appendRule_edge_c7 = candidate_appendRule_edge_c7.lgspOutNext) != head_candidate_appendRule_edge_c7 );
                                                }
                                                candidate_appendRule_node_v2_p0.lgspFlags = candidate_appendRule_node_v2_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v2_p0;
                                            }
                                            while( (candidate_appendRule_edge__edge1 = candidate_appendRule_edge__edge1.lgspInNext) != head_candidate_appendRule_edge__edge1 );
                                        }
                                        candidate_appendRule_node_e0.lgspFlags = candidate_appendRule_node_e0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_e0;
                                        candidate_appendRule_edge__edge0.lgspFlags = candidate_appendRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge__edge0;
                                    }
                                    while( (candidate_appendRule_edge__edge0 = candidate_appendRule_edge__edge0.lgspOutNext) != head_candidate_appendRule_edge__edge0 );
                                }
                                candidate_appendRule_node_v5.lgspFlags = candidate_appendRule_node_v5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v5;
                                candidate_appendRule_edge_c5.lgspFlags = candidate_appendRule_edge_c5.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c5;
                            }
                            while( (candidate_appendRule_edge_c5 = candidate_appendRule_edge_c5.lgspInNext) != head_candidate_appendRule_edge_c5 );
                        }
                        candidate_appendRule_node_v4_p0.lgspFlags = candidate_appendRule_node_v4_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v4_p0;
                        candidate_appendRule_edge_c4.lgspFlags = candidate_appendRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c4;
                    }
                    while( (candidate_appendRule_edge_c4 = candidate_appendRule_edge_c4.lgspInNext) != head_candidate_appendRule_edge_c4 );
                }
                candidate_appendRule_node_r1.lgspFlags = candidate_appendRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_r1;
                candidate_appendRule_node_v4.lgspFlags = candidate_appendRule_node_v4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_node_v4;
                candidate_appendRule_edge_c1.lgspFlags = candidate_appendRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_appendRule_edge_c1;
label8: ;
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_appendRule.IMatch_appendRule match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> matches)
        {
            foreach(Rule_appendRule.IMatch_appendRule match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_appendRule.IMatch_appendRule match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_appendRule.IMatch_appendRule)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_appendRule.IMatch_appendRule>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_returnRule
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_returnRule.IMatch_returnRule match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_returnRule : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_returnRule
    {
        public Action_returnRule()
            : base(Rule_returnRule.Instance.patternGraph)
        {
            _rulePattern = Rule_returnRule.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_returnRule _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "returnRule"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_returnRule.Match_returnRule, Rule_returnRule.IMatch_returnRule> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_returnRule Instance { get { return instance; } set { instance = value; } }
        private static Action_returnRule instance = new Action_returnRule();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_returnRule.Match_returnRule, Rule_returnRule.IMatch_returnRule>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            Stack<GRGEN_LGSP.LGSPSubpatternAction> openTasks = new Stack<GRGEN_LGSP.LGSPSubpatternAction>();
            List<Stack<GRGEN_LIBGR.IMatch>> foundPartialMatches = new List<Stack<GRGEN_LIBGR.IMatch>>();
            List<Stack<GRGEN_LIBGR.IMatch>> matchesList = foundPartialMatches;
            // Lookup returnRule_edge_c1 
            int type_id_candidate_returnRule_edge_c1 = 3;
            for(GRGEN_LGSP.LGSPEdge head_candidate_returnRule_edge_c1 = graph.edgesByTypeHeads[type_id_candidate_returnRule_edge_c1], candidate_returnRule_edge_c1 = head_candidate_returnRule_edge_c1.lgspTypeNext; candidate_returnRule_edge_c1 != head_candidate_returnRule_edge_c1; candidate_returnRule_edge_c1 = candidate_returnRule_edge_c1.lgspTypeNext)
            {
                uint prev__candidate_returnRule_edge_c1;
                prev__candidate_returnRule_edge_c1 = candidate_returnRule_edge_c1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_returnRule_edge_c1.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Implicit Source returnRule_node_v2 from returnRule_edge_c1 
                GRGEN_LGSP.LGSPNode candidate_returnRule_node_v2 = candidate_returnRule_edge_c1.lgspSource;
                if(candidate_returnRule_node_v2.lgspType.TypeID!=11) {
                    candidate_returnRule_edge_c1.lgspFlags = candidate_returnRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c1;
                    continue;
                }
                uint prev__candidate_returnRule_node_v2;
                prev__candidate_returnRule_node_v2 = candidate_returnRule_node_v2.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_returnRule_node_v2.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Variable nac_NodesWithoutSites_var_validChildCount_inlined_pat1_7 assigned from expression 1 
                System.Int32 var_nac_NodesWithoutSites_var_validChildCount_inlined_pat1_7 = (System.Int32)1;
                // Implicit Target returnRule_node_r1 from returnRule_edge_c1 
                GRGEN_LGSP.LGSPNode candidate_returnRule_node_r1 = candidate_returnRule_edge_c1.lgspTarget;
                if((candidate_returnRule_node_r1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                {
                    candidate_returnRule_node_v2.lgspFlags = candidate_returnRule_node_v2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v2;
                    candidate_returnRule_edge_c1.lgspFlags = candidate_returnRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c1;
                    continue;
                }
                uint prev__candidate_returnRule_node_r1;
                prev__candidate_returnRule_node_r1 = candidate_returnRule_node_r1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_returnRule_node_r1.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Element nac_NodesWithoutSites_node_src_inlined_pat1_7 assigned from other element returnRule_node_v2 
                GRGEN_LGSP.LGSPNode candidate_nac_NodesWithoutSites_node_src_inlined_pat1_7 = candidate_returnRule_node_v2;
                if(!GRGEN_MODEL.NodeType_BNode.isMyType[candidate_nac_NodesWithoutSites_node_src_inlined_pat1_7.lgspType.TypeID]) {
                    candidate_returnRule_node_r1.lgspFlags = candidate_returnRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_r1;
                    candidate_returnRule_node_v2.lgspFlags = candidate_returnRule_node_v2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v2;
                    candidate_returnRule_edge_c1.lgspFlags = candidate_returnRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c1;
                    continue;
                }
                // NegativePattern 
                {
                    ++isoSpace;
                    // Condition 
                    if(!(((GRGEN_LIBGR.GraphHelper.AdjacentIncoming((GRGEN_LIBGR.INode)candidate_nac_NodesWithoutSites_node_src_inlined_pat1_7, GRGEN_MODEL.EdgeType_bPrnt.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count != var_nac_NodesWithoutSites_var_validChildCount_inlined_pat1_7))) {
                        --isoSpace;
                        goto label13;
                    }
                    // negative pattern found
                    --isoSpace;
                    candidate_returnRule_node_r1.lgspFlags = candidate_returnRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_r1;
                    candidate_returnRule_node_v2.lgspFlags = candidate_returnRule_node_v2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v2;
                    candidate_returnRule_edge_c1.lgspFlags = candidate_returnRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c1;
                    goto label14;
                    --isoSpace;
                }
label13: ;
                // Extend Incoming returnRule_edge_c3 from returnRule_node_v2 
                GRGEN_LGSP.LGSPEdge head_candidate_returnRule_edge_c3 = candidate_returnRule_node_v2.lgspInhead;
                if(head_candidate_returnRule_edge_c3 != null)
                {
                    GRGEN_LGSP.LGSPEdge candidate_returnRule_edge_c3 = head_candidate_returnRule_edge_c3;
                    do
                    {
                        if(candidate_returnRule_edge_c3.lgspType.TypeID!=5) {
                            continue;
                        }
                        uint prev__candidate_returnRule_edge_c3;
                        prev__candidate_returnRule_edge_c3 = candidate_returnRule_edge_c3.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        candidate_returnRule_edge_c3.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        // Implicit Source returnRule_node_v2_p0 from returnRule_edge_c3 
                        GRGEN_LGSP.LGSPNode candidate_returnRule_node_v2_p0 = candidate_returnRule_edge_c3.lgspSource;
                        if(candidate_returnRule_node_v2_p0.lgspType.TypeID!=7) {
                            candidate_returnRule_edge_c3.lgspFlags = candidate_returnRule_edge_c3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c3;
                            continue;
                        }
                        if((candidate_returnRule_node_v2_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                        {
                            candidate_returnRule_edge_c3.lgspFlags = candidate_returnRule_edge_c3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c3;
                            continue;
                        }
                        uint prev__candidate_returnRule_node_v2_p0;
                        prev__candidate_returnRule_node_v2_p0 = candidate_returnRule_node_v2_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        candidate_returnRule_node_v2_p0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                        // Condition 
                        if(!((((GRGEN_MODEL.IBPort)candidate_returnRule_node_v2_p0).@ix == 0))) {
                            candidate_returnRule_node_v2_p0.lgspFlags = candidate_returnRule_node_v2_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v2_p0;
                            candidate_returnRule_edge_c3.lgspFlags = candidate_returnRule_edge_c3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c3;
                            continue;
                        }
                        // Extend Incoming returnRule_edge_c4 from returnRule_node_v2 
                        GRGEN_LGSP.LGSPEdge head_candidate_returnRule_edge_c4 = candidate_returnRule_node_v2.lgspInhead;
                        if(head_candidate_returnRule_edge_c4 != null)
                        {
                            GRGEN_LGSP.LGSPEdge candidate_returnRule_edge_c4 = head_candidate_returnRule_edge_c4;
                            do
                            {
                                if(candidate_returnRule_edge_c4.lgspType.TypeID!=3) {
                                    continue;
                                }
                                if((candidate_returnRule_edge_c4.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                {
                                    continue;
                                }
                                uint prev__candidate_returnRule_edge_c4;
                                prev__candidate_returnRule_edge_c4 = candidate_returnRule_edge_c4.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                candidate_returnRule_edge_c4.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                // Implicit Source returnRule_node_v3 from returnRule_edge_c4 
                                GRGEN_LGSP.LGSPNode candidate_returnRule_node_v3 = candidate_returnRule_edge_c4.lgspSource;
                                if(candidate_returnRule_node_v3.lgspType.TypeID!=17) {
                                    candidate_returnRule_edge_c4.lgspFlags = candidate_returnRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c4;
                                    continue;
                                }
                                if((candidate_returnRule_node_v3.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                {
                                    candidate_returnRule_edge_c4.lgspFlags = candidate_returnRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c4;
                                    continue;
                                }
                                uint prev__candidate_returnRule_node_v3;
                                prev__candidate_returnRule_node_v3 = candidate_returnRule_node_v3.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                candidate_returnRule_node_v3.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                // Variable nac_NodesWithoutSites_var_validChildCount_inlined_pat2_8 assigned from expression 0 
                                System.Int32 var_nac_NodesWithoutSites_var_validChildCount_inlined_pat2_8 = (System.Int32)0;
                                // Element nac_NodesWithoutSites_node_src_inlined_pat2_8 assigned from other element returnRule_node_v3 
                                GRGEN_LGSP.LGSPNode candidate_nac_NodesWithoutSites_node_src_inlined_pat2_8 = candidate_returnRule_node_v3;
                                if(!GRGEN_MODEL.NodeType_BNode.isMyType[candidate_nac_NodesWithoutSites_node_src_inlined_pat2_8.lgspType.TypeID]) {
                                    candidate_returnRule_node_v3.lgspFlags = candidate_returnRule_node_v3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v3;
                                    candidate_returnRule_edge_c4.lgspFlags = candidate_returnRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c4;
                                    continue;
                                }
                                // NegativePattern 
                                {
                                    ++isoSpace;
                                    // Condition 
                                    if(!(((GRGEN_LIBGR.GraphHelper.AdjacentIncoming((GRGEN_LIBGR.INode)candidate_nac_NodesWithoutSites_node_src_inlined_pat2_8, GRGEN_MODEL.EdgeType_bPrnt.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count != var_nac_NodesWithoutSites_var_validChildCount_inlined_pat2_8))) {
                                        --isoSpace;
                                        goto label15;
                                    }
                                    // negative pattern found
                                    --isoSpace;
                                    candidate_returnRule_node_v3.lgspFlags = candidate_returnRule_node_v3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v3;
                                    candidate_returnRule_edge_c4.lgspFlags = candidate_returnRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c4;
                                    goto label16;
                                    --isoSpace;
                                }
label15: ;
                                // Extend Outgoing returnRule_edge__edge0 from returnRule_node_v2_p0 
                                GRGEN_LGSP.LGSPEdge head_candidate_returnRule_edge__edge0 = candidate_returnRule_node_v2_p0.lgspOuthead;
                                if(head_candidate_returnRule_edge__edge0 != null)
                                {
                                    GRGEN_LGSP.LGSPEdge candidate_returnRule_edge__edge0 = head_candidate_returnRule_edge__edge0;
                                    do
                                    {
                                        if(candidate_returnRule_edge__edge0.lgspType.TypeID!=7) {
                                            continue;
                                        }
                                        uint prev__candidate_returnRule_edge__edge0;
                                        prev__candidate_returnRule_edge__edge0 = candidate_returnRule_edge__edge0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        candidate_returnRule_edge__edge0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        // Implicit Target returnRule_node_e0 from returnRule_edge__edge0 
                                        GRGEN_LGSP.LGSPNode candidate_returnRule_node_e0 = candidate_returnRule_edge__edge0.lgspTarget;
                                        if(candidate_returnRule_node_e0.lgspType.TypeID!=9) {
                                            candidate_returnRule_edge__edge0.lgspFlags = candidate_returnRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge__edge0;
                                            continue;
                                        }
                                        if((candidate_returnRule_node_e0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                        {
                                            candidate_returnRule_edge__edge0.lgspFlags = candidate_returnRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge__edge0;
                                            continue;
                                        }
                                        uint prev__candidate_returnRule_node_e0;
                                        prev__candidate_returnRule_node_e0 = candidate_returnRule_node_e0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        candidate_returnRule_node_e0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                        // Extend Incoming returnRule_edge__edge1 from returnRule_node_e0 
                                        GRGEN_LGSP.LGSPEdge head_candidate_returnRule_edge__edge1 = candidate_returnRule_node_e0.lgspInhead;
                                        if(head_candidate_returnRule_edge__edge1 != null)
                                        {
                                            GRGEN_LGSP.LGSPEdge candidate_returnRule_edge__edge1 = head_candidate_returnRule_edge__edge1;
                                            do
                                            {
                                                if(candidate_returnRule_edge__edge1.lgspType.TypeID!=7) {
                                                    continue;
                                                }
                                                if((candidate_returnRule_edge__edge1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                {
                                                    continue;
                                                }
                                                // Implicit Source returnRule_node_v1_p0 from returnRule_edge__edge1 
                                                GRGEN_LGSP.LGSPNode candidate_returnRule_node_v1_p0 = candidate_returnRule_edge__edge1.lgspSource;
                                                if(candidate_returnRule_node_v1_p0.lgspType.TypeID!=7) {
                                                    continue;
                                                }
                                                if((candidate_returnRule_node_v1_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                {
                                                    continue;
                                                }
                                                uint prev__candidate_returnRule_node_v1_p0;
                                                prev__candidate_returnRule_node_v1_p0 = candidate_returnRule_node_v1_p0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                candidate_returnRule_node_v1_p0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                // Condition 
                                                if(!((((GRGEN_MODEL.IBPort)candidate_returnRule_node_v1_p0).@ix == 0))) {
                                                    candidate_returnRule_node_v1_p0.lgspFlags = candidate_returnRule_node_v1_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v1_p0;
                                                    continue;
                                                }
                                                // Extend Outgoing returnRule_edge_c5 from returnRule_node_v1_p0 
                                                GRGEN_LGSP.LGSPEdge head_candidate_returnRule_edge_c5 = candidate_returnRule_node_v1_p0.lgspOuthead;
                                                if(head_candidate_returnRule_edge_c5 != null)
                                                {
                                                    GRGEN_LGSP.LGSPEdge candidate_returnRule_edge_c5 = head_candidate_returnRule_edge_c5;
                                                    do
                                                    {
                                                        if(candidate_returnRule_edge_c5.lgspType.TypeID!=5) {
                                                            continue;
                                                        }
                                                        if((candidate_returnRule_edge_c5.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                        {
                                                            continue;
                                                        }
                                                        // Implicit Target returnRule_node_v1 from returnRule_edge_c5 
                                                        GRGEN_LGSP.LGSPNode candidate_returnRule_node_v1 = candidate_returnRule_edge_c5.lgspTarget;
                                                        if(candidate_returnRule_node_v1.lgspType.TypeID!=15) {
                                                            continue;
                                                        }
                                                        if((candidate_returnRule_node_v1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                        {
                                                            continue;
                                                        }
                                                        uint prev__candidate_returnRule_node_v1;
                                                        prev__candidate_returnRule_node_v1 = candidate_returnRule_node_v1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                        candidate_returnRule_node_v1.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                        // Variable nac_NodesWithoutSites_var_validChildCount_inlined_pat0_6 assigned from expression 0 
                                                        System.Int32 var_nac_NodesWithoutSites_var_validChildCount_inlined_pat0_6 = (System.Int32)0;
                                                        // Element nac_NodesWithoutSites_node_src_inlined_pat0_6 assigned from other element returnRule_node_v1 
                                                        GRGEN_LGSP.LGSPNode candidate_nac_NodesWithoutSites_node_src_inlined_pat0_6 = candidate_returnRule_node_v1;
                                                        if(!GRGEN_MODEL.NodeType_BNode.isMyType[candidate_nac_NodesWithoutSites_node_src_inlined_pat0_6.lgspType.TypeID]) {
                                                            candidate_returnRule_node_v1.lgspFlags = candidate_returnRule_node_v1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v1;
                                                            continue;
                                                        }
                                                        // NegativePattern 
                                                        {
                                                            ++isoSpace;
                                                            // Condition 
                                                            if(!(((GRGEN_LIBGR.GraphHelper.AdjacentIncoming((GRGEN_LIBGR.INode)candidate_nac_NodesWithoutSites_node_src_inlined_pat0_6, GRGEN_MODEL.EdgeType_bPrnt.typeVar, GRGEN_MODEL.NodeType_Node.typeVar)).Count != var_nac_NodesWithoutSites_var_validChildCount_inlined_pat0_6))) {
                                                                --isoSpace;
                                                                goto label17;
                                                            }
                                                            // negative pattern found
                                                            --isoSpace;
                                                            candidate_returnRule_node_v1.lgspFlags = candidate_returnRule_node_v1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v1;
                                                            goto label18;
                                                            --isoSpace;
                                                        }
label17: ;
                                                        // Extend Outgoing returnRule_edge_c2 from returnRule_node_v1 
                                                        GRGEN_LGSP.LGSPEdge head_candidate_returnRule_edge_c2 = candidate_returnRule_node_v1.lgspOuthead;
                                                        if(head_candidate_returnRule_edge_c2 != null)
                                                        {
                                                            GRGEN_LGSP.LGSPEdge candidate_returnRule_edge_c2 = head_candidate_returnRule_edge_c2;
                                                            do
                                                            {
                                                                if(candidate_returnRule_edge_c2.lgspType.TypeID!=3) {
                                                                    continue;
                                                                }
                                                                if((candidate_returnRule_edge_c2.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                {
                                                                    continue;
                                                                }
                                                                uint prev__candidate_returnRule_edge_c2;
                                                                prev__candidate_returnRule_edge_c2 = candidate_returnRule_edge_c2.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                candidate_returnRule_edge_c2.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                // Implicit Target returnRule_node_v0 from returnRule_edge_c2 
                                                                GRGEN_LGSP.LGSPNode candidate_returnRule_node_v0 = candidate_returnRule_edge_c2.lgspTarget;
                                                                if(candidate_returnRule_node_v0.lgspType.TypeID!=14) {
                                                                    candidate_returnRule_edge_c2.lgspFlags = candidate_returnRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c2;
                                                                    continue;
                                                                }
                                                                if((candidate_returnRule_node_v0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                {
                                                                    candidate_returnRule_edge_c2.lgspFlags = candidate_returnRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c2;
                                                                    continue;
                                                                }
                                                                uint prev__candidate_returnRule_node_v0;
                                                                prev__candidate_returnRule_node_v0 = candidate_returnRule_node_v0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                candidate_returnRule_node_v0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                                                                // Extend Outgoing returnRule_edge_c0 from returnRule_node_v0 
                                                                GRGEN_LGSP.LGSPEdge head_candidate_returnRule_edge_c0 = candidate_returnRule_node_v0.lgspOuthead;
                                                                if(head_candidate_returnRule_edge_c0 != null)
                                                                {
                                                                    GRGEN_LGSP.LGSPEdge candidate_returnRule_edge_c0 = head_candidate_returnRule_edge_c0;
                                                                    do
                                                                    {
                                                                        if(candidate_returnRule_edge_c0.lgspType.TypeID!=3) {
                                                                            continue;
                                                                        }
                                                                        if((candidate_returnRule_edge_c0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                        {
                                                                            continue;
                                                                        }
                                                                        // Implicit Target returnRule_node_r0 from returnRule_edge_c0 
                                                                        GRGEN_LGSP.LGSPNode candidate_returnRule_node_r0 = candidate_returnRule_edge_c0.lgspTarget;
                                                                        if((candidate_returnRule_node_r0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                                                                        {
                                                                            continue;
                                                                        }
                                                                        Rule_returnRule.Match_returnRule match = matches.GetNextUnfilledPosition();
                                                                        Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match_pat0 = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                                                                        match_pat0.SetMatchOfEnclosingPattern(match);
                                                                        Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match_pat1 = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                                                                        match_pat1.SetMatchOfEnclosingPattern(match);
                                                                        Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites match_pat2 = new Pattern_nac_NodesWithoutSites.Match_nac_NodesWithoutSites();
                                                                        match_pat2.SetMatchOfEnclosingPattern(match);
                                                                        match._node_v0 = candidate_returnRule_node_v0;
                                                                        match._node_r0 = candidate_returnRule_node_r0;
                                                                        match._node_v2 = candidate_returnRule_node_v2;
                                                                        match._node_r1 = candidate_returnRule_node_r1;
                                                                        match._node_v1 = candidate_returnRule_node_v1;
                                                                        match._node_v2_p0 = candidate_returnRule_node_v2_p0;
                                                                        match._node_v3 = candidate_returnRule_node_v3;
                                                                        match._node_v1_p0 = candidate_returnRule_node_v1_p0;
                                                                        match._node_e0 = candidate_returnRule_node_e0;
                                                                        match_pat0._node_src = candidate_nac_NodesWithoutSites_node_src_inlined_pat0_6;
                                                                        match_pat1._node_src = candidate_nac_NodesWithoutSites_node_src_inlined_pat1_7;
                                                                        match_pat2._node_src = candidate_nac_NodesWithoutSites_node_src_inlined_pat2_8;
                                                                        match._edge_c0 = candidate_returnRule_edge_c0;
                                                                        match._edge_c1 = candidate_returnRule_edge_c1;
                                                                        match._edge_c2 = candidate_returnRule_edge_c2;
                                                                        match._edge_c3 = candidate_returnRule_edge_c3;
                                                                        match._edge_c4 = candidate_returnRule_edge_c4;
                                                                        match._edge_c5 = candidate_returnRule_edge_c5;
                                                                        match._edge__edge0 = candidate_returnRule_edge__edge0;
                                                                        match._edge__edge1 = candidate_returnRule_edge__edge1;
                                                                        match_pat0._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount_inlined_pat0_6;
                                                                        match_pat1._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount_inlined_pat1_7;
                                                                        match_pat2._var_validChildCount = var_nac_NodesWithoutSites_var_validChildCount_inlined_pat2_8;
                                                                        match._pat0 = match_pat0;
                                                                        match._pat1 = match_pat1;
                                                                        match._pat2 = match_pat2;
                                                                        matches.PositionWasFilledFixIt();
                                                                        // if enough matches were found, we leave
                                                                        if(maxMatches > 0 && matches.Count >= maxMatches)
                                                                        {
                                                                            candidate_returnRule_node_v0.MoveOutHeadAfter(candidate_returnRule_edge_c0);
                                                                            candidate_returnRule_node_v1.MoveOutHeadAfter(candidate_returnRule_edge_c2);
                                                                            candidate_returnRule_node_v1_p0.MoveOutHeadAfter(candidate_returnRule_edge_c5);
                                                                            candidate_returnRule_node_e0.MoveInHeadAfter(candidate_returnRule_edge__edge1);
                                                                            candidate_returnRule_node_v2_p0.MoveOutHeadAfter(candidate_returnRule_edge__edge0);
                                                                            candidate_returnRule_node_v2.MoveInHeadAfter(candidate_returnRule_edge_c4);
                                                                            candidate_returnRule_node_v2.MoveInHeadAfter(candidate_returnRule_edge_c3);
                                                                            graph.MoveHeadAfter(candidate_returnRule_edge_c1);
                                                                            candidate_returnRule_node_v0.lgspFlags = candidate_returnRule_node_v0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v0;
                                                                            candidate_returnRule_edge_c2.lgspFlags = candidate_returnRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c2;
                                                                            candidate_returnRule_node_v1.lgspFlags = candidate_returnRule_node_v1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v1;
                                                                            candidate_returnRule_node_v1_p0.lgspFlags = candidate_returnRule_node_v1_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v1_p0;
                                                                            candidate_returnRule_node_e0.lgspFlags = candidate_returnRule_node_e0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_e0;
                                                                            candidate_returnRule_edge__edge0.lgspFlags = candidate_returnRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge__edge0;
                                                                            candidate_returnRule_node_v3.lgspFlags = candidate_returnRule_node_v3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v3;
                                                                            candidate_returnRule_edge_c4.lgspFlags = candidate_returnRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c4;
                                                                            candidate_returnRule_node_v2_p0.lgspFlags = candidate_returnRule_node_v2_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v2_p0;
                                                                            candidate_returnRule_edge_c3.lgspFlags = candidate_returnRule_edge_c3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c3;
                                                                            candidate_returnRule_node_r1.lgspFlags = candidate_returnRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_r1;
                                                                            candidate_returnRule_node_v2.lgspFlags = candidate_returnRule_node_v2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v2;
                                                                            candidate_returnRule_edge_c1.lgspFlags = candidate_returnRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c1;
                                                                            return matches;
                                                                        }
                                                                    }
                                                                    while( (candidate_returnRule_edge_c0 = candidate_returnRule_edge_c0.lgspOutNext) != head_candidate_returnRule_edge_c0 );
                                                                }
                                                                candidate_returnRule_node_v0.lgspFlags = candidate_returnRule_node_v0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v0;
                                                                candidate_returnRule_edge_c2.lgspFlags = candidate_returnRule_edge_c2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c2;
                                                            }
                                                            while( (candidate_returnRule_edge_c2 = candidate_returnRule_edge_c2.lgspOutNext) != head_candidate_returnRule_edge_c2 );
                                                        }
                                                        candidate_returnRule_node_v1.lgspFlags = candidate_returnRule_node_v1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v1;
label18: ;
                                                    }
                                                    while( (candidate_returnRule_edge_c5 = candidate_returnRule_edge_c5.lgspOutNext) != head_candidate_returnRule_edge_c5 );
                                                }
                                                candidate_returnRule_node_v1_p0.lgspFlags = candidate_returnRule_node_v1_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v1_p0;
                                            }
                                            while( (candidate_returnRule_edge__edge1 = candidate_returnRule_edge__edge1.lgspInNext) != head_candidate_returnRule_edge__edge1 );
                                        }
                                        candidate_returnRule_node_e0.lgspFlags = candidate_returnRule_node_e0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_e0;
                                        candidate_returnRule_edge__edge0.lgspFlags = candidate_returnRule_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge__edge0;
                                    }
                                    while( (candidate_returnRule_edge__edge0 = candidate_returnRule_edge__edge0.lgspOutNext) != head_candidate_returnRule_edge__edge0 );
                                }
                                candidate_returnRule_node_v3.lgspFlags = candidate_returnRule_node_v3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v3;
                                candidate_returnRule_edge_c4.lgspFlags = candidate_returnRule_edge_c4.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c4;
label16: ;
                            }
                            while( (candidate_returnRule_edge_c4 = candidate_returnRule_edge_c4.lgspInNext) != head_candidate_returnRule_edge_c4 );
                        }
                        candidate_returnRule_node_v2_p0.lgspFlags = candidate_returnRule_node_v2_p0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v2_p0;
                        candidate_returnRule_edge_c3.lgspFlags = candidate_returnRule_edge_c3.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c3;
                    }
                    while( (candidate_returnRule_edge_c3 = candidate_returnRule_edge_c3.lgspInNext) != head_candidate_returnRule_edge_c3 );
                }
                candidate_returnRule_node_r1.lgspFlags = candidate_returnRule_node_r1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_r1;
                candidate_returnRule_node_v2.lgspFlags = candidate_returnRule_node_v2.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_node_v2;
                candidate_returnRule_edge_c1.lgspFlags = candidate_returnRule_edge_c1.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_returnRule_edge_c1;
label14: ;
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_returnRule.IMatch_returnRule match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> matches)
        {
            foreach(Rule_returnRule.IMatch_returnRule match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_returnRule.IMatch_returnRule match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_returnRule.IMatch_returnRule)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_returnRule.IMatch_returnRule>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    

    // class which instantiates and stores all the compiled actions of the module,
    // dynamic regeneration and compilation causes the old action to be overwritten by the new one
    // matching/rule patterns are analyzed at creation time here, once, so that later regeneration runs have all the information available
    public class rulesetActions : GRGEN_LGSP.LGSPActions
    {
        public rulesetActions(GRGEN_LGSP.LGSPGraph lgspgraph, string modelAsmName, string actionsAsmName)
            : base(lgspgraph, modelAsmName, actionsAsmName)
        {
            InitActions();
        }

        public rulesetActions(GRGEN_LGSP.LGSPGraph lgspgraph)
            : base(lgspgraph)
        {
            InitActions();
        }

        private void InitActions()
        {
            packages = new string[0];
            GRGEN_LGSP.PatternGraphAnalyzer analyzer = new GRGEN_LGSP.PatternGraphAnalyzer();
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_nextRule.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_nextRule.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_nextRule.Instance);
            actions.Add("nextRule", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_nextRule.Instance);
            @nextRule = GRGEN_ACTIONS.Action_nextRule.Instance;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_appendRule.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_appendRule.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_appendRule.Instance);
            actions.Add("appendRule", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_appendRule.Instance);
            @appendRule = GRGEN_ACTIONS.Action_appendRule.Instance;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_returnRule.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_returnRule.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_returnRule.Instance);
            actions.Add("returnRule", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_returnRule.Instance);
            @returnRule = GRGEN_ACTIONS.Action_returnRule.Instance;
            analyzer.ComputeInterPatternRelations(false);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_nextRule.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_appendRule.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_returnRule.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_nextRule.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_appendRule.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_returnRule.Instance.patternGraph);
            GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_nextRule.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_appendRule.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_returnRule.Instance.patternGraph.maxIsoSpace = 0;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Pattern_nac_NodesWithoutSites.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_nextRule.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_appendRule.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_returnRule.Instance.patternGraph, true);
            analyzer.ComputeInterPatternRelations(true);
        }
        
        public GRGEN_ACTIONS.IAction_nextRule @nextRule;
        public GRGEN_ACTIONS.IAction_appendRule @appendRule;
        public GRGEN_ACTIONS.IAction_returnRule @returnRule;
        
        
        public override string[] Packages { get { return packages; } }
        private string[] packages;
        
        public override string Name { get { return "rulesetActions"; } }
        public override string StatisticsPath { get { return null; } }
        public override bool LazyNIC { get { return false; } }
        public override bool InlineIndependents { get { return true; } }
        public override bool Profile { get { return false; } }

        public override IList ArrayOrderAscendingBy(IList array, string member)
        {
            if(array.Count == 0)
                return array;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return null;
            if(array[0] == null)
                return null;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return null;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "nextRule":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "appendRule":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "returnRule":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                default:
                    return null;
                }
            }
        }

        public override IList ArrayOrderDescendingBy(IList array, string member)
        {
            if(array.Count == 0)
                return array;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return null;
            if(array[0] == null)
                return null;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return null;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "nextRule":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "appendRule":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "returnRule":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                default:
                    return null;
                }
            }
        }

        public override IList ArrayGroupBy(IList array, string member)
        {
            if(array.Count == 0)
                return array;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return null;
            if(array[0] == null)
                return null;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return null;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "nextRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_nextRule_groupBy_v0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "r0":
                        return ArrayHelper.Array_nextRule_groupBy_r0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v2":
                        return ArrayHelper.Array_nextRule_groupBy_v2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v5":
                        return ArrayHelper.Array_nextRule_groupBy_v5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "r1":
                        return ArrayHelper.Array_nextRule_groupBy_r1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v1":
                        return ArrayHelper.Array_nextRule_groupBy_v1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v3":
                        return ArrayHelper.Array_nextRule_groupBy_v3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v5_p0":
                        return ArrayHelper.Array_nextRule_groupBy_v5_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v6":
                        return ArrayHelper.Array_nextRule_groupBy_v6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v1_p0":
                        return ArrayHelper.Array_nextRule_groupBy_v1_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v4":
                        return ArrayHelper.Array_nextRule_groupBy_v4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "e0":
                        return ArrayHelper.Array_nextRule_groupBy_e0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c0":
                        return ArrayHelper.Array_nextRule_groupBy_c0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c1":
                        return ArrayHelper.Array_nextRule_groupBy_c1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c2":
                        return ArrayHelper.Array_nextRule_groupBy_c2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c3":
                        return ArrayHelper.Array_nextRule_groupBy_c3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c4":
                        return ArrayHelper.Array_nextRule_groupBy_c4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c5":
                        return ArrayHelper.Array_nextRule_groupBy_c5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c6":
                        return ArrayHelper.Array_nextRule_groupBy_c6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c7":
                        return ArrayHelper.Array_nextRule_groupBy_c7(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c8":
                        return ArrayHelper.Array_nextRule_groupBy_c8(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_nextRule_groupBy__edge0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "_edge1":
                        return ArrayHelper.Array_nextRule_groupBy__edge1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "appendRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_appendRule_groupBy_v0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "r0":
                        return ArrayHelper.Array_appendRule_groupBy_r0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v4":
                        return ArrayHelper.Array_appendRule_groupBy_v4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "r1":
                        return ArrayHelper.Array_appendRule_groupBy_r1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v1":
                        return ArrayHelper.Array_appendRule_groupBy_v1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v3":
                        return ArrayHelper.Array_appendRule_groupBy_v3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v4_p0":
                        return ArrayHelper.Array_appendRule_groupBy_v4_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v5":
                        return ArrayHelper.Array_appendRule_groupBy_v5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v2":
                        return ArrayHelper.Array_appendRule_groupBy_v2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v2_p0":
                        return ArrayHelper.Array_appendRule_groupBy_v2_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "e0":
                        return ArrayHelper.Array_appendRule_groupBy_e0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c0":
                        return ArrayHelper.Array_appendRule_groupBy_c0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c1":
                        return ArrayHelper.Array_appendRule_groupBy_c1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c2":
                        return ArrayHelper.Array_appendRule_groupBy_c2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c3":
                        return ArrayHelper.Array_appendRule_groupBy_c3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c4":
                        return ArrayHelper.Array_appendRule_groupBy_c4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c5":
                        return ArrayHelper.Array_appendRule_groupBy_c5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c6":
                        return ArrayHelper.Array_appendRule_groupBy_c6(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c7":
                        return ArrayHelper.Array_appendRule_groupBy_c7(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_appendRule_groupBy__edge0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "_edge1":
                        return ArrayHelper.Array_appendRule_groupBy__edge1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "returnRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_returnRule_groupBy_v0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "r0":
                        return ArrayHelper.Array_returnRule_groupBy_r0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "v2":
                        return ArrayHelper.Array_returnRule_groupBy_v2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "r1":
                        return ArrayHelper.Array_returnRule_groupBy_r1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "v1":
                        return ArrayHelper.Array_returnRule_groupBy_v1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "v2_p0":
                        return ArrayHelper.Array_returnRule_groupBy_v2_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "v3":
                        return ArrayHelper.Array_returnRule_groupBy_v3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "v1_p0":
                        return ArrayHelper.Array_returnRule_groupBy_v1_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "e0":
                        return ArrayHelper.Array_returnRule_groupBy_e0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c0":
                        return ArrayHelper.Array_returnRule_groupBy_c0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c1":
                        return ArrayHelper.Array_returnRule_groupBy_c1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c2":
                        return ArrayHelper.Array_returnRule_groupBy_c2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c3":
                        return ArrayHelper.Array_returnRule_groupBy_c3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c4":
                        return ArrayHelper.Array_returnRule_groupBy_c4(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c5":
                        return ArrayHelper.Array_returnRule_groupBy_c5(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_returnRule_groupBy__edge0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "_edge1":
                        return ArrayHelper.Array_returnRule_groupBy__edge1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                default:
                    return null;
                }
            }
        }

        public override IList ArrayKeepOneForEach(IList array, string member)
        {
            if(array.Count == 0)
                return array;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return null;
            if(array[0] == null)
                return null;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return null;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "nextRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_v0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "r0":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_r0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v2":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_v2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v5":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_v5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "r1":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_r1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v1":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_v1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v3":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_v3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v5_p0":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_v5_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v6":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_v6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v1_p0":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_v1_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "v4":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_v4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "e0":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_e0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c0":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_c0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c1":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_c1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c2":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_c2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c3":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_c3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c4":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_c4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c5":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_c5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c6":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_c6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c7":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_c7(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "c8":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy_c8(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy__edge0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    case "_edge1":
                        return ArrayHelper.Array_nextRule_keepOneForEachBy__edge1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "appendRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_v0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "r0":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_r0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v4":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_v4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "r1":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_r1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v1":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_v1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v3":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_v3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v4_p0":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_v4_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v5":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_v5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v2":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_v2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "v2_p0":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_v2_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "e0":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_e0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c0":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_c0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c1":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_c1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c2":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_c2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c3":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_c3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c4":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_c4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c5":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_c5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c6":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_c6(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "c7":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy_c7(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy__edge0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    case "_edge1":
                        return ArrayHelper.Array_appendRule_keepOneForEachBy__edge1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "returnRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_v0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "r0":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_r0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "v2":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_v2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "r1":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_r1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "v1":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_v1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "v2_p0":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_v2_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "v3":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_v3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "v1_p0":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_v1_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "e0":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_e0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c0":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_c0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c1":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_c1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c2":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_c2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c3":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_c3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c4":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_c4(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "c5":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy_c5(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy__edge0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    case "_edge1":
                        return ArrayHelper.Array_returnRule_keepOneForEachBy__edge1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                default:
                    return null;
                }
            }
        }

        public override int ArrayIndexOfBy(IList array, string member, object value)
        {
            if(array.Count == 0)
                return -1;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return -1;
            if(array[0] == null)
                return -1;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return -1;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "nextRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_nextRule_indexOfBy_v0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value);
                    case "r0":
                        return ArrayHelper.Array_nextRule_indexOfBy_r0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v2":
                        return ArrayHelper.Array_nextRule_indexOfBy_v2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Inext)value);
                    case "v5":
                        return ArrayHelper.Array_nextRule_indexOfBy_v5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value);
                    case "r1":
                        return ArrayHelper.Array_nextRule_indexOfBy_r1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v1":
                        return ArrayHelper.Array_nextRule_indexOfBy_v1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value);
                    case "v3":
                        return ArrayHelper.Array_nextRule_indexOfBy_v3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.ICell)value);
                    case "v5_p0":
                        return ArrayHelper.Array_nextRule_indexOfBy_v5_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "v6":
                        return ArrayHelper.Array_nextRule_indexOfBy_v6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value);
                    case "v1_p0":
                        return ArrayHelper.Array_nextRule_indexOfBy_v1_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "v4":
                        return ArrayHelper.Array_nextRule_indexOfBy_v4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value);
                    case "e0":
                        return ArrayHelper.Array_nextRule_indexOfBy_e0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value);
                    case "c0":
                        return ArrayHelper.Array_nextRule_indexOfBy_c0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c1":
                        return ArrayHelper.Array_nextRule_indexOfBy_c1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c2":
                        return ArrayHelper.Array_nextRule_indexOfBy_c2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c3":
                        return ArrayHelper.Array_nextRule_indexOfBy_c3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c4":
                        return ArrayHelper.Array_nextRule_indexOfBy_c4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c5":
                        return ArrayHelper.Array_nextRule_indexOfBy_c5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "c6":
                        return ArrayHelper.Array_nextRule_indexOfBy_c6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c7":
                        return ArrayHelper.Array_nextRule_indexOfBy_c7(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "c8":
                        return ArrayHelper.Array_nextRule_indexOfBy_c8(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "_edge0":
                        return ArrayHelper.Array_nextRule_indexOfBy__edge0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    case "_edge1":
                        return ArrayHelper.Array_nextRule_indexOfBy__edge1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    default:
                        return -1;
                    }
                case "appendRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_appendRule_indexOfBy_v0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.ICell)value);
                    case "r0":
                        return ArrayHelper.Array_appendRule_indexOfBy_r0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v4":
                        return ArrayHelper.Array_appendRule_indexOfBy_v4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value);
                    case "r1":
                        return ArrayHelper.Array_appendRule_indexOfBy_r1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v1":
                        return ArrayHelper.Array_appendRule_indexOfBy_v1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value);
                    case "v3":
                        return ArrayHelper.Array_appendRule_indexOfBy_v3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value);
                    case "v4_p0":
                        return ArrayHelper.Array_appendRule_indexOfBy_v4_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "v5":
                        return ArrayHelper.Array_appendRule_indexOfBy_v5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value);
                    case "v2":
                        return ArrayHelper.Array_appendRule_indexOfBy_v2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value);
                    case "v2_p0":
                        return ArrayHelper.Array_appendRule_indexOfBy_v2_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "e0":
                        return ArrayHelper.Array_appendRule_indexOfBy_e0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value);
                    case "c0":
                        return ArrayHelper.Array_appendRule_indexOfBy_c0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c1":
                        return ArrayHelper.Array_appendRule_indexOfBy_c1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c2":
                        return ArrayHelper.Array_appendRule_indexOfBy_c2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c3":
                        return ArrayHelper.Array_appendRule_indexOfBy_c3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c4":
                        return ArrayHelper.Array_appendRule_indexOfBy_c4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "c5":
                        return ArrayHelper.Array_appendRule_indexOfBy_c5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c6":
                        return ArrayHelper.Array_appendRule_indexOfBy_c6(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c7":
                        return ArrayHelper.Array_appendRule_indexOfBy_c7(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "_edge0":
                        return ArrayHelper.Array_appendRule_indexOfBy__edge0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    case "_edge1":
                        return ArrayHelper.Array_appendRule_indexOfBy__edge1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    default:
                        return -1;
                    }
                case "returnRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_returnRule_indexOfBy_v0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value);
                    case "r0":
                        return ArrayHelper.Array_returnRule_indexOfBy_r0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v2":
                        return ArrayHelper.Array_returnRule_indexOfBy_v2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value);
                    case "r1":
                        return ArrayHelper.Array_returnRule_indexOfBy_r1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v1":
                        return ArrayHelper.Array_returnRule_indexOfBy_v1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value);
                    case "v2_p0":
                        return ArrayHelper.Array_returnRule_indexOfBy_v2_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "v3":
                        return ArrayHelper.Array_returnRule_indexOfBy_v3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IVoid)value);
                    case "v1_p0":
                        return ArrayHelper.Array_returnRule_indexOfBy_v1_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "e0":
                        return ArrayHelper.Array_returnRule_indexOfBy_e0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value);
                    case "c0":
                        return ArrayHelper.Array_returnRule_indexOfBy_c0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c1":
                        return ArrayHelper.Array_returnRule_indexOfBy_c1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c2":
                        return ArrayHelper.Array_returnRule_indexOfBy_c2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c3":
                        return ArrayHelper.Array_returnRule_indexOfBy_c3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "c4":
                        return ArrayHelper.Array_returnRule_indexOfBy_c4(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c5":
                        return ArrayHelper.Array_returnRule_indexOfBy_c5(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "_edge0":
                        return ArrayHelper.Array_returnRule_indexOfBy__edge0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    case "_edge1":
                        return ArrayHelper.Array_returnRule_indexOfBy__edge1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    default:
                        return -1;
                    }
                default:
                    return -1;
                }
            }
        }

        public override int ArrayIndexOfBy(IList array, string member, object value, int startIndex)
        {
            if(array.Count == 0)
                return -1;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return -1;
            if(array[0] == null)
                return -1;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return -1;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "nextRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_nextRule_indexOfBy_v0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value, startIndex);
                    case "r0":
                        return ArrayHelper.Array_nextRule_indexOfBy_r0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v2":
                        return ArrayHelper.Array_nextRule_indexOfBy_v2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Inext)value, startIndex);
                    case "v5":
                        return ArrayHelper.Array_nextRule_indexOfBy_v5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value, startIndex);
                    case "r1":
                        return ArrayHelper.Array_nextRule_indexOfBy_r1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v1":
                        return ArrayHelper.Array_nextRule_indexOfBy_v1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value, startIndex);
                    case "v3":
                        return ArrayHelper.Array_nextRule_indexOfBy_v3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.ICell)value, startIndex);
                    case "v5_p0":
                        return ArrayHelper.Array_nextRule_indexOfBy_v5_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "v6":
                        return ArrayHelper.Array_nextRule_indexOfBy_v6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value, startIndex);
                    case "v1_p0":
                        return ArrayHelper.Array_nextRule_indexOfBy_v1_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "v4":
                        return ArrayHelper.Array_nextRule_indexOfBy_v4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value, startIndex);
                    case "e0":
                        return ArrayHelper.Array_nextRule_indexOfBy_e0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value, startIndex);
                    case "c0":
                        return ArrayHelper.Array_nextRule_indexOfBy_c0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c1":
                        return ArrayHelper.Array_nextRule_indexOfBy_c1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c2":
                        return ArrayHelper.Array_nextRule_indexOfBy_c2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c3":
                        return ArrayHelper.Array_nextRule_indexOfBy_c3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c4":
                        return ArrayHelper.Array_nextRule_indexOfBy_c4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c5":
                        return ArrayHelper.Array_nextRule_indexOfBy_c5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "c6":
                        return ArrayHelper.Array_nextRule_indexOfBy_c6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c7":
                        return ArrayHelper.Array_nextRule_indexOfBy_c7(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "c8":
                        return ArrayHelper.Array_nextRule_indexOfBy_c8(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_nextRule_indexOfBy__edge0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    case "_edge1":
                        return ArrayHelper.Array_nextRule_indexOfBy__edge1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    default:
                        return -1;
                    }
                case "appendRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_appendRule_indexOfBy_v0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.ICell)value, startIndex);
                    case "r0":
                        return ArrayHelper.Array_appendRule_indexOfBy_r0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v4":
                        return ArrayHelper.Array_appendRule_indexOfBy_v4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value, startIndex);
                    case "r1":
                        return ArrayHelper.Array_appendRule_indexOfBy_r1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v1":
                        return ArrayHelper.Array_appendRule_indexOfBy_v1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value, startIndex);
                    case "v3":
                        return ArrayHelper.Array_appendRule_indexOfBy_v3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value, startIndex);
                    case "v4_p0":
                        return ArrayHelper.Array_appendRule_indexOfBy_v4_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "v5":
                        return ArrayHelper.Array_appendRule_indexOfBy_v5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value, startIndex);
                    case "v2":
                        return ArrayHelper.Array_appendRule_indexOfBy_v2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value, startIndex);
                    case "v2_p0":
                        return ArrayHelper.Array_appendRule_indexOfBy_v2_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "e0":
                        return ArrayHelper.Array_appendRule_indexOfBy_e0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value, startIndex);
                    case "c0":
                        return ArrayHelper.Array_appendRule_indexOfBy_c0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c1":
                        return ArrayHelper.Array_appendRule_indexOfBy_c1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c2":
                        return ArrayHelper.Array_appendRule_indexOfBy_c2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c3":
                        return ArrayHelper.Array_appendRule_indexOfBy_c3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c4":
                        return ArrayHelper.Array_appendRule_indexOfBy_c4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "c5":
                        return ArrayHelper.Array_appendRule_indexOfBy_c5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c6":
                        return ArrayHelper.Array_appendRule_indexOfBy_c6(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c7":
                        return ArrayHelper.Array_appendRule_indexOfBy_c7(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_appendRule_indexOfBy__edge0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    case "_edge1":
                        return ArrayHelper.Array_appendRule_indexOfBy__edge1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    default:
                        return -1;
                    }
                case "returnRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_returnRule_indexOfBy_v0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value, startIndex);
                    case "r0":
                        return ArrayHelper.Array_returnRule_indexOfBy_r0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v2":
                        return ArrayHelper.Array_returnRule_indexOfBy_v2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value, startIndex);
                    case "r1":
                        return ArrayHelper.Array_returnRule_indexOfBy_r1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v1":
                        return ArrayHelper.Array_returnRule_indexOfBy_v1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value, startIndex);
                    case "v2_p0":
                        return ArrayHelper.Array_returnRule_indexOfBy_v2_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "v3":
                        return ArrayHelper.Array_returnRule_indexOfBy_v3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IVoid)value, startIndex);
                    case "v1_p0":
                        return ArrayHelper.Array_returnRule_indexOfBy_v1_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "e0":
                        return ArrayHelper.Array_returnRule_indexOfBy_e0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value, startIndex);
                    case "c0":
                        return ArrayHelper.Array_returnRule_indexOfBy_c0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c1":
                        return ArrayHelper.Array_returnRule_indexOfBy_c1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c2":
                        return ArrayHelper.Array_returnRule_indexOfBy_c2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c3":
                        return ArrayHelper.Array_returnRule_indexOfBy_c3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "c4":
                        return ArrayHelper.Array_returnRule_indexOfBy_c4(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c5":
                        return ArrayHelper.Array_returnRule_indexOfBy_c5(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_returnRule_indexOfBy__edge0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    case "_edge1":
                        return ArrayHelper.Array_returnRule_indexOfBy__edge1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    default:
                        return -1;
                    }
                default:
                    return -1;
                }
            }
        }

        public override int ArrayLastIndexOfBy(IList array, string member, object value)
        {
            if(array.Count == 0)
                return -1;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return -1;
            if(array[0] == null)
                return -1;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return -1;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "nextRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value);
                    case "r0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_r0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v2":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Inext)value);
                    case "v5":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value);
                    case "r1":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_r1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v1":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value);
                    case "v3":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.ICell)value);
                    case "v5_p0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v5_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "v6":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value);
                    case "v1_p0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v1_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "v4":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value);
                    case "e0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_e0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value);
                    case "c0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c1":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c2":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c3":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c4":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c5":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "c6":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c7":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c7(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "c8":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c8(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "_edge0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    case "_edge1":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy__edge1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    default:
                        return -1;
                    }
                case "appendRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.ICell)value);
                    case "r0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_r0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v4":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value);
                    case "r1":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_r1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v1":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value);
                    case "v3":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value);
                    case "v4_p0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v4_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "v5":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value);
                    case "v2":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value);
                    case "v2_p0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v2_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "e0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_e0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value);
                    case "c0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c1":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c2":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c3":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c4":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "c5":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c6":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c6(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c7":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c7(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "_edge0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    case "_edge1":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy__edge1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    default:
                        return -1;
                    }
                case "returnRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value);
                    case "r0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_r0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v2":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value);
                    case "r1":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_r1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value);
                    case "v1":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value);
                    case "v2_p0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v2_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "v3":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IVoid)value);
                    case "v1_p0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v1_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value);
                    case "e0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_e0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value);
                    case "c0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c1":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c2":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c3":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "c4":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c4(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value);
                    case "c5":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c5(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value);
                    case "_edge0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    case "_edge1":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy__edge1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value);
                    default:
                        return -1;
                    }
                default:
                    return -1;
                }
            }
        }

        public override int ArrayLastIndexOfBy(IList array, string member, object value, int startIndex)
        {
            if(array.Count == 0)
                return -1;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return -1;
            if(array[0] == null)
                return -1;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return -1;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "nextRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value, startIndex);
                    case "r0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_r0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v2":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Inext)value, startIndex);
                    case "v5":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value, startIndex);
                    case "r1":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_r1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v1":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value, startIndex);
                    case "v3":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.ICell)value, startIndex);
                    case "v5_p0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v5_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "v6":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value, startIndex);
                    case "v1_p0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v1_p0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "v4":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_v4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value, startIndex);
                    case "e0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_e0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value, startIndex);
                    case "c0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c1":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c2":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c2(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c3":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c3(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c4":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c4(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c5":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c5(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "c6":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c6(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c7":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c7(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "c8":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy_c8(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    case "_edge1":
                        return ArrayHelper.Array_nextRule_lastIndexOfBy__edge1(GRGEN_ACTIONS.Rule_nextRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    default:
                        return -1;
                    }
                case "appendRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.ICell)value, startIndex);
                    case "r0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_r0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v4":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value, startIndex);
                    case "r1":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_r1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v1":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value, startIndex);
                    case "v3":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value, startIndex);
                    case "v4_p0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v4_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "v5":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ival)value, startIndex);
                    case "v2":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value, startIndex);
                    case "v2_p0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_v2_p0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "e0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_e0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value, startIndex);
                    case "c0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c1":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c2":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c2(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c3":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c3(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c4":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c4(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "c5":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c5(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c6":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c6(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c7":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy_c7(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    case "_edge1":
                        return ArrayHelper.Array_appendRule_lastIndexOfBy__edge1(GRGEN_ACTIONS.Rule_appendRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    default:
                        return -1;
                    }
                case "returnRule":
                    switch(member)
                    {
                    case "v0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.Ithis)value, startIndex);
                    case "r0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_r0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v2":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.Iappend)value, startIndex);
                    case "r1":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_r1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_LIBGR.INode)value, startIndex);
                    case "v1":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IthisRef)value, startIndex);
                    case "v2_p0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v2_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "v3":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IVoid)value, startIndex);
                    case "v1_p0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_v1_p0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBPort)value, startIndex);
                    case "e0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_e0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IBEdge)value, startIndex);
                    case "c0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c1":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c2":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c2(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c3":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c3(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "c4":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c4(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbPrnt)value, startIndex);
                    case "c5":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy_c5(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbNode)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    case "_edge1":
                        return ArrayHelper.Array_returnRule_lastIndexOfBy__edge1(GRGEN_ACTIONS.Rule_returnRule.ConvertAsNeeded(array), (GRGEN_MODEL.IbLink)value, startIndex);
                    default:
                        return -1;
                    }
                default:
                    return -1;
                }
            }
        }

        public override int ArrayIndexOfOrderedBy(IList array, string member, object value)
        {
            if(array.Count == 0)
                return -1;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return -1;
            if(array[0] == null)
                return -1;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return -1;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "nextRule":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "appendRule":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "returnRule":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                default:
                    return -1;
                }
            }
        }
        public override void FailAssertion() { Debug.Assert(false); }
        public override string ModelMD5Hash { get { return "e940e56c921e42e8d3acfd8fe92fc79b"; } }
    }
}