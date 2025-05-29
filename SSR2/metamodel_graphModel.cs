// This file has been generated automatically by GrGen (www.grgen.net)
// Do not modify this file! Any changes will be lost!
// Generated from "./foo/ruleset.grg" on Wed May 28 21:07:08 CEST 2025

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

	public enum NodeTypes { @Node=0, @BPlace=1, @BPoint=2, @BLink=3, @BNode=4, @BRoot=5, @BSite=6, @BPort=7, @BInnerName=8, @BEdge=9, @BOuterName=10, @VarSpace=11, @True=12, @False=13, @Error=14, @Locale=15, @Route=16, @WayPoint=17, @OccupiedBy=18, @Robot=19, @ID=20, @N0=21, @N1=22, @N2=23, @N3=24, @N4=25, @N5=26, @N6=27, @N7=28, @N8=29, @N9=30, @N10=31, @Bat=32, @Pow=33, @SLck=34, @SLckRef=35, @Mvmt=36, @Token=37 };

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
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, };
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
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, true, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, true, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, true, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, true, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, };
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
		public static bool[] isA = new bool[] { true, true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, true, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, false, true, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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

	// *** Node VarSpace ***

	public interface IVarSpace : IBNode
	{
	}

	public sealed partial class @VarSpace : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IVarSpace
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@VarSpace[] pool;

		// explicit initializations of BNode for target VarSpace
		// implicit initializations of BNode for target VarSpace
		// explicit initializations of VarSpace for target VarSpace
		// implicit initializations of VarSpace for target VarSpace
		static @VarSpace() {
		}

		public @VarSpace() : base(GRGEN_MODEL.NodeType_VarSpace.typeVar)
		{
			// implicit initialization, container creation of VarSpace
			// explicit initializations of BNode for target VarSpace
			// explicit initializations of VarSpace for target VarSpace
		}

		public static GRGEN_MODEL.NodeType_VarSpace TypeInstance { get { return GRGEN_MODEL.NodeType_VarSpace.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@VarSpace(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@VarSpace(this, graph, oldToNewObjectMap);
		}

		private @VarSpace(GRGEN_MODEL.@VarSpace oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_VarSpace.typeVar)
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
			if(!(that is @VarSpace))
				return false;
			@VarSpace that_ = (@VarSpace)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@VarSpace CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@VarSpace node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@VarSpace();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@VarSpace[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of VarSpace
				// explicit initializations of BNode for target VarSpace
				// explicit initializations of VarSpace for target VarSpace
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@VarSpace CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@VarSpace node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@VarSpace();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@VarSpace[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of VarSpace
				// explicit initializations of BNode for target VarSpace
				// explicit initializations of VarSpace for target VarSpace
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@VarSpace[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"VarSpace\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"VarSpace\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of VarSpace
			// explicit initializations of BNode for target VarSpace
			// explicit initializations of VarSpace for target VarSpace
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("VarSpace does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("VarSpace does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_VarSpace : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_VarSpace typeVar = new GRGEN_MODEL.NodeType_VarSpace();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_VarSpace() : base((int) NodeTypes.@VarSpace)
		{
		}
		public override string Name { get { return "VarSpace"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "VarSpace"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IVarSpace"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@VarSpace"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@VarSpace();
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
			return new GRGEN_MODEL.@VarSpace();
		}

	}

	// *** Node True ***

	public interface ITrue : IBNode
	{
	}

	public sealed partial class @True : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.ITrue
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@True[] pool;

		// explicit initializations of BNode for target True
		// implicit initializations of BNode for target True
		// explicit initializations of True for target True
		// implicit initializations of True for target True
		static @True() {
		}

		public @True() : base(GRGEN_MODEL.NodeType_True.typeVar)
		{
			// implicit initialization, container creation of True
			// explicit initializations of BNode for target True
			// explicit initializations of True for target True
		}

		public static GRGEN_MODEL.NodeType_True TypeInstance { get { return GRGEN_MODEL.NodeType_True.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@True(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@True(this, graph, oldToNewObjectMap);
		}

		private @True(GRGEN_MODEL.@True oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_True.typeVar)
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
			if(!(that is @True))
				return false;
			@True that_ = (@True)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@True CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@True node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@True();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@True[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of True
				// explicit initializations of BNode for target True
				// explicit initializations of True for target True
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@True CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@True node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@True();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@True[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of True
				// explicit initializations of BNode for target True
				// explicit initializations of True for target True
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@True[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"True\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"True\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of True
			// explicit initializations of BNode for target True
			// explicit initializations of True for target True
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("True does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("True does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_True : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_True typeVar = new GRGEN_MODEL.NodeType_True();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_True() : base((int) NodeTypes.@True)
		{
		}
		public override string Name { get { return "True"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "True"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.ITrue"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@True"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@True();
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
			return new GRGEN_MODEL.@True();
		}

	}

	// *** Node False ***

	public interface IFalse : IBNode
	{
	}

	public sealed partial class @False : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IFalse
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@False[] pool;

		// explicit initializations of BNode for target False
		// implicit initializations of BNode for target False
		// explicit initializations of False for target False
		// implicit initializations of False for target False
		static @False() {
		}

		public @False() : base(GRGEN_MODEL.NodeType_False.typeVar)
		{
			// implicit initialization, container creation of False
			// explicit initializations of BNode for target False
			// explicit initializations of False for target False
		}

		public static GRGEN_MODEL.NodeType_False TypeInstance { get { return GRGEN_MODEL.NodeType_False.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@False(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@False(this, graph, oldToNewObjectMap);
		}

		private @False(GRGEN_MODEL.@False oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_False.typeVar)
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
			if(!(that is @False))
				return false;
			@False that_ = (@False)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@False CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@False node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@False();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@False[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of False
				// explicit initializations of BNode for target False
				// explicit initializations of False for target False
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@False CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@False node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@False();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@False[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of False
				// explicit initializations of BNode for target False
				// explicit initializations of False for target False
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@False[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"False\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"False\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of False
			// explicit initializations of BNode for target False
			// explicit initializations of False for target False
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("False does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("False does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_False : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_False typeVar = new GRGEN_MODEL.NodeType_False();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_False() : base((int) NodeTypes.@False)
		{
		}
		public override string Name { get { return "False"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "False"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IFalse"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@False"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@False();
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
			return new GRGEN_MODEL.@False();
		}

	}

	// *** Node Error ***

	public interface IError : IBNode
	{
	}

	public sealed partial class @Error : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IError
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Error[] pool;

		// explicit initializations of BNode for target Error
		// implicit initializations of BNode for target Error
		// explicit initializations of Error for target Error
		// implicit initializations of Error for target Error
		static @Error() {
		}

		public @Error() : base(GRGEN_MODEL.NodeType_Error.typeVar)
		{
			// implicit initialization, container creation of Error
			// explicit initializations of BNode for target Error
			// explicit initializations of Error for target Error
		}

		public static GRGEN_MODEL.NodeType_Error TypeInstance { get { return GRGEN_MODEL.NodeType_Error.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Error(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Error(this, graph, oldToNewObjectMap);
		}

		private @Error(GRGEN_MODEL.@Error oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Error.typeVar)
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
			if(!(that is @Error))
				return false;
			@Error that_ = (@Error)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Error CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Error node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Error();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Error[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Error
				// explicit initializations of BNode for target Error
				// explicit initializations of Error for target Error
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Error CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Error node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Error();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Error[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Error
				// explicit initializations of BNode for target Error
				// explicit initializations of Error for target Error
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Error[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Error\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Error\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Error
			// explicit initializations of BNode for target Error
			// explicit initializations of Error for target Error
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Error does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Error does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Error : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Error typeVar = new GRGEN_MODEL.NodeType_Error();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Error() : base((int) NodeTypes.@Error)
		{
		}
		public override string Name { get { return "Error"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Error"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IError"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Error"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Error();
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
			return new GRGEN_MODEL.@Error();
		}

	}

	// *** Node Locale ***

	public interface ILocale : IBNode
	{
	}

	public sealed partial class @Locale : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.ILocale
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Locale[] pool;

		// explicit initializations of BNode for target Locale
		// implicit initializations of BNode for target Locale
		// explicit initializations of Locale for target Locale
		// implicit initializations of Locale for target Locale
		static @Locale() {
		}

		public @Locale() : base(GRGEN_MODEL.NodeType_Locale.typeVar)
		{
			// implicit initialization, container creation of Locale
			// explicit initializations of BNode for target Locale
			// explicit initializations of Locale for target Locale
		}

		public static GRGEN_MODEL.NodeType_Locale TypeInstance { get { return GRGEN_MODEL.NodeType_Locale.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Locale(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Locale(this, graph, oldToNewObjectMap);
		}

		private @Locale(GRGEN_MODEL.@Locale oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Locale.typeVar)
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
			if(!(that is @Locale))
				return false;
			@Locale that_ = (@Locale)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Locale CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Locale node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Locale();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Locale[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Locale
				// explicit initializations of BNode for target Locale
				// explicit initializations of Locale for target Locale
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Locale CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Locale node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Locale();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Locale[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Locale
				// explicit initializations of BNode for target Locale
				// explicit initializations of Locale for target Locale
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Locale[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Locale\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Locale\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Locale
			// explicit initializations of BNode for target Locale
			// explicit initializations of Locale for target Locale
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Locale does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Locale does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Locale : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Locale typeVar = new GRGEN_MODEL.NodeType_Locale();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Locale() : base((int) NodeTypes.@Locale)
		{
		}
		public override string Name { get { return "Locale"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Locale"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.ILocale"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Locale"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Locale();
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
			return new GRGEN_MODEL.@Locale();
		}

	}

	// *** Node Route ***

	public interface IRoute : IBNode
	{
	}

	public sealed partial class @Route : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IRoute
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Route[] pool;

		// explicit initializations of BNode for target Route
		// implicit initializations of BNode for target Route
		// explicit initializations of Route for target Route
		// implicit initializations of Route for target Route
		static @Route() {
		}

		public @Route() : base(GRGEN_MODEL.NodeType_Route.typeVar)
		{
			// implicit initialization, container creation of Route
			// explicit initializations of BNode for target Route
			// explicit initializations of Route for target Route
		}

		public static GRGEN_MODEL.NodeType_Route TypeInstance { get { return GRGEN_MODEL.NodeType_Route.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Route(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Route(this, graph, oldToNewObjectMap);
		}

		private @Route(GRGEN_MODEL.@Route oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Route.typeVar)
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
			if(!(that is @Route))
				return false;
			@Route that_ = (@Route)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Route CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Route node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Route();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Route[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Route
				// explicit initializations of BNode for target Route
				// explicit initializations of Route for target Route
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Route CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Route node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Route();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Route[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Route
				// explicit initializations of BNode for target Route
				// explicit initializations of Route for target Route
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Route[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Route\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Route\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Route
			// explicit initializations of BNode for target Route
			// explicit initializations of Route for target Route
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Route does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Route does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Route : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Route typeVar = new GRGEN_MODEL.NodeType_Route();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Route() : base((int) NodeTypes.@Route)
		{
		}
		public override string Name { get { return "Route"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Route"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IRoute"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Route"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Route();
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
			return new GRGEN_MODEL.@Route();
		}

	}

	// *** Node WayPoint ***

	public interface IWayPoint : IBNode
	{
	}

	public sealed partial class @WayPoint : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IWayPoint
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@WayPoint[] pool;

		// explicit initializations of BNode for target WayPoint
		// implicit initializations of BNode for target WayPoint
		// explicit initializations of WayPoint for target WayPoint
		// implicit initializations of WayPoint for target WayPoint
		static @WayPoint() {
		}

		public @WayPoint() : base(GRGEN_MODEL.NodeType_WayPoint.typeVar)
		{
			// implicit initialization, container creation of WayPoint
			// explicit initializations of BNode for target WayPoint
			// explicit initializations of WayPoint for target WayPoint
		}

		public static GRGEN_MODEL.NodeType_WayPoint TypeInstance { get { return GRGEN_MODEL.NodeType_WayPoint.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@WayPoint(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@WayPoint(this, graph, oldToNewObjectMap);
		}

		private @WayPoint(GRGEN_MODEL.@WayPoint oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_WayPoint.typeVar)
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
			if(!(that is @WayPoint))
				return false;
			@WayPoint that_ = (@WayPoint)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@WayPoint CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@WayPoint node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@WayPoint();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@WayPoint[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of WayPoint
				// explicit initializations of BNode for target WayPoint
				// explicit initializations of WayPoint for target WayPoint
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@WayPoint CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@WayPoint node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@WayPoint();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@WayPoint[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of WayPoint
				// explicit initializations of BNode for target WayPoint
				// explicit initializations of WayPoint for target WayPoint
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@WayPoint[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"WayPoint\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"WayPoint\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of WayPoint
			// explicit initializations of BNode for target WayPoint
			// explicit initializations of WayPoint for target WayPoint
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("WayPoint does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("WayPoint does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_WayPoint : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_WayPoint typeVar = new GRGEN_MODEL.NodeType_WayPoint();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_WayPoint() : base((int) NodeTypes.@WayPoint)
		{
		}
		public override string Name { get { return "WayPoint"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "WayPoint"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IWayPoint"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@WayPoint"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@WayPoint();
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
			return new GRGEN_MODEL.@WayPoint();
		}

	}

	// *** Node OccupiedBy ***

	public interface IOccupiedBy : IBNode
	{
	}

	public sealed partial class @OccupiedBy : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IOccupiedBy
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@OccupiedBy[] pool;

		// explicit initializations of BNode for target OccupiedBy
		// implicit initializations of BNode for target OccupiedBy
		// explicit initializations of OccupiedBy for target OccupiedBy
		// implicit initializations of OccupiedBy for target OccupiedBy
		static @OccupiedBy() {
		}

		public @OccupiedBy() : base(GRGEN_MODEL.NodeType_OccupiedBy.typeVar)
		{
			// implicit initialization, container creation of OccupiedBy
			// explicit initializations of BNode for target OccupiedBy
			// explicit initializations of OccupiedBy for target OccupiedBy
		}

		public static GRGEN_MODEL.NodeType_OccupiedBy TypeInstance { get { return GRGEN_MODEL.NodeType_OccupiedBy.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@OccupiedBy(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@OccupiedBy(this, graph, oldToNewObjectMap);
		}

		private @OccupiedBy(GRGEN_MODEL.@OccupiedBy oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_OccupiedBy.typeVar)
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
			if(!(that is @OccupiedBy))
				return false;
			@OccupiedBy that_ = (@OccupiedBy)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@OccupiedBy CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@OccupiedBy node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@OccupiedBy();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@OccupiedBy[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of OccupiedBy
				// explicit initializations of BNode for target OccupiedBy
				// explicit initializations of OccupiedBy for target OccupiedBy
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@OccupiedBy CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@OccupiedBy node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@OccupiedBy();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@OccupiedBy[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of OccupiedBy
				// explicit initializations of BNode for target OccupiedBy
				// explicit initializations of OccupiedBy for target OccupiedBy
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@OccupiedBy[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"OccupiedBy\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"OccupiedBy\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of OccupiedBy
			// explicit initializations of BNode for target OccupiedBy
			// explicit initializations of OccupiedBy for target OccupiedBy
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("OccupiedBy does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("OccupiedBy does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_OccupiedBy : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_OccupiedBy typeVar = new GRGEN_MODEL.NodeType_OccupiedBy();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_OccupiedBy() : base((int) NodeTypes.@OccupiedBy)
		{
		}
		public override string Name { get { return "OccupiedBy"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "OccupiedBy"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IOccupiedBy"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@OccupiedBy"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@OccupiedBy();
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
			return new GRGEN_MODEL.@OccupiedBy();
		}

	}

	// *** Node Robot ***

	public interface IRobot : IBNode
	{
	}

	public sealed partial class @Robot : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IRobot
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Robot[] pool;

		// explicit initializations of BNode for target Robot
		// implicit initializations of BNode for target Robot
		// explicit initializations of Robot for target Robot
		// implicit initializations of Robot for target Robot
		static @Robot() {
		}

		public @Robot() : base(GRGEN_MODEL.NodeType_Robot.typeVar)
		{
			// implicit initialization, container creation of Robot
			// explicit initializations of BNode for target Robot
			// explicit initializations of Robot for target Robot
		}

		public static GRGEN_MODEL.NodeType_Robot TypeInstance { get { return GRGEN_MODEL.NodeType_Robot.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Robot(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Robot(this, graph, oldToNewObjectMap);
		}

		private @Robot(GRGEN_MODEL.@Robot oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Robot.typeVar)
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
			if(!(that is @Robot))
				return false;
			@Robot that_ = (@Robot)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Robot CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Robot node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Robot();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Robot[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Robot
				// explicit initializations of BNode for target Robot
				// explicit initializations of Robot for target Robot
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Robot CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Robot node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Robot();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Robot[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Robot
				// explicit initializations of BNode for target Robot
				// explicit initializations of Robot for target Robot
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Robot[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Robot\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Robot\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Robot
			// explicit initializations of BNode for target Robot
			// explicit initializations of Robot for target Robot
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Robot does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Robot does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Robot : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Robot typeVar = new GRGEN_MODEL.NodeType_Robot();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Robot() : base((int) NodeTypes.@Robot)
		{
		}
		public override string Name { get { return "Robot"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Robot"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IRobot"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Robot"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Robot();
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
			return new GRGEN_MODEL.@Robot();
		}

	}

	// *** Node ID ***

	public interface IID : IBNode
	{
	}

	public sealed partial class @ID : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IID
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@ID[] pool;

		// explicit initializations of BNode for target ID
		// implicit initializations of BNode for target ID
		// explicit initializations of ID for target ID
		// implicit initializations of ID for target ID
		static @ID() {
		}

		public @ID() : base(GRGEN_MODEL.NodeType_ID.typeVar)
		{
			// implicit initialization, container creation of ID
			// explicit initializations of BNode for target ID
			// explicit initializations of ID for target ID
		}

		public static GRGEN_MODEL.NodeType_ID TypeInstance { get { return GRGEN_MODEL.NodeType_ID.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@ID(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@ID(this, graph, oldToNewObjectMap);
		}

		private @ID(GRGEN_MODEL.@ID oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_ID.typeVar)
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
			if(!(that is @ID))
				return false;
			@ID that_ = (@ID)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@ID CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@ID node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@ID();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@ID[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of ID
				// explicit initializations of BNode for target ID
				// explicit initializations of ID for target ID
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@ID CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@ID node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@ID();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@ID[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of ID
				// explicit initializations of BNode for target ID
				// explicit initializations of ID for target ID
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@ID[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"ID\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"ID\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of ID
			// explicit initializations of BNode for target ID
			// explicit initializations of ID for target ID
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("ID does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("ID does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_ID : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_ID typeVar = new GRGEN_MODEL.NodeType_ID();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_ID() : base((int) NodeTypes.@ID)
		{
		}
		public override string Name { get { return "ID"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "ID"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IID"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@ID"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@ID();
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
			return new GRGEN_MODEL.@ID();
		}

	}

	// *** Node N0 ***

	public interface IN0 : IBNode
	{
	}

	public sealed partial class @N0 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN0
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N0[] pool;

		// explicit initializations of BNode for target N0
		// implicit initializations of BNode for target N0
		// explicit initializations of N0 for target N0
		// implicit initializations of N0 for target N0
		static @N0() {
		}

		public @N0() : base(GRGEN_MODEL.NodeType_N0.typeVar)
		{
			// implicit initialization, container creation of N0
			// explicit initializations of BNode for target N0
			// explicit initializations of N0 for target N0
		}

		public static GRGEN_MODEL.NodeType_N0 TypeInstance { get { return GRGEN_MODEL.NodeType_N0.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N0(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N0(this, graph, oldToNewObjectMap);
		}

		private @N0(GRGEN_MODEL.@N0 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N0.typeVar)
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
			if(!(that is @N0))
				return false;
			@N0 that_ = (@N0)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N0 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N0 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N0();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N0[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N0
				// explicit initializations of BNode for target N0
				// explicit initializations of N0 for target N0
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N0 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N0 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N0();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N0[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N0
				// explicit initializations of BNode for target N0
				// explicit initializations of N0 for target N0
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N0[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N0\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N0\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N0
			// explicit initializations of BNode for target N0
			// explicit initializations of N0 for target N0
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N0 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N0 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N0 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N0 typeVar = new GRGEN_MODEL.NodeType_N0();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N0() : base((int) NodeTypes.@N0)
		{
		}
		public override string Name { get { return "N0"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N0"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN0"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N0"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N0();
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
			return new GRGEN_MODEL.@N0();
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
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, };
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
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, };
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

	// *** Node N7 ***

	public interface IN7 : IBNode
	{
	}

	public sealed partial class @N7 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN7
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N7[] pool;

		// explicit initializations of BNode for target N7
		// implicit initializations of BNode for target N7
		// explicit initializations of N7 for target N7
		// implicit initializations of N7 for target N7
		static @N7() {
		}

		public @N7() : base(GRGEN_MODEL.NodeType_N7.typeVar)
		{
			// implicit initialization, container creation of N7
			// explicit initializations of BNode for target N7
			// explicit initializations of N7 for target N7
		}

		public static GRGEN_MODEL.NodeType_N7 TypeInstance { get { return GRGEN_MODEL.NodeType_N7.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N7(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N7(this, graph, oldToNewObjectMap);
		}

		private @N7(GRGEN_MODEL.@N7 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N7.typeVar)
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
			if(!(that is @N7))
				return false;
			@N7 that_ = (@N7)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N7 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N7 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N7();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N7[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N7
				// explicit initializations of BNode for target N7
				// explicit initializations of N7 for target N7
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N7 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N7 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N7();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N7[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N7
				// explicit initializations of BNode for target N7
				// explicit initializations of N7 for target N7
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N7[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N7\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N7\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N7
			// explicit initializations of BNode for target N7
			// explicit initializations of N7 for target N7
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N7 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N7 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N7 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N7 typeVar = new GRGEN_MODEL.NodeType_N7();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N7() : base((int) NodeTypes.@N7)
		{
		}
		public override string Name { get { return "N7"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N7"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN7"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N7"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N7();
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
			return new GRGEN_MODEL.@N7();
		}

	}

	// *** Node N8 ***

	public interface IN8 : IBNode
	{
	}

	public sealed partial class @N8 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN8
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N8[] pool;

		// explicit initializations of BNode for target N8
		// implicit initializations of BNode for target N8
		// explicit initializations of N8 for target N8
		// implicit initializations of N8 for target N8
		static @N8() {
		}

		public @N8() : base(GRGEN_MODEL.NodeType_N8.typeVar)
		{
			// implicit initialization, container creation of N8
			// explicit initializations of BNode for target N8
			// explicit initializations of N8 for target N8
		}

		public static GRGEN_MODEL.NodeType_N8 TypeInstance { get { return GRGEN_MODEL.NodeType_N8.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N8(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N8(this, graph, oldToNewObjectMap);
		}

		private @N8(GRGEN_MODEL.@N8 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N8.typeVar)
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
			if(!(that is @N8))
				return false;
			@N8 that_ = (@N8)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N8 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N8 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N8();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N8[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N8
				// explicit initializations of BNode for target N8
				// explicit initializations of N8 for target N8
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N8 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N8 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N8();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N8[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N8
				// explicit initializations of BNode for target N8
				// explicit initializations of N8 for target N8
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N8[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N8\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N8\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N8
			// explicit initializations of BNode for target N8
			// explicit initializations of N8 for target N8
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N8 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N8 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N8 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N8 typeVar = new GRGEN_MODEL.NodeType_N8();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N8() : base((int) NodeTypes.@N8)
		{
		}
		public override string Name { get { return "N8"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N8"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN8"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N8"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N8();
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
			return new GRGEN_MODEL.@N8();
		}

	}

	// *** Node N9 ***

	public interface IN9 : IBNode
	{
	}

	public sealed partial class @N9 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN9
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N9[] pool;

		// explicit initializations of BNode for target N9
		// implicit initializations of BNode for target N9
		// explicit initializations of N9 for target N9
		// implicit initializations of N9 for target N9
		static @N9() {
		}

		public @N9() : base(GRGEN_MODEL.NodeType_N9.typeVar)
		{
			// implicit initialization, container creation of N9
			// explicit initializations of BNode for target N9
			// explicit initializations of N9 for target N9
		}

		public static GRGEN_MODEL.NodeType_N9 TypeInstance { get { return GRGEN_MODEL.NodeType_N9.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N9(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N9(this, graph, oldToNewObjectMap);
		}

		private @N9(GRGEN_MODEL.@N9 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N9.typeVar)
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
			if(!(that is @N9))
				return false;
			@N9 that_ = (@N9)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N9 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N9 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N9();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N9[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N9
				// explicit initializations of BNode for target N9
				// explicit initializations of N9 for target N9
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N9 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N9 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N9();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N9[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N9
				// explicit initializations of BNode for target N9
				// explicit initializations of N9 for target N9
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N9[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N9\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N9\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N9
			// explicit initializations of BNode for target N9
			// explicit initializations of N9 for target N9
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N9 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N9 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N9 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N9 typeVar = new GRGEN_MODEL.NodeType_N9();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N9() : base((int) NodeTypes.@N9)
		{
		}
		public override string Name { get { return "N9"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N9"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN9"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N9"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N9();
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
			return new GRGEN_MODEL.@N9();
		}

	}

	// *** Node N10 ***

	public interface IN10 : IBNode
	{
	}

	public sealed partial class @N10 : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IN10
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@N10[] pool;

		// explicit initializations of BNode for target N10
		// implicit initializations of BNode for target N10
		// explicit initializations of N10 for target N10
		// implicit initializations of N10 for target N10
		static @N10() {
		}

		public @N10() : base(GRGEN_MODEL.NodeType_N10.typeVar)
		{
			// implicit initialization, container creation of N10
			// explicit initializations of BNode for target N10
			// explicit initializations of N10 for target N10
		}

		public static GRGEN_MODEL.NodeType_N10 TypeInstance { get { return GRGEN_MODEL.NodeType_N10.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@N10(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@N10(this, graph, oldToNewObjectMap);
		}

		private @N10(GRGEN_MODEL.@N10 oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_N10.typeVar)
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
			if(!(that is @N10))
				return false;
			@N10 that_ = (@N10)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@N10 CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@N10 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N10();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N10[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N10
				// explicit initializations of BNode for target N10
				// explicit initializations of N10 for target N10
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@N10 CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@N10 node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@N10();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@N10[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of N10
				// explicit initializations of BNode for target N10
				// explicit initializations of N10 for target N10
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@N10[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"N10\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"N10\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of N10
			// explicit initializations of BNode for target N10
			// explicit initializations of N10 for target N10
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N10 does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("N10 does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_N10 : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_N10 typeVar = new GRGEN_MODEL.NodeType_N10();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_N10() : base((int) NodeTypes.@N10)
		{
		}
		public override string Name { get { return "N10"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "N10"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IN10"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@N10"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@N10();
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
			return new GRGEN_MODEL.@N10();
		}

	}

	// *** Node Bat ***

	public interface IBat : IBNode
	{
	}

	public sealed partial class @Bat : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IBat
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Bat[] pool;

		// explicit initializations of BNode for target Bat
		// implicit initializations of BNode for target Bat
		// explicit initializations of Bat for target Bat
		// implicit initializations of Bat for target Bat
		static @Bat() {
		}

		public @Bat() : base(GRGEN_MODEL.NodeType_Bat.typeVar)
		{
			// implicit initialization, container creation of Bat
			// explicit initializations of BNode for target Bat
			// explicit initializations of Bat for target Bat
		}

		public static GRGEN_MODEL.NodeType_Bat TypeInstance { get { return GRGEN_MODEL.NodeType_Bat.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Bat(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Bat(this, graph, oldToNewObjectMap);
		}

		private @Bat(GRGEN_MODEL.@Bat oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Bat.typeVar)
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
			if(!(that is @Bat))
				return false;
			@Bat that_ = (@Bat)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Bat CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Bat node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Bat();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Bat[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Bat
				// explicit initializations of BNode for target Bat
				// explicit initializations of Bat for target Bat
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Bat CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Bat node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Bat();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Bat[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Bat
				// explicit initializations of BNode for target Bat
				// explicit initializations of Bat for target Bat
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Bat[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Bat\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Bat\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Bat
			// explicit initializations of BNode for target Bat
			// explicit initializations of Bat for target Bat
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Bat does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Bat does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Bat : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Bat typeVar = new GRGEN_MODEL.NodeType_Bat();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Bat() : base((int) NodeTypes.@Bat)
		{
		}
		public override string Name { get { return "Bat"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Bat"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IBat"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Bat"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Bat();
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
			return new GRGEN_MODEL.@Bat();
		}

	}

	// *** Node Pow ***

	public interface IPow : IBNode
	{
	}

	public sealed partial class @Pow : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IPow
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Pow[] pool;

		// explicit initializations of BNode for target Pow
		// implicit initializations of BNode for target Pow
		// explicit initializations of Pow for target Pow
		// implicit initializations of Pow for target Pow
		static @Pow() {
		}

		public @Pow() : base(GRGEN_MODEL.NodeType_Pow.typeVar)
		{
			// implicit initialization, container creation of Pow
			// explicit initializations of BNode for target Pow
			// explicit initializations of Pow for target Pow
		}

		public static GRGEN_MODEL.NodeType_Pow TypeInstance { get { return GRGEN_MODEL.NodeType_Pow.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Pow(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Pow(this, graph, oldToNewObjectMap);
		}

		private @Pow(GRGEN_MODEL.@Pow oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Pow.typeVar)
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
			if(!(that is @Pow))
				return false;
			@Pow that_ = (@Pow)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Pow CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Pow node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Pow();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Pow[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Pow
				// explicit initializations of BNode for target Pow
				// explicit initializations of Pow for target Pow
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Pow CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Pow node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Pow();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Pow[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Pow
				// explicit initializations of BNode for target Pow
				// explicit initializations of Pow for target Pow
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Pow[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Pow\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Pow\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Pow
			// explicit initializations of BNode for target Pow
			// explicit initializations of Pow for target Pow
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Pow does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Pow does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Pow : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Pow typeVar = new GRGEN_MODEL.NodeType_Pow();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Pow() : base((int) NodeTypes.@Pow)
		{
		}
		public override string Name { get { return "Pow"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Pow"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IPow"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Pow"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Pow();
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
			return new GRGEN_MODEL.@Pow();
		}

	}

	// *** Node SLck ***

	public interface ISLck : IBNode
	{
	}

	public sealed partial class @SLck : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.ISLck
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@SLck[] pool;

		// explicit initializations of BNode for target SLck
		// implicit initializations of BNode for target SLck
		// explicit initializations of SLck for target SLck
		// implicit initializations of SLck for target SLck
		static @SLck() {
		}

		public @SLck() : base(GRGEN_MODEL.NodeType_SLck.typeVar)
		{
			// implicit initialization, container creation of SLck
			// explicit initializations of BNode for target SLck
			// explicit initializations of SLck for target SLck
		}

		public static GRGEN_MODEL.NodeType_SLck TypeInstance { get { return GRGEN_MODEL.NodeType_SLck.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@SLck(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@SLck(this, graph, oldToNewObjectMap);
		}

		private @SLck(GRGEN_MODEL.@SLck oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_SLck.typeVar)
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
			if(!(that is @SLck))
				return false;
			@SLck that_ = (@SLck)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@SLck CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@SLck node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@SLck();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@SLck[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of SLck
				// explicit initializations of BNode for target SLck
				// explicit initializations of SLck for target SLck
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@SLck CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@SLck node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@SLck();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@SLck[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of SLck
				// explicit initializations of BNode for target SLck
				// explicit initializations of SLck for target SLck
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@SLck[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"SLck\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"SLck\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of SLck
			// explicit initializations of BNode for target SLck
			// explicit initializations of SLck for target SLck
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("SLck does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("SLck does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_SLck : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_SLck typeVar = new GRGEN_MODEL.NodeType_SLck();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_SLck() : base((int) NodeTypes.@SLck)
		{
		}
		public override string Name { get { return "SLck"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "SLck"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.ISLck"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@SLck"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@SLck();
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
			return new GRGEN_MODEL.@SLck();
		}

	}

	// *** Node SLckRef ***

	public interface ISLckRef : IBNode
	{
	}

	public sealed partial class @SLckRef : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.ISLckRef
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@SLckRef[] pool;

		// explicit initializations of BNode for target SLckRef
		// implicit initializations of BNode for target SLckRef
		// explicit initializations of SLckRef for target SLckRef
		// implicit initializations of SLckRef for target SLckRef
		static @SLckRef() {
		}

		public @SLckRef() : base(GRGEN_MODEL.NodeType_SLckRef.typeVar)
		{
			// implicit initialization, container creation of SLckRef
			// explicit initializations of BNode for target SLckRef
			// explicit initializations of SLckRef for target SLckRef
		}

		public static GRGEN_MODEL.NodeType_SLckRef TypeInstance { get { return GRGEN_MODEL.NodeType_SLckRef.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@SLckRef(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@SLckRef(this, graph, oldToNewObjectMap);
		}

		private @SLckRef(GRGEN_MODEL.@SLckRef oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_SLckRef.typeVar)
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
			if(!(that is @SLckRef))
				return false;
			@SLckRef that_ = (@SLckRef)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@SLckRef CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@SLckRef node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@SLckRef();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@SLckRef[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of SLckRef
				// explicit initializations of BNode for target SLckRef
				// explicit initializations of SLckRef for target SLckRef
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@SLckRef CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@SLckRef node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@SLckRef();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@SLckRef[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of SLckRef
				// explicit initializations of BNode for target SLckRef
				// explicit initializations of SLckRef for target SLckRef
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@SLckRef[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"SLckRef\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"SLckRef\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of SLckRef
			// explicit initializations of BNode for target SLckRef
			// explicit initializations of SLckRef for target SLckRef
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("SLckRef does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("SLckRef does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_SLckRef : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_SLckRef typeVar = new GRGEN_MODEL.NodeType_SLckRef();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_SLckRef() : base((int) NodeTypes.@SLckRef)
		{
		}
		public override string Name { get { return "SLckRef"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "SLckRef"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.ISLckRef"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@SLckRef"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@SLckRef();
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
			return new GRGEN_MODEL.@SLckRef();
		}

	}

	// *** Node Mvmt ***

	public interface IMvmt : IBNode
	{
	}

	public sealed partial class @Mvmt : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IMvmt
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Mvmt[] pool;

		// explicit initializations of BNode for target Mvmt
		// implicit initializations of BNode for target Mvmt
		// explicit initializations of Mvmt for target Mvmt
		// implicit initializations of Mvmt for target Mvmt
		static @Mvmt() {
		}

		public @Mvmt() : base(GRGEN_MODEL.NodeType_Mvmt.typeVar)
		{
			// implicit initialization, container creation of Mvmt
			// explicit initializations of BNode for target Mvmt
			// explicit initializations of Mvmt for target Mvmt
		}

		public static GRGEN_MODEL.NodeType_Mvmt TypeInstance { get { return GRGEN_MODEL.NodeType_Mvmt.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Mvmt(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Mvmt(this, graph, oldToNewObjectMap);
		}

		private @Mvmt(GRGEN_MODEL.@Mvmt oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Mvmt.typeVar)
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
			if(!(that is @Mvmt))
				return false;
			@Mvmt that_ = (@Mvmt)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Mvmt CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Mvmt node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Mvmt();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Mvmt[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Mvmt
				// explicit initializations of BNode for target Mvmt
				// explicit initializations of Mvmt for target Mvmt
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Mvmt CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Mvmt node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Mvmt();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Mvmt[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Mvmt
				// explicit initializations of BNode for target Mvmt
				// explicit initializations of Mvmt for target Mvmt
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Mvmt[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Mvmt\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Mvmt\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Mvmt
			// explicit initializations of BNode for target Mvmt
			// explicit initializations of Mvmt for target Mvmt
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Mvmt does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Mvmt does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Mvmt : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Mvmt typeVar = new GRGEN_MODEL.NodeType_Mvmt();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Mvmt() : base((int) NodeTypes.@Mvmt)
		{
		}
		public override string Name { get { return "Mvmt"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Mvmt"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IMvmt"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Mvmt"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Mvmt();
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
			return new GRGEN_MODEL.@Mvmt();
		}

	}

	// *** Node Token ***

	public interface IToken : IBNode
	{
	}

	public sealed partial class @Token : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IToken
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Token[] pool;

		// explicit initializations of BNode for target Token
		// implicit initializations of BNode for target Token
		// explicit initializations of Token for target Token
		// implicit initializations of Token for target Token
		static @Token() {
		}

		public @Token() : base(GRGEN_MODEL.NodeType_Token.typeVar)
		{
			// implicit initialization, container creation of Token
			// explicit initializations of BNode for target Token
			// explicit initializations of Token for target Token
		}

		public static GRGEN_MODEL.NodeType_Token TypeInstance { get { return GRGEN_MODEL.NodeType_Token.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Token(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Token(this, graph, oldToNewObjectMap);
		}

		private @Token(GRGEN_MODEL.@Token oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Token.typeVar)
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
			if(!(that is @Token))
				return false;
			@Token that_ = (@Token)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Token CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Token node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Token();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Token[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Token
				// explicit initializations of BNode for target Token
				// explicit initializations of Token for target Token
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Token CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Token node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Token();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Token[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Token
				// explicit initializations of BNode for target Token
				// explicit initializations of Token for target Token
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Token[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Token\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Token\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Token
			// explicit initializations of BNode for target Token
			// explicit initializations of Token for target Token
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Token does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Token does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Token : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Token typeVar = new GRGEN_MODEL.NodeType_Token();
		public static bool[] isA = new bool[] { true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Token() : base((int) NodeTypes.@Token)
		{
		}
		public override string Name { get { return "Token"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Token"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.IToken"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_metamodel_graph.@Token"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Token();
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
			return new GRGEN_MODEL.@Token();
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
				GRGEN_MODEL.NodeType_VarSpace.typeVar,
				GRGEN_MODEL.NodeType_True.typeVar,
				GRGEN_MODEL.NodeType_False.typeVar,
				GRGEN_MODEL.NodeType_Error.typeVar,
				GRGEN_MODEL.NodeType_Locale.typeVar,
				GRGEN_MODEL.NodeType_Route.typeVar,
				GRGEN_MODEL.NodeType_WayPoint.typeVar,
				GRGEN_MODEL.NodeType_OccupiedBy.typeVar,
				GRGEN_MODEL.NodeType_Robot.typeVar,
				GRGEN_MODEL.NodeType_ID.typeVar,
				GRGEN_MODEL.NodeType_N0.typeVar,
				GRGEN_MODEL.NodeType_N1.typeVar,
				GRGEN_MODEL.NodeType_N2.typeVar,
				GRGEN_MODEL.NodeType_N3.typeVar,
				GRGEN_MODEL.NodeType_N4.typeVar,
				GRGEN_MODEL.NodeType_N5.typeVar,
				GRGEN_MODEL.NodeType_N6.typeVar,
				GRGEN_MODEL.NodeType_N7.typeVar,
				GRGEN_MODEL.NodeType_N8.typeVar,
				GRGEN_MODEL.NodeType_N9.typeVar,
				GRGEN_MODEL.NodeType_N10.typeVar,
				GRGEN_MODEL.NodeType_Bat.typeVar,
				GRGEN_MODEL.NodeType_Pow.typeVar,
				GRGEN_MODEL.NodeType_SLck.typeVar,
				GRGEN_MODEL.NodeType_SLckRef.typeVar,
				GRGEN_MODEL.NodeType_Mvmt.typeVar,
				GRGEN_MODEL.NodeType_Token.typeVar,
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
				GRGEN_MODEL.NodeType_VarSpace.typeVar,
				GRGEN_MODEL.NodeType_True.typeVar,
				GRGEN_MODEL.NodeType_False.typeVar,
				GRGEN_MODEL.NodeType_Error.typeVar,
				GRGEN_MODEL.NodeType_Locale.typeVar,
				GRGEN_MODEL.NodeType_Route.typeVar,
				GRGEN_MODEL.NodeType_WayPoint.typeVar,
				GRGEN_MODEL.NodeType_OccupiedBy.typeVar,
				GRGEN_MODEL.NodeType_Robot.typeVar,
				GRGEN_MODEL.NodeType_ID.typeVar,
				GRGEN_MODEL.NodeType_N0.typeVar,
				GRGEN_MODEL.NodeType_N1.typeVar,
				GRGEN_MODEL.NodeType_N2.typeVar,
				GRGEN_MODEL.NodeType_N3.typeVar,
				GRGEN_MODEL.NodeType_N4.typeVar,
				GRGEN_MODEL.NodeType_N5.typeVar,
				GRGEN_MODEL.NodeType_N6.typeVar,
				GRGEN_MODEL.NodeType_N7.typeVar,
				GRGEN_MODEL.NodeType_N8.typeVar,
				GRGEN_MODEL.NodeType_N9.typeVar,
				GRGEN_MODEL.NodeType_N10.typeVar,
				GRGEN_MODEL.NodeType_Bat.typeVar,
				GRGEN_MODEL.NodeType_Pow.typeVar,
				GRGEN_MODEL.NodeType_SLck.typeVar,
				GRGEN_MODEL.NodeType_SLckRef.typeVar,
				GRGEN_MODEL.NodeType_Mvmt.typeVar,
				GRGEN_MODEL.NodeType_Token.typeVar,
			};
			GRGEN_MODEL.NodeType_BNode.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BNode.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_VarSpace.typeVar,
				GRGEN_MODEL.NodeType_True.typeVar,
				GRGEN_MODEL.NodeType_False.typeVar,
				GRGEN_MODEL.NodeType_Error.typeVar,
				GRGEN_MODEL.NodeType_Locale.typeVar,
				GRGEN_MODEL.NodeType_Route.typeVar,
				GRGEN_MODEL.NodeType_WayPoint.typeVar,
				GRGEN_MODEL.NodeType_OccupiedBy.typeVar,
				GRGEN_MODEL.NodeType_Robot.typeVar,
				GRGEN_MODEL.NodeType_ID.typeVar,
				GRGEN_MODEL.NodeType_N0.typeVar,
				GRGEN_MODEL.NodeType_N1.typeVar,
				GRGEN_MODEL.NodeType_N2.typeVar,
				GRGEN_MODEL.NodeType_N3.typeVar,
				GRGEN_MODEL.NodeType_N4.typeVar,
				GRGEN_MODEL.NodeType_N5.typeVar,
				GRGEN_MODEL.NodeType_N6.typeVar,
				GRGEN_MODEL.NodeType_N7.typeVar,
				GRGEN_MODEL.NodeType_N8.typeVar,
				GRGEN_MODEL.NodeType_N9.typeVar,
				GRGEN_MODEL.NodeType_N10.typeVar,
				GRGEN_MODEL.NodeType_Bat.typeVar,
				GRGEN_MODEL.NodeType_Pow.typeVar,
				GRGEN_MODEL.NodeType_SLck.typeVar,
				GRGEN_MODEL.NodeType_SLckRef.typeVar,
				GRGEN_MODEL.NodeType_Mvmt.typeVar,
				GRGEN_MODEL.NodeType_Token.typeVar,
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
			GRGEN_MODEL.NodeType_VarSpace.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_VarSpace.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_VarSpace.typeVar,
			};
			GRGEN_MODEL.NodeType_VarSpace.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_VarSpace.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_VarSpace.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_VarSpace.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_VarSpace.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_VarSpace.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_VarSpace.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_True.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_True.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_True.typeVar,
			};
			GRGEN_MODEL.NodeType_True.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_True.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_True.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_True.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_True.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_True.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_True.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_False.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_False.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_False.typeVar,
			};
			GRGEN_MODEL.NodeType_False.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_False.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_False.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_False.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_False.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_False.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_False.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Error.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Error.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Error.typeVar,
			};
			GRGEN_MODEL.NodeType_Error.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Error.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Error.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Error.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Error.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Error.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Error.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Locale.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Locale.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Locale.typeVar,
			};
			GRGEN_MODEL.NodeType_Locale.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Locale.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Locale.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Locale.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Locale.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Locale.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Locale.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Route.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Route.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Route.typeVar,
			};
			GRGEN_MODEL.NodeType_Route.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Route.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Route.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Route.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Route.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Route.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Route.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_WayPoint.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_WayPoint.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_WayPoint.typeVar,
			};
			GRGEN_MODEL.NodeType_WayPoint.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_WayPoint.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_WayPoint.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_WayPoint.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_WayPoint.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_WayPoint.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_WayPoint.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_OccupiedBy.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_OccupiedBy.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_OccupiedBy.typeVar,
			};
			GRGEN_MODEL.NodeType_OccupiedBy.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_OccupiedBy.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_OccupiedBy.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_OccupiedBy.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_OccupiedBy.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_OccupiedBy.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_OccupiedBy.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Robot.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Robot.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Robot.typeVar,
			};
			GRGEN_MODEL.NodeType_Robot.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Robot.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Robot.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Robot.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Robot.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Robot.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Robot.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_ID.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_ID.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_ID.typeVar,
			};
			GRGEN_MODEL.NodeType_ID.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_ID.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_ID.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_ID.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_ID.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_ID.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_ID.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N0.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N0.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N0.typeVar,
			};
			GRGEN_MODEL.NodeType_N0.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N0.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N0.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N0.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N0.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N0.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N0.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
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
			GRGEN_MODEL.NodeType_N7.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N7.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N7.typeVar,
			};
			GRGEN_MODEL.NodeType_N7.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N7.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N7.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N7.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N7.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N7.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N7.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N8.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N8.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N8.typeVar,
			};
			GRGEN_MODEL.NodeType_N8.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N8.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N8.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N8.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N8.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N8.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N8.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N9.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N9.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N9.typeVar,
			};
			GRGEN_MODEL.NodeType_N9.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N9.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N9.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N9.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N9.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N9.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N9.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N10.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_N10.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N10.typeVar,
			};
			GRGEN_MODEL.NodeType_N10.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_N10.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_N10.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_N10.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_N10.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_N10.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_N10.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Bat.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Bat.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Bat.typeVar,
			};
			GRGEN_MODEL.NodeType_Bat.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Bat.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Bat.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Bat.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Bat.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Bat.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Bat.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Pow.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Pow.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Pow.typeVar,
			};
			GRGEN_MODEL.NodeType_Pow.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Pow.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Pow.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Pow.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Pow.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Pow.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Pow.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_SLck.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_SLck.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_SLck.typeVar,
			};
			GRGEN_MODEL.NodeType_SLck.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_SLck.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_SLck.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_SLck.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_SLck.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_SLck.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_SLck.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_SLckRef.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_SLckRef.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_SLckRef.typeVar,
			};
			GRGEN_MODEL.NodeType_SLckRef.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_SLckRef.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_SLckRef.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_SLckRef.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_SLckRef.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_SLckRef.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_SLckRef.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Mvmt.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Mvmt.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Mvmt.typeVar,
			};
			GRGEN_MODEL.NodeType_Mvmt.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Mvmt.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Mvmt.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Mvmt.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Mvmt.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Mvmt.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Mvmt.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Token.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Token.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Token.typeVar,
			};
			GRGEN_MODEL.NodeType_Token.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Token.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Token.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Token.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Token.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Token.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Token.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
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
				case "VarSpace" : return GRGEN_MODEL.NodeType_VarSpace.typeVar;
				case "True" : return GRGEN_MODEL.NodeType_True.typeVar;
				case "False" : return GRGEN_MODEL.NodeType_False.typeVar;
				case "Error" : return GRGEN_MODEL.NodeType_Error.typeVar;
				case "Locale" : return GRGEN_MODEL.NodeType_Locale.typeVar;
				case "Route" : return GRGEN_MODEL.NodeType_Route.typeVar;
				case "WayPoint" : return GRGEN_MODEL.NodeType_WayPoint.typeVar;
				case "OccupiedBy" : return GRGEN_MODEL.NodeType_OccupiedBy.typeVar;
				case "Robot" : return GRGEN_MODEL.NodeType_Robot.typeVar;
				case "ID" : return GRGEN_MODEL.NodeType_ID.typeVar;
				case "N0" : return GRGEN_MODEL.NodeType_N0.typeVar;
				case "N1" : return GRGEN_MODEL.NodeType_N1.typeVar;
				case "N2" : return GRGEN_MODEL.NodeType_N2.typeVar;
				case "N3" : return GRGEN_MODEL.NodeType_N3.typeVar;
				case "N4" : return GRGEN_MODEL.NodeType_N4.typeVar;
				case "N5" : return GRGEN_MODEL.NodeType_N5.typeVar;
				case "N6" : return GRGEN_MODEL.NodeType_N6.typeVar;
				case "N7" : return GRGEN_MODEL.NodeType_N7.typeVar;
				case "N8" : return GRGEN_MODEL.NodeType_N8.typeVar;
				case "N9" : return GRGEN_MODEL.NodeType_N9.typeVar;
				case "N10" : return GRGEN_MODEL.NodeType_N10.typeVar;
				case "Bat" : return GRGEN_MODEL.NodeType_Bat.typeVar;
				case "Pow" : return GRGEN_MODEL.NodeType_Pow.typeVar;
				case "SLck" : return GRGEN_MODEL.NodeType_SLck.typeVar;
				case "SLckRef" : return GRGEN_MODEL.NodeType_SLckRef.typeVar;
				case "Mvmt" : return GRGEN_MODEL.NodeType_Mvmt.typeVar;
				case "Token" : return GRGEN_MODEL.NodeType_Token.typeVar;
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
			GRGEN_MODEL.NodeType_VarSpace.typeVar,
			GRGEN_MODEL.NodeType_True.typeVar,
			GRGEN_MODEL.NodeType_False.typeVar,
			GRGEN_MODEL.NodeType_Error.typeVar,
			GRGEN_MODEL.NodeType_Locale.typeVar,
			GRGEN_MODEL.NodeType_Route.typeVar,
			GRGEN_MODEL.NodeType_WayPoint.typeVar,
			GRGEN_MODEL.NodeType_OccupiedBy.typeVar,
			GRGEN_MODEL.NodeType_Robot.typeVar,
			GRGEN_MODEL.NodeType_ID.typeVar,
			GRGEN_MODEL.NodeType_N0.typeVar,
			GRGEN_MODEL.NodeType_N1.typeVar,
			GRGEN_MODEL.NodeType_N2.typeVar,
			GRGEN_MODEL.NodeType_N3.typeVar,
			GRGEN_MODEL.NodeType_N4.typeVar,
			GRGEN_MODEL.NodeType_N5.typeVar,
			GRGEN_MODEL.NodeType_N6.typeVar,
			GRGEN_MODEL.NodeType_N7.typeVar,
			GRGEN_MODEL.NodeType_N8.typeVar,
			GRGEN_MODEL.NodeType_N9.typeVar,
			GRGEN_MODEL.NodeType_N10.typeVar,
			GRGEN_MODEL.NodeType_Bat.typeVar,
			GRGEN_MODEL.NodeType_Pow.typeVar,
			GRGEN_MODEL.NodeType_SLck.typeVar,
			GRGEN_MODEL.NodeType_SLckRef.typeVar,
			GRGEN_MODEL.NodeType_Mvmt.typeVar,
			GRGEN_MODEL.NodeType_Token.typeVar,
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
			typeof(GRGEN_MODEL.NodeType_VarSpace),
			typeof(GRGEN_MODEL.NodeType_True),
			typeof(GRGEN_MODEL.NodeType_False),
			typeof(GRGEN_MODEL.NodeType_Error),
			typeof(GRGEN_MODEL.NodeType_Locale),
			typeof(GRGEN_MODEL.NodeType_Route),
			typeof(GRGEN_MODEL.NodeType_WayPoint),
			typeof(GRGEN_MODEL.NodeType_OccupiedBy),
			typeof(GRGEN_MODEL.NodeType_Robot),
			typeof(GRGEN_MODEL.NodeType_ID),
			typeof(GRGEN_MODEL.NodeType_N0),
			typeof(GRGEN_MODEL.NodeType_N1),
			typeof(GRGEN_MODEL.NodeType_N2),
			typeof(GRGEN_MODEL.NodeType_N3),
			typeof(GRGEN_MODEL.NodeType_N4),
			typeof(GRGEN_MODEL.NodeType_N5),
			typeof(GRGEN_MODEL.NodeType_N6),
			typeof(GRGEN_MODEL.NodeType_N7),
			typeof(GRGEN_MODEL.NodeType_N8),
			typeof(GRGEN_MODEL.NodeType_N9),
			typeof(GRGEN_MODEL.NodeType_N10),
			typeof(GRGEN_MODEL.NodeType_Bat),
			typeof(GRGEN_MODEL.NodeType_Pow),
			typeof(GRGEN_MODEL.NodeType_SLck),
			typeof(GRGEN_MODEL.NodeType_SLckRef),
			typeof(GRGEN_MODEL.NodeType_Mvmt),
			typeof(GRGEN_MODEL.NodeType_Token),
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
			case "VarSpace":
				switch(member)
				{
				default:
					return null;
				}
			case "True":
				switch(member)
				{
				default:
					return null;
				}
			case "False":
				switch(member)
				{
				default:
					return null;
				}
			case "Error":
				switch(member)
				{
				default:
					return null;
				}
			case "Locale":
				switch(member)
				{
				default:
					return null;
				}
			case "Route":
				switch(member)
				{
				default:
					return null;
				}
			case "WayPoint":
				switch(member)
				{
				default:
					return null;
				}
			case "OccupiedBy":
				switch(member)
				{
				default:
					return null;
				}
			case "Robot":
				switch(member)
				{
				default:
					return null;
				}
			case "ID":
				switch(member)
				{
				default:
					return null;
				}
			case "N0":
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
			case "N7":
				switch(member)
				{
				default:
					return null;
				}
			case "N8":
				switch(member)
				{
				default:
					return null;
				}
			case "N9":
				switch(member)
				{
				default:
					return null;
				}
			case "N10":
				switch(member)
				{
				default:
					return null;
				}
			case "Bat":
				switch(member)
				{
				default:
					return null;
				}
			case "Pow":
				switch(member)
				{
				default:
					return null;
				}
			case "SLck":
				switch(member)
				{
				default:
					return null;
				}
			case "SLckRef":
				switch(member)
				{
				default:
					return null;
				}
			case "Mvmt":
				switch(member)
				{
				default:
					return null;
				}
			case "Token":
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
			case "VarSpace":
				switch(member)
				{
				default:
					return null;
				}
			case "True":
				switch(member)
				{
				default:
					return null;
				}
			case "False":
				switch(member)
				{
				default:
					return null;
				}
			case "Error":
				switch(member)
				{
				default:
					return null;
				}
			case "Locale":
				switch(member)
				{
				default:
					return null;
				}
			case "Route":
				switch(member)
				{
				default:
					return null;
				}
			case "WayPoint":
				switch(member)
				{
				default:
					return null;
				}
			case "OccupiedBy":
				switch(member)
				{
				default:
					return null;
				}
			case "Robot":
				switch(member)
				{
				default:
					return null;
				}
			case "ID":
				switch(member)
				{
				default:
					return null;
				}
			case "N0":
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
			case "N7":
				switch(member)
				{
				default:
					return null;
				}
			case "N8":
				switch(member)
				{
				default:
					return null;
				}
			case "N9":
				switch(member)
				{
				default:
					return null;
				}
			case "N10":
				switch(member)
				{
				default:
					return null;
				}
			case "Bat":
				switch(member)
				{
				default:
					return null;
				}
			case "Pow":
				switch(member)
				{
				default:
					return null;
				}
			case "SLck":
				switch(member)
				{
				default:
					return null;
				}
			case "SLckRef":
				switch(member)
				{
				default:
					return null;
				}
			case "Mvmt":
				switch(member)
				{
				default:
					return null;
				}
			case "Token":
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
			case "VarSpace":
				switch(member)
				{
				default:
					return null;
				}
			case "True":
				switch(member)
				{
				default:
					return null;
				}
			case "False":
				switch(member)
				{
				default:
					return null;
				}
			case "Error":
				switch(member)
				{
				default:
					return null;
				}
			case "Locale":
				switch(member)
				{
				default:
					return null;
				}
			case "Route":
				switch(member)
				{
				default:
					return null;
				}
			case "WayPoint":
				switch(member)
				{
				default:
					return null;
				}
			case "OccupiedBy":
				switch(member)
				{
				default:
					return null;
				}
			case "Robot":
				switch(member)
				{
				default:
					return null;
				}
			case "ID":
				switch(member)
				{
				default:
					return null;
				}
			case "N0":
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
			case "N7":
				switch(member)
				{
				default:
					return null;
				}
			case "N8":
				switch(member)
				{
				default:
					return null;
				}
			case "N9":
				switch(member)
				{
				default:
					return null;
				}
			case "N10":
				switch(member)
				{
				default:
					return null;
				}
			case "Bat":
				switch(member)
				{
				default:
					return null;
				}
			case "Pow":
				switch(member)
				{
				default:
					return null;
				}
			case "SLck":
				switch(member)
				{
				default:
					return null;
				}
			case "SLckRef":
				switch(member)
				{
				default:
					return null;
				}
			case "Mvmt":
				switch(member)
				{
				default:
					return null;
				}
			case "Token":
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
			case "VarSpace":
				switch(member)
				{
				default:
					return null;
				}
			case "True":
				switch(member)
				{
				default:
					return null;
				}
			case "False":
				switch(member)
				{
				default:
					return null;
				}
			case "Error":
				switch(member)
				{
				default:
					return null;
				}
			case "Locale":
				switch(member)
				{
				default:
					return null;
				}
			case "Route":
				switch(member)
				{
				default:
					return null;
				}
			case "WayPoint":
				switch(member)
				{
				default:
					return null;
				}
			case "OccupiedBy":
				switch(member)
				{
				default:
					return null;
				}
			case "Robot":
				switch(member)
				{
				default:
					return null;
				}
			case "ID":
				switch(member)
				{
				default:
					return null;
				}
			case "N0":
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
			case "N7":
				switch(member)
				{
				default:
					return null;
				}
			case "N8":
				switch(member)
				{
				default:
					return null;
				}
			case "N9":
				switch(member)
				{
				default:
					return null;
				}
			case "N10":
				switch(member)
				{
				default:
					return null;
				}
			case "Bat":
				switch(member)
				{
				default:
					return null;
				}
			case "Pow":
				switch(member)
				{
				default:
					return null;
				}
			case "SLck":
				switch(member)
				{
				default:
					return null;
				}
			case "SLckRef":
				switch(member)
				{
				default:
					return null;
				}
			case "Mvmt":
				switch(member)
				{
				default:
					return null;
				}
			case "Token":
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
			case "VarSpace":
				switch(member)
				{
				default:
					return -1;
				}
			case "True":
				switch(member)
				{
				default:
					return -1;
				}
			case "False":
				switch(member)
				{
				default:
					return -1;
				}
			case "Error":
				switch(member)
				{
				default:
					return -1;
				}
			case "Locale":
				switch(member)
				{
				default:
					return -1;
				}
			case "Route":
				switch(member)
				{
				default:
					return -1;
				}
			case "WayPoint":
				switch(member)
				{
				default:
					return -1;
				}
			case "OccupiedBy":
				switch(member)
				{
				default:
					return -1;
				}
			case "Robot":
				switch(member)
				{
				default:
					return -1;
				}
			case "ID":
				switch(member)
				{
				default:
					return -1;
				}
			case "N0":
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
			case "N7":
				switch(member)
				{
				default:
					return -1;
				}
			case "N8":
				switch(member)
				{
				default:
					return -1;
				}
			case "N9":
				switch(member)
				{
				default:
					return -1;
				}
			case "N10":
				switch(member)
				{
				default:
					return -1;
				}
			case "Bat":
				switch(member)
				{
				default:
					return -1;
				}
			case "Pow":
				switch(member)
				{
				default:
					return -1;
				}
			case "SLck":
				switch(member)
				{
				default:
					return -1;
				}
			case "SLckRef":
				switch(member)
				{
				default:
					return -1;
				}
			case "Mvmt":
				switch(member)
				{
				default:
					return -1;
				}
			case "Token":
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
			case "VarSpace":
				switch(member)
				{
				default:
					return -1;
				}
			case "True":
				switch(member)
				{
				default:
					return -1;
				}
			case "False":
				switch(member)
				{
				default:
					return -1;
				}
			case "Error":
				switch(member)
				{
				default:
					return -1;
				}
			case "Locale":
				switch(member)
				{
				default:
					return -1;
				}
			case "Route":
				switch(member)
				{
				default:
					return -1;
				}
			case "WayPoint":
				switch(member)
				{
				default:
					return -1;
				}
			case "OccupiedBy":
				switch(member)
				{
				default:
					return -1;
				}
			case "Robot":
				switch(member)
				{
				default:
					return -1;
				}
			case "ID":
				switch(member)
				{
				default:
					return -1;
				}
			case "N0":
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
			case "N7":
				switch(member)
				{
				default:
					return -1;
				}
			case "N8":
				switch(member)
				{
				default:
					return -1;
				}
			case "N9":
				switch(member)
				{
				default:
					return -1;
				}
			case "N10":
				switch(member)
				{
				default:
					return -1;
				}
			case "Bat":
				switch(member)
				{
				default:
					return -1;
				}
			case "Pow":
				switch(member)
				{
				default:
					return -1;
				}
			case "SLck":
				switch(member)
				{
				default:
					return -1;
				}
			case "SLckRef":
				switch(member)
				{
				default:
					return -1;
				}
			case "Mvmt":
				switch(member)
				{
				default:
					return -1;
				}
			case "Token":
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
			case "VarSpace":
				switch(member)
				{
				default:
					return -1;
				}
			case "True":
				switch(member)
				{
				default:
					return -1;
				}
			case "False":
				switch(member)
				{
				default:
					return -1;
				}
			case "Error":
				switch(member)
				{
				default:
					return -1;
				}
			case "Locale":
				switch(member)
				{
				default:
					return -1;
				}
			case "Route":
				switch(member)
				{
				default:
					return -1;
				}
			case "WayPoint":
				switch(member)
				{
				default:
					return -1;
				}
			case "OccupiedBy":
				switch(member)
				{
				default:
					return -1;
				}
			case "Robot":
				switch(member)
				{
				default:
					return -1;
				}
			case "ID":
				switch(member)
				{
				default:
					return -1;
				}
			case "N0":
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
			case "N7":
				switch(member)
				{
				default:
					return -1;
				}
			case "N8":
				switch(member)
				{
				default:
					return -1;
				}
			case "N9":
				switch(member)
				{
				default:
					return -1;
				}
			case "N10":
				switch(member)
				{
				default:
					return -1;
				}
			case "Bat":
				switch(member)
				{
				default:
					return -1;
				}
			case "Pow":
				switch(member)
				{
				default:
					return -1;
				}
			case "SLck":
				switch(member)
				{
				default:
					return -1;
				}
			case "SLckRef":
				switch(member)
				{
				default:
					return -1;
				}
			case "Mvmt":
				switch(member)
				{
				default:
					return -1;
				}
			case "Token":
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
			case "VarSpace":
				switch(member)
				{
				default:
					return -1;
				}
			case "True":
				switch(member)
				{
				default:
					return -1;
				}
			case "False":
				switch(member)
				{
				default:
					return -1;
				}
			case "Error":
				switch(member)
				{
				default:
					return -1;
				}
			case "Locale":
				switch(member)
				{
				default:
					return -1;
				}
			case "Route":
				switch(member)
				{
				default:
					return -1;
				}
			case "WayPoint":
				switch(member)
				{
				default:
					return -1;
				}
			case "OccupiedBy":
				switch(member)
				{
				default:
					return -1;
				}
			case "Robot":
				switch(member)
				{
				default:
					return -1;
				}
			case "ID":
				switch(member)
				{
				default:
					return -1;
				}
			case "N0":
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
			case "N7":
				switch(member)
				{
				default:
					return -1;
				}
			case "N8":
				switch(member)
				{
				default:
					return -1;
				}
			case "N9":
				switch(member)
				{
				default:
					return -1;
				}
			case "N10":
				switch(member)
				{
				default:
					return -1;
				}
			case "Bat":
				switch(member)
				{
				default:
					return -1;
				}
			case "Pow":
				switch(member)
				{
				default:
					return -1;
				}
			case "SLck":
				switch(member)
				{
				default:
					return -1;
				}
			case "SLckRef":
				switch(member)
				{
				default:
					return -1;
				}
			case "Mvmt":
				switch(member)
				{
				default:
					return -1;
				}
			case "Token":
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
			case "VarSpace":
				switch(member)
				{
				default:
					return -1;
				}
			case "True":
				switch(member)
				{
				default:
					return -1;
				}
			case "False":
				switch(member)
				{
				default:
					return -1;
				}
			case "Error":
				switch(member)
				{
				default:
					return -1;
				}
			case "Locale":
				switch(member)
				{
				default:
					return -1;
				}
			case "Route":
				switch(member)
				{
				default:
					return -1;
				}
			case "WayPoint":
				switch(member)
				{
				default:
					return -1;
				}
			case "OccupiedBy":
				switch(member)
				{
				default:
					return -1;
				}
			case "Robot":
				switch(member)
				{
				default:
					return -1;
				}
			case "ID":
				switch(member)
				{
				default:
					return -1;
				}
			case "N0":
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
			case "N7":
				switch(member)
				{
				default:
					return -1;
				}
			case "N8":
				switch(member)
				{
				default:
					return -1;
				}
			case "N9":
				switch(member)
				{
				default:
					return -1;
				}
			case "N10":
				switch(member)
				{
				default:
					return -1;
				}
			case "Bat":
				switch(member)
				{
				default:
					return -1;
				}
			case "Pow":
				switch(member)
				{
				default:
					return -1;
				}
			case "SLck":
				switch(member)
				{
				default:
					return -1;
				}
			case "SLckRef":
				switch(member)
				{
				default:
					return -1;
				}
			case "Mvmt":
				switch(member)
				{
				default:
					return -1;
				}
			case "Token":
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
		public override string MD5Hash { get { return "69a2e3a65b2231ca55c41413c5095d45"; } }
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

		public GRGEN_MODEL.@VarSpace CreateNodeVarSpace()
		{
			return GRGEN_MODEL.@VarSpace.CreateNode(this);
		}

		public GRGEN_MODEL.@True CreateNodeTrue()
		{
			return GRGEN_MODEL.@True.CreateNode(this);
		}

		public GRGEN_MODEL.@False CreateNodeFalse()
		{
			return GRGEN_MODEL.@False.CreateNode(this);
		}

		public GRGEN_MODEL.@Error CreateNodeError()
		{
			return GRGEN_MODEL.@Error.CreateNode(this);
		}

		public GRGEN_MODEL.@Locale CreateNodeLocale()
		{
			return GRGEN_MODEL.@Locale.CreateNode(this);
		}

		public GRGEN_MODEL.@Route CreateNodeRoute()
		{
			return GRGEN_MODEL.@Route.CreateNode(this);
		}

		public GRGEN_MODEL.@WayPoint CreateNodeWayPoint()
		{
			return GRGEN_MODEL.@WayPoint.CreateNode(this);
		}

		public GRGEN_MODEL.@OccupiedBy CreateNodeOccupiedBy()
		{
			return GRGEN_MODEL.@OccupiedBy.CreateNode(this);
		}

		public GRGEN_MODEL.@Robot CreateNodeRobot()
		{
			return GRGEN_MODEL.@Robot.CreateNode(this);
		}

		public GRGEN_MODEL.@ID CreateNodeID()
		{
			return GRGEN_MODEL.@ID.CreateNode(this);
		}

		public GRGEN_MODEL.@N0 CreateNodeN0()
		{
			return GRGEN_MODEL.@N0.CreateNode(this);
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

		public GRGEN_MODEL.@N7 CreateNodeN7()
		{
			return GRGEN_MODEL.@N7.CreateNode(this);
		}

		public GRGEN_MODEL.@N8 CreateNodeN8()
		{
			return GRGEN_MODEL.@N8.CreateNode(this);
		}

		public GRGEN_MODEL.@N9 CreateNodeN9()
		{
			return GRGEN_MODEL.@N9.CreateNode(this);
		}

		public GRGEN_MODEL.@N10 CreateNodeN10()
		{
			return GRGEN_MODEL.@N10.CreateNode(this);
		}

		public GRGEN_MODEL.@Bat CreateNodeBat()
		{
			return GRGEN_MODEL.@Bat.CreateNode(this);
		}

		public GRGEN_MODEL.@Pow CreateNodePow()
		{
			return GRGEN_MODEL.@Pow.CreateNode(this);
		}

		public GRGEN_MODEL.@SLck CreateNodeSLck()
		{
			return GRGEN_MODEL.@SLck.CreateNode(this);
		}

		public GRGEN_MODEL.@SLckRef CreateNodeSLckRef()
		{
			return GRGEN_MODEL.@SLckRef.CreateNode(this);
		}

		public GRGEN_MODEL.@Mvmt CreateNodeMvmt()
		{
			return GRGEN_MODEL.@Mvmt.CreateNode(this);
		}

		public GRGEN_MODEL.@Token CreateNodeToken()
		{
			return GRGEN_MODEL.@Token.CreateNode(this);
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

		public GRGEN_MODEL.@VarSpace CreateNodeVarSpace()
		{
			return GRGEN_MODEL.@VarSpace.CreateNode(this);
		}

		public GRGEN_MODEL.@VarSpace CreateNodeVarSpace(string nodeName)
		{
			return GRGEN_MODEL.@VarSpace.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@True CreateNodeTrue()
		{
			return GRGEN_MODEL.@True.CreateNode(this);
		}

		public GRGEN_MODEL.@True CreateNodeTrue(string nodeName)
		{
			return GRGEN_MODEL.@True.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@False CreateNodeFalse()
		{
			return GRGEN_MODEL.@False.CreateNode(this);
		}

		public GRGEN_MODEL.@False CreateNodeFalse(string nodeName)
		{
			return GRGEN_MODEL.@False.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Error CreateNodeError()
		{
			return GRGEN_MODEL.@Error.CreateNode(this);
		}

		public GRGEN_MODEL.@Error CreateNodeError(string nodeName)
		{
			return GRGEN_MODEL.@Error.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Locale CreateNodeLocale()
		{
			return GRGEN_MODEL.@Locale.CreateNode(this);
		}

		public GRGEN_MODEL.@Locale CreateNodeLocale(string nodeName)
		{
			return GRGEN_MODEL.@Locale.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Route CreateNodeRoute()
		{
			return GRGEN_MODEL.@Route.CreateNode(this);
		}

		public GRGEN_MODEL.@Route CreateNodeRoute(string nodeName)
		{
			return GRGEN_MODEL.@Route.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@WayPoint CreateNodeWayPoint()
		{
			return GRGEN_MODEL.@WayPoint.CreateNode(this);
		}

		public GRGEN_MODEL.@WayPoint CreateNodeWayPoint(string nodeName)
		{
			return GRGEN_MODEL.@WayPoint.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@OccupiedBy CreateNodeOccupiedBy()
		{
			return GRGEN_MODEL.@OccupiedBy.CreateNode(this);
		}

		public GRGEN_MODEL.@OccupiedBy CreateNodeOccupiedBy(string nodeName)
		{
			return GRGEN_MODEL.@OccupiedBy.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Robot CreateNodeRobot()
		{
			return GRGEN_MODEL.@Robot.CreateNode(this);
		}

		public GRGEN_MODEL.@Robot CreateNodeRobot(string nodeName)
		{
			return GRGEN_MODEL.@Robot.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@ID CreateNodeID()
		{
			return GRGEN_MODEL.@ID.CreateNode(this);
		}

		public GRGEN_MODEL.@ID CreateNodeID(string nodeName)
		{
			return GRGEN_MODEL.@ID.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@N0 CreateNodeN0()
		{
			return GRGEN_MODEL.@N0.CreateNode(this);
		}

		public GRGEN_MODEL.@N0 CreateNodeN0(string nodeName)
		{
			return GRGEN_MODEL.@N0.CreateNode(this, nodeName);
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

		public GRGEN_MODEL.@N7 CreateNodeN7()
		{
			return GRGEN_MODEL.@N7.CreateNode(this);
		}

		public GRGEN_MODEL.@N7 CreateNodeN7(string nodeName)
		{
			return GRGEN_MODEL.@N7.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@N8 CreateNodeN8()
		{
			return GRGEN_MODEL.@N8.CreateNode(this);
		}

		public GRGEN_MODEL.@N8 CreateNodeN8(string nodeName)
		{
			return GRGEN_MODEL.@N8.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@N9 CreateNodeN9()
		{
			return GRGEN_MODEL.@N9.CreateNode(this);
		}

		public GRGEN_MODEL.@N9 CreateNodeN9(string nodeName)
		{
			return GRGEN_MODEL.@N9.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@N10 CreateNodeN10()
		{
			return GRGEN_MODEL.@N10.CreateNode(this);
		}

		public GRGEN_MODEL.@N10 CreateNodeN10(string nodeName)
		{
			return GRGEN_MODEL.@N10.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Bat CreateNodeBat()
		{
			return GRGEN_MODEL.@Bat.CreateNode(this);
		}

		public GRGEN_MODEL.@Bat CreateNodeBat(string nodeName)
		{
			return GRGEN_MODEL.@Bat.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Pow CreateNodePow()
		{
			return GRGEN_MODEL.@Pow.CreateNode(this);
		}

		public GRGEN_MODEL.@Pow CreateNodePow(string nodeName)
		{
			return GRGEN_MODEL.@Pow.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@SLck CreateNodeSLck()
		{
			return GRGEN_MODEL.@SLck.CreateNode(this);
		}

		public GRGEN_MODEL.@SLck CreateNodeSLck(string nodeName)
		{
			return GRGEN_MODEL.@SLck.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@SLckRef CreateNodeSLckRef()
		{
			return GRGEN_MODEL.@SLckRef.CreateNode(this);
		}

		public GRGEN_MODEL.@SLckRef CreateNodeSLckRef(string nodeName)
		{
			return GRGEN_MODEL.@SLckRef.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Mvmt CreateNodeMvmt()
		{
			return GRGEN_MODEL.@Mvmt.CreateNode(this);
		}

		public GRGEN_MODEL.@Mvmt CreateNodeMvmt(string nodeName)
		{
			return GRGEN_MODEL.@Mvmt.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Token CreateNodeToken()
		{
			return GRGEN_MODEL.@Token.CreateNode(this);
		}

		public GRGEN_MODEL.@Token CreateNodeToken(string nodeName)
		{
			return GRGEN_MODEL.@Token.CreateNode(this, nodeName);
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
