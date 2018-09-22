﻿using UnityEngine;
using EGL = UnityEditor.EditorGUILayout;
using UnityEditor;

[CustomEditor(typeof(Gun))]
public class GunEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Gun gun = (Gun)target;

        if (Application.isPlaying == false) return;

        gun.Active = EGL.Toggle("Active", gun.Active);

        if (GUILayout.Button("Fire"))
        {
            //weaponHardpoint.Fire();
        }
    }
}