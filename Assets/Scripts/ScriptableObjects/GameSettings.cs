﻿using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Settings/GameSettings")]
public class GameSettings : SingletonScriptableObject<GameSettings>
{
    [Header("Default Prefabs")]
    public Ship defaultShip;
    public HUDManager HUDPrefab;
    public FLTerminal terminalPrefab;
    public PlayerController pcPrefab;
    public Canvas nebulaCanvasPrefab;
    public Loot lootPrefab;

    public Loadout defaultLoadout;
    public Inventory playerInventory;

    public GameObject[] globalPrefabs;
    public GameObject[] localPrefabs;

    public static PlayerController pc;

    public string menuSceneName = "SCN_MainMenu";

    public Resolution[] resolutions;
    public List<string> resolutionOptions;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void GameLoading()
    {
        Instance.InitResolutions();

        // pc = FindObjectOfType<PlayerController>();

        // if (pc == null)
        //     pc = Instantiate(Instance.pcPrefab);

        // DontDestroyOnLoad(pc);

        // DontDestroyOnLoad(pc.GetComponent<NebulaCameraFog>().fadeQuad = Instantiate(Instance.nebulaCanvasPrefab).GetComponent<Image>());

        // Instance.playerInventory = Utilities.CheckScriptableObject<Inventory>(Instance.playerInventory);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void GameStartup()
    {
        new GameObject().AddComponent<FLTerminal>();
    }


    private void InitResolutions()
    {
        resolutions = Screen.resolutions;
        resolutionOptions = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + " : " + resolutions[i].refreshRate + "hz";
            resolutionOptions.Add(option);
        }
    }
}
