// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAsset.cs" company="ccartlidge@yahoo.com">
//   Copyright C.Cartlidge 2011
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace F1.Fantasy.DataTransferObjects.Interfaces
{
    using System;

    /// <summary>
    /// Defines a contract that represents the basic 
    /// values of a asset within the domain. An example
    /// of an asset: Engine, Driver est.
    /// </summary>
    public interface IAsset
    {
        /// <summary>
        /// Gets or sets the Id of the asset.
        /// </summary>
        /// <value>
        /// The value of the Id which is of type <see cref="Guid"/>.
        /// </value>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the asset.
        /// </summary>
        /// <value>
        /// The name of the asset which is of type <see cref="string"/>.
        /// </value>
        string Name { get; set; } 
    }
}
