﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_EventSystems_IPointerMoveHandler : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnPointerMove(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.EventSystems.IPointerMoveHandler self=(UnityEngine.EventSystems.IPointerMoveHandler)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l, 2, out a1);
			self.OnPointerMove(a1);
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
		getTypeTable(l,"UnityEngine.EventSystems.IPointerMoveHandler");
		addMember(l,OnPointerMove);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.IPointerMoveHandler));
	}
}
