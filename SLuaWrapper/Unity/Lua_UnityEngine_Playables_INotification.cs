﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Playables_INotification : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_id(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Playables.INotification self=(UnityEngine.Playables.INotification)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.id);
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
		getTypeTable(l,"UnityEngine.Playables.INotification");
		addMember(l,"id",get_id,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Playables.INotification));
	}
}
