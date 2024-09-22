﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Animations_AnimationSceneHandleUtility : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadInts_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Animations.AnimationStream a1;
			checkValueType(l, 1, out a1);
			Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> a2;
			checkValueType(l, 2, out a2);
			Unity.Collections.NativeArray<System.Int32> a3;
			checkValueType(l, 3, out a3);
			UnityEngine.Animations.AnimationSceneHandleUtility.ReadInts(a1,a2,a3);
			pushValue(l,true);
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
	static public int ReadFloats_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Animations.AnimationStream a1;
			checkValueType(l, 1, out a1);
			Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> a2;
			checkValueType(l, 2, out a2);
			Unity.Collections.NativeArray<System.Single> a3;
			checkValueType(l, 3, out a3);
			UnityEngine.Animations.AnimationSceneHandleUtility.ReadFloats(a1,a2,a3);
			pushValue(l,true);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Animations.AnimationSceneHandleUtility");
		addMember(l,ReadInts_s);
		addMember(l,ReadFloats_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Animations.AnimationSceneHandleUtility));
	}
}
