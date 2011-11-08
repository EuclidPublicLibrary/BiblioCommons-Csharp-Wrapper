using System.Collections.Generic;

namespace BiblioCommons
{
    /// <summary>
    /// A UserContent instance resource represents a list of user contributed content, including 
    /// comments, ratings, tags and more, for a given set of search criteria.  User content 
    /// can be searched by title, or by most recent
    /// </summary>
    public class UserContent : SearchResult
    {
        /// <summary>
        /// The user who created this content. 
        /// </summary>
        public User user { get; set; }

        /// <summary>
        /// The title that this content is associated with.
        /// </summary>
        public Title title { get; set; }

        /// <summary>
        /// The list of content created by this user associated with this title.
        /// </summary>
        public List<Content> content { get; set; }
    }
}
