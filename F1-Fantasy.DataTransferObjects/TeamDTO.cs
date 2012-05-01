namespace F1.Fantasy.DataTransferObjects
{
    using System;
    using System.Collections.Generic;

    using F1.Fantasy.DataTransferObjects.Interfaces;

    /// <summary>
    /// Represents a Formula 1 team that
    /// contains a number of Drivers and
    /// an Engine.
    /// </summary>
    public sealed class TeamDTO : IAsset
    {
        /// <summary>
        /// Gets or sets the Id of the Team.
        /// </summary>
        public Guid Id
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the name of the Team.
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Drivers of the Team.
        /// </summary>
        public IEnumerable<DriverDTO> Drivers
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Engine of the Team.
        /// </summary>
        public EngineDTO Engine
        {
            get; set;
        }
    }
}
