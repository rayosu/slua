﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioHighPassFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioHighPassFilter o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioHighPassFilter();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cutoffFrequency(IntPtr l) {
		UnityEngine.AudioHighPassFilter o = checkSelf<UnityEngine.AudioHighPassFilter>(l);
		pushValue(l,o.cutoffFrequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cutoffFrequency(IntPtr l) {
		UnityEngine.AudioHighPassFilter o = checkSelf<UnityEngine.AudioHighPassFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.cutoffFrequency=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highpassResonaceQ(IntPtr l) {
		UnityEngine.AudioHighPassFilter o = checkSelf<UnityEngine.AudioHighPassFilter>(l);
		pushValue(l,o.highpassResonaceQ);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highpassResonaceQ(IntPtr l) {
		UnityEngine.AudioHighPassFilter o = checkSelf<UnityEngine.AudioHighPassFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.highpassResonaceQ=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioHighPassFilter");
		addMember(l,get_cutoffFrequency, "get_cutoffFrequency");
		addMember(l,set_cutoffFrequency, "set_cutoffFrequency");
		addMember(l,get_highpassResonaceQ, "get_highpassResonaceQ");
		addMember(l,set_highpassResonaceQ, "set_highpassResonaceQ");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AudioHighPassFilter),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
