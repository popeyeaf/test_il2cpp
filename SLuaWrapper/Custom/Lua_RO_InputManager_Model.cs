using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_RO_InputManager_Model : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"RO.InputManager.Model");
		addMember(l,0,"DEFAULT");
		addMember(l,1,"PHOTOGRAPH");
		LuaDLL.lua_pop(l, 1);
	}
}
