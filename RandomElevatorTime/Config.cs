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