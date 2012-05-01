namespace F1.Fantasy.DataTransferObjects
{
    using System;

    using F1.Fantasy.DataTransferObjects.Interfaces;

    public sealed class RaceDTO : IAsset
    {
        /// <summary>
        /// Gets or sets the Id of the Race.
        /// </summary>
        public Guid Id
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the name of the Race.
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the circuit of the Race.
        /// </summary>
        public CircuitDTO Circuit
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the laps of the Race. 
        /// </summary>
        public int Laps
        {
            get; set;
        }
    }
}
