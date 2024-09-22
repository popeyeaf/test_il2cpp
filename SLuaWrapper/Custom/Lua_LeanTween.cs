﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_LeanTween : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Update(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			LeanTween self=(LeanTween)checkSelf(l);
			self.Update();
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
	static public int OnLevelWasLoaded(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			LeanTween self=(LeanTween)checkSelf(l);
			System.Int32 a1;
			checkType(l, 2, out a1);
			self.OnLevelWasLoaded(a1);
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
	static public int init_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==0){
				LeanTween.init();
				pushValue(l,true);
				return 1;
			}
			else if(argc==1){
				System.Int32 a1;
				checkType(l, 1, out a1);
				LeanTween.init(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function init to call");
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
	static public int reset_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			LeanTween.reset();
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
	static public int CancelAll_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			LeanTween.CancelAll();
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
	static public int update_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			LeanTween.update();
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
	static public int removeTween_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 a1;
			checkType(l, 1, out a1);
			LeanTween.removeTween(a1);
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
	static public int add_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Vector3[] a1;
			checkArray(l, 1, out a1);
			UnityEngine.Vector3 a2;
			checkType(l, 2, out a2);
			var ret=LeanTween.add(a1,a2);
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
	static public int closestRot_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Single a1;
			checkType(l, 1, out a1);
			System.Single a2;
			checkType(l, 2, out a2);
			var ret=LeanTween.closestRot(a1,a2);
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
	static public int cancel_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				LeanTween.cancel(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(int))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Int32 a2;
				checkType(l, 2, out a2);
				LeanTween.cancel(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(int))){
				LTRect a1;
				checkType(l, 1, out a1);
				System.Int32 a2;
				checkType(l, 2, out a2);
				LeanTween.cancel(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function cancel to call");
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
	static public int description_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 a1;
			checkType(l, 1, out a1);
			var ret=LeanTween.description(a1);
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
	static public int pause_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l, 1, out a1);
				LeanTween.pause(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				LeanTween.pause(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Int32 a2;
				checkType(l, 2, out a2);
				LeanTween.pause(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function pause to call");
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
	static public int resume_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l, 1, out a1);
				LeanTween.resume(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				LeanTween.resume(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Int32 a2;
				checkType(l, 2, out a2);
				LeanTween.resume(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function resume to call");
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
	static public int isTweening_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				var ret=LeanTween.isTweening(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l, 1, out a1);
				var ret=LeanTween.isTweening(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect))){
				LTRect a1;
				checkType(l, 1, out a1);
				var ret=LeanTween.isTweening(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function isTweening to call");
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
	static public int drawBezierPath_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Vector3 a1;
			checkType(l, 1, out a1);
			UnityEngine.Vector3 a2;
			checkType(l, 2, out a2);
			UnityEngine.Vector3 a3;
			checkType(l, 3, out a3);
			UnityEngine.Vector3 a4;
			checkType(l, 4, out a4);
			LeanTween.drawBezierPath(a1,a2,a3,a4);
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
	static public int logError_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.String a1;
			checkType(l, 1, out a1);
			var ret=LeanTween.logError(a1);
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
	static public int options_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==0){
				var ret=LeanTween.options();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==1){
				LTDescr a1;
				checkType(l, 1, out a1);
				var ret=LeanTween.options(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function options to call");
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
	static public int alpha_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.alpha(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(float),typeof(float))){
				LTRect a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.alpha(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				LTRect a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.alpha(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(float),typeof(float),typeof(object[]))){
				LTRect a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.alpha(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.alpha(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.alpha(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function alpha to call");
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
	static public int alphaVertex_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.GameObject a1;
			checkType(l, 1, out a1);
			System.Single a2;
			checkType(l, 2, out a2);
			System.Single a3;
			checkType(l, 3, out a3);
			var ret=LeanTween.alphaVertex(a1,a2,a3);
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
	static public int delayedCall_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(float),typeof(System.Action))){
				System.Single a1;
				checkType(l, 1, out a1);
				System.Action a2;
				checkDelegate(l,2,out a2);
				var ret=LeanTween.delayedCall(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(System.Action<object>))){
				System.Single a1;
				checkType(l, 1, out a1);
				System.Action<System.Object> a2;
				checkDelegate(l,2,out a2);
				var ret=LeanTween.delayedCall(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(System.Action))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Action a3;
				checkDelegate(l,3,out a3);
				var ret=LeanTween.delayedCall(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(System.Action<object>))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Action<System.Object> a3;
				checkDelegate(l,3,out a3);
				var ret=LeanTween.delayedCall(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(string),typeof(System.Collections.Hashtable))){
				System.Single a1;
				checkType(l, 1, out a1);
				System.String a2;
				checkType(l, 2, out a2);
				System.Collections.Hashtable a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.delayedCall(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(System.Action),typeof(object[]))){
				System.Single a1;
				checkType(l, 1, out a1);
				System.Action a2;
				checkDelegate(l,2,out a2);
				System.Object[] a3;
				checkArray(l, 3, out a3);
				var ret=LeanTween.delayedCall(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(string),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.String a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.delayedCall(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(System.Action),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Action a3;
				checkDelegate(l,3,out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.delayedCall(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(string),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.String a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.delayedCall(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(System.Action),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Action a3;
				checkDelegate(l,3,out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.delayedCall(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(System.Action<object>),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Action<System.Object> a3;
				checkDelegate(l,3,out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.delayedCall(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function delayedCall to call");
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
	static public int destroyAfter_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			LTRect a1;
			checkType(l, 1, out a1);
			System.Single a2;
			checkType(l, 2, out a2);
			var ret=LeanTween.destroyAfter(a1,a2);
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
	static public int move_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.move(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector2),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector2 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.move(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3[]),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3[] a2;
				checkArray(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.move(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(UnityEngine.Vector2),typeof(float))){
				LTRect a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector2 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.move(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.move(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.move(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3[]),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3[] a2;
				checkArray(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.move(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3[]),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3[] a2;
				checkArray(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.move(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(UnityEngine.Vector2),typeof(float),typeof(System.Collections.Hashtable))){
				LTRect a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector2 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.move(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(UnityEngine.Vector3),typeof(float),typeof(object[]))){
				LTRect a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.move(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function move to call");
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
	static public int moveSpline_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.GameObject a1;
			checkType(l, 1, out a1);
			UnityEngine.Vector3[] a2;
			checkArray(l, 2, out a2);
			System.Single a3;
			checkType(l, 3, out a3);
			var ret=LeanTween.moveSpline(a1,a2,a3);
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
	static public int moveSplineLocal_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.GameObject a1;
			checkType(l, 1, out a1);
			UnityEngine.Vector3[] a2;
			checkArray(l, 2, out a2);
			System.Single a3;
			checkType(l, 3, out a3);
			var ret=LeanTween.moveSplineLocal(a1,a2,a3);
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
	static public int moveMargin_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			LTRect a1;
			checkType(l, 1, out a1);
			UnityEngine.Vector2 a2;
			checkType(l, 2, out a2);
			System.Single a3;
			checkType(l, 3, out a3);
			var ret=LeanTween.moveMargin(a1,a2,a3);
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
	static public int moveX_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.moveX(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.moveX(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.moveX(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function moveX to call");
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
	static public int moveY_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.moveY(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.moveY(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.moveY(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function moveY to call");
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
	static public int moveZ_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.moveZ(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.moveZ(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.moveZ(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function moveZ to call");
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
	static public int moveLocal_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.moveLocal(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3[]),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3[] a2;
				checkArray(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.moveLocal(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.moveLocal(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.moveLocal(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3[]),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3[] a2;
				checkArray(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.moveLocal(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3[]),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3[] a2;
				checkArray(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.moveLocal(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function moveLocal to call");
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
	static public int moveLocalX_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.moveLocalX(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.moveLocalX(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.moveLocalX(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function moveLocalX to call");
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
	static public int moveLocalY_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.moveLocalY(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.moveLocalY(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.moveLocalY(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function moveLocalY to call");
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
	static public int moveLocalZ_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.moveLocalZ(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.moveLocalZ(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.moveLocalZ(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function moveLocalZ to call");
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
	static public int rotate_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.rotate(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(float),typeof(float))){
				LTRect a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.rotate(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.rotate(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.rotate(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				LTRect a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.rotate(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(float),typeof(float),typeof(object[]))){
				LTRect a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.rotate(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function rotate to call");
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
	static public int rotateLocal_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.rotateLocal(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.rotateLocal(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.rotateLocal(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function rotateLocal to call");
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
	static public int rotateX_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.rotateX(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.rotateX(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.rotateX(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function rotateX to call");
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
	static public int rotateY_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.rotateY(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.rotateY(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.rotateY(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function rotateY to call");
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
	static public int rotateZ_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.rotateZ(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.rotateZ(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.rotateZ(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function rotateZ to call");
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
	static public int rotateAround_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.rotateAround(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Collections.Hashtable a5;
				checkType(l, 5, out a5);
				var ret=LeanTween.rotateAround(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Object[] a5;
				checkArray(l, 5, out a5);
				var ret=LeanTween.rotateAround(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function rotateAround to call");
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
	static public int scale_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.scale(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(UnityEngine.Vector2),typeof(float))){
				LTRect a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector2 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.scale(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.scale(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(UnityEngine.Vector3),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.scale(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(UnityEngine.Vector2),typeof(float),typeof(System.Collections.Hashtable))){
				LTRect a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector2 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.scale(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(LTRect),typeof(UnityEngine.Vector2),typeof(float),typeof(object[]))){
				LTRect a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector2 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.scale(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function scale to call");
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
	static public int scaleX_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.scaleX(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.scaleX(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.scaleX(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function scaleX to call");
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
	static public int scaleY_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.scaleY(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.scaleY(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.scaleY(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function scaleY to call");
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
	static public int scaleZ_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=LeanTween.scaleZ(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Collections.Hashtable a4;
				checkType(l, 4, out a4);
				var ret=LeanTween.scaleZ(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Object[] a4;
				checkArray(l, 4, out a4);
				var ret=LeanTween.scaleZ(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function scaleZ to call");
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
	static public int value_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<System.Single>),typeof(float),typeof(float),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<System.Single> a2;
				checkDelegate(l,2,out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				var ret=LeanTween.value(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<UnityEngine.Vector3>),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<UnityEngine.Vector3> a2;
				checkDelegate(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l, 3, out a3);
				UnityEngine.Vector3 a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				var ret=LeanTween.value(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<System.Single,object>),typeof(float),typeof(float),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<System.Single,System.Object> a2;
				checkDelegate(l,2,out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				var ret=LeanTween.value(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(float),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				System.String a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Collections.Hashtable a5;
				checkType(l, 5, out a5);
				var ret=LeanTween.value(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(string),typeof(float),typeof(float),typeof(float))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.String a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				var ret=LeanTween.value(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<UnityEngine.Vector3,System.Collections.Hashtable>),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<UnityEngine.Vector3,System.Collections.Hashtable> a2;
				checkDelegate(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l, 3, out a3);
				UnityEngine.Vector3 a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Collections.Hashtable a6;
				checkType(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<UnityEngine.Vector3>),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<UnityEngine.Vector3> a2;
				checkDelegate(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l, 3, out a3);
				UnityEngine.Vector3 a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Collections.Hashtable a6;
				checkType(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(string),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.String a2;
				checkType(l, 2, out a2);
				UnityEngine.Vector3 a3;
				checkType(l, 3, out a3);
				UnityEngine.Vector3 a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Object[] a6;
				checkArray(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(string),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.String a2;
				checkType(l, 2, out a2);
				UnityEngine.Vector3 a3;
				checkType(l, 3, out a3);
				UnityEngine.Vector3 a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Collections.Hashtable a6;
				checkType(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<System.Single,System.Collections.Hashtable>),typeof(float),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<System.Single,System.Collections.Hashtable> a2;
				checkDelegate(l,2,out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Collections.Hashtable a6;
				checkType(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(string),typeof(float),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.String a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Collections.Hashtable a6;
				checkType(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<UnityEngine.Vector3>),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<UnityEngine.Vector3> a2;
				checkDelegate(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l, 3, out a3);
				UnityEngine.Vector3 a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Object[] a6;
				checkArray(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<System.Single,System.Collections.Hashtable>),typeof(float),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<System.Single,System.Collections.Hashtable> a2;
				checkDelegate(l,2,out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Object[] a6;
				checkArray(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<System.Single>),typeof(float),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<System.Single> a2;
				checkDelegate(l,2,out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Object[] a6;
				checkArray(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(string),typeof(float),typeof(float),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.String a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Object[] a6;
				checkArray(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<System.Single>),typeof(float),typeof(float),typeof(float),typeof(System.Collections.Hashtable))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<System.Single> a2;
				checkDelegate(l,2,out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Collections.Hashtable a6;
				checkType(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Action<UnityEngine.Vector3,System.Collections.Hashtable>),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(object[]))){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Action<UnityEngine.Vector3,System.Collections.Hashtable> a2;
				checkDelegate(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l, 3, out a3);
				UnityEngine.Vector3 a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Object[] a6;
				checkArray(l, 6, out a6);
				var ret=LeanTween.value(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function value to call");
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
	static public int delayedSound_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.AudioClip a1;
			checkType(l, 1, out a1);
			UnityEngine.Vector3 a2;
			checkType(l, 2, out a2);
			System.Single a3;
			checkType(l, 3, out a3);
			var ret=LeanTween.delayedSound(a1,a2,a3);
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
	static public int h_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Object[] a1;
			checkArray(l, 1, out a1);
			var ret=LeanTween.h(a1);
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
	static public int addListener_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Int32 a1;
				checkType(l, 1, out a1);
				System.Action<LTEvent> a2;
				checkDelegate(l,2,out a2);
				LeanTween.addListener(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Int32 a2;
				checkType(l, 2, out a2);
				System.Action<LTEvent> a3;
				checkDelegate(l,3,out a3);
				LeanTween.addListener(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function addListener to call");
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
	static public int removeListener_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Int32 a1;
				checkType(l, 1, out a1);
				System.Action<LTEvent> a2;
				checkDelegate(l,2,out a2);
				var ret=LeanTween.removeListener(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l, 1, out a1);
				System.Int32 a2;
				checkType(l, 2, out a2);
				System.Action<LTEvent> a3;
				checkDelegate(l,3,out a3);
				var ret=LeanTween.removeListener(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function removeListener to call");
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
	static public int dispatchEvent_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Int32 a1;
				checkType(l, 1, out a1);
				LeanTween.dispatchEvent(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Int32 a1;
				checkType(l, 1, out a1);
				System.Object a2;
				checkType(l, 2, out a2);
				LeanTween.dispatchEvent(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function dispatchEvent to call");
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
	static public int get_throwErrors(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			pushValue(l,true);
			pushValue(l,LeanTween.throwErrors);
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
	static public int set_throwErrors(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Boolean v;
			checkType(l,2,out v);
			LeanTween.throwErrors=v;
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
	static public int get_startSearch(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			pushValue(l,true);
			pushValue(l,LeanTween.startSearch);
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
	static public int set_startSearch(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 v;
			checkType(l,2,out v);
			LeanTween.startSearch=v;
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
	static public int get_descr(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			pushValue(l,true);
			pushValue(l,LeanTween.descr);
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
	static public int set_descr(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			LTDescr v;
			checkType(l,2,out v);
			LeanTween.descr=v;
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
	static public int get_EVENTS_MAX(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			pushValue(l,true);
			pushValue(l,LeanTween.EVENTS_MAX);
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
	static public int set_EVENTS_MAX(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 v;
			checkType(l,2,out v);
			LeanTween.EVENTS_MAX=v;
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
	static public int get_LISTENERS_MAX(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			pushValue(l,true);
			pushValue(l,LeanTween.LISTENERS_MAX);
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
	static public int set_LISTENERS_MAX(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 v;
			checkType(l,2,out v);
			LeanTween.LISTENERS_MAX=v;
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
	static public int get_tweenEmpty(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			pushValue(l,true);
			pushValue(l,LeanTween.tweenEmpty);
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
		getTypeTable(l,"LeanTween");
		addMember(l,Update);
		addMember(l,OnLevelWasLoaded);
		addMember(l,init_s);
		addMember(l,reset_s);
		addMember(l,CancelAll_s);
		addMember(l,update_s);
		addMember(l,removeTween_s);
		addMember(l,add_s);
		addMember(l,closestRot_s);
		addMember(l,cancel_s);
		addMember(l,description_s);
		addMember(l,pause_s);
		addMember(l,resume_s);
		addMember(l,isTweening_s);
		addMember(l,drawBezierPath_s);
		addMember(l,logError_s);
		addMember(l,options_s);
		addMember(l,alpha_s);
		addMember(l,alphaVertex_s);
		addMember(l,delayedCall_s);
		addMember(l,destroyAfter_s);
		addMember(l,move_s);
		addMember(l,moveSpline_s);
		addMember(l,moveSplineLocal_s);
		addMember(l,moveMargin_s);
		addMember(l,moveX_s);
		addMember(l,moveY_s);
		addMember(l,moveZ_s);
		addMember(l,moveLocal_s);
		addMember(l,moveLocalX_s);
		addMember(l,moveLocalY_s);
		addMember(l,moveLocalZ_s);
		addMember(l,rotate_s);
		addMember(l,rotateLocal_s);
		addMember(l,rotateX_s);
		addMember(l,rotateY_s);
		addMember(l,rotateZ_s);
		addMember(l,rotateAround_s);
		addMember(l,scale_s);
		addMember(l,scaleX_s);
		addMember(l,scaleY_s);
		addMember(l,scaleZ_s);
		addMember(l,value_s);
		addMember(l,delayedSound_s);
		addMember(l,h_s);
		addMember(l,addListener_s);
		addMember(l,removeListener_s);
		addMember(l,dispatchEvent_s);
		addMember(l,"throwErrors",get_throwErrors,set_throwErrors,false);
		addMember(l,"startSearch",get_startSearch,set_startSearch,false);
		addMember(l,"descr",get_descr,set_descr,false);
		addMember(l,"EVENTS_MAX",get_EVENTS_MAX,set_EVENTS_MAX,false);
		addMember(l,"LISTENERS_MAX",get_LISTENERS_MAX,set_LISTENERS_MAX,false);
		addMember(l,"tweenEmpty",get_tweenEmpty,null,false);
		createTypeMetatable(l,null, typeof(LeanTween),typeof(UnityEngine.MonoBehaviour));
	}
}
