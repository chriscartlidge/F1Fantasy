// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EngineDTO.cs" company="ccartlidge@yahoo.com">
//   Copyright C.Cartlidge 2011
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace F1.Fantasy.DataTransferObjects
{
    using System;

    using F1.Fantasy.DataTransferObjects.Interfaces;

    /// <summary>
    /// Represents a Formula 1 Engine 
    /// this is an asset that can accrue points and
    /// is also classed as an expense. 
    /// </summary>
    public sealed class EngineDTO : IAsset
    {
        /// <summary>
        /// Gets or sets the Id of the asset.
        /// </summary>
        /// <value>
        /// The value of the Id which is of type <see cref="Guid"/>.
        /// </value>
        public Guid Id
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the name of the asset.
        /// </summary>
        /// <value>
        /// The name of the asset which is of type <see cref="string"/>.
        /// </value>
        public string Name
        {
            get; set;
        }
    }
}
