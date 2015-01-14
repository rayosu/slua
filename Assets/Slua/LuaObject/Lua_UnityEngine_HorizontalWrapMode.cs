﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HorizontalWrapMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.HorizontalWrapMode o = (UnityEngine.HorizontalWrapMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HorizontalWrapMode");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "Wrap");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "Overflow");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
