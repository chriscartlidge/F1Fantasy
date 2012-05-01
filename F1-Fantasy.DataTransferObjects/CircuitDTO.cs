namespace F1.Fantasy.DataTransferObjects
{
    using System;
    using System.Collections.Generic;

    using F1.Fantasy.DataTransferObjects.Interfaces;

    /// <summary>
    /// Represents a Circuit that a Formula 1 event 
    /// will take place.
    /// </summary>
    public sealed class CircuitDTO : IAsset
    {
        /// <summary>
        /// Gets or sets the Id of the Circuit.
        /// </summary>
        public Guid Id
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the name of the Circuit.
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the location of the Circuit.
        /// </summary>
        public string Location
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the length of the Circuit.
        /// </summary>
        public double Length
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the lap record of the Circuit.
        /// </summary>
        public KeyValuePair<DriverDTO, double> LapRecord
        {
            get; set;
        } 


    }
}
