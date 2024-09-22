using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_RO_PhotographMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"RO.PhotographMode");
		addMember(l,0,"SELFIE");
		addMember(l,1,"PHOTOGRAPHER");
		LuaDLL.lua_pop(l, 1);
	}
}
