using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;
using CommonModNS;

namespace ExampleModNS
{
    public class ExampleMod : Mod
    {
        public static ExampleMod instance;
        public static void Log(string msg) => instance.Logger.Log(msg);
        public static void LogError(string msg) => instance.Logger.LogError(msg);

        private void Awake()
        {
            instance = this;
            //WorldManagerPatches.LoadSaveRound += WM_OnLoad;
            //WorldManagerPatches.GetSaveRound += WM_OnSave;
            //WorldManagerPatches.StartNewRound += WM_OnNewGame;
            //WorldManagerPatches.Play += WM_OnPlay;
            //WorldManagerPatches.Update += WM_OnUpdate;
            //WorldManagerPatches.ApplyPatches(Harmony);
            //Harmony.PatchAll();
        }

        public override void Ready()
        {
            Logger.Log("Ready!");
        }
    }
}