namespace BiblioCommons
{
    /// <summary>
    /// Base class for all requests that return a list of results
    /// </summary>
    public abstract class SearchResult
    {
        /// <summary>
        /// The total numer of contributions.
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// The number of contributions returned on each page.
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        public int pages { get; set; }

        /// <summary>
        /// The current page.  The index of the first page is 1.
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// If metadata=1 is passed, metadata will be returned about the list of results, 
        /// including options for sorting and narrowing the result set.
        /// </summary>
        public Metadata metadata { get; set; }
    }
}
