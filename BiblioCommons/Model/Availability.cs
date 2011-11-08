namespace BiblioCommons
{
    /// <summary>
    /// A Availability instance resource describes the current availability of a Title
    /// across all copies and locations.
    /// </summary>
    public class Availability
    {
        /// <summary>
        /// The ID of the availability status.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The user-friendly name of the availability status.
        /// </summary>
        public string name { get; set; }
    }
}
