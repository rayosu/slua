﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_InteractiveCloth : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.InteractiveCloth o;
		if(matchType(l,1)){
			o=new UnityEngine.InteractiveCloth();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddForceAtPosition(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.ForceMode))){
				UnityEngine.InteractiveCloth self=checkSelf<UnityEngine.InteractiveCloth>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.ForceMode a4;
				checkType(l,5,out a4);
				self.AddForceAtPosition(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.InteractiveCloth self=checkSelf<UnityEngine.InteractiveCloth>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddForceAtPosition(a1,a2,a3);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AttachToCollider(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Collider),typeof(System.Boolean),typeof(System.Boolean))){
				UnityEngine.InteractiveCloth self=checkSelf<UnityEngine.InteractiveCloth>(l);
				UnityEngine.Collider a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.AttachToCollider(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Collider),typeof(System.Boolean))){
				UnityEngine.InteractiveCloth self=checkSelf<UnityEngine.InteractiveCloth>(l);
				UnityEngine.Collider a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.AttachToCollider(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Collider))){
				UnityEngine.InteractiveCloth self=checkSelf<UnityEngine.InteractiveCloth>(l);
				UnityEngine.Collider a1;
				checkType(l,2,out a1);
				self.AttachToCollider(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DetachFromCollider(IntPtr l) {
		try{
			UnityEngine.InteractiveCloth self=checkSelf<UnityEngine.InteractiveCloth>(l);
			UnityEngine.Collider a1;
			checkType(l,2,out a1);
			self.DetachFromCollider(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mesh(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		pushValue(l,o.mesh);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mesh(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		UnityEngine.Mesh v;
		checkType(l,2,out v);
		o.mesh=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_friction(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		pushValue(l,o.friction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_friction(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.friction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_density(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		pushValue(l,o.density);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_density(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.density=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressure(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		pushValue(l,o.pressure);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressure(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.pressure=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionResponse(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		pushValue(l,o.collisionResponse);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collisionResponse(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.collisionResponse=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tearFactor(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		pushValue(l,o.tearFactor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tearFactor(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.tearFactor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachmentTearFactor(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		pushValue(l,o.attachmentTearFactor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_attachmentTearFactor(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.attachmentTearFactor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachmentResponse(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		pushValue(l,o.attachmentResponse);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_attachmentResponse(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.attachmentResponse=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isTeared(IntPtr l) {
		UnityEngine.InteractiveCloth o = checkSelf<UnityEngine.InteractiveCloth>(l);
		pushValue(l,o.isTeared);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.InteractiveCloth");
		addMember(l,AddForceAtPosition, "AddForceAtPosition");
		addMember(l,AttachToCollider, "AttachToCollider");
		addMember(l,DetachFromCollider, "DetachFromCollider");
		addMember(l,get_mesh, "get_mesh");
		addMember(l,set_mesh, "set_mesh");
		addMember(l,get_friction, "get_friction");
		addMember(l,set_friction, "set_friction");
		addMember(l,get_density, "get_density");
		addMember(l,set_density, "set_density");
		addMember(l,get_pressure, "get_pressure");
		addMember(l,set_pressure, "set_pressure");
		addMember(l,get_collisionResponse, "get_collisionResponse");
		addMember(l,set_collisionResponse, "set_collisionResponse");
		addMember(l,get_tearFactor, "get_tearFactor");
		addMember(l,set_tearFactor, "set_tearFactor");
		addMember(l,get_attachmentTearFactor, "get_attachmentTearFactor");
		addMember(l,set_attachmentTearFactor, "set_attachmentTearFactor");
		addMember(l,get_attachmentResponse, "get_attachmentResponse");
		addMember(l,set_attachmentResponse, "set_attachmentResponse");
		addMember(l,get_isTeared, "get_isTeared");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.InteractiveCloth),typeof(UnityEngine.Cloth));
		LuaDLL.lua_pop(l, 1);
	}
}
