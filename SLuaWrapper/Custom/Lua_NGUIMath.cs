﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_NGUIMath : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Lerp_s(IntPtr l) {
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
			System.Single a3;
			checkType(l, 3, out a3);
			var ret=NGUIMath.Lerp(a1,a2,a3);
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
	static public int ClampIndex_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 a1;
			checkType(l, 1, out a1);
			System.Int32 a2;
			checkType(l, 2, out a2);
			var ret=NGUIMath.ClampIndex(a1,a2);
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
	static public int RepeatIndex_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 a1;
			checkType(l, 1, out a1);
			System.Int32 a2;
			checkType(l, 2, out a2);
			var ret=NGUIMath.RepeatIndex(a1,a2);
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
	static public int WrapAngle_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Single a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.WrapAngle(a1);
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
	static public int Wrap01_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Single a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.Wrap01(a1);
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
	static public int HexToDecimal_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Char a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.HexToDecimal(a1);
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
	static public int DecimalToHexChar_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.DecimalToHexChar(a1);
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
	static public int DecimalToHex8_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.DecimalToHex8(a1);
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
	static public int DecimalToHex24_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.DecimalToHex24(a1);
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
	static public int DecimalToHex32_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.DecimalToHex32(a1);
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
	static public int ColorToInt_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Color a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.ColorToInt(a1);
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
	static public int IntToColor_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.IntToColor(a1);
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
	static public int IntToBinary_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Int32 a1;
			checkType(l, 1, out a1);
			System.Int32 a2;
			checkType(l, 2, out a2);
			var ret=NGUIMath.IntToBinary(a1,a2);
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
	static public int HexToColor_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.UInt32 a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.HexToColor(a1);
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
	static public int ConvertToTexCoords_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rect a1;
			checkValueType(l, 1, out a1);
			System.Int32 a2;
			checkType(l, 2, out a2);
			System.Int32 a3;
			checkType(l, 3, out a3);
			var ret=NGUIMath.ConvertToTexCoords(a1,a2,a3);
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
	static public int ConvertToPixels_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Rect a1;
			checkValueType(l, 1, out a1);
			System.Int32 a2;
			checkType(l, 2, out a2);
			System.Int32 a3;
			checkType(l, 3, out a3);
			System.Boolean a4;
			checkType(l, 4, out a4);
			var ret=NGUIMath.ConvertToPixels(a1,a2,a3,a4);
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
	static public int MakePixelPerfect_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Rect a1;
				checkValueType(l, 1, out a1);
				var ret=NGUIMath.MakePixelPerfect(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Rect a1;
				checkValueType(l, 1, out a1);
				System.Int32 a2;
				checkType(l, 2, out a2);
				System.Int32 a3;
				checkType(l, 3, out a3);
				var ret=NGUIMath.MakePixelPerfect(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function MakePixelPerfect to call");
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
	static public int ConstrainRect_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Vector2 a1;
			checkType(l, 1, out a1);
			UnityEngine.Vector2 a2;
			checkType(l, 2, out a2);
			UnityEngine.Vector2 a3;
			checkType(l, 3, out a3);
			UnityEngine.Vector2 a4;
			checkType(l, 4, out a4);
			var ret=NGUIMath.ConstrainRect(a1,a2,a3,a4);
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
	static public int CalculateAbsoluteWidgetBounds_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Transform a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.CalculateAbsoluteWidgetBounds(a1);
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
	static public int CalculateRelativeWidgetBounds_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform a1;
				checkType(l, 1, out a1);
				var ret=NGUIMath.CalculateRelativeWidgetBounds(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Transform),typeof(bool))){
				UnityEngine.Transform a1;
				checkType(l, 1, out a1);
				System.Boolean a2;
				checkType(l, 2, out a2);
				var ret=NGUIMath.CalculateRelativeWidgetBounds(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Transform),typeof(UnityEngine.Transform))){
				UnityEngine.Transform a1;
				checkType(l, 1, out a1);
				UnityEngine.Transform a2;
				checkType(l, 2, out a2);
				var ret=NGUIMath.CalculateRelativeWidgetBounds(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Transform a1;
				checkType(l, 1, out a1);
				UnityEngine.Transform a2;
				checkType(l, 2, out a2);
				System.Boolean a3;
				checkType(l, 3, out a3);
				System.Boolean a4;
				checkType(l, 4, out a4);
				var ret=NGUIMath.CalculateRelativeWidgetBounds(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function CalculateRelativeWidgetBounds to call");
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
	static public int SpringDampen_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=NGUIMath.SpringDampen(ref a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a1);
				return 3;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector2),typeof(float),typeof(float))){
				UnityEngine.Vector2 a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				var ret=NGUIMath.SpringDampen(ref a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a1);
				return 3;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function SpringDampen to call");
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
	static public int SpringLerp_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Single a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				var ret=NGUIMath.SpringLerp(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(float),typeof(float))){
				System.Single a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				var ret=NGUIMath.SpringLerp(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(float),typeof(float))){
				UnityEngine.Vector2 a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector2 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				var ret=NGUIMath.SpringLerp(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				var ret=NGUIMath.SpringLerp(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Quaternion),typeof(UnityEngine.Quaternion),typeof(float),typeof(float))){
				UnityEngine.Quaternion a1;
				checkType(l, 1, out a1);
				UnityEngine.Quaternion a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				var ret=NGUIMath.SpringLerp(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function SpringLerp to call");
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
	static public int RotateTowards_s(IntPtr l) {
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
			System.Single a3;
			checkType(l, 3, out a3);
			var ret=NGUIMath.RotateTowards(a1,a2,a3);
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
	static public int DistanceToRectangle_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector2[] a1;
				checkArray(l, 1, out a1);
				UnityEngine.Vector2 a2;
				checkType(l, 2, out a2);
				var ret=NGUIMath.DistanceToRectangle(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Vector3[] a1;
				checkArray(l, 1, out a1);
				UnityEngine.Vector2 a2;
				checkType(l, 2, out a2);
				UnityEngine.Camera a3;
				checkType(l, 3, out a3);
				var ret=NGUIMath.DistanceToRectangle(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function DistanceToRectangle to call");
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
	static public int GetPivotOffset_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UIWidget.Pivot a1;
			checkEnum(l,1,out a1);
			var ret=NGUIMath.GetPivotOffset(a1);
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
	static public int GetPivot_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Vector2 a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.GetPivot(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
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
	static public int MoveWidget_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UIRect a1;
			checkType(l, 1, out a1);
			System.Single a2;
			checkType(l, 2, out a2);
			System.Single a3;
			checkType(l, 3, out a3);
			NGUIMath.MoveWidget(a1,a2,a3);
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
	static public int MoveRect_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UIRect a1;
			checkType(l, 1, out a1);
			System.Single a2;
			checkType(l, 2, out a2);
			System.Single a3;
			checkType(l, 3, out a3);
			NGUIMath.MoveRect(a1,a2,a3);
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
	static public int ResizeWidget_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UIWidget a1;
				checkType(l, 1, out a1);
				UIWidget.Pivot a2;
				checkEnum(l,2,out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Int32 a5;
				checkType(l, 5, out a5);
				System.Int32 a6;
				checkType(l, 6, out a6);
				NGUIMath.ResizeWidget(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(argc==8){
				UIWidget a1;
				checkType(l, 1, out a1);
				UIWidget.Pivot a2;
				checkEnum(l,2,out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Int32 a5;
				checkType(l, 5, out a5);
				System.Int32 a6;
				checkType(l, 6, out a6);
				System.Int32 a7;
				checkType(l, 7, out a7);
				System.Int32 a8;
				checkType(l, 8, out a8);
				NGUIMath.ResizeWidget(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function ResizeWidget to call");
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
	static public int AdjustWidget_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UIWidget a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				NGUIMath.AdjustWidget(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(argc==7){
				UIWidget a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Int32 a6;
				checkType(l, 6, out a6);
				System.Int32 a7;
				checkType(l, 7, out a7);
				NGUIMath.AdjustWidget(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				return 1;
			}
			else if(argc==9){
				UIWidget a1;
				checkType(l, 1, out a1);
				System.Single a2;
				checkType(l, 2, out a2);
				System.Single a3;
				checkType(l, 3, out a3);
				System.Single a4;
				checkType(l, 4, out a4);
				System.Single a5;
				checkType(l, 5, out a5);
				System.Int32 a6;
				checkType(l, 6, out a6);
				System.Int32 a7;
				checkType(l, 7, out a7);
				System.Int32 a8;
				checkType(l, 8, out a8);
				System.Int32 a9;
				checkType(l, 9, out a9);
				NGUIMath.AdjustWidget(a1,a2,a3,a4,a5,a6,a7,a8,a9);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function AdjustWidget to call");
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
	static public int AdjustByDPI_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			System.Single a1;
			checkType(l, 1, out a1);
			var ret=NGUIMath.AdjustByDPI(a1);
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
	static public int ScreenToPixels_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Vector2 a1;
			checkType(l, 1, out a1);
			UnityEngine.Transform a2;
			checkType(l, 2, out a2);
			var ret=NGUIMath.ScreenToPixels(a1,a2);
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
	static public int ScreenToParentPixels_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Vector2 a1;
			checkType(l, 1, out a1);
			UnityEngine.Transform a2;
			checkType(l, 2, out a2);
			var ret=NGUIMath.ScreenToParentPixels(a1,a2);
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
	static public int WorldToLocalPoint_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Vector3 a1;
			checkType(l, 1, out a1);
			UnityEngine.Camera a2;
			checkType(l, 2, out a2);
			UnityEngine.Camera a3;
			checkType(l, 3, out a3);
			UnityEngine.Transform a4;
			checkType(l, 4, out a4);
			var ret=NGUIMath.WorldToLocalPoint(a1,a2,a3,a4);
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
	static public int OverlayPosition_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Transform a1;
				checkType(l, 1, out a1);
				UnityEngine.Transform a2;
				checkType(l, 2, out a2);
				NGUIMath.OverlayPosition(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Transform a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				UnityEngine.Camera a3;
				checkType(l, 3, out a3);
				NGUIMath.OverlayPosition(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Transform a1;
				checkType(l, 1, out a1);
				UnityEngine.Vector3 a2;
				checkType(l, 2, out a2);
				UnityEngine.Camera a3;
				checkType(l, 3, out a3);
				UnityEngine.Camera a4;
				checkType(l, 4, out a4);
				NGUIMath.OverlayPosition(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function OverlayPosition to call");
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
		getTypeTable(l,"NGUIMath");
		addMember(l,Lerp_s);
		addMember(l,ClampIndex_s);
		addMember(l,RepeatIndex_s);
		addMember(l,WrapAngle_s);
		addMember(l,Wrap01_s);
		addMember(l,HexToDecimal_s);
		addMember(l,DecimalToHexChar_s);
		addMember(l,DecimalToHex8_s);
		addMember(l,DecimalToHex24_s);
		addMember(l,DecimalToHex32_s);
		addMember(l,ColorToInt_s);
		addMember(l,IntToColor_s);
		addMember(l,IntToBinary_s);
		addMember(l,HexToColor_s);
		addMember(l,ConvertToTexCoords_s);
		addMember(l,ConvertToPixels_s);
		addMember(l,MakePixelPerfect_s);
		addMember(l,ConstrainRect_s);
		addMember(l,CalculateAbsoluteWidgetBounds_s);
		addMember(l,CalculateRelativeWidgetBounds_s);
		addMember(l,SpringDampen_s);
		addMember(l,SpringLerp_s);
		addMember(l,RotateTowards_s);
		addMember(l,DistanceToRectangle_s);
		addMember(l,GetPivotOffset_s);
		addMember(l,GetPivot_s);
		addMember(l,MoveWidget_s);
		addMember(l,MoveRect_s);
		addMember(l,ResizeWidget_s);
		addMember(l,AdjustWidget_s);
		addMember(l,AdjustByDPI_s);
		addMember(l,ScreenToPixels_s);
		addMember(l,ScreenToParentPixels_s);
		addMember(l,WorldToLocalPoint_s);
		addMember(l,OverlayPosition_s);
		createTypeMetatable(l,null, typeof(NGUIMath));
	}
}
