using System.Collections.Generic;

namespace BiblioCommons
{
    /// <summary>
    /// Represents a single option for narrowing a BiblioCommons result set.
    /// </summary>
    public class NarrowBy
    {
        /// <summary>
        /// The narrow by ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The user-friendly name of this narrow_by.
        /// </summary>
        public string name { get; set; }

        public List<NarrowTo> narrow_tos { get; set; }
    }
}
