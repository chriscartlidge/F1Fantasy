namespace F1.Fantasy.DataTransferObjects
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a Formula 1
    /// season. A season contains
    /// a number of races.
    /// </summary>
    public sealed class SeasonDTO
    {
        /// <summary>
        /// Gets or sets the Id of the Season.
        /// </summary>
        public Guid Id
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the GrandPrixes of the Season. 
        /// </summary>
        public IEnumerable<GrandPrixDTO> GrandPrixes
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Year of the Season.
        /// </summary>
        public int Year
        {
            get; set;
        }
    }
}
