using System.Collections.Generic;

namespace BiblioCommons
{
    /// <summary>
    /// A Titles instance resource represents a list of titles from a given library catalog 
    /// and matching a given set of search criteria, with basic information about each title.
    /// </summary>
    public class Titles : SearchResult
    {
        /// <summary>
        /// A list of BiblioCommons Titles
        /// </summary>
        public List<Title> titles { get; set; }
    }
}
