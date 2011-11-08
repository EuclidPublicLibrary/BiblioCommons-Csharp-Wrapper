namespace BiblioCommons
{
    /// <summary>
    /// The type of user content, for example comment, rating, tag, etc.
    /// </summary>
    public class ContentType
    {
        /// <summary>
        /// The ID of the content type.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The user-friendly name of the content type.
        /// </summary>
        public string name { get; set; }
    }
}
