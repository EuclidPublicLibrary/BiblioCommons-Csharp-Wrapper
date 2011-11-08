namespace BiblioCommons
{
    /// <summary>
    /// Represents a single option for sorting a BiblioCommons result set.
    /// </summary>
    public class SortBy
    {
        /// <summary>
        /// The sort by ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The user-friendly sort name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// A link to the result set sorted by this sort_by.
        /// </summary>
        public string link { get; set; }
    }
}
