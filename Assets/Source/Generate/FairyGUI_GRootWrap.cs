﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_GRootWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.GRoot), typeof(FairyGUI.GComponent));
		L.RegFunction("SetContentScaleFactor", SetContentScaleFactor);
		L.RegFunction("ApplyContentScaleFactor", ApplyContentScaleFactor);
		L.RegFunction("ShowWindow", ShowWindow);
		L.RegFunction("HideWindow", HideWindow);
		L.RegFunction("HideWindowImmediately", HideWindowImmediately);
		L.RegFunction("BringToFront", BringToFront);
		L.RegFunction("ShowModalWait", ShowModalWait);
		L.RegFunction("CloseModalWait", CloseModalWait);
		L.RegFunction("CloseAllExceptModals", CloseAllExceptModals);
		L.RegFunction("CloseAllWindows", CloseAllWindows);
		L.RegFunction("GetTopWindow", GetTopWindow);
		L.RegFunction("DisplayObjectToGObject", DisplayObjectToGObject);
		L.RegFunction("ShowPopup", ShowPopup);
		L.RegFunction("GetPoupPosition", GetPoupPosition);
		L.RegFunction("TogglePopup", TogglePopup);
		L.RegFunction("HidePopup", HidePopup);
		L.RegFunction("ShowTooltips", ShowTooltips);
		L.RegFunction("ShowTooltipsWin", ShowTooltipsWin);
		L.RegFunction("HideTooltips", HideTooltips);
		L.RegFunction("EnableSound", EnableSound);
		L.RegFunction("DisableSound", DisableSound);
		L.RegFunction("PlayOneShotSound", PlayOneShotSound);
		L.RegFunction("New", _CreateFairyGUI_GRoot);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("contentScaleFactor", get_contentScaleFactor, null);
		L.RegVar("inst", get_inst, null);
		L.RegVar("hasModalWindow", get_hasModalWindow, null);
		L.RegVar("modalWaiting", get_modalWaiting, null);
		L.RegVar("touchTarget", get_touchTarget, null);
		L.RegVar("hasAnyPopup", get_hasAnyPopup, null);
		L.RegVar("focus", get_focus, set_focus);
		L.RegVar("soundVolume", get_soundVolume, set_soundVolume);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_GRoot(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.GRoot obj = new FairyGUI.GRoot();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.GRoot.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetContentScaleFactor(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(int), typeof(int)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.SetContentScaleFactor(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(int), typeof(int), typeof(FairyGUI.UIContentScaler.ScreenMatchMode)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				FairyGUI.UIContentScaler.ScreenMatchMode arg2 = (FairyGUI.UIContentScaler.ScreenMatchMode)ToLua.ToObject(L, 4);
				obj.SetContentScaleFactor(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GRoot.SetContentScaleFactor");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ApplyContentScaleFactor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			obj.ApplyContentScaleFactor();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowWindow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			FairyGUI.Window arg0 = (FairyGUI.Window)ToLua.CheckObject(L, 2, typeof(FairyGUI.Window));
			obj.ShowWindow(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HideWindow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			FairyGUI.Window arg0 = (FairyGUI.Window)ToLua.CheckObject(L, 2, typeof(FairyGUI.Window));
			obj.HideWindow(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HideWindowImmediately(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(FairyGUI.Window)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				FairyGUI.Window arg0 = (FairyGUI.Window)ToLua.ToObject(L, 2);
				obj.HideWindowImmediately(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(FairyGUI.Window), typeof(bool)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				FairyGUI.Window arg0 = (FairyGUI.Window)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.HideWindowImmediately(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GRoot.HideWindowImmediately");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BringToFront(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			FairyGUI.Window arg0 = (FairyGUI.Window)ToLua.CheckObject(L, 2, typeof(FairyGUI.Window));
			obj.BringToFront(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowModalWait(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			obj.ShowModalWait();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseModalWait(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			obj.CloseModalWait();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseAllExceptModals(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			obj.CloseAllExceptModals();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseAllWindows(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			obj.CloseAllWindows();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTopWindow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			FairyGUI.Window o = obj.GetTopWindow();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DisplayObjectToGObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.DisplayObject));
			FairyGUI.GObject o = obj.DisplayObjectToGObject(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowPopup(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(FairyGUI.GObject)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				obj.ShowPopup(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(FairyGUI.GObject), typeof(FairyGUI.GObject)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				FairyGUI.GObject arg1 = (FairyGUI.GObject)ToLua.ToObject(L, 3);
				obj.ShowPopup(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(FairyGUI.GObject), typeof(FairyGUI.GObject), typeof(object)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				FairyGUI.GObject arg1 = (FairyGUI.GObject)ToLua.ToObject(L, 3);
				object arg2 = ToLua.ToVarObject(L, 4);
				obj.ShowPopup(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GRoot.ShowPopup");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPoupPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			FairyGUI.GObject arg1 = (FairyGUI.GObject)ToLua.CheckObject(L, 3, typeof(FairyGUI.GObject));
			object arg2 = ToLua.ToVarObject(L, 4);
			UnityEngine.Vector2 o = obj.GetPoupPosition(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TogglePopup(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(FairyGUI.GObject)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				obj.TogglePopup(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(FairyGUI.GObject), typeof(FairyGUI.GObject)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				FairyGUI.GObject arg1 = (FairyGUI.GObject)ToLua.ToObject(L, 3);
				obj.TogglePopup(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(FairyGUI.GObject), typeof(FairyGUI.GObject), typeof(object)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				FairyGUI.GObject arg1 = (FairyGUI.GObject)ToLua.ToObject(L, 3);
				object arg2 = ToLua.ToVarObject(L, 4);
				obj.TogglePopup(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GRoot.TogglePopup");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HidePopup(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				obj.HidePopup();
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(FairyGUI.GObject)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				obj.HidePopup(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GRoot.HidePopup");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowTooltips(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			string arg0 = ToLua.CheckString(L, 2);
			obj.ShowTooltips(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowTooltipsWin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			obj.ShowTooltipsWin(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HideTooltips(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			obj.HideTooltips();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnableSound(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			obj.EnableSound();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DisableSound(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRoot));
			obj.DisableSound();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayOneShotSound(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(UnityEngine.AudioClip)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				UnityEngine.AudioClip arg0 = (UnityEngine.AudioClip)ToLua.ToObject(L, 2);
				obj.PlayOneShotSound(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GRoot), typeof(UnityEngine.AudioClip), typeof(float)))
			{
				FairyGUI.GRoot obj = (FairyGUI.GRoot)ToLua.ToObject(L, 1);
				UnityEngine.AudioClip arg0 = (UnityEngine.AudioClip)ToLua.ToObject(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				obj.PlayOneShotSound(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GRoot.PlayOneShotSound");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_contentScaleFactor(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, FairyGUI.GRoot.contentScaleFactor);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inst(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FairyGUI.GRoot.inst);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasModalWindow(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)o;
			bool ret = obj.hasModalWindow;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index hasModalWindow on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_modalWaiting(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)o;
			bool ret = obj.modalWaiting;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index modalWaiting on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_touchTarget(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)o;
			FairyGUI.GObject ret = obj.touchTarget;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index touchTarget on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasAnyPopup(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)o;
			bool ret = obj.hasAnyPopup;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index hasAnyPopup on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_focus(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)o;
			FairyGUI.GObject ret = obj.focus;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index focus on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_soundVolume(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)o;
			float ret = obj.soundVolume;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index soundVolume on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_focus(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)o;
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			obj.focus = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index focus on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_soundVolume(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRoot obj = (FairyGUI.GRoot)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.soundVolume = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index soundVolume on a nil value" : e.Message);
		}
	}
}

