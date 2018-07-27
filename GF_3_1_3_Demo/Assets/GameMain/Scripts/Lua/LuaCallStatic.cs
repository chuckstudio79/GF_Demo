﻿//------------------------------------------------------------
// Copyright © 2017-2020 Chen Hua. All rights reserved.
// Author: 一条猪儿虫
// Email: 1184923569@qq.com
//------------------------------------------------------------

using GameFramework;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityGameFramework.Runtime;

/// <summary>
/// Lua调用的常用方法 ( 需要Wrap!)
/// </summary>
public class LuaCallStatic
{
    public static void LuaCloseForm(string uiFormId)
    {
        GameManager.UI.CloseUIForm(uiFormId);
    }

    public static void LuaOpenForm(string uiFormId,object userData = null)
    {
        GameManager.UI.OpenUIForm(uiFormId,userData);
    }

    public static void AddButtonClick(GameObject go, UnityAction onBtnClick)
    {
        Button btn = go.GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(onBtnClick);
        }
        else
        {
            Log.Error("Form => GameObject '{0}' not have Button Component !", go.name);
        }
    }

    public static void RemoveButtonClick(GameObject go, UnityAction onBtnClick)
    {
        Button btn = go.GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.RemoveListener(onBtnClick);
            btn.onClick = null;
        }
        else
        {
            Log.Error("Form => GameObject '{0}' not have Button Component !", go.name);
        }
    }
}