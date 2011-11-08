using System.Collections.Generic;

namespace BiblioCommons
{
    /// <summary>
    /// A Lists instance resource represents a list of user lists, for a given set of criteria, 
    /// with basic information about each user list.  Currently the only supported criteria 
    /// is most recently created.
    /// </summary>
    public class Lists : SearchResult
    {
        /// <summary>
        /// A list of BiblioCommoons User Lists.
        /// </summary>
        public List<List> lists { get; set; }
    }
}
