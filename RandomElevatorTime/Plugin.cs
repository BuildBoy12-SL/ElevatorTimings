// -----------------------------------------------------------------------
// <copyright file="Plugin.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace RandomElevatorTime
{
    using System;
    using Exiled.API.Features;
    using HarmonyLib;

    /// <summary>
    /// The main plugin class.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        private Harmony harmony;

        /// <summary>
        /// Gets a static instance of the <see cref="Plugin"/> class.
        /// </summary>
        public static Plugin Instance { get; private set; }

        /// <inheritdoc />
        public override string Author { get; } = "Build";

        /// <inheritdoc/>
        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);

        /// <inheritdoc />
        public override void OnEnabled()
        {
            Instance = this;
            harmony = new Harmony($"build.randomElevatorTimings.{DateTime.UtcNow.Ticks}");
            harmony.PatchAll();
            base.OnEnabled();
        }

        /// <inheritdoc />
        public override void OnDisabled()
        {
            harmony?.UnpatchAll(harmony.Id);
            harmony = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}