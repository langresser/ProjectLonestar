﻿using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "PrefabManager")]
public class PrefabManager : ScriptableObject
{
    public GameObject HUDPrefab;
    public GameObject terminalPrefab;
    public GameObject shipPrefab;
    public GameObject flycamPrefab;
    public Loadout defaultLoadout;
}