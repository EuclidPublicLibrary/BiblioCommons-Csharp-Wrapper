using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioCommons
{
    /// <summary>
    /// A Copy instance resource represents single BiblioCommons Copy for a given title with basic information about each copy.
    /// </summary>
    public class Copy
    {
        /// <summary>
        /// The collection the copy belongs to.
        /// </summary>
        public string collection { get; set; }

        /// <summary>
        /// The call number of the copy.
        /// </summary>
        public string call_number { get; set; }

        /// <summary>
        /// The library-specific status string.
        /// </summary>
        public string library_status { get; set; }

        /// <summary>
        /// The library location the copy belongs to.
        /// </summary>
        public Location location { get; set; }

        /// <summary>
        /// The normalized BiblioCommons status.
        /// </summary>
        public Status status { get; set; }
    }
}
