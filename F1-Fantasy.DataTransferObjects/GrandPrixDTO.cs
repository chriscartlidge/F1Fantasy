namespace F1.Fantasy.DataTransferObjects
{
    using System;

    /// <summary>
    /// Represents a Formula 1 grand prix race.
    /// This represents the year that the grand prix 
    /// took place and the results of the race.
    /// </summary>
    public sealed class GrandPrixDTO
    {
        /// <summary>
        /// Gets or sets the Id of the Grand Prix.
        /// </summary>
        public Guid Id
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the year of the Grand Prix.
        /// </summary>
        public int Year
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the race of the Grand Prix.
        /// </summary>
        public RaceDTO Race
        {
            get; set;
        }
    }
}
