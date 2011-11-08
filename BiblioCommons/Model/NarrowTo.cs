namespace BiblioCommons
{
    /// <summary>
    /// Represents a single option for narrowing a BiblioCommons result to.
    /// </summary>
    public class NarrowTo
    {
        /// <summary>
        /// The narrow to ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The user-friendly name of the narrow to.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The number of results that would be returned by this narrow to.
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// A link to the result set narrowed to this narrow_to.
        /// </summary>
        public string link { get; set; }
    }
}
