namespace BiblioCommons
{
    /// <summary>
    ///  A single location for a given library.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// The library-specific location ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The user-friendly name of the library location.
        /// </summary>
        public string name { get; set; }
    }
}
