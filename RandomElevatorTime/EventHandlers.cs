// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace RandomElevatorTime
{
    using Exiled.Events.EventArgs;
    using RandomElevatorTime.Models;
    using UnityEngine;

    /// <summary>
    /// Handles events derived from <see cref="Exiled.Events.Handlers"/>.
    /// </summary>
    public class EventHandlers
    {
        private readonly Plugin plugin;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="plugin">An instance of the <see cref="Plugin"/> class.</param>
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnInteractingElevator(InteractingElevatorEventArgs)"/>
        public void OnInteractingElevator(InteractingElevatorEventArgs ev)
        {
            if (plugin.Config.ElevatorTimings == null || plugin.Config.ElevatorTimings.IsEmpty())
                return;

            ElevatorTimings elevatorTimings = plugin.Config.ElevatorTimings[Random.Range(0, plugin.Config.ElevatorTimings.Count)];
            ev.Lift.movingSpeed = Random.Range(elevatorTimings.Minimum, elevatorTimings.Maximum);
        }
    }
}