using System.Collections.Generic;

namespace BiblioCommons
{
    /// <summary>
    /// If metadata=1 is passed, metadata will be returned about the list of results, 
    /// including options for sorting and narrowing the result set.
    /// </summary>
    public class Metadata
    {
        /// <summary>
        /// Options for sorting the result set.
        /// </summary>
        public List<SortBy> sort_bys { get; set; }

        /// <summary>
        /// Options for narrowing the result set.
        /// </summary>
        public List<NarrowBy> narrow_bys { get; set; }
    }
}
