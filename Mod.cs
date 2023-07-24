using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace ExampleModNS
{
    public class ExampleMod : Mod
    {
        public override void Ready()
        {
            Logger.Log("Ready!");
        }
    }
}