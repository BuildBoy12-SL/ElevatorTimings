// -----------------------------------------------------------------------
// <copyright file="UseLiftPatch.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace RandomElevatorTime.Patches
{
#pragma warning disable SA1313
    using HarmonyLib;
    using RandomElevatorTime.Models;
    using UnityEngine;

    /// <summary>
    /// Patches <see cref="Lift.UseLift"/> to adjust the elevator speed.
    /// </summary>
    [HarmonyPatch(typeof(Lift), nameof(Lift.UseLift))]
    internal static class UseLiftPatch
    {
        private static void Prefix(Lift __instance)
        {
            ElevatorTimings elevatorTimings = Plugin.Instance.Config.ElevatorTimings[Random.Range(0, Plugin.Instance.Config.ElevatorTimings.Count)];
            __instance.movingSpeed = Random.Range(elevatorTimings.Minimum, elevatorTimings.Maximum);
        }
    }
}