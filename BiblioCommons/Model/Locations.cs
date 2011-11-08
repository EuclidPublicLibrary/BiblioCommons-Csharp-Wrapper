using System.Collections.Generic;

namespace BiblioCommons
{
    /// <summary>
    /// A list of locations for a given library, specified by library ID, with basic information about each location.
    /// </summary>
    public class Locations
    {
        /// <summary>
        /// The list of locations.
        /// </summary>
        public List<Location> locations { get; set; }
    }
}
