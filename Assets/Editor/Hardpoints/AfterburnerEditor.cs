﻿using UnityEngine;
using EGL = UnityEditor.EditorGUILayout;
using UnityEditor;

[CustomEditor(typeof(Afterburner))]
public class AfterburnerEditor : Editor
{
    Afterburner afterburner;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        afterburner = target as Afterburner;

        EGL.LabelField("Is Active?", afterburner.Burning.ToString());
        EGL.LabelField("Is On Cooldown?", afterburner.IsOnCooldown.ToString());

        ShowButtons();
    }

    private void ShowButtons()
    {
        if (Application.isPlaying == false || afterburner.stats == null) return;

        var buttonString = afterburner.Burning ? "Deactivate" : "Activate";

        if (GUILayout.Button(buttonString))
        {
            if (afterburner.Burning)
            {
                afterburner.Deactivate();
            }

            else
            {
                afterburner.Activate();
            }
        }
    }
}