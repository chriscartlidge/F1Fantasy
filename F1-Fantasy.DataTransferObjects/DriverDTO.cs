namespace F1.Fantasy.DataTransferObjects
{
    using System;

    using F1.Fantasy.DataTransferObjects.Interfaces;

    /// <summary>
    /// Represents a Formula 1 Driver 
    /// that drives for a Formula 1 Team.
    /// </summary>
    public sealed class DriverDTO : IAsset
    {
        /// <summary>
        /// Gets or sets the Id of the Driver.
        /// </summary>
        public Guid Id
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the name of the Driver.
        /// </summary>
        public string Name
        {
            get; set;
        }
    }
}
