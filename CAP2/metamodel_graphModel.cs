// This file has been generated automatically by GrGen (www.grgen.net)
// Do not modify this file! Any changes will be lost!
// Generated from "./foo/ruleset.grg" on Wed May 28 21:58:35 CEST 2025

using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Diagnostics;
using GRGEN_LIBGR = de.unika.ipd.grGen.libGr;
using GRGEN_LGSP = de.unika.ipd.grGen.lgsp;
using GRGEN_EXPR = de.unika.ipd.grGen.expression;
using GRGEN_MODEL = de.unika.ipd.grGen.Model_metamodel_graph;

namespace de.unika.ipd.grGen.Model_metamodel_graph
{

	//
	// Enums
	//

	public class Enums
	{
	}

	//
	// Node types
	//

	public enum NodeTypes { @Node=0, @BPlace=1, @BPoint=2, @BLink=3, @BNode=4, @BRoot=5, @BSite=6, @BPort=7, @BInnerName=8, @BEdge=9, @BOuterName=10, @append=11, @main=12, @list=13, @this=14, @thisRef=15, @Cell=16, @Void=17, @val=18, @N1=19, @N2=20, @N3=21, @N4=22, @N5=23, @N6=24, @next=25 };

	// *** Node Node ***


	public sealed partial class @Node : GRGEN_LGSP.LGSPNode, GRGEN_LIBGR.INode
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Node[] pool;

		static @Node() {
		}

		public @Node() : base(GRGEN_MODEL.NodeType_Node.typeVar)
		{
			// implicit initialization, container creation of Node
		}

		public static GRGEN_MODEL.NodeType_Node TypeInstance { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Node(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Node(this, graph, oldToNewObjectMap);
		}

		private @Node(GRGEN_MODEL.@Node oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Node.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Node))
				return false;
			@Node that_ = (@Node)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Node CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Node node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Node();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Node[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Node
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Node CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Node node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Node();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Node[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Node
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Node[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Node\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Node\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Node
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Node does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Node does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Node : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Node typeVar = new GRGEN_MODEL.NodeType_Node();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Node() : base((int) NodeTypes.@Node)
		{
		}
		public override string Name { get { return "Node"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Node"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.libGr.INode"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Node"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Node();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@Node();
		}

	}

	// *** Node BPlace ***

	public interface IBPlace : GRGEN_LIBGR.INode
	{
	}

	public sealed partial class NodeType_BPlace : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BPlace typeVar = new GRGEN_MODEL.NodeType_BPlace();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, true, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_BPlace() : base((int) NodeTypes.@BPlace)
		{
		}
		public override string Name { get { return "BPlace"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "BPlace"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBPlace"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type BPlace cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type BPlace!");
		}
	}

	// *** Node BPoint ***

	public interface IBPoint : GRGEN_LIBGR.INode
	{
	}

	public sealed partial class NodeType_BPoint : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BPoint typeVar = new GRGEN_MODEL.NodeType_BPoint();
		public static bool[] isA = new bool[] { true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, true, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_BPoint() : base((int) NodeTypes.@BPoint)
		{
		}
		public override string Name { get { return "BPoint"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "BPoint"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBPoint"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type BPoint cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type BPoint!");
		}
	}

	// *** Node BLink ***

	public interface IBLink : GRGEN_LIBGR.INode
	{
	}

	public sealed partial class NodeType_BLink : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BLink typeVar = new GRGEN_MODEL.NodeType_BLink();
		public static bool[] isA = new bool[] { true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, true, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_BLink() : base((int) NodeTypes.@BLink)
		{
		}
		public override string Name { get { return "BLink"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "BLink"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBLink"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type BLink cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type BLink!");
		}
	}

	// *** Node BNode ***

	public interface IBNode : GRGEN_LIBGR.INode
	{
	}

	public sealed partial class NodeType_BNode : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BNode typeVar = new GRGEN_MODEL.NodeType_BNode();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, true, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_BNode() : base((int) NodeTypes.@BNode)
		{
		}
		public override string Name { get { return "BNode"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "BNode"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBNode"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type BNode cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type BNode!");
		}
	}

	// *** Node BRoot ***

	public interface IBRoot : IBPlace
	{
		int @ix { get; set; }
	}

	public sealed partial class @BRoot : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IBRoot
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@BRoot[] pool;

		// explicit initializations of BPlace for target BRoot
		// implicit initializations of BPlace for target BRoot
		// explicit initializations of BRoot for target BRoot
		// implicit initializations of BRoot for target BRoot
		static @BRoot() {
		}

		public @BRoot() : base(GRGEN_MODEL.NodeType_BRoot.typeVar)
		{
			// implicit initialization, container creation of BRoot
			// explicit initializations of BPlace for target BRoot
			// explicit initializations of BRoot for target BRoot
		}

		public static GRGEN_MODEL.NodeType_BRoot TypeInstance { get { return GRGEN_MODEL.NodeType_BRoot.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@BRoot(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@BRoot(this, graph, oldToNewObjectMap);
		}

		private @BRoot(GRGEN_MODEL.@BRoot oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_BRoot.typeVar)
		{
			ix_M0no_suXx_h4rD = oldElem.ix_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @BRoot))
				return false;
			@BRoot that_ = (@BRoot)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& ix_M0no_suXx_h4rD == that_.ix_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@BRoot CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@BRoot node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BRoot();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BRoot[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BRoot
				node.@ix = 0;
				// explicit initializations of BPlace for target BRoot
				// explicit initializations of BRoot for target BRoot
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@BRoot CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@BRoot node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BRoot();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BRoot[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BRoot
				node.@ix = 0;
				// explicit initializations of BPlace for target BRoot
				// explicit initializations of BRoot for target BRoot
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@BRoot[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private int ix_M0no_suXx_h4rD;
		public int @ix
		{
			get { return ix_M0no_suXx_h4rD; }
			set { ix_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "ix": return this.@ix;
			}
			throw new NullReferenceException(
				"The Node type \"BRoot\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "ix": this.@ix = (int) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"BRoot\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of BRoot
			this.@ix = 0;
			// explicit initializations of BPlace for target BRoot
			// explicit initializations of BRoot for target BRoot
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BRoot does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BRoot does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_BRoot : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BRoot typeVar = new GRGEN_MODEL.NodeType_BRoot();
		public static bool[] isA = new bool[] { true, true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public static GRGEN_LIBGR.AttributeType AttributeType_ix;
		public NodeType_BRoot() : base((int) NodeTypes.@BRoot)
		{
			AttributeType_ix = new GRGEN_LIBGR.AttributeType("ix", this, GRGEN_LIBGR.AttributeKind.IntegerAttr, null, null, null, null, null, null, typeof(int));
		}
		public override string Name { get { return "BRoot"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "BRoot"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBRoot"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@BRoot"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@BRoot();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_ix;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "ix" : return AttributeType_ix;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@BRoot newNode = new GRGEN_MODEL.@BRoot();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@BRoot:
					// copy attributes for: BRoot
					{
						GRGEN_MODEL.IBRoot old = (GRGEN_MODEL.IBRoot) oldNode;
						newNode.@ix = old.@ix;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_BRoot_ix : Comparer<GRGEN_MODEL.IBRoot>
	{
		public static Comparer_BRoot_ix thisComparer = new Comparer_BRoot_ix();
		public override int Compare(GRGEN_MODEL.IBRoot a, GRGEN_MODEL.IBRoot b)
		{
			return a.@ix.CompareTo(b.@ix);
		}
	}

	public class ReverseComparer_BRoot_ix : Comparer<GRGEN_MODEL.IBRoot>
	{
		public static ReverseComparer_BRoot_ix thisComparer = new ReverseComparer_BRoot_ix();
		public override int Compare(GRGEN_MODEL.IBRoot b, GRGEN_MODEL.IBRoot a)
		{
			return a.@ix.CompareTo(b.@ix);
		}
	}

	public class ArrayHelper_BRoot_ix
	{
		private static GRGEN_MODEL.IBRoot instanceBearingAttributeForSearch = new GRGEN_MODEL.@BRoot();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IBRoot> list, int entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IBRoot> list, int entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IBRoot> list, int entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IBRoot> list, int entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IBRoot> list, int entry)
		{
			instanceBearingAttributeForSearch.@ix = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_BRoot_ix.thisComparer);
		}
		public static List<GRGEN_MODEL.IBRoot> ArrayOrderAscendingBy(List<GRGEN_MODEL.IBRoot> list)
		{
			List<GRGEN_MODEL.IBRoot> newList = new List<GRGEN_MODEL.IBRoot>(list);
			newList.Sort(Comparer_BRoot_ix.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IBRoot> ArrayOrderDescendingBy(List<GRGEN_MODEL.IBRoot> list)
		{
			List<GRGEN_MODEL.IBRoot> newList = new List<GRGEN_MODEL.IBRoot>(list);
			newList.Sort(ReverseComparer_BRoot_ix.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IBRoot> ArrayGroupBy(List<GRGEN_MODEL.IBRoot> list)
		{
			Dictionary<int, List<GRGEN_MODEL.IBRoot>> seenValues = new Dictionary<int, List<GRGEN_MODEL.IBRoot>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@ix)) {
					seenValues[list[pos].@ix].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IBRoot> tempList = new List<GRGEN_MODEL.IBRoot>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@ix, tempList);
				}
			}
			List<GRGEN_MODEL.IBRoot> newList = new List<GRGEN_MODEL.IBRoot>();
			foreach(List<GRGEN_MODEL.IBRoot> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IBRoot> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IBRoot> list)
		{
			List<GRGEN_MODEL.IBRoot> newList = new List<GRGEN_MODEL.IBRoot>();
			Dictionary<int, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<int, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IBRoot element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@ix)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@ix, null);
				}
			}
			return newList;
		}
		public static List<int> Extract(List<GRGEN_MODEL.IBRoot> list)
		{
			List<int> resultList = new List<int>(list.Count);
			foreach(GRGEN_MODEL.IBRoot entry in list)
				resultList.Add(entry.@ix);
			return resultList;
		}
	}


	// *** Node BSite ***

	public interface IBSite : IBPlace
	{
		int @ix { get; set; }
	}

	public sealed partial class @BSite : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IBSite
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@BSite[] pool;

		// explicit initializations of BPlace for target BSite
		// implicit initializations of BPlace for target BSite
		// explicit initializations of BSite for target BSite
		// implicit initializations of BSite for target BSite
		static @BSite() {
		}

		public @BSite() : base(GRGEN_MODEL.NodeType_BSite.typeVar)
		{
			// implicit initialization, container creation of BSite
			// explicit initializations of BPlace for target BSite
			// explicit initializations of BSite for target BSite
		}

		public static GRGEN_MODEL.NodeType_BSite TypeInstance { get { return GRGEN_MODEL.NodeType_BSite.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@BSite(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@BSite(this, graph, oldToNewObjectMap);
		}

		private @BSite(GRGEN_MODEL.@BSite oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_BSite.typeVar)
		{
			ix_M0no_suXx_h4rD = oldElem.ix_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @BSite))
				return false;
			@BSite that_ = (@BSite)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& ix_M0no_suXx_h4rD == that_.ix_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@BSite CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@BSite node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BSite();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BSite[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BSite
				node.@ix = 0;
				// explicit initializations of BPlace for target BSite
				// explicit initializations of BSite for target BSite
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@BSite CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@BSite node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BSite();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BSite[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BSite
				node.@ix = 0;
				// explicit initializations of BPlace for target BSite
				// explicit initializations of BSite for target BSite
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@BSite[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private int ix_M0no_suXx_h4rD;
		public int @ix
		{
			get { return ix_M0no_suXx_h4rD; }
			set { ix_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "ix": return this.@ix;
			}
			throw new NullReferenceException(
				"The Node type \"BSite\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "ix": this.@ix = (int) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"BSite\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of BSite
			this.@ix = 0;
			// explicit initializations of BPlace for target BSite
			// explicit initializations of BSite for target BSite
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BSite does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BSite does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_BSite : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BSite typeVar = new GRGEN_MODEL.NodeType_BSite();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public static GRGEN_LIBGR.AttributeType AttributeType_ix;
		public NodeType_BSite() : base((int) NodeTypes.@BSite)
		{
			AttributeType_ix = new GRGEN_LIBGR.AttributeType("ix", this, GRGEN_LIBGR.AttributeKind.IntegerAttr, null, null, null, null, null, null, typeof(int));
		}
		public override string Name { get { return "BSite"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "BSite"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBSite"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@BSite"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@BSite();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_ix;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "ix" : return AttributeType_ix;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@BSite newNode = new GRGEN_MODEL.@BSite();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@BSite:
					// copy attributes for: BSite
					{
						GRGEN_MODEL.IBSite old = (GRGEN_MODEL.IBSite) oldNode;
						newNode.@ix = old.@ix;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_BSite_ix : Comparer<GRGEN_MODEL.IBSite>
	{
		public static Comparer_BSite_ix thisComparer = new Comparer_BSite_ix();
		public override int Compare(GRGEN_MODEL.IBSite a, GRGEN_MODEL.IBSite b)
		{
			return a.@ix.CompareTo(b.@ix);
		}
	}

	public class ReverseComparer_BSite_ix : Comparer<GRGEN_MODEL.IBSite>
	{
		public static ReverseComparer_BSite_ix thisComparer = new ReverseComparer_BSite_ix();
		public override int Compare(GRGEN_MODEL.IBSite b, GRGEN_MODEL.IBSite a)
		{
			return a.@ix.CompareTo(b.@ix);
		}
	}

	public class ArrayHelper_BSite_ix
	{
		private static GRGEN_MODEL.IBSite instanceBearingAttributeForSearch = new GRGEN_MODEL.@BSite();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IBSite> list, int entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IBSite> list, int entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IBSite> list, int entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IBSite> list, int entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IBSite> list, int entry)
		{
			instanceBearingAttributeForSearch.@ix = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_BSite_ix.thisComparer);
		}
		public static List<GRGEN_MODEL.IBSite> ArrayOrderAscendingBy(List<GRGEN_MODEL.IBSite> list)
		{
			List<GRGEN_MODEL.IBSite> newList = new List<GRGEN_MODEL.IBSite>(list);
			newList.Sort(Comparer_BSite_ix.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IBSite> ArrayOrderDescendingBy(List<GRGEN_MODEL.IBSite> list)
		{
			List<GRGEN_MODEL.IBSite> newList = new List<GRGEN_MODEL.IBSite>(list);
			newList.Sort(ReverseComparer_BSite_ix.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IBSite> ArrayGroupBy(List<GRGEN_MODEL.IBSite> list)
		{
			Dictionary<int, List<GRGEN_MODEL.IBSite>> seenValues = new Dictionary<int, List<GRGEN_MODEL.IBSite>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@ix)) {
					seenValues[list[pos].@ix].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IBSite> tempList = new List<GRGEN_MODEL.IBSite>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@ix, tempList);
				}
			}
			List<GRGEN_MODEL.IBSite> newList = new List<GRGEN_MODEL.IBSite>();
			foreach(List<GRGEN_MODEL.IBSite> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IBSite> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IBSite> list)
		{
			List<GRGEN_MODEL.IBSite> newList = new List<GRGEN_MODEL.IBSite>();
			Dictionary<int, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<int, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IBSite element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@ix)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@ix, null);
				}
			}
			return newList;
		}
		public static List<int> Extract(List<GRGEN_MODEL.IBSite> list)
		{
			List<int> resultList = new List<int>(list.Count);
			foreach(GRGEN_MODEL.IBSite entry in list)
				resultList.Add(entry.@ix);
			return resultList;
		}
	}


	// *** Node BPort ***

	public interface IBPort : IBPoint
	{
		int @ix { get; set; }
	}

	public sealed partial class @BPort : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IBPort
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@BPort[] pool;

		// explicit initializations of BPoint for target BPort
		// implicit initializations of BPoint for target BPort
		// explicit initializations of BPort for target BPort
		// implicit initializations of BPort for target BPort
		static @BPort() {
		}

		public @BPort() : base(GRGEN_MODEL.NodeType_BPort.typeVar)
		{
			// implicit initialization, container creation of BPort
			// explicit initializations of BPoint for target BPort
			// explicit initializations of BPort for target BPort
		}

		public static GRGEN_MODEL.NodeType_BPort TypeInstance { get { return GRGEN_MODEL.NodeType_BPort.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@BPort(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@BPort(this, graph, oldToNewObjectMap);
		}

		private @BPort(GRGEN_MODEL.@BPort oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_BPort.typeVar)
		{
			ix_M0no_suXx_h4rD = oldElem.ix_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @BPort))
				return false;
			@BPort that_ = (@BPort)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& ix_M0no_suXx_h4rD == that_.ix_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@BPort CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@BPort node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BPort();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BPort[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BPort
				node.@ix = 0;
				// explicit initializations of BPoint for target BPort
				// explicit initializations of BPort for target BPort
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@BPort CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@BPort node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BPort();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BPort[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BPort
				node.@ix = 0;
				// explicit initializations of BPoint for target BPort
				// explicit initializations of BPort for target BPort
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@BPort[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private int ix_M0no_suXx_h4rD;
		public int @ix
		{
			get { return ix_M0no_suXx_h4rD; }
			set { ix_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "ix": return this.@ix;
			}
			throw new NullReferenceException(
				"The Node type \"BPort\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "ix": this.@ix = (int) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"BPort\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of BPort
			this.@ix = 0;
			// explicit initializations of BPoint for target BPort
			// explicit initializations of BPort for target BPort
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BPort does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BPort does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_BPort : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BPort typeVar = new GRGEN_MODEL.NodeType_BPort();
		public static bool[] isA = new bool[] { true, false, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public static GRGEN_LIBGR.AttributeType AttributeType_ix;
		public NodeType_BPort() : base((int) NodeTypes.@BPort)
		{
			AttributeType_ix = new GRGEN_LIBGR.AttributeType("ix", this, GRGEN_LIBGR.AttributeKind.IntegerAttr, null, null, null, null, null, null, typeof(int));
		}
		public override string Name { get { return "BPort"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "BPort"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBPort"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@BPort"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@BPort();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_ix;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "ix" : return AttributeType_ix;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@BPort newNode = new GRGEN_MODEL.@BPort();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@BPort:
					// copy attributes for: BPort
					{
						GRGEN_MODEL.IBPort old = (GRGEN_MODEL.IBPort) oldNode;
						newNode.@ix = old.@ix;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_BPort_ix : Comparer<GRGEN_MODEL.IBPort>
	{
		public static Comparer_BPort_ix thisComparer = new Comparer_BPort_ix();
		public override int Compare(GRGEN_MODEL.IBPort a, GRGEN_MODEL.IBPort b)
		{
			return a.@ix.CompareTo(b.@ix);
		}
	}

	public class ReverseComparer_BPort_ix : Comparer<GRGEN_MODEL.IBPort>
	{
		public static ReverseComparer_BPort_ix thisComparer = new ReverseComparer_BPort_ix();
		public override int Compare(GRGEN_MODEL.IBPort b, GRGEN_MODEL.IBPort a)
		{
			return a.@ix.CompareTo(b.@ix);
		}
	}

	public class ArrayHelper_BPort_ix
	{
		private static GRGEN_MODEL.IBPort instanceBearingAttributeForSearch = new GRGEN_MODEL.@BPort();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IBPort> list, int entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IBPort> list, int entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IBPort> list, int entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IBPort> list, int entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@ix.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IBPort> list, int entry)
		{
			instanceBearingAttributeForSearch.@ix = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_BPort_ix.thisComparer);
		}
		public static List<GRGEN_MODEL.IBPort> ArrayOrderAscendingBy(List<GRGEN_MODEL.IBPort> list)
		{
			List<GRGEN_MODEL.IBPort> newList = new List<GRGEN_MODEL.IBPort>(list);
			newList.Sort(Comparer_BPort_ix.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IBPort> ArrayOrderDescendingBy(List<GRGEN_MODEL.IBPort> list)
		{
			List<GRGEN_MODEL.IBPort> newList = new List<GRGEN_MODEL.IBPort>(list);
			newList.Sort(ReverseComparer_BPort_ix.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IBPort> ArrayGroupBy(List<GRGEN_MODEL.IBPort> list)
		{
			Dictionary<int, List<GRGEN_MODEL.IBPort>> seenValues = new Dictionary<int, List<GRGEN_MODEL.IBPort>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@ix)) {
					seenValues[list[pos].@ix].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IBPort> tempList = new List<GRGEN_MODEL.IBPort>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@ix, tempList);
				}
			}
			List<GRGEN_MODEL.IBPort> newList = new List<GRGEN_MODEL.IBPort>();
			foreach(List<GRGEN_MODEL.IBPort> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IBPort> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IBPort> list)
		{
			List<GRGEN_MODEL.IBPort> newList = new List<GRGEN_MODEL.IBPort>();
			Dictionary<int, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<int, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IBPort element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@ix)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@ix, null);
				}
			}
			return newList;
		}
		public static List<int> Extract(List<GRGEN_MODEL.IBPort> list)
		{
			List<int> resultList = new List<int>(list.Count);
			foreach(GRGEN_MODEL.IBPort entry in list)
				resultList.Add(entry.@ix);
			return resultList;
		}
	}


	// *** Node BInnerName ***

	public interface IBInnerName : IBPoint
	{
	}

	public sealed partial class @BInnerName : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IBInnerName
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@BInnerName[] pool;

		// explicit initializations of BPoint for target BInnerName
		// implicit initializations of BPoint for target BInnerName
		// explicit initializations of BInnerName for target BInnerName
		// implicit initializations of BInnerName for target BInnerName
		static @BInnerName() {
		}

		public @BInnerName() : base(GRGEN_MODEL.NodeType_BInnerName.typeVar)
		{
			// implicit initialization, container creation of BInnerName
			// explicit initializations of BPoint for target BInnerName
			// explicit initializations of BInnerName for target BInnerName
		}

		public static GRGEN_MODEL.NodeType_BInnerName TypeInstance { get { return GRGEN_MODEL.NodeType_BInnerName.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@BInnerName(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@BInnerName(this, graph, oldToNewObjectMap);
		}

		private @BInnerName(GRGEN_MODEL.@BInnerName oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_BInnerName.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @BInnerName))
				return false;
			@BInnerName that_ = (@BInnerName)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@BInnerName CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@BInnerName node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BInnerName();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BInnerName[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BInnerName
				// explicit initializations of BPoint for target BInnerName
				// explicit initializations of BInnerName for target BInnerName
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@BInnerName CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@BInnerName node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BInnerName();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BInnerName[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BInnerName
				// explicit initializations of BPoint for target BInnerName
				// explicit initializations of BInnerName for target BInnerName
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@BInnerName[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"BInnerName\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"BInnerName\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of BInnerName
			// explicit initializations of BPoint for target BInnerName
			// explicit initializations of BInnerName for target BInnerName
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BInnerName does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BInnerName does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_BInnerName : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BInnerName typeVar = new GRGEN_MODEL.NodeType_BInnerName();
		public static bool[] isA = new bool[] { true, false, true, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_BInnerName() : base((int) NodeTypes.@BInnerName)
		{
		}
		public override string Name { get { return "BInnerName"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "BInnerName"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBInnerName"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@BInnerName"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@BInnerName();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@BInnerName();
		}

	}

	// *** Node BEdge ***

	public interface IBEdge : IBLink
	{
	}

	public sealed partial class @BEdge : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IBEdge
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@BEdge[] pool;

		// explicit initializations of BLink for target BEdge
		// implicit initializations of BLink for target BEdge
		// explicit initializations of BEdge for target BEdge
		// implicit initializations of BEdge for target BEdge
		static @BEdge() {
		}

		public @BEdge() : base(GRGEN_MODEL.NodeType_BEdge.typeVar)
		{
			// implicit initialization, container creation of BEdge
			// explicit initializations of BLink for target BEdge
			// explicit initializations of BEdge for target BEdge
		}

		public static GRGEN_MODEL.NodeType_BEdge TypeInstance { get { return GRGEN_MODEL.NodeType_BEdge.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@BEdge(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@BEdge(this, graph, oldToNewObjectMap);
		}

		private @BEdge(GRGEN_MODEL.@BEdge oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_BEdge.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @BEdge))
				return false;
			@BEdge that_ = (@BEdge)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@BEdge CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@BEdge node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BEdge();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BEdge[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BEdge
				// explicit initializations of BLink for target BEdge
				// explicit initializations of BEdge for target BEdge
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@BEdge CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@BEdge node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BEdge();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BEdge[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BEdge
				// explicit initializations of BLink for target BEdge
				// explicit initializations of BEdge for target BEdge
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@BEdge[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"BEdge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"BEdge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of BEdge
			// explicit initializations of BLink for target BEdge
			// explicit initializations of BEdge for target BEdge
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BEdge does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BEdge does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_BEdge : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BEdge typeVar = new GRGEN_MODEL.NodeType_BEdge();
		public static bool[] isA = new bool[] { true, false, false, true, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_BEdge() : base((int) NodeTypes.@BEdge)
		{
		}
		public override string Name { get { return "BEdge"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "BEdge"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBEdge"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@BEdge"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@BEdge();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@BEdge();
		}

	}

	// *** Node BOuterName ***

	public interface IBOuterName : IBLink
	{
	}

	public sealed partial class @BOuterName : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IBOuterName
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@BOuterName[] pool;

		// explicit initializations of BLink for target BOuterName
		// implicit initializations of BLink for target BOuterName
		// explicit initializations of BOuterName for target BOuterName
		// implicit initializations of BOuterName for target BOuterName
		static @BOuterName() {
		}

		public @BOuterName() : base(GRGEN_MODEL.NodeType_BOuterName.typeVar)
		{
			// implicit initialization, container creation of BOuterName
			// explicit initializations of BLink for target BOuterName
			// explicit initializations of BOuterName for target BOuterName
		}

		public static GRGEN_MODEL.NodeType_BOuterName TypeInstance { get { return GRGEN_MODEL.NodeType_BOuterName.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@BOuterName(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@BOuterName(this, graph, oldToNewObjectMap);
		}

		private @BOuterName(GRGEN_MODEL.@BOuterName oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_BOuterName.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @BOuterName))
				return false;
			@BOuterName that_ = (@BOuterName)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@BOuterName CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@BOuterName node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BOuterName();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BOuterName[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BOuterName
				// explicit initializations of BLink for target BOuterName
				// explicit initializations of BOuterName for target BOuterName
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@BOuterName CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@BOuterName node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BOuterName();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@BOuterName[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of BOuterName
				// explicit initializations of BLink for target BOuterName
				// explicit initializations of BOuterName for target BOuterName
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@BOuterName[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"BOuterName\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"BOuterName\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of BOuterName
			// explicit initializations of BLink for target BOuterName
			// explicit initializations of BOuterName for target BOuterName
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BOuterName does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("BOuterName does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_BOuterName : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BOuterName typeVar = new GRGEN_MODEL.NodeType_BOuterName();
		public static bool[] isA = new bool[] { true, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_BOuterName() : base((int) NodeTypes.@BOuterName)
		{
		}
		public override string Name { get { return "BOuterName"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "BOuterName"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBOuterName"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@BOuterName"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@BOuterName();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@BOuterName();
		}

	}

	// *** Node append ***

	public interface Iappend : IBNode
	{
	}

	public sealed partial class @append : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.Iappend
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@append[] pool;

		// explicit initializations of BNode for target append
		// implicit initializations of BNode for target append
		// explicit initializations of append for target append
		// implicit initializations of append for target append
		static @append() {
		}

		public @append() : base(GRGEN_MODEL.NodeType_append.typeVar)
		{
			// implicit initialization, container creation of append
			// explicit initializations of BNode for target append
			// explicit initializations of append for target append
		}

		public static GRGEN_MODEL.NodeType_append TypeInstance { get { return GRGEN_MODEL.NodeType_append.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@append(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@append(this, graph, oldToNewObjectMap);
		}

		private @append(GRGEN_MODEL.@append oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_append.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @append))
				return false;
			@append that_ = (@append)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@append CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@append node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@append();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@append[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of append
				// explicit initializations of BNode for target append
				// explicit initializations of append for target append
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@append CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@append node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@append();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@append[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of append
				// explicit initializations of BNode for target append
				// explicit initializations of append for target append
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@append[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"append\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"append\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of append
			// explicit initializations of BNode for target append
			// explicit initializations of append for target append
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("append does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("append does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_append : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_append typeVar = new GRGEN_MODEL.NodeType_append();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_append() : base((int) NodeTypes.@append)
		{
		}
		public override string Name { get { return "append"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "append"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.Iappend"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@append"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@append();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@append();
		}

	}

	// *** Node main ***

	public interface Imain : IBNode
	{
	}

	public sealed partial class @main : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.Imain
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@main[] pool;

		// explicit initializations of BNode for target main
		// implicit initializations of BNode for target main
		// explicit initializations of main for target main
		// implicit initializations of main for target main
		static @main() {
		}

		public @main() : base(GRGEN_MODEL.NodeType_main.typeVar)
		{
			// implicit initialization, container creation of main
			// explicit initializations of BNode for target main
			// explicit initializations of main for target main
		}

		public static GRGEN_MODEL.NodeType_main TypeInstance { get { return GRGEN_MODEL.NodeType_main.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@main(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@main(this, graph, oldToNewObjectMap);
		}

		private @main(GRGEN_MODEL.@main oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_main.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @main))
				return false;
			@main that_ = (@main)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@main CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@main node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@main();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@main[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of main
				// explicit initializations of BNode for target main
				// explicit initializations of main for target main
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@main CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@main node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@main();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@main[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of main
				// explicit initializations of BNode for target main
				// explicit initializations of main for target main
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@main[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"main\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"main\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of main
			// explicit initializations of BNode for target main
			// explicit initializations of main for target main
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("main does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("main does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_main : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_main typeVar = new GRGEN_MODEL.NodeType_main();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_main() : base((int) NodeTypes.@main)
		{
		}
		public override string Name { get { return "main"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "main"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.Imain"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@main"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@main();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@main();
		}

	}

	// *** Node list ***

	public interface Ilist : IBNode
	{
	}

	public sealed partial class @list : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.Ilist
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@list[] pool;

		// explicit initializations of BNode for target list
		// implicit initializations of BNode for target list
		// explicit initializations of list for target list
		// implicit initializations of list for target list
		static @list() {
		}

		public @list() : base(GRGEN_MODEL.NodeType_list.typeVar)
		{
			// implicit initialization, container creation of list
			// explicit initializations of BNode for target list
			// explicit initializations of list for target list
		}

		public static GRGEN_MODEL.NodeType_list TypeInstance { get { return GRGEN_MODEL.NodeType_list.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@list(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@list(this, graph, oldToNewObjectMap);
		}

		private @list(GRGEN_MODEL.@list oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_list.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @list))
				return false;
			@list that_ = (@list)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@list CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@list node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@list();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@list[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of list
				// explicit initializations of BNode for target list
				// explicit initializations of list for target list
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@list CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@list node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@list();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@list[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of list
				// explicit initializations of BNode for target list
				// explicit initializations of list for target list
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@list[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"list\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"list\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of list
			// explicit initializations of BNode for target list
			// explicit initializations of list for target list
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("list does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("list does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_list : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_list typeVar = new GRGEN_MODEL.NodeType_list();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_list() : base((int) NodeTypes.@list)
		{
		}
		public override string Name { get { return "list"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "list"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.Ilist"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@list"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@list();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@list();
		}

	}

	// *** Node this ***

	public interface Ithis : IBNode
	{
	}

	public sealed partial class @this : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.Ithis
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@this[] pool;

		// explicit initializations of BNode for target this
		// implicit initializations of BNode for target this
		// explicit initializations of this for target this
		// implicit initializations of this for target this
		static @this() {
		}

		public @this() : base(GRGEN_MODEL.NodeType_this.typeVar)
		{
			// implicit initialization, container creation of this
			// explicit initializations of BNode for target this
			// explicit initializations of this for target this
		}

		public static GRGEN_MODEL.NodeType_this TypeInstance { get { return GRGEN_MODEL.NodeType_this.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@this(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@this(this, graph, oldToNewObjectMap);
		}

		private @this(GRGEN_MODEL.@this oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_this.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @this))
				return false;
			@this that_ = (@this)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@this CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@this node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@this();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@this[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of this
				// explicit initializations of BNode for target this
				// explicit initializations of this for target this
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@this CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@this node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@this();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@this[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of this
				// explicit initializations of BNode for target this
				// explicit initializations of this for target this
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@this[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"this\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"this\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of this
			// explicit initializations of BNode for target this
			// explicit initializations of this for target this
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("this does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("this does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_this : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_this typeVar = new GRGEN_MODEL.NodeType_this();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_this() : base((int) NodeTypes.@this)
		{
		}
		public override string Name { get { return "this"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "this"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.Ithis"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@this"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@this();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@this();
		}

	}

	// *** Node thisRef ***

	public interface IthisRef : IBNode
	{
	}

	public sealed partial class @thisRef : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IthisRef
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@thisRef[] pool;

		// explicit initializations of BNode for target thisRef
		// implicit initializations of BNode for target thisRef
		// explicit initializations of thisRef for target thisRef
		// implicit initializations of thisRef for target thisRef
		static @thisRef() {
		}

		public @thisRef() : base(GRGEN_MODEL.NodeType_thisRef.typeVar)
		{
			// implicit initialization, container creation of thisRef
			// explicit initializations of BNode for target thisRef
			// explicit initializations of thisRef for target thisRef
		}

		public static GRGEN_MODEL.NodeType_thisRef TypeInstance { get { return GRGEN_MODEL.NodeType_thisRef.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@thisRef(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@thisRef(this, graph, oldToNewObjectMap);
		}

		private @thisRef(GRGEN_MODEL.@thisRef oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_thisRef.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @thisRef))
				return false;
			@thisRef that_ = (@thisRef)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@thisRef CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@thisRef node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@thisRef();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@thisRef[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of thisRef
				// explicit initializations of BNode for target thisRef
				// explicit initializations of thisRef for target thisRef
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@thisRef CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@thisRef node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@thisRef();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@thisRef[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of thisRef
				// explicit initializations of BNode for target thisRef
				// explicit initializations of thisRef for target thisRef
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@thisRef[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"thisRef\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"thisRef\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of thisRef
			// explicit initializations of BNode for target thisRef
			// explicit initializations of thisRef for target thisRef
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("thisRef does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("thisRef does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_thisRef : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_thisRef typeVar = new GRGEN_MODEL.NodeType_thisRef();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_thisRef() : base((int) NodeTypes.@thisRef)
		{
		}
		public override string Name { get { return "thisRef"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "thisRef"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IthisRef"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@thisRef"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@thisRef();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@thisRef();
		}

	}

	// *** Node Cell ***

	public interface ICell : IBNode
	{
	}

	public sealed partial class @Cell : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.ICell
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Cell[] pool;

		// explicit initializations of BNode for target Cell
		// implicit initializations of BNode for target Cell
		// explicit initializations of Cell for target Cell
		// implicit initializations of Cell for target Cell
		static @Cell() {
		}

		public @Cell() : base(GRGEN_MODEL.NodeType_Cell.typeVar)
		{
			// implicit initialization, container creation of Cell
			// explicit initializations of BNode for target Cell
			// explicit initializations of Cell for target Cell
		}

		public static GRGEN_MODEL.NodeType_Cell TypeInstance { get { return GRGEN_MODEL.NodeType_Cell.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Cell(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Cell(this, graph, oldToNewObjectMap);
		}

		private @Cell(GRGEN_MODEL.@Cell oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Cell.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Cell))
				return false;
			@Cell that_ = (@Cell)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Cell CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Cell node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Cell();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Cell[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Cell
				// explicit initializations of BNode for target Cell
				// explicit initializations of Cell for target Cell
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Cell CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Cell node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Cell();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Cell[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Cell
				// explicit initializations of BNode for target Cell
				// explicit initializations of Cell for target Cell
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Cell[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Cell\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Cell\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Cell
			// explicit initializations of BNode for target Cell
			// explicit initializations of Cell for target Cell
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Cell does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Cell does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Cell : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Cell typeVar = new GRGEN_MODEL.NodeType_Cell();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Cell() : base((int) NodeTypes.@Cell)
		{
		}
		public override string Name { get { return "Cell"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Cell"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.ICell"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Cell"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Cell();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@Cell();
		}

	}

	// *** Node Void ***

	public interface IVoid : IBNode
	{
	}

	public sealed partial class @Void : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IVoid
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Void[] pool;

		// explicit initializations of BNode for target Void
		// implicit initializations of BNode for target Void
		// explicit initializations of Void for target Void
		// implicit initializations of Void for target Void
		static @Void() {
		}

		public @Void() : base(GRGEN_MODEL.NodeType_Void.typeVar)
		{
			// implicit initialization, container creation of Void
			// explicit initializations of BNode for target Void
			// explicit initializations of Void for target Void
		}

		public static GRGEN_MODEL.NodeType_Void TypeInstance { get { return GRGEN_MODEL.NodeType_Void.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Void(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Void(this, graph, oldToNewObjectMap);
		}

		private @Void(GRGEN_MODEL.@Void oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Void.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Void))
				return false;
			@Void that_ = (@Void)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Void CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Void node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Void();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Void[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Void
				// explicit initializations of BNode for target Void
				// explicit initializations of Void for target Void
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Void CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Void node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Void();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Void[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Void
				// explicit initializations of BNode for target Void
				// explicit initializations of Void for target Void
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Void[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Void\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Void\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Void
			// explicit initializations of BNode for target Void
			// explicit initializations of Void for target Void
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Void does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Void does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Void : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Void typeVar = new GRGEN_MODEL.NodeType_Void();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Void() : base((int) NodeTypes.@Void)
		{
		}
		public override string Name { get { return "Void"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Void"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IVoid"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Void"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Void();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@Void();
		}

	}

	// *** Node val ***

	public interface Ival : IBNode
	{
	}

	public sealed partial class @val : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.Ival
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@val[] pool;

		// explicit initializations of BNode for target val
		// implicit initializations of BNode for target val
		// explicit initializations of val for target val
		// implicit initializations of val for target val
		static @val() {
		}

		public @val() : base(GRGEN_MODEL.NodeType_val.typeVar)
		{
			// implicit initialization, container creation of val
			// explicit initializations of BNode for target val
			// explicit initializations of val for target val
		}

		public static GRGEN_MODEL.NodeType_val TypeInstance { get { return GRGEN_MODEL.NodeType_val.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@val(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@val(this, graph, oldToNewObjectMap);
		}

		private @val(GRGEN_MODEL.@val oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_val.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @val))
				return false;
			@val that_ = (@val)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@val CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@val node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@val();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@val[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of val
				// explicit initializations of BNode for target val
				// explicit initializations of val for target val
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@val CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@val node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@val();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@val[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of val
				// explicit initializations of BNode for target val
				// explicit initializations of val for target val
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@val[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"val\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"val\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of val
			// explicit initializations of BNode for target val
			// explicit initializations of val for target val
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("val does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("val does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_val : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_val typeVar = new GRGEN_MODEL.NodeType_val();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_val() : base((int) NodeTypes.@val)
		{
		}
		public override string Name { get { return "val"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "val"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.Ival"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@val"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@val();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@val();
		}

	}

	// *** Node N1 ***

	public interface IN1 : IBNode
	{
	}

	public sealed partial class @N1 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN1
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N1[] pool;

		// explicit initializations of BNode for target N1
		// implicit initializations of BNode for target N1
		// explicit initializations of N1 for target N1
		// implicit initializations of N1 for target N1
		static @N1() {
		}

		public @N1() : base(GRGEN_MODEL.NodeType_N1.typeVar)
		{
			// implicit initialization, container creation of N1
			// explicit initializations of BNode for target N1
			// explicit initializations of N1 for target N1
		}

		public static GRGEN_MODEL.NodeType_N1 TypeInstance { get { return GRGEN_MODEL.NodeType_N1.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N1(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N1(this, graph, oldToNewObjectMap);
		}

		private @N1(GRGEN_MODEL.@N1 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N1.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @N1))
				return false;
			@N1 that_ = (@N1)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N1 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N1 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N1();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N1[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N1
				// explicit initializations of BNode for target N1
				// explicit initializations of N1 for target N1
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N1 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N1 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N1();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N1[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N1
				// explicit initializations of BNode for target N1
				// explicit initializations of N1 for target N1
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N1[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N1\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N1\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N1
			// explicit initializations of BNode for target N1
			// explicit initializations of N1 for target N1
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N1 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N1 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N1 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N1 typeVar = new GRGEN_MODEL.NodeType_N1();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N1() : base((int) NodeTypes.@N1)
		{
		}
		public override string Name { get { return "N1"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N1"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN1"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N1"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N1();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@N1();
		}

	}

	// *** Node N2 ***

	public interface IN2 : IBNode
	{
	}

	public sealed partial class @N2 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN2
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N2[] pool;

		// explicit initializations of BNode for target N2
		// implicit initializations of BNode for target N2
		// explicit initializations of N2 for target N2
		// implicit initializations of N2 for target N2
		static @N2() {
		}

		public @N2() : base(GRGEN_MODEL.NodeType_N2.typeVar)
		{
			// implicit initialization, container creation of N2
			// explicit initializations of BNode for target N2
			// explicit initializations of N2 for target N2
		}

		public static GRGEN_MODEL.NodeType_N2 TypeInstance { get { return GRGEN_MODEL.NodeType_N2.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N2(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N2(this, graph, oldToNewObjectMap);
		}

		private @N2(GRGEN_MODEL.@N2 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N2.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @N2))
				return false;
			@N2 that_ = (@N2)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N2 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N2 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N2();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N2[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N2
				// explicit initializations of BNode for target N2
				// explicit initializations of N2 for target N2
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N2 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N2 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N2();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N2[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N2
				// explicit initializations of BNode for target N2
				// explicit initializations of N2 for target N2
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N2[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N2\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N2\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N2
			// explicit initializations of BNode for target N2
			// explicit initializations of N2 for target N2
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N2 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N2 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N2 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N2 typeVar = new GRGEN_MODEL.NodeType_N2();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N2() : base((int) NodeTypes.@N2)
		{
		}
		public override string Name { get { return "N2"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N2"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN2"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N2"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N2();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@N2();
		}

	}

	// *** Node N3 ***

	public interface IN3 : IBNode
	{
	}

	public sealed partial class @N3 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN3
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N3[] pool;

		// explicit initializations of BNode for target N3
		// implicit initializations of BNode for target N3
		// explicit initializations of N3 for target N3
		// implicit initializations of N3 for target N3
		static @N3() {
		}

		public @N3() : base(GRGEN_MODEL.NodeType_N3.typeVar)
		{
			// implicit initialization, container creation of N3
			// explicit initializations of BNode for target N3
			// explicit initializations of N3 for target N3
		}

		public static GRGEN_MODEL.NodeType_N3 TypeInstance { get { return GRGEN_MODEL.NodeType_N3.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N3(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N3(this, graph, oldToNewObjectMap);
		}

		private @N3(GRGEN_MODEL.@N3 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N3.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @N3))
				return false;
			@N3 that_ = (@N3)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N3 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N3 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N3();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N3[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N3
				// explicit initializations of BNode for target N3
				// explicit initializations of N3 for target N3
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N3 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N3 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N3();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N3[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N3
				// explicit initializations of BNode for target N3
				// explicit initializations of N3 for target N3
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N3[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N3\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N3\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N3
			// explicit initializations of BNode for target N3
			// explicit initializations of N3 for target N3
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N3 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N3 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N3 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N3 typeVar = new GRGEN_MODEL.NodeType_N3();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N3() : base((int) NodeTypes.@N3)
		{
		}
		public override string Name { get { return "N3"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N3"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN3"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N3"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N3();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@N3();
		}

	}

	// *** Node N4 ***

	public interface IN4 : IBNode
	{
	}

	public sealed partial class @N4 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN4
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N4[] pool;

		// explicit initializations of BNode for target N4
		// implicit initializations of BNode for target N4
		// explicit initializations of N4 for target N4
		// implicit initializations of N4 for target N4
		static @N4() {
		}

		public @N4() : base(GRGEN_MODEL.NodeType_N4.typeVar)
		{
			// implicit initialization, container creation of N4
			// explicit initializations of BNode for target N4
			// explicit initializations of N4 for target N4
		}

		public static GRGEN_MODEL.NodeType_N4 TypeInstance { get { return GRGEN_MODEL.NodeType_N4.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N4(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N4(this, graph, oldToNewObjectMap);
		}

		private @N4(GRGEN_MODEL.@N4 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N4.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @N4))
				return false;
			@N4 that_ = (@N4)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N4 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N4 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N4();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N4[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N4
				// explicit initializations of BNode for target N4
				// explicit initializations of N4 for target N4
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N4 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N4 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N4();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N4[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N4
				// explicit initializations of BNode for target N4
				// explicit initializations of N4 for target N4
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N4[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N4\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N4\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N4
			// explicit initializations of BNode for target N4
			// explicit initializations of N4 for target N4
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N4 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N4 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N4 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N4 typeVar = new GRGEN_MODEL.NodeType_N4();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N4() : base((int) NodeTypes.@N4)
		{
		}
		public override string Name { get { return "N4"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N4"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN4"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N4"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N4();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@N4();
		}

	}

	// *** Node N5 ***

	public interface IN5 : IBNode
	{
	}

	public sealed partial class @N5 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN5
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N5[] pool;

		// explicit initializations of BNode for target N5
		// implicit initializations of BNode for target N5
		// explicit initializations of N5 for target N5
		// implicit initializations of N5 for target N5
		static @N5() {
		}

		public @N5() : base(GRGEN_MODEL.NodeType_N5.typeVar)
		{
			// implicit initialization, container creation of N5
			// explicit initializations of BNode for target N5
			// explicit initializations of N5 for target N5
		}

		public static GRGEN_MODEL.NodeType_N5 TypeInstance { get { return GRGEN_MODEL.NodeType_N5.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N5(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N5(this, graph, oldToNewObjectMap);
		}

		private @N5(GRGEN_MODEL.@N5 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N5.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @N5))
				return false;
			@N5 that_ = (@N5)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N5 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N5 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N5();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N5[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N5
				// explicit initializations of BNode for target N5
				// explicit initializations of N5 for target N5
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N5 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N5 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N5();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N5[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N5
				// explicit initializations of BNode for target N5
				// explicit initializations of N5 for target N5
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N5[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N5\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N5\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N5
			// explicit initializations of BNode for target N5
			// explicit initializations of N5 for target N5
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N5 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N5 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N5 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N5 typeVar = new GRGEN_MODEL.NodeType_N5();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N5() : base((int) NodeTypes.@N5)
		{
		}
		public override string Name { get { return "N5"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N5"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN5"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N5"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N5();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@N5();
		}

	}

	// *** Node N6 ***

	public interface IN6 : IBNode
	{
	}

	public sealed partial class @N6 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN6
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N6[] pool;

		// explicit initializations of BNode for target N6
		// implicit initializations of BNode for target N6
		// explicit initializations of N6 for target N6
		// implicit initializations of N6 for target N6
		static @N6() {
		}

		public @N6() : base(GRGEN_MODEL.NodeType_N6.typeVar)
		{
			// implicit initialization, container creation of N6
			// explicit initializations of BNode for target N6
			// explicit initializations of N6 for target N6
		}

		public static GRGEN_MODEL.NodeType_N6 TypeInstance { get { return GRGEN_MODEL.NodeType_N6.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N6(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N6(this, graph, oldToNewObjectMap);
		}

		private @N6(GRGEN_MODEL.@N6 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N6.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @N6))
				return false;
			@N6 that_ = (@N6)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N6 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N6 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N6();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N6[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N6
				// explicit initializations of BNode for target N6
				// explicit initializations of N6 for target N6
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N6 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N6 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N6();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N6[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N6
				// explicit initializations of BNode for target N6
				// explicit initializations of N6 for target N6
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N6[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N6\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N6\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N6
			// explicit initializations of BNode for target N6
			// explicit initializations of N6 for target N6
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N6 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N6 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N6 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N6 typeVar = new GRGEN_MODEL.NodeType_N6();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N6() : base((int) NodeTypes.@N6)
		{
		}
		public override string Name { get { return "N6"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N6"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN6"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N6"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N6();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@N6();
		}

	}

	// *** Node next ***

	public interface Inext : IBNode
	{
	}

	public sealed partial class @next : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.Inext
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@next[] pool;

		// explicit initializations of BNode for target next
		// implicit initializations of BNode for target next
		// explicit initializations of next for target next
		// implicit initializations of next for target next
		static @next() {
		}

		public @next() : base(GRGEN_MODEL.NodeType_next.typeVar)
		{
			// implicit initialization, container creation of next
			// explicit initializations of BNode for target next
			// explicit initializations of next for target next
		}

		public static GRGEN_MODEL.NodeType_next TypeInstance { get { return GRGEN_MODEL.NodeType_next.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@next(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@next(this, graph, oldToNewObjectMap);
		}

		private @next(GRGEN_MODEL.@next oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_next.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @next))
				return false;
			@next that_ = (@next)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@next CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@next node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@next();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@next[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of next
				// explicit initializations of BNode for target next
				// explicit initializations of next for target next
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@next CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@next node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@next();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@next[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of next
				// explicit initializations of BNode for target next
				// explicit initializations of next for target next
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@next[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"next\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"next\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of next
			// explicit initializations of BNode for target next
			// explicit initializations of next for target next
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("next does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("next does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_next : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_next typeVar = new GRGEN_MODEL.NodeType_next();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_next() : base((int) NodeTypes.@next)
		{
		}
		public override string Name { get { return "next"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "next"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.Inext"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@next"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@next();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@next();
		}

	}

	//
	// Edge types
	//

	public enum EdgeTypes { @AEdge=0, @Edge=1, @UEdge=2, @bPrnt=3, @bChild=4, @bNode=5, @bPorts=6, @bLink=7, @bPoints=8 };

	// *** Edge AEdge ***


	public sealed partial class EdgeType_AEdge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_AEdge typeVar = new GRGEN_MODEL.EdgeType_AEdge();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { true, true, true, true, true, true, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_AEdge() : base((int) EdgeTypes.@AEdge)
		{
		}
		public override string Name { get { return "AEdge"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "AEdge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IEdge"; } }
		public override string EdgeClassName { get { return null; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Arbitrary; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			throw new Exception("The abstract edge type AEdge cannot be instantiated!");
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			throw new Exception("The abstract edge type AEdge does not support source and target setting!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			throw new Exception("Cannot retype to the abstract type AEdge!");
		}
	}

	// *** Edge Edge ***


	public sealed partial class @Edge : GRGEN_LGSP.LGSPEdge, GRGEN_LIBGR.IDEdge
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Edge[] pool;

		static @Edge() {
		}

		public @Edge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Edge.typeVar, source, target)
		{
			// implicit initialization, container creation of Edge
		}

		public static GRGEN_MODEL.EdgeType_Edge TypeInstance { get { return GRGEN_MODEL.EdgeType_Edge.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@Edge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Edge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @Edge(GRGEN_MODEL.@Edge oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_Edge.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Edge))
				return false;
			@Edge that_ = (@Edge)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Edge CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Edge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Edge(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Edge[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of Edge
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Edge CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@Edge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Edge(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Edge[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of Edge
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Edge[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"Edge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"Edge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Edge
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Edge does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Edge does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_Edge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Edge typeVar = new GRGEN_MODEL.EdgeType_Edge();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, true, false, true, true, true, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_Edge() : base((int) EdgeTypes.@Edge)
		{
		}
		public override string Name { get { return "Edge"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Edge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IDEdge"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Edge"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Edge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@Edge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge UEdge ***


	public sealed partial class @UEdge : GRGEN_LGSP.LGSPEdge, GRGEN_LIBGR.IUEdge
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@UEdge[] pool;

		static @UEdge() {
		}

		public @UEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_UEdge.typeVar, source, target)
		{
			// implicit initialization, container creation of UEdge
		}

		public static GRGEN_MODEL.EdgeType_UEdge TypeInstance { get { return GRGEN_MODEL.EdgeType_UEdge.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@UEdge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@UEdge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @UEdge(GRGEN_MODEL.@UEdge oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_UEdge.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @UEdge))
				return false;
			@UEdge that_ = (@UEdge)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@UEdge CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@UEdge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@UEdge(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@UEdge[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of UEdge
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@UEdge CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@UEdge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@UEdge(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@UEdge[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of UEdge
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@UEdge[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"UEdge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"UEdge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of UEdge
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("UEdge does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("UEdge does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_UEdge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_UEdge typeVar = new GRGEN_MODEL.EdgeType_UEdge();
		public static bool[] isA = new bool[] { true, false, true, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, true, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_UEdge() : base((int) EdgeTypes.@UEdge)
		{
		}
		public override string Name { get { return "UEdge"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "UEdge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IUEdge"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@UEdge"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Undirected; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@UEdge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@UEdge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge bPrnt ***

	public interface IbPrnt : GRGEN_LIBGR.IDEdge
	{
	}

	public sealed partial class @bPrnt : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IbPrnt
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@bPrnt[] pool;

		// explicit initializations of bPrnt for target bPrnt
		// implicit initializations of bPrnt for target bPrnt
		static @bPrnt() {
		}

		public @bPrnt(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_bPrnt.typeVar, source, target)
		{
			// implicit initialization, container creation of bPrnt
			// explicit initializations of bPrnt for target bPrnt
		}

		public static GRGEN_MODEL.EdgeType_bPrnt TypeInstance { get { return GRGEN_MODEL.EdgeType_bPrnt.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@bPrnt(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@bPrnt(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @bPrnt(GRGEN_MODEL.@bPrnt oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_bPrnt.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @bPrnt))
				return false;
			@bPrnt that_ = (@bPrnt)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@bPrnt CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@bPrnt edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bPrnt(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bPrnt[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bPrnt
				// explicit initializations of bPrnt for target bPrnt
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@bPrnt CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@bPrnt edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bPrnt(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bPrnt[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bPrnt
				// explicit initializations of bPrnt for target bPrnt
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@bPrnt[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"bPrnt\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"bPrnt\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of bPrnt
			// explicit initializations of bPrnt for target bPrnt
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bPrnt does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bPrnt does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_bPrnt : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_bPrnt typeVar = new GRGEN_MODEL.EdgeType_bPrnt();
		public static bool[] isA = new bool[] { true, true, false, true, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, true, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_bPrnt() : base((int) EdgeTypes.@bPrnt)
		{
		}
		public override string Name { get { return "bPrnt"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "bPrnt"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IbPrnt"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@bPrnt"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@bPrnt((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@bPrnt((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge bChild ***

	public interface IbChild : GRGEN_LIBGR.IDEdge
	{
	}

	public sealed partial class @bChild : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IbChild
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@bChild[] pool;

		// explicit initializations of bChild for target bChild
		// implicit initializations of bChild for target bChild
		static @bChild() {
		}

		public @bChild(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_bChild.typeVar, source, target)
		{
			// implicit initialization, container creation of bChild
			// explicit initializations of bChild for target bChild
		}

		public static GRGEN_MODEL.EdgeType_bChild TypeInstance { get { return GRGEN_MODEL.EdgeType_bChild.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@bChild(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@bChild(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @bChild(GRGEN_MODEL.@bChild oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_bChild.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @bChild))
				return false;
			@bChild that_ = (@bChild)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@bChild CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@bChild edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bChild(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bChild[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bChild
				// explicit initializations of bChild for target bChild
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@bChild CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@bChild edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bChild(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bChild[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bChild
				// explicit initializations of bChild for target bChild
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@bChild[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"bChild\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"bChild\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of bChild
			// explicit initializations of bChild for target bChild
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bChild does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bChild does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_bChild : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_bChild typeVar = new GRGEN_MODEL.EdgeType_bChild();
		public static bool[] isA = new bool[] { true, true, false, false, true, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, true, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_bChild() : base((int) EdgeTypes.@bChild)
		{
		}
		public override string Name { get { return "bChild"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "bChild"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IbChild"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@bChild"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@bChild((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@bChild((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge bNode ***

	public interface IbNode : GRGEN_LIBGR.IDEdge
	{
	}

	public sealed partial class @bNode : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IbNode
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@bNode[] pool;

		// explicit initializations of bNode for target bNode
		// implicit initializations of bNode for target bNode
		static @bNode() {
		}

		public @bNode(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_bNode.typeVar, source, target)
		{
			// implicit initialization, container creation of bNode
			// explicit initializations of bNode for target bNode
		}

		public static GRGEN_MODEL.EdgeType_bNode TypeInstance { get { return GRGEN_MODEL.EdgeType_bNode.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@bNode(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@bNode(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @bNode(GRGEN_MODEL.@bNode oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_bNode.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @bNode))
				return false;
			@bNode that_ = (@bNode)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@bNode CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@bNode edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bNode(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bNode[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bNode
				// explicit initializations of bNode for target bNode
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@bNode CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@bNode edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bNode(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bNode[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bNode
				// explicit initializations of bNode for target bNode
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@bNode[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"bNode\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"bNode\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of bNode
			// explicit initializations of bNode for target bNode
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bNode does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bNode does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_bNode : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_bNode typeVar = new GRGEN_MODEL.EdgeType_bNode();
		public static bool[] isA = new bool[] { true, true, false, false, false, true, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, true, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_bNode() : base((int) EdgeTypes.@bNode)
		{
		}
		public override string Name { get { return "bNode"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "bNode"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IbNode"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@bNode"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@bNode((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@bNode((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge bPorts ***

	public interface IbPorts : GRGEN_LIBGR.IDEdge
	{
	}

	public sealed partial class @bPorts : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IbPorts
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@bPorts[] pool;

		// explicit initializations of bPorts for target bPorts
		// implicit initializations of bPorts for target bPorts
		static @bPorts() {
		}

		public @bPorts(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_bPorts.typeVar, source, target)
		{
			// implicit initialization, container creation of bPorts
			// explicit initializations of bPorts for target bPorts
		}

		public static GRGEN_MODEL.EdgeType_bPorts TypeInstance { get { return GRGEN_MODEL.EdgeType_bPorts.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@bPorts(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@bPorts(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @bPorts(GRGEN_MODEL.@bPorts oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_bPorts.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @bPorts))
				return false;
			@bPorts that_ = (@bPorts)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@bPorts CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@bPorts edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bPorts(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bPorts[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bPorts
				// explicit initializations of bPorts for target bPorts
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@bPorts CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@bPorts edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bPorts(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bPorts[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bPorts
				// explicit initializations of bPorts for target bPorts
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@bPorts[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"bPorts\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"bPorts\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of bPorts
			// explicit initializations of bPorts for target bPorts
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bPorts does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bPorts does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_bPorts : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_bPorts typeVar = new GRGEN_MODEL.EdgeType_bPorts();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, true, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, true, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_bPorts() : base((int) EdgeTypes.@bPorts)
		{
		}
		public override string Name { get { return "bPorts"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "bPorts"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IbPorts"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@bPorts"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@bPorts((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@bPorts((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge bLink ***

	public interface IbLink : GRGEN_LIBGR.IDEdge
	{
	}

	public sealed partial class @bLink : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IbLink
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@bLink[] pool;

		// explicit initializations of bLink for target bLink
		// implicit initializations of bLink for target bLink
		static @bLink() {
		}

		public @bLink(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_bLink.typeVar, source, target)
		{
			// implicit initialization, container creation of bLink
			// explicit initializations of bLink for target bLink
		}

		public static GRGEN_MODEL.EdgeType_bLink TypeInstance { get { return GRGEN_MODEL.EdgeType_bLink.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@bLink(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@bLink(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @bLink(GRGEN_MODEL.@bLink oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_bLink.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @bLink))
				return false;
			@bLink that_ = (@bLink)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@bLink CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@bLink edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bLink(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bLink[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bLink
				// explicit initializations of bLink for target bLink
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@bLink CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@bLink edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bLink(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bLink[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bLink
				// explicit initializations of bLink for target bLink
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@bLink[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"bLink\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"bLink\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of bLink
			// explicit initializations of bLink for target bLink
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bLink does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bLink does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_bLink : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_bLink typeVar = new GRGEN_MODEL.EdgeType_bLink();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, true, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, true, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_bLink() : base((int) EdgeTypes.@bLink)
		{
		}
		public override string Name { get { return "bLink"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "bLink"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IbLink"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@bLink"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@bLink((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@bLink((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge bPoints ***

	public interface IbPoints : GRGEN_LIBGR.IDEdge
	{
	}

	public sealed partial class @bPoints : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IbPoints
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@bPoints[] pool;

		// explicit initializations of bPoints for target bPoints
		// implicit initializations of bPoints for target bPoints
		static @bPoints() {
		}

		public @bPoints(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_bPoints.typeVar, source, target)
		{
			// implicit initialization, container creation of bPoints
			// explicit initializations of bPoints for target bPoints
		}

		public static GRGEN_MODEL.EdgeType_bPoints TypeInstance { get { return GRGEN_MODEL.EdgeType_bPoints.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@bPoints(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@bPoints(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @bPoints(GRGEN_MODEL.@bPoints oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_bPoints.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @bPoints))
				return false;
			@bPoints that_ = (@bPoints)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@bPoints CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@bPoints edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bPoints(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bPoints[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bPoints
				// explicit initializations of bPoints for target bPoints
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@bPoints CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@bPoints edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@bPoints(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@bPoints[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of bPoints
				// explicit initializations of bPoints for target bPoints
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@bPoints[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"bPoints\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"bPoints\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of bPoints
			// explicit initializations of bPoints for target bPoints
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bPoints does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("bPoints does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_bPoints : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_bPoints typeVar = new GRGEN_MODEL.EdgeType_bPoints();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, true, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_bPoints() : base((int) EdgeTypes.@bPoints)
		{
		}
		public override string Name { get { return "bPoints"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "bPoints"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IbPoints"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@bPoints"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@bPoints((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@bPoints((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	//
	// Object types
	//

	public enum ObjectTypes { @Object=0 };

	// *** Object Object ***


	public sealed partial class @Object : GRGEN_LGSP.LGSPObject, GRGEN_LIBGR.IObject
	{

		static @Object() {
		}

		//create object by CreateObject of the type class, not this internal-use constructor
		public @Object(long uniqueId) : base(GRGEN_MODEL.ObjectType_Object.typeVar, uniqueId)
		{
			// implicit initialization, container creation of Object
		}

		public static GRGEN_MODEL.ObjectType_Object TypeInstance { get { return GRGEN_MODEL.ObjectType_Object.typeVar; } }

		public override GRGEN_LIBGR.IObject Clone(GRGEN_LIBGR.IGraph graph) {
			GRGEN_MODEL.@Object newObject = new GRGEN_MODEL.@Object(this, graph, null);
			((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
			return newObject;
		}

		public override GRGEN_LIBGR.IObject Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			GRGEN_MODEL.@Object newObject = new GRGEN_MODEL.@Object(this, graph, oldToNewObjectMap);
			((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
			return newObject;
		}

		private @Object(GRGEN_MODEL.@Object oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.ObjectType_Object.typeVar, -1)
		{
			if(oldToNewObjectMap != null)
				oldToNewObjectMap.Add(oldElem, this);
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Object))
				return false;
			@Object that_ = (@Object)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Object type \"Object\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Object type \"Object\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Object
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Object does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Object does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class ObjectType_Object : GRGEN_LIBGR.ObjectType
	{
		public static GRGEN_MODEL.ObjectType_Object typeVar = new GRGEN_MODEL.ObjectType_Object();
		public static bool[] isA = new bool[] { true, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public ObjectType_Object() : base((int) ObjectTypes.@Object)
		{
		}
		public override string Name { get { return "Object"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Object"; } }
		public override string ObjectInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IObject"; } }
		public override string ObjectClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Object"; } }
		public override GRGEN_LIBGR.IObject CreateObject(GRGEN_LIBGR.IGraph graph, long uniqueId)
		{
			if(uniqueId != -1) {
				throw new Exception("The model of the object class type Object does not support uniqueIds!");
			} else {
				GRGEN_MODEL.@Object newObject = new GRGEN_MODEL.@Object(-1);
				((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
				return newObject;
			}
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
	}

	//
	// Transient object types
	//

	public enum TransientObjectTypes { @TransientObject=0 };

	// *** TransientObject TransientObject ***


	public sealed partial class @TransientObject : GRGEN_LGSP.LGSPTransientObject, GRGEN_LIBGR.ITransientObject
	{

		static @TransientObject() {
		}

		//create object by CreateTransientObject of the type class, not this internal-use constructor
		public @TransientObject() : base(GRGEN_MODEL.TransientObjectType_TransientObject.typeVar)
		{
			// implicit initialization, container creation of TransientObject
		}

		public static GRGEN_MODEL.TransientObjectType_TransientObject TypeInstance { get { return GRGEN_MODEL.TransientObjectType_TransientObject.typeVar; } }

		public override GRGEN_LIBGR.ITransientObject Clone() {
			return new GRGEN_MODEL.@TransientObject(this, null, null);
		}

		public override GRGEN_LIBGR.ITransientObject Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@TransientObject(this, graph, oldToNewObjectMap);
		}

		private @TransientObject(GRGEN_MODEL.@TransientObject oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.TransientObjectType_TransientObject.typeVar)
		{
			if(oldToNewObjectMap != null)
				oldToNewObjectMap.Add(oldElem, this);
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @TransientObject))
				return false;
			@TransientObject that_ = (@TransientObject)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The TransientObject type \"TransientObject\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The TransientObject type \"TransientObject\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of TransientObject
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("TransientObject does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("TransientObject does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class TransientObjectType_TransientObject : GRGEN_LIBGR.TransientObjectType
	{
		public static GRGEN_MODEL.TransientObjectType_TransientObject typeVar = new GRGEN_MODEL.TransientObjectType_TransientObject();
		public static bool[] isA = new bool[] { true, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public TransientObjectType_TransientObject() : base((int) TransientObjectTypes.@TransientObject)
		{
		}
		public override string Name { get { return "TransientObject"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "TransientObject"; } }
		public override string TransientObjectInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.ITransientObject"; } }
		public override string TransientObjectClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@TransientObject"; } }
		public override GRGEN_LIBGR.ITransientObject CreateTransientObject()
		{
			return new GRGEN_MODEL.@TransientObject();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
	}

	public sealed class ExternalObjectType_object : GRGEN_LIBGR.ExternalObjectType
	{
		public ExternalObjectType_object()
			: base("object", typeof(object))
		{
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }

		public static object ThrowCopyClassMissingException() { throw new Exception("Cannot copy/clone external object, copy class specification is missing in the model."); }
	}

	//
	// Indices
	//

	public class metamodel_graphIndexSet : GRGEN_LIBGR.IIndexSet
	{
		public metamodel_graphIndexSet(GRGEN_LGSP.LGSPGraph graph)
		{
		}


		public GRGEN_LIBGR.IIndex GetIndex(string indexName)
		{
			switch(indexName)
			{
				default: return null;
			}
		}

		public void FillAsClone(GRGEN_LGSP.LGSPGraph originalGraph, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
		{
		}
	}

	//
	// Node model
	//

	public sealed class metamodel_graphNodeModel : GRGEN_LIBGR.INodeModel
	{
		public metamodel_graphNodeModel()
		{
			GRGEN_MODEL.NodeType_Node.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BPlace.typeVar,
				GRGEN_MODEL.NodeType_BPoint.typeVar,
				GRGEN_MODEL.NodeType_BLink.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
				GRGEN_MODEL.NodeType_BRoot.typeVar,
				GRGEN_MODEL.NodeType_BSite.typeVar,
				GRGEN_MODEL.NodeType_BPort.typeVar,
				GRGEN_MODEL.NodeType_BInnerName.typeVar,
				GRGEN_MODEL.NodeType_BEdge.typeVar,
				GRGEN_MODEL.NodeType_BOuterName.typeVar,
				GRGEN_MODEL.NodeType_append.typeVar,
				GRGEN_MODEL.NodeType_main.typeVar,
				GRGEN_MODEL.NodeType_list.typeVar,
				GRGEN_MODEL.NodeType_this.typeVar,
				GRGEN_MODEL.NodeType_thisRef.typeVar,
				GRGEN_MODEL.NodeType_Cell.typeVar,
				GRGEN_MODEL.NodeType_Void.typeVar,
				GRGEN_MODEL.NodeType_val.typeVar,
				GRGEN_MODEL.NodeType_N1.typeVar,
				GRGEN_MODEL.NodeType_N2.typeVar,
				GRGEN_MODEL.NodeType_N3.typeVar,
				GRGEN_MODEL.NodeType_N4.typeVar,
				GRGEN_MODEL.NodeType_N5.typeVar,
				GRGEN_MODEL.NodeType_N6.typeVar,
				GRGEN_MODEL.NodeType_next.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPlace.typeVar,
				GRGEN_MODEL.NodeType_BPoint.typeVar,
				GRGEN_MODEL.NodeType_BLink.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_BPlace.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BPlace.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPlace.typeVar,
				GRGEN_MODEL.NodeType_BRoot.typeVar,
				GRGEN_MODEL.NodeType_BSite.typeVar,
			};
			GRGEN_MODEL.NodeType_BPlace.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BPlace.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BRoot.typeVar,
				GRGEN_MODEL.NodeType_BSite.typeVar,
			};
			GRGEN_MODEL.NodeType_BPlace.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BPlace.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPlace.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_BPlace.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BPlace.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_BPoint.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BPoint.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPoint.typeVar,
				GRGEN_MODEL.NodeType_BPort.typeVar,
				GRGEN_MODEL.NodeType_BInnerName.typeVar,
			};
			GRGEN_MODEL.NodeType_BPoint.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BPoint.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPort.typeVar,
				GRGEN_MODEL.NodeType_BInnerName.typeVar,
			};
			GRGEN_MODEL.NodeType_BPoint.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BPoint.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPoint.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_BPoint.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BPoint.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_BLink.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BLink.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BLink.typeVar,
				GRGEN_MODEL.NodeType_BEdge.typeVar,
				GRGEN_MODEL.NodeType_BOuterName.typeVar,
			};
			GRGEN_MODEL.NodeType_BLink.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BLink.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BEdge.typeVar,
				GRGEN_MODEL.NodeType_BOuterName.typeVar,
			};
			GRGEN_MODEL.NodeType_BLink.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BLink.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BLink.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_BLink.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BLink.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_BNode.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BNode.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
				GRGEN_MODEL.NodeType_append.typeVar,
				GRGEN_MODEL.NodeType_main.typeVar,
				GRGEN_MODEL.NodeType_list.typeVar,
				GRGEN_MODEL.NodeType_this.typeVar,
				GRGEN_MODEL.NodeType_thisRef.typeVar,
				GRGEN_MODEL.NodeType_Cell.typeVar,
				GRGEN_MODEL.NodeType_Void.typeVar,
				GRGEN_MODEL.NodeType_val.typeVar,
				GRGEN_MODEL.NodeType_N1.typeVar,
				GRGEN_MODEL.NodeType_N2.typeVar,
				GRGEN_MODEL.NodeType_N3.typeVar,
				GRGEN_MODEL.NodeType_N4.typeVar,
				GRGEN_MODEL.NodeType_N5.typeVar,
				GRGEN_MODEL.NodeType_N6.typeVar,
				GRGEN_MODEL.NodeType_next.typeVar,
			};
			GRGEN_MODEL.NodeType_BNode.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BNode.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_append.typeVar,
				GRGEN_MODEL.NodeType_main.typeVar,
				GRGEN_MODEL.NodeType_list.typeVar,
				GRGEN_MODEL.NodeType_this.typeVar,
				GRGEN_MODEL.NodeType_thisRef.typeVar,
				GRGEN_MODEL.NodeType_Cell.typeVar,
				GRGEN_MODEL.NodeType_Void.typeVar,
				GRGEN_MODEL.NodeType_val.typeVar,
				GRGEN_MODEL.NodeType_N1.typeVar,
				GRGEN_MODEL.NodeType_N2.typeVar,
				GRGEN_MODEL.NodeType_N3.typeVar,
				GRGEN_MODEL.NodeType_N4.typeVar,
				GRGEN_MODEL.NodeType_N5.typeVar,
				GRGEN_MODEL.NodeType_N6.typeVar,
				GRGEN_MODEL.NodeType_next.typeVar,
			};
			GRGEN_MODEL.NodeType_BNode.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BNode.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_BNode.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BNode.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_BRoot.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BRoot.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BRoot.typeVar,
			};
			GRGEN_MODEL.NodeType_BRoot.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BRoot.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_BRoot.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BRoot.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BRoot.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BPlace.typeVar,
			};
			GRGEN_MODEL.NodeType_BRoot.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BRoot.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPlace.typeVar,
			};
			GRGEN_MODEL.NodeType_BSite.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BSite.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BSite.typeVar,
			};
			GRGEN_MODEL.NodeType_BSite.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BSite.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_BSite.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BSite.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BSite.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BPlace.typeVar,
			};
			GRGEN_MODEL.NodeType_BSite.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BSite.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPlace.typeVar,
			};
			GRGEN_MODEL.NodeType_BPort.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BPort.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPort.typeVar,
			};
			GRGEN_MODEL.NodeType_BPort.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BPort.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_BPort.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BPort.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPort.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BPoint.typeVar,
			};
			GRGEN_MODEL.NodeType_BPort.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BPort.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPoint.typeVar,
			};
			GRGEN_MODEL.NodeType_BInnerName.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BInnerName.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BInnerName.typeVar,
			};
			GRGEN_MODEL.NodeType_BInnerName.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BInnerName.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_BInnerName.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BInnerName.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BInnerName.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BPoint.typeVar,
			};
			GRGEN_MODEL.NodeType_BInnerName.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BInnerName.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BPoint.typeVar,
			};
			GRGEN_MODEL.NodeType_BEdge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BEdge.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BEdge.typeVar,
			};
			GRGEN_MODEL.NodeType_BEdge.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BEdge.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_BEdge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BEdge.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BEdge.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BLink.typeVar,
			};
			GRGEN_MODEL.NodeType_BEdge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BEdge.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BLink.typeVar,
			};
			GRGEN_MODEL.NodeType_BOuterName.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BOuterName.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BOuterName.typeVar,
			};
			GRGEN_MODEL.NodeType_BOuterName.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BOuterName.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_BOuterName.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BOuterName.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BOuterName.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BLink.typeVar,
			};
			GRGEN_MODEL.NodeType_BOuterName.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BOuterName.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BLink.typeVar,
			};
			GRGEN_MODEL.NodeType_append.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_append.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_append.typeVar,
			};
			GRGEN_MODEL.NodeType_append.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_append.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_append.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_append.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_append.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_append.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_append.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_main.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_main.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_main.typeVar,
			};
			GRGEN_MODEL.NodeType_main.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_main.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_main.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_main.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_main.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_main.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_main.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_list.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_list.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_list.typeVar,
			};
			GRGEN_MODEL.NodeType_list.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_list.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_list.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_list.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_list.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_list.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_list.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_this.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_this.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_this.typeVar,
			};
			GRGEN_MODEL.NodeType_this.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_this.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_this.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_this.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_this.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_this.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_this.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_thisRef.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_thisRef.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_thisRef.typeVar,
			};
			GRGEN_MODEL.NodeType_thisRef.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_thisRef.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_thisRef.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_thisRef.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_thisRef.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_thisRef.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_thisRef.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Cell.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Cell.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Cell.typeVar,
			};
			GRGEN_MODEL.NodeType_Cell.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Cell.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Cell.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Cell.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Cell.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Cell.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Cell.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Void.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Void.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Void.typeVar,
			};
			GRGEN_MODEL.NodeType_Void.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Void.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Void.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Void.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Void.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Void.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Void.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_val.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_val.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_val.typeVar,
			};
			GRGEN_MODEL.NodeType_val.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_val.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_val.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_val.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_val.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_val.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_val.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N1.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N1.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N1.typeVar,
			};
			GRGEN_MODEL.NodeType_N1.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N1.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N1.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N1.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N1.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N1.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N1.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N2.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N2.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N2.typeVar,
			};
			GRGEN_MODEL.NodeType_N2.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N2.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N2.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N2.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N2.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N2.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N2.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N3.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N3.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N3.typeVar,
			};
			GRGEN_MODEL.NodeType_N3.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N3.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N3.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N3.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N3.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N3.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N3.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N4.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N4.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N4.typeVar,
			};
			GRGEN_MODEL.NodeType_N4.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N4.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N4.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N4.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N4.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N4.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N4.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N5.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N5.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N5.typeVar,
			};
			GRGEN_MODEL.NodeType_N5.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N5.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N5.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N5.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N5.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N5.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N5.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N6.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N6.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N6.typeVar,
			};
			GRGEN_MODEL.NodeType_N6.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N6.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N6.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N6.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N6.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N6.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N6.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_next.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_next.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_next.typeVar,
			};
			GRGEN_MODEL.NodeType_next.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_next.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_next.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_next.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_next.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_next.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_next.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
		}
		public bool IsNodeModel { get { return true; } }
		public GRGEN_LIBGR.NodeType RootType { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }
		GRGEN_LIBGR.GraphElementType GRGEN_LIBGR.IGraphElementTypeModel.RootType { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }
		public GRGEN_LIBGR.NodeType GetType(string name)
		{
			switch(name)
			{
				case "Node" : return GRGEN_MODEL.NodeType_Node.typeVar;
				case "BPlace" : return GRGEN_MODEL.NodeType_BPlace.typeVar;
				case "BPoint" : return GRGEN_MODEL.NodeType_BPoint.typeVar;
				case "BLink" : return GRGEN_MODEL.NodeType_BLink.typeVar;
				case "BNode" : return GRGEN_MODEL.NodeType_BNode.typeVar;
				case "BRoot" : return GRGEN_MODEL.NodeType_BRoot.typeVar;
				case "BSite" : return GRGEN_MODEL.NodeType_BSite.typeVar;
				case "BPort" : return GRGEN_MODEL.NodeType_BPort.typeVar;
				case "BInnerName" : return GRGEN_MODEL.NodeType_BInnerName.typeVar;
				case "BEdge" : return GRGEN_MODEL.NodeType_BEdge.typeVar;
				case "BOuterName" : return GRGEN_MODEL.NodeType_BOuterName.typeVar;
				case "append" : return GRGEN_MODEL.NodeType_append.typeVar;
				case "main" : return GRGEN_MODEL.NodeType_main.typeVar;
				case "list" : return GRGEN_MODEL.NodeType_list.typeVar;
				case "this" : return GRGEN_MODEL.NodeType_this.typeVar;
				case "thisRef" : return GRGEN_MODEL.NodeType_thisRef.typeVar;
				case "Cell" : return GRGEN_MODEL.NodeType_Cell.typeVar;
				case "Void" : return GRGEN_MODEL.NodeType_Void.typeVar;
				case "val" : return GRGEN_MODEL.NodeType_val.typeVar;
				case "N1" : return GRGEN_MODEL.NodeType_N1.typeVar;
				case "N2" : return GRGEN_MODEL.NodeType_N2.typeVar;
				case "N3" : return GRGEN_MODEL.NodeType_N3.typeVar;
				case "N4" : return GRGEN_MODEL.NodeType_N4.typeVar;
				case "N5" : return GRGEN_MODEL.NodeType_N5.typeVar;
				case "N6" : return GRGEN_MODEL.NodeType_N6.typeVar;
				case "next" : return GRGEN_MODEL.NodeType_next.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.GraphElementType GRGEN_LIBGR.IGraphElementTypeModel.GetType(string name)
		{
			return GetType(name);
		}
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.NodeType[] types = {
			GRGEN_MODEL.NodeType_Node.typeVar,
			GRGEN_MODEL.NodeType_BPlace.typeVar,
			GRGEN_MODEL.NodeType_BPoint.typeVar,
			GRGEN_MODEL.NodeType_BLink.typeVar,
			GRGEN_MODEL.NodeType_BNode.typeVar,
			GRGEN_MODEL.NodeType_BRoot.typeVar,
			GRGEN_MODEL.NodeType_BSite.typeVar,
			GRGEN_MODEL.NodeType_BPort.typeVar,
			GRGEN_MODEL.NodeType_BInnerName.typeVar,
			GRGEN_MODEL.NodeType_BEdge.typeVar,
			GRGEN_MODEL.NodeType_BOuterName.typeVar,
			GRGEN_MODEL.NodeType_append.typeVar,
			GRGEN_MODEL.NodeType_main.typeVar,
			GRGEN_MODEL.NodeType_list.typeVar,
			GRGEN_MODEL.NodeType_this.typeVar,
			GRGEN_MODEL.NodeType_thisRef.typeVar,
			GRGEN_MODEL.NodeType_Cell.typeVar,
			GRGEN_MODEL.NodeType_Void.typeVar,
			GRGEN_MODEL.NodeType_val.typeVar,
			GRGEN_MODEL.NodeType_N1.typeVar,
			GRGEN_MODEL.NodeType_N2.typeVar,
			GRGEN_MODEL.NodeType_N3.typeVar,
			GRGEN_MODEL.NodeType_N4.typeVar,
			GRGEN_MODEL.NodeType_N5.typeVar,
			GRGEN_MODEL.NodeType_N6.typeVar,
			GRGEN_MODEL.NodeType_next.typeVar,
		};
		public GRGEN_LIBGR.NodeType[] Types { get { return types; } }
		GRGEN_LIBGR.GraphElementType[] GRGEN_LIBGR.IGraphElementTypeModel.Types { get { return types; } }
		GRGEN_LIBGR.InheritanceType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private global::System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.NodeType_Node),
			typeof(GRGEN_MODEL.NodeType_BPlace),
			typeof(GRGEN_MODEL.NodeType_BPoint),
			typeof(GRGEN_MODEL.NodeType_BLink),
			typeof(GRGEN_MODEL.NodeType_BNode),
			typeof(GRGEN_MODEL.NodeType_BRoot),
			typeof(GRGEN_MODEL.NodeType_BSite),
			typeof(GRGEN_MODEL.NodeType_BPort),
			typeof(GRGEN_MODEL.NodeType_BInnerName),
			typeof(GRGEN_MODEL.NodeType_BEdge),
			typeof(GRGEN_MODEL.NodeType_BOuterName),
			typeof(GRGEN_MODEL.NodeType_append),
			typeof(GRGEN_MODEL.NodeType_main),
			typeof(GRGEN_MODEL.NodeType_list),
			typeof(GRGEN_MODEL.NodeType_this),
			typeof(GRGEN_MODEL.NodeType_thisRef),
			typeof(GRGEN_MODEL.NodeType_Cell),
			typeof(GRGEN_MODEL.NodeType_Void),
			typeof(GRGEN_MODEL.NodeType_val),
			typeof(GRGEN_MODEL.NodeType_N1),
			typeof(GRGEN_MODEL.NodeType_N2),
			typeof(GRGEN_MODEL.NodeType_N3),
			typeof(GRGEN_MODEL.NodeType_N4),
			typeof(GRGEN_MODEL.NodeType_N5),
			typeof(GRGEN_MODEL.NodeType_N6),
			typeof(GRGEN_MODEL.NodeType_next),
		};
		public global::System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
			GRGEN_MODEL.NodeType_BRoot.AttributeType_ix,
			GRGEN_MODEL.NodeType_BSite.AttributeType_ix,
			GRGEN_MODEL.NodeType_BPort.AttributeType_ix,
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// Edge model
	//

	public sealed class metamodel_graphEdgeModel : GRGEN_LIBGR.IEdgeModel
	{
		public metamodel_graphEdgeModel()
		{
			GRGEN_MODEL.EdgeType_AEdge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
				GRGEN_MODEL.EdgeType_bPrnt.typeVar,
				GRGEN_MODEL.EdgeType_bChild.typeVar,
				GRGEN_MODEL.EdgeType_bNode.typeVar,
				GRGEN_MODEL.EdgeType_bPorts.typeVar,
				GRGEN_MODEL.EdgeType_bLink.typeVar,
				GRGEN_MODEL.EdgeType_bPoints.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_bPrnt.typeVar,
				GRGEN_MODEL.EdgeType_bChild.typeVar,
				GRGEN_MODEL.EdgeType_bNode.typeVar,
				GRGEN_MODEL.EdgeType_bPorts.typeVar,
				GRGEN_MODEL.EdgeType_bLink.typeVar,
				GRGEN_MODEL.EdgeType_bPoints.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bPrnt.typeVar,
				GRGEN_MODEL.EdgeType_bChild.typeVar,
				GRGEN_MODEL.EdgeType_bNode.typeVar,
				GRGEN_MODEL.EdgeType_bPorts.typeVar,
				GRGEN_MODEL.EdgeType_bLink.typeVar,
				GRGEN_MODEL.EdgeType_bPoints.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bPrnt.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bPrnt.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bPrnt.typeVar,
			};
			GRGEN_MODEL.EdgeType_bPrnt.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_bPrnt.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_bPrnt.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bPrnt.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bPrnt.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bPrnt.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_bPrnt.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bChild.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bChild.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bChild.typeVar,
			};
			GRGEN_MODEL.EdgeType_bChild.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_bChild.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_bChild.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bChild.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bChild.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bChild.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_bChild.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bNode.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bNode.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bNode.typeVar,
			};
			GRGEN_MODEL.EdgeType_bNode.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_bNode.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_bNode.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bNode.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bNode.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bNode.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_bNode.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bPorts.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bPorts.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bPorts.typeVar,
			};
			GRGEN_MODEL.EdgeType_bPorts.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_bPorts.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_bPorts.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bPorts.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bPorts.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bPorts.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_bPorts.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bLink.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bLink.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bLink.typeVar,
			};
			GRGEN_MODEL.EdgeType_bLink.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_bLink.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_bLink.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bLink.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bLink.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bLink.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_bLink.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bPoints.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bPoints.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bPoints.typeVar,
			};
			GRGEN_MODEL.EdgeType_bPoints.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_bPoints.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_bPoints.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_bPoints.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_bPoints.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_bPoints.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_bPoints.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
		}
		public bool IsNodeModel { get { return false; } }
		public GRGEN_LIBGR.EdgeType RootType { get { return GRGEN_MODEL.EdgeType_AEdge.typeVar; } }
		GRGEN_LIBGR.GraphElementType GRGEN_LIBGR.IGraphElementTypeModel.RootType { get { return GRGEN_MODEL.EdgeType_AEdge.typeVar; } }
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.EdgeType_AEdge.typeVar; } }
		public GRGEN_LIBGR.EdgeType GetType(string name)
		{
			switch(name)
			{
				case "AEdge" : return GRGEN_MODEL.EdgeType_AEdge.typeVar;
				case "Edge" : return GRGEN_MODEL.EdgeType_Edge.typeVar;
				case "UEdge" : return GRGEN_MODEL.EdgeType_UEdge.typeVar;
				case "bPrnt" : return GRGEN_MODEL.EdgeType_bPrnt.typeVar;
				case "bChild" : return GRGEN_MODEL.EdgeType_bChild.typeVar;
				case "bNode" : return GRGEN_MODEL.EdgeType_bNode.typeVar;
				case "bPorts" : return GRGEN_MODEL.EdgeType_bPorts.typeVar;
				case "bLink" : return GRGEN_MODEL.EdgeType_bLink.typeVar;
				case "bPoints" : return GRGEN_MODEL.EdgeType_bPoints.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.GraphElementType GRGEN_LIBGR.IGraphElementTypeModel.GetType(string name)
		{
			return GetType(name);
		}
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.EdgeType[] types = {
			GRGEN_MODEL.EdgeType_AEdge.typeVar,
			GRGEN_MODEL.EdgeType_Edge.typeVar,
			GRGEN_MODEL.EdgeType_UEdge.typeVar,
			GRGEN_MODEL.EdgeType_bPrnt.typeVar,
			GRGEN_MODEL.EdgeType_bChild.typeVar,
			GRGEN_MODEL.EdgeType_bNode.typeVar,
			GRGEN_MODEL.EdgeType_bPorts.typeVar,
			GRGEN_MODEL.EdgeType_bLink.typeVar,
			GRGEN_MODEL.EdgeType_bPoints.typeVar,
		};
		public GRGEN_LIBGR.EdgeType[] Types { get { return types; } }
		GRGEN_LIBGR.GraphElementType[] GRGEN_LIBGR.IGraphElementTypeModel.Types { get { return types; } }
		GRGEN_LIBGR.InheritanceType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private global::System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.EdgeType_AEdge),
			typeof(GRGEN_MODEL.EdgeType_Edge),
			typeof(GRGEN_MODEL.EdgeType_UEdge),
			typeof(GRGEN_MODEL.EdgeType_bPrnt),
			typeof(GRGEN_MODEL.EdgeType_bChild),
			typeof(GRGEN_MODEL.EdgeType_bNode),
			typeof(GRGEN_MODEL.EdgeType_bPorts),
			typeof(GRGEN_MODEL.EdgeType_bLink),
			typeof(GRGEN_MODEL.EdgeType_bPoints),
		};
		public global::System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// Object model
	//

	public sealed class metamodel_graphObjectModel : GRGEN_LIBGR.IObjectModel
	{
		public metamodel_graphObjectModel()
		{
			GRGEN_MODEL.ObjectType_Object.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.ObjectType_Object.typeVar.subOrSameTypes = new GRGEN_LIBGR.ObjectType[] {
				GRGEN_MODEL.ObjectType_Object.typeVar,
			};
			GRGEN_MODEL.ObjectType_Object.typeVar.directSubGrGenTypes = GRGEN_MODEL.ObjectType_Object.typeVar.directSubTypes = new GRGEN_LIBGR.ObjectType[] {
			};
			GRGEN_MODEL.ObjectType_Object.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.ObjectType_Object.typeVar.superOrSameTypes = new GRGEN_LIBGR.ObjectType[] {
				GRGEN_MODEL.ObjectType_Object.typeVar,
			};
			GRGEN_MODEL.ObjectType_Object.typeVar.directSuperGrGenTypes = GRGEN_MODEL.ObjectType_Object.typeVar.directSuperTypes = new GRGEN_LIBGR.ObjectType[] {
			};
		}
		public bool IsTransientModel { get { return false; } }
		public GRGEN_LIBGR.ObjectType RootType { get { return GRGEN_MODEL.ObjectType_Object.typeVar; } }
		GRGEN_LIBGR.BaseObjectType GRGEN_LIBGR.IBaseObjectTypeModel.RootType { get { return GRGEN_MODEL.ObjectType_Object.typeVar; } }
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.ObjectType_Object.typeVar; } }
		public GRGEN_LIBGR.ObjectType GetType(string name)
		{
			switch(name)
			{
				case "Object" : return GRGEN_MODEL.ObjectType_Object.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.BaseObjectType GRGEN_LIBGR.IBaseObjectTypeModel.GetType(string name)
		{
			return GetType(name);
		}
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.ObjectType[] types = {
			GRGEN_MODEL.ObjectType_Object.typeVar,
		};
		public GRGEN_LIBGR.ObjectType[] Types { get { return types; } }
		GRGEN_LIBGR.BaseObjectType[] GRGEN_LIBGR.IBaseObjectTypeModel.Types { get { return types; } }
		GRGEN_LIBGR.InheritanceType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private global::System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.ObjectType_Object),
		};
		public global::System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// TransientObject model
	//

	public sealed class metamodel_graphTransientObjectModel : GRGEN_LIBGR.ITransientObjectModel
	{
		public metamodel_graphTransientObjectModel()
		{
			GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.subOrSameTypes = new GRGEN_LIBGR.TransientObjectType[] {
				GRGEN_MODEL.TransientObjectType_TransientObject.typeVar,
			};
			GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.directSubGrGenTypes = GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.directSubTypes = new GRGEN_LIBGR.TransientObjectType[] {
			};
			GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.superOrSameTypes = new GRGEN_LIBGR.TransientObjectType[] {
				GRGEN_MODEL.TransientObjectType_TransientObject.typeVar,
			};
			GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.directSuperGrGenTypes = GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.directSuperTypes = new GRGEN_LIBGR.TransientObjectType[] {
			};
		}
		public bool IsTransientModel { get { return true; } }
		public GRGEN_LIBGR.TransientObjectType RootType { get { return GRGEN_MODEL.TransientObjectType_TransientObject.typeVar; } }
		GRGEN_LIBGR.BaseObjectType GRGEN_LIBGR.IBaseObjectTypeModel.RootType { get { return GRGEN_MODEL.TransientObjectType_TransientObject.typeVar; } }
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.TransientObjectType_TransientObject.typeVar; } }
		public GRGEN_LIBGR.TransientObjectType GetType(string name)
		{
			switch(name)
			{
				case "TransientObject" : return GRGEN_MODEL.TransientObjectType_TransientObject.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.BaseObjectType GRGEN_LIBGR.IBaseObjectTypeModel.GetType(string name)
		{
			return GetType(name);
		}
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.TransientObjectType[] types = {
			GRGEN_MODEL.TransientObjectType_TransientObject.typeVar,
		};
		public GRGEN_LIBGR.TransientObjectType[] Types { get { return types; } }
		GRGEN_LIBGR.BaseObjectType[] GRGEN_LIBGR.IBaseObjectTypeModel.Types { get { return types; } }
		GRGEN_LIBGR.InheritanceType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private global::System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.TransientObjectType_TransientObject),
		};
		public global::System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// IGraphModel (LGSPGraphModel) implementation
	//
	public sealed class metamodel_graphGraphModel : GRGEN_LGSP.LGSPGraphModel
	{
		public metamodel_graphGraphModel()
		{
			FullyInitializeExternalObjectTypes();
		}

		private metamodel_graphNodeModel nodeModel = new metamodel_graphNodeModel();
		private metamodel_graphEdgeModel edgeModel = new metamodel_graphEdgeModel();
		private metamodel_graphObjectModel objectModel = new metamodel_graphObjectModel();
		private metamodel_graphTransientObjectModel transientObjectModel = new metamodel_graphTransientObjectModel();
		private string[] packages = {
		};
		private GRGEN_LIBGR.EnumAttributeType[] enumAttributeTypes = {
		};
		private GRGEN_LIBGR.ValidateInfo[] validateInfos = {
		};
		private static GRGEN_LIBGR.IndexDescription[] indexDescriptions = {
		};
		public override GRGEN_LIBGR.IUniquenessHandler CreateUniquenessHandler(GRGEN_LIBGR.IGraph graph) {
			return null;
		}
		public override GRGEN_LIBGR.IIndexSet CreateIndexSet(GRGEN_LIBGR.IGraph graph) {
			return new metamodel_graphIndexSet((GRGEN_LGSP.LGSPGraph)graph);
		}
		public override void FillIndexSetAsClone(GRGEN_LIBGR.IGraph graph, GRGEN_LIBGR.IGraph originalGraph, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) {
			((metamodel_graphIndexSet)graph.Indices).FillAsClone((GRGEN_LGSP.LGSPGraph)originalGraph, oldToNewMap);
		}

		public override string ModelName { get { return "metamodel_graph"; } }
		public override GRGEN_LIBGR.INodeModel NodeModel { get { return nodeModel; } }
		public override GRGEN_LIBGR.IEdgeModel EdgeModel { get { return edgeModel; } }
		public override GRGEN_LIBGR.IObjectModel ObjectModel { get { return objectModel; } }
		public override GRGEN_LIBGR.ITransientObjectModel TransientObjectModel { get { return transientObjectModel; } }
		public override IEnumerable<string> Packages { get { return packages; } }
		public override IEnumerable<GRGEN_LIBGR.EnumAttributeType> EnumAttributeTypes { get { return enumAttributeTypes; } }
		public override IEnumerable<GRGEN_LIBGR.ValidateInfo> ValidateInfo { get { return validateInfos; } }
		public override IEnumerable<GRGEN_LIBGR.IndexDescription> IndexDescriptions { get { return indexDescriptions; } }
		public static GRGEN_LIBGR.IndexDescription GetIndexDescription(int i) { return indexDescriptions[i]; }
		public static GRGEN_LIBGR.IndexDescription GetIndexDescription(string indexName)
 		{
			for(int i=0; i<indexDescriptions.Length; ++i)
				if(indexDescriptions[i].Name==indexName)
					return indexDescriptions[i];
			return null;
		}
		public override bool GraphElementsReferenceContainingGraph { get { return false; } }
		public override bool GraphElementUniquenessIsEnsured { get { return false; } }
		public override bool GraphElementUniquenessIsUserRequested { get { return false; } }
		public override bool ObjectUniquenessIsEnsured { get { return false; } }
		public override bool GraphElementsAreAccessibleByUniqueId { get { return false; } }
		public override bool AreFunctionsParallelized { get { return false; } }
		public override int BranchingFactorForEqualsAny { get { return 0; } }
		public override int ThreadPoolSizeForSequencesParallelExecution { get { return 0; } }

		public static GRGEN_LIBGR.ExternalObjectType externalObjectType_object = new ExternalObjectType_object();
		private GRGEN_LIBGR.ExternalObjectType[] externalObjectTypes = { externalObjectType_object };
		public override GRGEN_LIBGR.ExternalObjectType[] ExternalObjectTypes { get { return externalObjectTypes; } }

		private void FullyInitializeExternalObjectTypes()
		{
			externalObjectType_object.InitDirectSupertypes( new GRGEN_LIBGR.ExternalObjectType[] { } );
		}

		public override global::System.Collections.IList ArrayOrderAscendingBy(global::System.Collections.IList array, string member)
		{
			if(array.Count == 0)
				return array;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return null;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return null;
				}
			case "BPlace":
				switch(member)
				{
				default:
					return null;
				}
			case "BPoint":
				switch(member)
				{
				default:
					return null;
				}
			case "BLink":
				switch(member)
				{
				default:
					return null;
				}
			case "BNode":
				switch(member)
				{
				default:
					return null;
				}
			case "BRoot":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BRoot_ix.ArrayOrderAscendingBy((List<GRGEN_MODEL.IBRoot>)array);
				default:
					return null;
				}
			case "BSite":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BSite_ix.ArrayOrderAscendingBy((List<GRGEN_MODEL.IBSite>)array);
				default:
					return null;
				}
			case "BPort":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BPort_ix.ArrayOrderAscendingBy((List<GRGEN_MODEL.IBPort>)array);
				default:
					return null;
				}
			case "BInnerName":
				switch(member)
				{
				default:
					return null;
				}
			case "BEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "BOuterName":
				switch(member)
				{
				default:
					return null;
				}
			case "append":
				switch(member)
				{
				default:
					return null;
				}
			case "main":
				switch(member)
				{
				default:
					return null;
				}
			case "list":
				switch(member)
				{
				default:
					return null;
				}
			case "this":
				switch(member)
				{
				default:
					return null;
				}
			case "thisRef":
				switch(member)
				{
				default:
					return null;
				}
			case "Cell":
				switch(member)
				{
				default:
					return null;
				}
			case "Void":
				switch(member)
				{
				default:
					return null;
				}
			case "val":
				switch(member)
				{
				default:
					return null;
				}
			case "N1":
				switch(member)
				{
				default:
					return null;
				}
			case "N2":
				switch(member)
				{
				default:
					return null;
				}
			case "N3":
				switch(member)
				{
				default:
					return null;
				}
			case "N4":
				switch(member)
				{
				default:
					return null;
				}
			case "N5":
				switch(member)
				{
				default:
					return null;
				}
			case "N6":
				switch(member)
				{
				default:
					return null;
				}
			case "next":
				switch(member)
				{
				default:
					return null;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "Edge":
				switch(member)
				{
				default:
					return null;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "bPrnt":
				switch(member)
				{
				default:
					return null;
				}
			case "bChild":
				switch(member)
				{
				default:
					return null;
				}
			case "bNode":
				switch(member)
				{
				default:
					return null;
				}
			case "bPorts":
				switch(member)
				{
				default:
					return null;
				}
			case "bLink":
				switch(member)
				{
				default:
					return null;
				}
			case "bPoints":
				switch(member)
				{
				default:
					return null;
				}
			case "Object":
				switch(member)
				{
				default:
					return null;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return null;
				}
			default: return null;
			}
		}

		public override global::System.Collections.IList ArrayOrderDescendingBy(global::System.Collections.IList array, string member)
		{
			if(array.Count == 0)
				return array;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return null;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return null;
				}
			case "BPlace":
				switch(member)
				{
				default:
					return null;
				}
			case "BPoint":
				switch(member)
				{
				default:
					return null;
				}
			case "BLink":
				switch(member)
				{
				default:
					return null;
				}
			case "BNode":
				switch(member)
				{
				default:
					return null;
				}
			case "BRoot":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BRoot_ix.ArrayOrderDescendingBy((List<GRGEN_MODEL.IBRoot>)array);
				default:
					return null;
				}
			case "BSite":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BSite_ix.ArrayOrderDescendingBy((List<GRGEN_MODEL.IBSite>)array);
				default:
					return null;
				}
			case "BPort":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BPort_ix.ArrayOrderDescendingBy((List<GRGEN_MODEL.IBPort>)array);
				default:
					return null;
				}
			case "BInnerName":
				switch(member)
				{
				default:
					return null;
				}
			case "BEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "BOuterName":
				switch(member)
				{
				default:
					return null;
				}
			case "append":
				switch(member)
				{
				default:
					return null;
				}
			case "main":
				switch(member)
				{
				default:
					return null;
				}
			case "list":
				switch(member)
				{
				default:
					return null;
				}
			case "this":
				switch(member)
				{
				default:
					return null;
				}
			case "thisRef":
				switch(member)
				{
				default:
					return null;
				}
			case "Cell":
				switch(member)
				{
				default:
					return null;
				}
			case "Void":
				switch(member)
				{
				default:
					return null;
				}
			case "val":
				switch(member)
				{
				default:
					return null;
				}
			case "N1":
				switch(member)
				{
				default:
					return null;
				}
			case "N2":
				switch(member)
				{
				default:
					return null;
				}
			case "N3":
				switch(member)
				{
				default:
					return null;
				}
			case "N4":
				switch(member)
				{
				default:
					return null;
				}
			case "N5":
				switch(member)
				{
				default:
					return null;
				}
			case "N6":
				switch(member)
				{
				default:
					return null;
				}
			case "next":
				switch(member)
				{
				default:
					return null;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "Edge":
				switch(member)
				{
				default:
					return null;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "bPrnt":
				switch(member)
				{
				default:
					return null;
				}
			case "bChild":
				switch(member)
				{
				default:
					return null;
				}
			case "bNode":
				switch(member)
				{
				default:
					return null;
				}
			case "bPorts":
				switch(member)
				{
				default:
					return null;
				}
			case "bLink":
				switch(member)
				{
				default:
					return null;
				}
			case "bPoints":
				switch(member)
				{
				default:
					return null;
				}
			case "Object":
				switch(member)
				{
				default:
					return null;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return null;
				}
			default: return null;
			}
		}

		public override global::System.Collections.IList ArrayGroupBy(global::System.Collections.IList array, string member)
		{
			if(array.Count == 0)
				return array;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return null;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return null;
				}
			case "BPlace":
				switch(member)
				{
				default:
					return null;
				}
			case "BPoint":
				switch(member)
				{
				default:
					return null;
				}
			case "BLink":
				switch(member)
				{
				default:
					return null;
				}
			case "BNode":
				switch(member)
				{
				default:
					return null;
				}
			case "BRoot":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BRoot_ix.ArrayGroupBy((List<GRGEN_MODEL.IBRoot>)array);
				default:
					return null;
				}
			case "BSite":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BSite_ix.ArrayGroupBy((List<GRGEN_MODEL.IBSite>)array);
				default:
					return null;
				}
			case "BPort":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BPort_ix.ArrayGroupBy((List<GRGEN_MODEL.IBPort>)array);
				default:
					return null;
				}
			case "BInnerName":
				switch(member)
				{
				default:
					return null;
				}
			case "BEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "BOuterName":
				switch(member)
				{
				default:
					return null;
				}
			case "append":
				switch(member)
				{
				default:
					return null;
				}
			case "main":
				switch(member)
				{
				default:
					return null;
				}
			case "list":
				switch(member)
				{
				default:
					return null;
				}
			case "this":
				switch(member)
				{
				default:
					return null;
				}
			case "thisRef":
				switch(member)
				{
				default:
					return null;
				}
			case "Cell":
				switch(member)
				{
				default:
					return null;
				}
			case "Void":
				switch(member)
				{
				default:
					return null;
				}
			case "val":
				switch(member)
				{
				default:
					return null;
				}
			case "N1":
				switch(member)
				{
				default:
					return null;
				}
			case "N2":
				switch(member)
				{
				default:
					return null;
				}
			case "N3":
				switch(member)
				{
				default:
					return null;
				}
			case "N4":
				switch(member)
				{
				default:
					return null;
				}
			case "N5":
				switch(member)
				{
				default:
					return null;
				}
			case "N6":
				switch(member)
				{
				default:
					return null;
				}
			case "next":
				switch(member)
				{
				default:
					return null;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "Edge":
				switch(member)
				{
				default:
					return null;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "bPrnt":
				switch(member)
				{
				default:
					return null;
				}
			case "bChild":
				switch(member)
				{
				default:
					return null;
				}
			case "bNode":
				switch(member)
				{
				default:
					return null;
				}
			case "bPorts":
				switch(member)
				{
				default:
					return null;
				}
			case "bLink":
				switch(member)
				{
				default:
					return null;
				}
			case "bPoints":
				switch(member)
				{
				default:
					return null;
				}
			case "Object":
				switch(member)
				{
				default:
					return null;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return null;
				}
			default: return null;
			}
		}

		public override global::System.Collections.IList ArrayKeepOneForEach(global::System.Collections.IList array, string member)
		{
			if(array.Count == 0)
				return array;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return null;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return null;
				}
			case "BPlace":
				switch(member)
				{
				default:
					return null;
				}
			case "BPoint":
				switch(member)
				{
				default:
					return null;
				}
			case "BLink":
				switch(member)
				{
				default:
					return null;
				}
			case "BNode":
				switch(member)
				{
				default:
					return null;
				}
			case "BRoot":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BRoot_ix.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IBRoot>)array);
				default:
					return null;
				}
			case "BSite":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BSite_ix.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IBSite>)array);
				default:
					return null;
				}
			case "BPort":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BPort_ix.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IBPort>)array);
				default:
					return null;
				}
			case "BInnerName":
				switch(member)
				{
				default:
					return null;
				}
			case "BEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "BOuterName":
				switch(member)
				{
				default:
					return null;
				}
			case "append":
				switch(member)
				{
				default:
					return null;
				}
			case "main":
				switch(member)
				{
				default:
					return null;
				}
			case "list":
				switch(member)
				{
				default:
					return null;
				}
			case "this":
				switch(member)
				{
				default:
					return null;
				}
			case "thisRef":
				switch(member)
				{
				default:
					return null;
				}
			case "Cell":
				switch(member)
				{
				default:
					return null;
				}
			case "Void":
				switch(member)
				{
				default:
					return null;
				}
			case "val":
				switch(member)
				{
				default:
					return null;
				}
			case "N1":
				switch(member)
				{
				default:
					return null;
				}
			case "N2":
				switch(member)
				{
				default:
					return null;
				}
			case "N3":
				switch(member)
				{
				default:
					return null;
				}
			case "N4":
				switch(member)
				{
				default:
					return null;
				}
			case "N5":
				switch(member)
				{
				default:
					return null;
				}
			case "N6":
				switch(member)
				{
				default:
					return null;
				}
			case "next":
				switch(member)
				{
				default:
					return null;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "Edge":
				switch(member)
				{
				default:
					return null;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "bPrnt":
				switch(member)
				{
				default:
					return null;
				}
			case "bChild":
				switch(member)
				{
				default:
					return null;
				}
			case "bNode":
				switch(member)
				{
				default:
					return null;
				}
			case "bPorts":
				switch(member)
				{
				default:
					return null;
				}
			case "bLink":
				switch(member)
				{
				default:
					return null;
				}
			case "bPoints":
				switch(member)
				{
				default:
					return null;
				}
			case "Object":
				switch(member)
				{
				default:
					return null;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return null;
				}
			default: return null;
			}
		}

		public override int ArrayIndexOfBy(global::System.Collections.IList array, string member, object value)
		{
			if(array.Count == 0)
				return -1;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return -1;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return -1;
				}
			case "BPlace":
				switch(member)
				{
				default:
					return -1;
				}
			case "BPoint":
				switch(member)
				{
				default:
					return -1;
				}
			case "BLink":
				switch(member)
				{
				default:
					return -1;
				}
			case "BNode":
				switch(member)
				{
				default:
					return -1;
				}
			case "BRoot":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BRoot_ix.ArrayIndexOfBy((List<GRGEN_MODEL.IBRoot>)array, (int)value);
				default:
					return -1;
				}
			case "BSite":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BSite_ix.ArrayIndexOfBy((List<GRGEN_MODEL.IBSite>)array, (int)value);
				default:
					return -1;
				}
			case "BPort":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BPort_ix.ArrayIndexOfBy((List<GRGEN_MODEL.IBPort>)array, (int)value);
				default:
					return -1;
				}
			case "BInnerName":
				switch(member)
				{
				default:
					return -1;
				}
			case "BEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "BOuterName":
				switch(member)
				{
				default:
					return -1;
				}
			case "append":
				switch(member)
				{
				default:
					return -1;
				}
			case "main":
				switch(member)
				{
				default:
					return -1;
				}
			case "list":
				switch(member)
				{
				default:
					return -1;
				}
			case "this":
				switch(member)
				{
				default:
					return -1;
				}
			case "thisRef":
				switch(member)
				{
				default:
					return -1;
				}
			case "Cell":
				switch(member)
				{
				default:
					return -1;
				}
			case "Void":
				switch(member)
				{
				default:
					return -1;
				}
			case "val":
				switch(member)
				{
				default:
					return -1;
				}
			case "N1":
				switch(member)
				{
				default:
					return -1;
				}
			case "N2":
				switch(member)
				{
				default:
					return -1;
				}
			case "N3":
				switch(member)
				{
				default:
					return -1;
				}
			case "N4":
				switch(member)
				{
				default:
					return -1;
				}
			case "N5":
				switch(member)
				{
				default:
					return -1;
				}
			case "N6":
				switch(member)
				{
				default:
					return -1;
				}
			case "next":
				switch(member)
				{
				default:
					return -1;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "Edge":
				switch(member)
				{
				default:
					return -1;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPrnt":
				switch(member)
				{
				default:
					return -1;
				}
			case "bChild":
				switch(member)
				{
				default:
					return -1;
				}
			case "bNode":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPorts":
				switch(member)
				{
				default:
					return -1;
				}
			case "bLink":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPoints":
				switch(member)
				{
				default:
					return -1;
				}
			case "Object":
				switch(member)
				{
				default:
					return -1;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return -1;
				}
			default: return -1;
			}
		}

		public override int ArrayIndexOfBy(global::System.Collections.IList array, string member, object value, int startIndex)
		{
			if(array.Count == 0)
				return -1;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return -1;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return -1;
				}
			case "BPlace":
				switch(member)
				{
				default:
					return -1;
				}
			case "BPoint":
				switch(member)
				{
				default:
					return -1;
				}
			case "BLink":
				switch(member)
				{
				default:
					return -1;
				}
			case "BNode":
				switch(member)
				{
				default:
					return -1;
				}
			case "BRoot":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BRoot_ix.ArrayIndexOfBy((List<GRGEN_MODEL.IBRoot>)array, (int)value, startIndex);
				default:
					return -1;
				}
			case "BSite":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BSite_ix.ArrayIndexOfBy((List<GRGEN_MODEL.IBSite>)array, (int)value, startIndex);
				default:
					return -1;
				}
			case "BPort":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BPort_ix.ArrayIndexOfBy((List<GRGEN_MODEL.IBPort>)array, (int)value, startIndex);
				default:
					return -1;
				}
			case "BInnerName":
				switch(member)
				{
				default:
					return -1;
				}
			case "BEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "BOuterName":
				switch(member)
				{
				default:
					return -1;
				}
			case "append":
				switch(member)
				{
				default:
					return -1;
				}
			case "main":
				switch(member)
				{
				default:
					return -1;
				}
			case "list":
				switch(member)
				{
				default:
					return -1;
				}
			case "this":
				switch(member)
				{
				default:
					return -1;
				}
			case "thisRef":
				switch(member)
				{
				default:
					return -1;
				}
			case "Cell":
				switch(member)
				{
				default:
					return -1;
				}
			case "Void":
				switch(member)
				{
				default:
					return -1;
				}
			case "val":
				switch(member)
				{
				default:
					return -1;
				}
			case "N1":
				switch(member)
				{
				default:
					return -1;
				}
			case "N2":
				switch(member)
				{
				default:
					return -1;
				}
			case "N3":
				switch(member)
				{
				default:
					return -1;
				}
			case "N4":
				switch(member)
				{
				default:
					return -1;
				}
			case "N5":
				switch(member)
				{
				default:
					return -1;
				}
			case "N6":
				switch(member)
				{
				default:
					return -1;
				}
			case "next":
				switch(member)
				{
				default:
					return -1;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "Edge":
				switch(member)
				{
				default:
					return -1;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPrnt":
				switch(member)
				{
				default:
					return -1;
				}
			case "bChild":
				switch(member)
				{
				default:
					return -1;
				}
			case "bNode":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPorts":
				switch(member)
				{
				default:
					return -1;
				}
			case "bLink":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPoints":
				switch(member)
				{
				default:
					return -1;
				}
			case "Object":
				switch(member)
				{
				default:
					return -1;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return -1;
				}
			default: return -1;
			}
		}

		public override int ArrayLastIndexOfBy(global::System.Collections.IList array, string member, object value)
		{
			if(array.Count == 0)
				return -1;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return -1;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return -1;
				}
			case "BPlace":
				switch(member)
				{
				default:
					return -1;
				}
			case "BPoint":
				switch(member)
				{
				default:
					return -1;
				}
			case "BLink":
				switch(member)
				{
				default:
					return -1;
				}
			case "BNode":
				switch(member)
				{
				default:
					return -1;
				}
			case "BRoot":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BRoot_ix.ArrayLastIndexOfBy((List<GRGEN_MODEL.IBRoot>)array, (int)value);
				default:
					return -1;
				}
			case "BSite":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BSite_ix.ArrayLastIndexOfBy((List<GRGEN_MODEL.IBSite>)array, (int)value);
				default:
					return -1;
				}
			case "BPort":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BPort_ix.ArrayLastIndexOfBy((List<GRGEN_MODEL.IBPort>)array, (int)value);
				default:
					return -1;
				}
			case "BInnerName":
				switch(member)
				{
				default:
					return -1;
				}
			case "BEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "BOuterName":
				switch(member)
				{
				default:
					return -1;
				}
			case "append":
				switch(member)
				{
				default:
					return -1;
				}
			case "main":
				switch(member)
				{
				default:
					return -1;
				}
			case "list":
				switch(member)
				{
				default:
					return -1;
				}
			case "this":
				switch(member)
				{
				default:
					return -1;
				}
			case "thisRef":
				switch(member)
				{
				default:
					return -1;
				}
			case "Cell":
				switch(member)
				{
				default:
					return -1;
				}
			case "Void":
				switch(member)
				{
				default:
					return -1;
				}
			case "val":
				switch(member)
				{
				default:
					return -1;
				}
			case "N1":
				switch(member)
				{
				default:
					return -1;
				}
			case "N2":
				switch(member)
				{
				default:
					return -1;
				}
			case "N3":
				switch(member)
				{
				default:
					return -1;
				}
			case "N4":
				switch(member)
				{
				default:
					return -1;
				}
			case "N5":
				switch(member)
				{
				default:
					return -1;
				}
			case "N6":
				switch(member)
				{
				default:
					return -1;
				}
			case "next":
				switch(member)
				{
				default:
					return -1;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "Edge":
				switch(member)
				{
				default:
					return -1;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPrnt":
				switch(member)
				{
				default:
					return -1;
				}
			case "bChild":
				switch(member)
				{
				default:
					return -1;
				}
			case "bNode":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPorts":
				switch(member)
				{
				default:
					return -1;
				}
			case "bLink":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPoints":
				switch(member)
				{
				default:
					return -1;
				}
			case "Object":
				switch(member)
				{
				default:
					return -1;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return -1;
				}
			default: return -1;
			}
		}

		public override int ArrayLastIndexOfBy(global::System.Collections.IList array, string member, object value, int startIndex)
		{
			if(array.Count == 0)
				return -1;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return -1;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return -1;
				}
			case "BPlace":
				switch(member)
				{
				default:
					return -1;
				}
			case "BPoint":
				switch(member)
				{
				default:
					return -1;
				}
			case "BLink":
				switch(member)
				{
				default:
					return -1;
				}
			case "BNode":
				switch(member)
				{
				default:
					return -1;
				}
			case "BRoot":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BRoot_ix.ArrayLastIndexOfBy((List<GRGEN_MODEL.IBRoot>)array, (int)value, startIndex);
				default:
					return -1;
				}
			case "BSite":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BSite_ix.ArrayLastIndexOfBy((List<GRGEN_MODEL.IBSite>)array, (int)value, startIndex);
				default:
					return -1;
				}
			case "BPort":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BPort_ix.ArrayLastIndexOfBy((List<GRGEN_MODEL.IBPort>)array, (int)value, startIndex);
				default:
					return -1;
				}
			case "BInnerName":
				switch(member)
				{
				default:
					return -1;
				}
			case "BEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "BOuterName":
				switch(member)
				{
				default:
					return -1;
				}
			case "append":
				switch(member)
				{
				default:
					return -1;
				}
			case "main":
				switch(member)
				{
				default:
					return -1;
				}
			case "list":
				switch(member)
				{
				default:
					return -1;
				}
			case "this":
				switch(member)
				{
				default:
					return -1;
				}
			case "thisRef":
				switch(member)
				{
				default:
					return -1;
				}
			case "Cell":
				switch(member)
				{
				default:
					return -1;
				}
			case "Void":
				switch(member)
				{
				default:
					return -1;
				}
			case "val":
				switch(member)
				{
				default:
					return -1;
				}
			case "N1":
				switch(member)
				{
				default:
					return -1;
				}
			case "N2":
				switch(member)
				{
				default:
					return -1;
				}
			case "N3":
				switch(member)
				{
				default:
					return -1;
				}
			case "N4":
				switch(member)
				{
				default:
					return -1;
				}
			case "N5":
				switch(member)
				{
				default:
					return -1;
				}
			case "N6":
				switch(member)
				{
				default:
					return -1;
				}
			case "next":
				switch(member)
				{
				default:
					return -1;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "Edge":
				switch(member)
				{
				default:
					return -1;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPrnt":
				switch(member)
				{
				default:
					return -1;
				}
			case "bChild":
				switch(member)
				{
				default:
					return -1;
				}
			case "bNode":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPorts":
				switch(member)
				{
				default:
					return -1;
				}
			case "bLink":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPoints":
				switch(member)
				{
				default:
					return -1;
				}
			case "Object":
				switch(member)
				{
				default:
					return -1;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return -1;
				}
			default: return -1;
			}
		}

		public override int ArrayIndexOfOrderedBy(global::System.Collections.IList array, string member, object value)
		{
			if(array.Count == 0)
				return -1;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return -1;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return -1;
				}
			case "BPlace":
				switch(member)
				{
				default:
					return -1;
				}
			case "BPoint":
				switch(member)
				{
				default:
					return -1;
				}
			case "BLink":
				switch(member)
				{
				default:
					return -1;
				}
			case "BNode":
				switch(member)
				{
				default:
					return -1;
				}
			case "BRoot":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BRoot_ix.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IBRoot>)array, (int)value);
				default:
					return -1;
				}
			case "BSite":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BSite_ix.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IBSite>)array, (int)value);
				default:
					return -1;
				}
			case "BPort":
				switch(member)
				{
				case "ix":
					return ArrayHelper_BPort_ix.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IBPort>)array, (int)value);
				default:
					return -1;
				}
			case "BInnerName":
				switch(member)
				{
				default:
					return -1;
				}
			case "BEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "BOuterName":
				switch(member)
				{
				default:
					return -1;
				}
			case "append":
				switch(member)
				{
				default:
					return -1;
				}
			case "main":
				switch(member)
				{
				default:
					return -1;
				}
			case "list":
				switch(member)
				{
				default:
					return -1;
				}
			case "this":
				switch(member)
				{
				default:
					return -1;
				}
			case "thisRef":
				switch(member)
				{
				default:
					return -1;
				}
			case "Cell":
				switch(member)
				{
				default:
					return -1;
				}
			case "Void":
				switch(member)
				{
				default:
					return -1;
				}
			case "val":
				switch(member)
				{
				default:
					return -1;
				}
			case "N1":
				switch(member)
				{
				default:
					return -1;
				}
			case "N2":
				switch(member)
				{
				default:
					return -1;
				}
			case "N3":
				switch(member)
				{
				default:
					return -1;
				}
			case "N4":
				switch(member)
				{
				default:
					return -1;
				}
			case "N5":
				switch(member)
				{
				default:
					return -1;
				}
			case "N6":
				switch(member)
				{
				default:
					return -1;
				}
			case "next":
				switch(member)
				{
				default:
					return -1;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "Edge":
				switch(member)
				{
				default:
					return -1;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPrnt":
				switch(member)
				{
				default:
					return -1;
				}
			case "bChild":
				switch(member)
				{
				default:
					return -1;
				}
			case "bNode":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPorts":
				switch(member)
				{
				default:
					return -1;
				}
			case "bLink":
				switch(member)
				{
				default:
					return -1;
				}
			case "bPoints":
				switch(member)
				{
				default:
					return -1;
				}
			case "Object":
				switch(member)
				{
				default:
					return -1;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return -1;
				}
			default: return -1;
			}
		}


		public override void FailAssertion() { Debug.Assert(false); }
		public override string MD5Hash { get { return "e940e56c921e42e8d3acfd8fe92fc79b"; } }
	}

	//
	// IGraph (LGSPGraph) implementation
	//
	public class metamodel_graphGraph : GRGEN_LGSP.LGSPGraph
	{
		public metamodel_graphGraph(GRGEN_LGSP.LGSPGlobalVariables globalVariables) : base(new metamodel_graphGraphModel(), globalVariables, GetGraphName())
		{
		}

		public GRGEN_MODEL.@Node CreateNodeNode()
		{
			return GRGEN_MODEL.@Node.CreateNode(this);
		}

		public GRGEN_MODEL.@BRoot CreateNodeBRoot()
		{
			return GRGEN_MODEL.@BRoot.CreateNode(this);
		}

		public GRGEN_MODEL.@BSite CreateNodeBSite()
		{
			return GRGEN_MODEL.@BSite.CreateNode(this);
		}

		public GRGEN_MODEL.@BPort CreateNodeBPort()
		{
			return GRGEN_MODEL.@BPort.CreateNode(this);
		}

		public GRGEN_MODEL.@BInnerName CreateNodeBInnerName()
		{
			return GRGEN_MODEL.@BInnerName.CreateNode(this);
		}

		public GRGEN_MODEL.@BEdge CreateNodeBEdge()
		{
			return GRGEN_MODEL.@BEdge.CreateNode(this);
		}

		public GRGEN_MODEL.@BOuterName CreateNodeBOuterName()
		{
			return GRGEN_MODEL.@BOuterName.CreateNode(this);
		}

		public GRGEN_MODEL.@append CreateNodeappend()
		{
			return GRGEN_MODEL.@append.CreateNode(this);
		}

		public GRGEN_MODEL.@main CreateNodemain()
		{
			return GRGEN_MODEL.@main.CreateNode(this);
		}

		public GRGEN_MODEL.@list CreateNodelist()
		{
			return GRGEN_MODEL.@list.CreateNode(this);
		}

		public GRGEN_MODEL.@this CreateNodethis()
		{
			return GRGEN_MODEL.@this.CreateNode(this);
		}

		public GRGEN_MODEL.@thisRef CreateNodethisRef()
		{
			return GRGEN_MODEL.@thisRef.CreateNode(this);
		}

		public GRGEN_MODEL.@Cell CreateNodeCell()
		{
			return GRGEN_MODEL.@Cell.CreateNode(this);
		}

		public GRGEN_MODEL.@Void CreateNodeVoid()
		{
			return GRGEN_MODEL.@Void.CreateNode(this);
		}

		public GRGEN_MODEL.@val CreateNodeval()
		{
			return GRGEN_MODEL.@val.CreateNode(this);
		}

		public GRGEN_MODEL.@N1 CreateNodeN1()
		{
			return GRGEN_MODEL.@N1.CreateNode(this);
		}

		public GRGEN_MODEL.@N2 CreateNodeN2()
		{
			return GRGEN_MODEL.@N2.CreateNode(this);
		}

		public GRGEN_MODEL.@N3 CreateNodeN3()
		{
			return GRGEN_MODEL.@N3.CreateNode(this);
		}

		public GRGEN_MODEL.@N4 CreateNodeN4()
		{
			return GRGEN_MODEL.@N4.CreateNode(this);
		}

		public GRGEN_MODEL.@N5 CreateNodeN5()
		{
			return GRGEN_MODEL.@N5.CreateNode(this);
		}

		public GRGEN_MODEL.@N6 CreateNodeN6()
		{
			return GRGEN_MODEL.@N6.CreateNode(this);
		}

		public GRGEN_MODEL.@next CreateNodenext()
		{
			return GRGEN_MODEL.@next.CreateNode(this);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bPrnt CreateEdgebPrnt(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bPrnt.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bChild CreateEdgebChild(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bChild.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bNode CreateEdgebNode(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bNode.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bPorts CreateEdgebPorts(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bPorts.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bLink CreateEdgebLink(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bLink.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bPoints CreateEdgebPoints(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bPoints.CreateEdge(this, source, target);
		}

	}

	//
	// INamedGraph (LGSPNamedGraph) implementation
	//
	public class metamodel_graphNamedGraph : GRGEN_LGSP.LGSPNamedGraph
	{
		public metamodel_graphNamedGraph(GRGEN_LGSP.LGSPGlobalVariables globalVariables) : base(new metamodel_graphGraphModel(), globalVariables, GetGraphName(), 0)
		{
		}

		public GRGEN_MODEL.@Node CreateNodeNode()
		{
			return GRGEN_MODEL.@Node.CreateNode(this);
		}

		public GRGEN_MODEL.@Node CreateNodeNode(string nodeName)
		{
			return GRGEN_MODEL.@Node.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@BRoot CreateNodeBRoot()
		{
			return GRGEN_MODEL.@BRoot.CreateNode(this);
		}

		public GRGEN_MODEL.@BRoot CreateNodeBRoot(string nodeName)
		{
			return GRGEN_MODEL.@BRoot.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@BSite CreateNodeBSite()
		{
			return GRGEN_MODEL.@BSite.CreateNode(this);
		}

		public GRGEN_MODEL.@BSite CreateNodeBSite(string nodeName)
		{
			return GRGEN_MODEL.@BSite.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@BPort CreateNodeBPort()
		{
			return GRGEN_MODEL.@BPort.CreateNode(this);
		}

		public GRGEN_MODEL.@BPort CreateNodeBPort(string nodeName)
		{
			return GRGEN_MODEL.@BPort.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@BInnerName CreateNodeBInnerName()
		{
			return GRGEN_MODEL.@BInnerName.CreateNode(this);
		}

		public GRGEN_MODEL.@BInnerName CreateNodeBInnerName(string nodeName)
		{
			return GRGEN_MODEL.@BInnerName.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@BEdge CreateNodeBEdge()
		{
			return GRGEN_MODEL.@BEdge.CreateNode(this);
		}

		public GRGEN_MODEL.@BEdge CreateNodeBEdge(string nodeName)
		{
			return GRGEN_MODEL.@BEdge.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@BOuterName CreateNodeBOuterName()
		{
			return GRGEN_MODEL.@BOuterName.CreateNode(this);
		}

		public GRGEN_MODEL.@BOuterName CreateNodeBOuterName(string nodeName)
		{
			return GRGEN_MODEL.@BOuterName.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@append CreateNodeappend()
		{
			return GRGEN_MODEL.@append.CreateNode(this);
		}

		public GRGEN_MODEL.@append CreateNodeappend(string nodeName)
		{
			return GRGEN_MODEL.@append.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@main CreateNodemain()
		{
			return GRGEN_MODEL.@main.CreateNode(this);
		}

		public GRGEN_MODEL.@main CreateNodemain(string nodeName)
		{
			return GRGEN_MODEL.@main.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@list CreateNodelist()
		{
			return GRGEN_MODEL.@list.CreateNode(this);
		}

		public GRGEN_MODEL.@list CreateNodelist(string nodeName)
		{
			return GRGEN_MODEL.@list.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@this CreateNodethis()
		{
			return GRGEN_MODEL.@this.CreateNode(this);
		}

		public GRGEN_MODEL.@this CreateNodethis(string nodeName)
		{
			return GRGEN_MODEL.@this.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@thisRef CreateNodethisRef()
		{
			return GRGEN_MODEL.@thisRef.CreateNode(this);
		}

		public GRGEN_MODEL.@thisRef CreateNodethisRef(string nodeName)
		{
			return GRGEN_MODEL.@thisRef.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Cell CreateNodeCell()
		{
			return GRGEN_MODEL.@Cell.CreateNode(this);
		}

		public GRGEN_MODEL.@Cell CreateNodeCell(string nodeName)
		{
			return GRGEN_MODEL.@Cell.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Void CreateNodeVoid()
		{
			return GRGEN_MODEL.@Void.CreateNode(this);
		}

		public GRGEN_MODEL.@Void CreateNodeVoid(string nodeName)
		{
			return GRGEN_MODEL.@Void.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@val CreateNodeval()
		{
			return GRGEN_MODEL.@val.CreateNode(this);
		}

		public GRGEN_MODEL.@val CreateNodeval(string nodeName)
		{
			return GRGEN_MODEL.@val.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@N1 CreateNodeN1()
		{
			return GRGEN_MODEL.@N1.CreateNode(this);
		}

		public GRGEN_MODEL.@N1 CreateNodeN1(string nodeName)
		{
			return GRGEN_MODEL.@N1.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@N2 CreateNodeN2()
		{
			return GRGEN_MODEL.@N2.CreateNode(this);
		}

		public GRGEN_MODEL.@N2 CreateNodeN2(string nodeName)
		{
			return GRGEN_MODEL.@N2.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@N3 CreateNodeN3()
		{
			return GRGEN_MODEL.@N3.CreateNode(this);
		}

		public GRGEN_MODEL.@N3 CreateNodeN3(string nodeName)
		{
			return GRGEN_MODEL.@N3.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@N4 CreateNodeN4()
		{
			return GRGEN_MODEL.@N4.CreateNode(this);
		}

		public GRGEN_MODEL.@N4 CreateNodeN4(string nodeName)
		{
			return GRGEN_MODEL.@N4.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@N5 CreateNodeN5()
		{
			return GRGEN_MODEL.@N5.CreateNode(this);
		}

		public GRGEN_MODEL.@N5 CreateNodeN5(string nodeName)
		{
			return GRGEN_MODEL.@N5.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@N6 CreateNodeN6()
		{
			return GRGEN_MODEL.@N6.CreateNode(this);
		}

		public GRGEN_MODEL.@N6 CreateNodeN6(string nodeName)
		{
			return GRGEN_MODEL.@N6.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@next CreateNodenext()
		{
			return GRGEN_MODEL.@next.CreateNode(this);
		}

		public GRGEN_MODEL.@next CreateNodenext(string nodeName)
		{
			return GRGEN_MODEL.@next.CreateNode(this, nodeName);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@bPrnt CreateEdgebPrnt(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bPrnt.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bPrnt CreateEdgebPrnt(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@bPrnt.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@bChild CreateEdgebChild(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bChild.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bChild CreateEdgebChild(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@bChild.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@bNode CreateEdgebNode(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bNode.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bNode CreateEdgebNode(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@bNode.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@bPorts CreateEdgebPorts(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bPorts.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bPorts CreateEdgebPorts(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@bPorts.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@bLink CreateEdgebLink(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bLink.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bLink CreateEdgebLink(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@bLink.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@bPoints CreateEdgebPoints(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@bPoints.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@bPoints CreateEdgebPoints(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@bPoints.CreateEdge(this, source, target, edgeName);
		}

	}
}
