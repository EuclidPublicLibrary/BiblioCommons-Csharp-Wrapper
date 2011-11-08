namespace BiblioCommons
{
    /// <summary>
    /// An User instance resource represents a single BiblioCommons User
    /// </summary>
    public class User
    {
        /// <summary>
        /// The user ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The user's screen name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The URL for the user's profile page.
        /// </summary>
        public string profile_url { get; set; }
    }
}
