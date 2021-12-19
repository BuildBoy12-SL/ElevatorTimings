// -----------------------------------------------------------------------
// <copyright file="ElevatorTimings.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace RandomElevatorTime.Models
{
    /// <summary>
    /// Designed for config serialization of <see cref="Config.ElevatorTimings"/>.
    /// </summary>
    public class ElevatorTimings
    {
        /// <summary>
        /// Gets or sets the minimum time that an elevator can travel.
        /// </summary>
        public float Minimum { get; set; }

        /// <summary>
        /// Gets or sets the maximum time that an elevator can travel.
        /// </summary>
        public float Maximum { get; set; }
    }
}