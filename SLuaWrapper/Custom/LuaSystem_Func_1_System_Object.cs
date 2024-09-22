﻿
using System;
using System.Collections.Generic;
namespace SLua
{
    public partial class LuaDelegation : LuaObject
    {

        static internal System.Object Lua_System_Func_1_System_Object(LuaFunction ld ) {
            IntPtr l = ld.L;
            int error = pushTry(l);

			ld.pcall(0, error);
			System.Object ret;
			checkType(l,error+1,out ret);
			LuaDLL.lua_settop(l, error-1);
			return ret;
		}
	}
}
