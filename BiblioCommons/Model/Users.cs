using System.Collections.Generic;

namespace BiblioCommons
{
    /// <summary>
    /// A Titles instance resource represents a list of users matching a given set of search criteria, 
    /// with basic public information about each user.  Currently only username search is supported.
    /// </summary>
    public class Users : SearchResult
    {
        /// <summary>
        /// A list of BiblioCommons Users
        /// </summary>
        public List<User> users { get; set; }
    }
}
