namespace F1.Fantasy.DataTransferObjects
{
    using System;

    public sealed class UserDTO
    {
        /// <summary>
        /// Gets or sets the Id of the User.
        /// </summary>
        public Guid Id
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Username of the User.
        /// </summary>
        public string Username
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Name of the User.
        /// </summary>
        public string Name
        {
            get; set;
        }
    }
}
