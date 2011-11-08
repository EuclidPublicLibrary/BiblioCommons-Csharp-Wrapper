namespace BiblioCommons
{
    /// <summary>
    /// A Library instance resource represents a single BiblioCommons Library.
    /// </summary>
    public class Library
    {
        /// <summary>
        /// The library ID. (Always)
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The full name of the library. (Always)
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The URL for the library's BiblioCommons catalog. (Always)
        /// </summary>
        public string catalog_url { get; set; }
    }
}
