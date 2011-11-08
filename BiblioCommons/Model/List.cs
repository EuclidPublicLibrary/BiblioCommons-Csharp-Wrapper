using System.Collections.Generic;
namespace BiblioCommons
{
    /// <summary>
    /// A List instance resource represents a single BiblioCommons List.
    /// </summary>
    public class List
    {
        /// <summary>
        /// The unique list ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The name of the list.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The total number of items on the list.
        /// </summary>
        public int item_count { get; set; }

        /// <summary>
        /// The date and time that the list was created.
        /// </summary>
        public string created { get; set; }

        /// <summary>
        /// The date and time that the list was last updated.
        /// </summary>
        public string updated { get; set; }

        /// <summary>
        /// The list type.
        /// </summary>
        public ListType list_type { get; set; }

        /// <summary>
        /// The user who created this list.
        /// </summary>
        public User user { get; set; }

        /// <summary>
        /// The URL for the list details page.
        /// </summary>
        public string details_url { get; set; }

        /// <summary>
        /// The list items contained in the list.
        /// </summary>
        public List<ListItem> list_items { get; set; }
        
    }
}
