﻿using HarmonyLib;
using SpaceEngineersVR.Plugin;
using System.Reflection;

namespace SpaceEngineersVR.Patches
{
    [HarmonyPatch]
    public static class PlayerAndCameraDisabler
    {
        public static MethodBase TargetMethod()
        {
            return AccessTools.Method("Sandbox.Game.Gui.MyGuiScreenGamePlay:MoveAndRotatePlayerOrCamera");
        }

        public static bool Prefix()
        {
            if (Common.Config.EnableKeyboardAndMouseControls)
            {
                return true;
            }
            return false;
        }
    }
}