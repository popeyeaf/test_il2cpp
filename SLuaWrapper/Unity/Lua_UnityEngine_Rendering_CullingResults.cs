﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_CullingResults : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults o;
			o=new UnityEngine.Rendering.CullingResults();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FillLightAndReflectionProbeIndices(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.ComputeBuffer))){
				UnityEngine.Rendering.CullingResults self;
				checkValueType(l,1,out self);
				UnityEngine.ComputeBuffer a1;
				checkType(l, 2, out a1);
				self.FillLightAndReflectionProbeIndices(a1);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.GraphicsBuffer))){
				UnityEngine.Rendering.CullingResults self;
				checkValueType(l,1,out self);
				UnityEngine.GraphicsBuffer a1;
				checkType(l, 2, out a1);
				self.FillLightAndReflectionProbeIndices(a1);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function FillLightAndReflectionProbeIndices to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLightIndexMap(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			Unity.Collections.Allocator a1;
			checkEnum(l,2,out a1);
			var ret=self.GetLightIndexMap(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetLightIndexMap(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			Unity.Collections.NativeArray<System.Int32> a1;
			checkValueType(l, 2, out a1);
			self.SetLightIndexMap(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetReflectionProbeIndexMap(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			Unity.Collections.Allocator a1;
			checkEnum(l,2,out a1);
			var ret=self.GetReflectionProbeIndexMap(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetReflectionProbeIndexMap(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			Unity.Collections.NativeArray<System.Int32> a1;
			checkValueType(l, 2, out a1);
			self.SetReflectionProbeIndexMap(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetShadowCasterBounds(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l, 2, out a1);
			UnityEngine.Bounds a2;
			var ret=self.GetShadowCasterBounds(a1,out a2);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ComputeSpotShadowMatricesAndCullingPrimitives(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l, 2, out a1);
			UnityEngine.Matrix4x4 a2;
			UnityEngine.Matrix4x4 a3;
			UnityEngine.Rendering.ShadowSplitData a4;
			var ret=self.ComputeSpotShadowMatricesAndCullingPrimitives(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ComputePointShadowMatricesAndCullingPrimitives(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l, 2, out a1);
			UnityEngine.CubemapFace a2;
			checkEnum(l,3,out a2);
			System.Single a3;
			checkType(l, 4, out a3);
			UnityEngine.Matrix4x4 a4;
			UnityEngine.Matrix4x4 a5;
			UnityEngine.Rendering.ShadowSplitData a6;
			var ret=self.ComputePointShadowMatricesAndCullingPrimitives(a1,a2,a3,out a4,out a5,out a6);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			pushValue(l,a5);
			pushValue(l,a6);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l, 2, out a1);
			System.Int32 a2;
			checkType(l, 3, out a2);
			System.Int32 a3;
			checkType(l, 4, out a3);
			UnityEngine.Vector3 a4;
			checkType(l, 5, out a4);
			System.Int32 a5;
			checkType(l, 6, out a5);
			System.Single a6;
			checkType(l, 7, out a6);
			UnityEngine.Matrix4x4 a7;
			UnityEngine.Matrix4x4 a8;
			UnityEngine.Rendering.ShadowSplitData a9;
			var ret=self.ComputeDirectionalShadowMatricesAndCullingPrimitives(a1,a2,a3,a4,a5,a6,out a7,out a8,out a9);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a7);
			pushValue(l,a8);
			pushValue(l,a9);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Equality(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults a1;
			checkValueType(l, 1, out a1);
			UnityEngine.Rendering.CullingResults a2;
			checkValueType(l, 2, out a2);
			var ret=(a1==a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Inequality(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults a1;
			checkValueType(l, 1, out a1);
			UnityEngine.Rendering.CullingResults a2;
			checkValueType(l, 2, out a2);
			var ret=(a1!=a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_visibleLights(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.visibleLights);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_visibleOffscreenVertexLights(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.visibleOffscreenVertexLights);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_visibleReflectionProbes(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.visibleReflectionProbes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightIndexCount(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lightIndexCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_reflectionProbeIndexCount(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.reflectionProbeIndexCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightAndReflectionProbeIndexCount(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rendering.CullingResults self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lightAndReflectionProbeIndexCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.CullingResults");
		addMember(l,FillLightAndReflectionProbeIndices);
		addMember(l,GetLightIndexMap);
		addMember(l,SetLightIndexMap);
		addMember(l,GetReflectionProbeIndexMap);
		addMember(l,SetReflectionProbeIndexMap);
		addMember(l,GetShadowCasterBounds);
		addMember(l,ComputeSpotShadowMatricesAndCullingPrimitives);
		addMember(l,ComputePointShadowMatricesAndCullingPrimitives);
		addMember(l,ComputeDirectionalShadowMatricesAndCullingPrimitives);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,"visibleLights",get_visibleLights,null,true);
		addMember(l,"visibleOffscreenVertexLights",get_visibleOffscreenVertexLights,null,true);
		addMember(l,"visibleReflectionProbes",get_visibleReflectionProbes,null,true);
		addMember(l,"lightIndexCount",get_lightIndexCount,null,true);
		addMember(l,"reflectionProbeIndexCount",get_reflectionProbeIndexCount,null,true);
		addMember(l,"lightAndReflectionProbeIndexCount",get_lightAndReflectionProbeIndexCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.CullingResults),typeof(System.ValueType));
	}
}
