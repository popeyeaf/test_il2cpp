﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Hash128 : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Hash128 o;
			if(argc==5){
				System.UInt32 a1;
				checkType(l, 2, out a1);
				System.UInt32 a2;
				checkType(l, 3, out a2);
				System.UInt32 a3;
				checkType(l, 4, out a3);
				System.UInt32 a4;
				checkType(l, 5, out a4);
				o=new UnityEngine.Hash128(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==3){
				System.UInt64 a1;
				checkType(l, 2, out a1);
				System.UInt64 a2;
				checkType(l, 3, out a2);
				o=new UnityEngine.Hash128(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==0){
				o=new UnityEngine.Hash128();
				pushValue(l,true);
				pushObject(l,o);
				return 2;
			}
			return error(l,"New object failed.");
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
	static public int CompareTo(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Hash128))){
				UnityEngine.Hash128 self;
				checkValueType(l,1,out self);
				UnityEngine.Hash128 a1;
				checkValueType(l, 2, out a1);
				var ret=self.CompareTo(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Object))){
				UnityEngine.Hash128 self;
				checkValueType(l,1,out self);
				System.Object a1;
				checkType(l, 2, out a1);
				var ret=self.CompareTo(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function CompareTo to call");
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
	/*[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public unsafe int Append(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Hash128 self;
				checkValueType(l,1,out self);
				System.String a1;
				checkType(l, 2, out a1);
				self.Append(a1);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(int))){
				UnityEngine.Hash128 self;
				checkValueType(l,1,out self);
				System.Int32 a1;
				checkType(l, 2, out a1);
				self.Append(a1);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(float))){
				UnityEngine.Hash128 self;
				checkValueType(l,1,out self);
				System.Single a1;
				checkType(l, 2, out a1);
				self.Append(a1);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Hash128 self;
				checkValueType(l,1,out self);
				IntPtr tempPtr;
				checkType(l, 2, out tempPtr);
				void* a1 = (void*)tempPtr;
				System.UInt64 a2;
				checkType(l, 3, out a2);
				self.Append(a1,a2);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function Append to call");
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
	}*/
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Parse_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.String a1;
			checkType(l, 1, out a1);
			var ret=UnityEngine.Hash128.Parse(a1);
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
	/*[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public unsafe int Compute_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l, 1, out a1);
				var ret=UnityEngine.Hash128.Compute(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l, 1, out a1);
				var ret=UnityEngine.Hash128.Compute(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float))){
				System.Single a1;
				checkType(l, 1, out a1);
				var ret=UnityEngine.Hash128.Compute(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				IntPtr tempPtr;
				checkType(l, 1, out tempPtr);
				void* a1 = (void*)tempPtr;
				System.UInt64 a2;
				checkType(l, 2, out a2);
				var ret=UnityEngine.Hash128.Compute(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function Compute to call");
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
	}*/
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Equality(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Hash128 a1;
			checkValueType(l, 1, out a1);
			UnityEngine.Hash128 a2;
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
			UnityEngine.Hash128 a1;
			checkValueType(l, 1, out a1);
			UnityEngine.Hash128 a2;
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
	static public int op_LessThan(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Hash128 a1;
			checkValueType(l, 1, out a1);
			UnityEngine.Hash128 a2;
			checkValueType(l, 2, out a2);
			var ret=(a1<a2);
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
	static public int op_GreaterThan(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Hash128 a1;
			checkValueType(l, 1, out a1);
			UnityEngine.Hash128 a2;
			checkValueType(l, 2, out a2);
			var ret=(a2<a1);
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
	static public int get_isValid(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Hash128 self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isValid);
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
		getTypeTable(l,"UnityEngine.Hash128");
		addMember(l,CompareTo);
		//addMember(l,Append);
		addMember(l,Parse_s);
		//addMember(l,Compute_s);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,op_LessThan);
		addMember(l,op_GreaterThan);
		addMember(l,"isValid",get_isValid,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Hash128),typeof(System.ValueType));
	}
}
