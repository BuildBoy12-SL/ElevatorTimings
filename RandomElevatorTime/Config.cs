// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace RandomElevatorTime
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Interfaces;
    using RandomElevatorTime.Models;

    /// <inheritdoc cref="IConfig"/>
    public sealed class Config : IConfig
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether <see cref="StaticTime"/> should be used instead of <see cref="ElevatorTimings"/>.
        /// </summary>
        [Description("Whether static_time should be used instead of elevator_timings.")]
        public bool UseStaticTime { get; set; } = false;

        /// <summary>
        /// Gets or sets the speed of a lift.
        /// </summary>
        [Description("The speed of a lift.")]
        public float StaticTime { get; set; } = 3f;

        /// <summary>
        /// Gets or sets the collection of which random elevator timings are chosen.
        /// </summary>
        [Description("The collection of which random elevator timings are chosen.")]
        public List<ElevatorTimings> ElevatorTimings { get; set; } = new List<ElevatorTimings>
        {
            new ElevatorTimings
            {
                Minimum = 2f,
                Maximum = 6f,
            },
            new ElevatorTimings
            {
                Minimum = 4f,
                Maximum = 7f,
            },
        };
    }
}