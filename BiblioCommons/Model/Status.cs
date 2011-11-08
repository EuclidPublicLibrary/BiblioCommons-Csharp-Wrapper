using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioCommons
{
    /// <summary>
    /// A Status instance resource represents a single BiblioCommons normalized Status.
    /// </summary>
    public class Status
    {
        /// <summary>
        /// The ID of the status.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The user-friendly name of the status.
        /// </summary>
        public string name { get; set; }
    }
}
