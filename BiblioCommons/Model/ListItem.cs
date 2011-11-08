namespace BiblioCommons
{
    /// <summary>
    /// A ListItem instance resource represents a single item from a BiblioCommons List
    /// </summary>
    public class ListItem
    {
        /// <summary>
        /// The type of list item, either title or url.
        /// </summary>
        public string list_item_type { get; set; }

        /// <summary>
        /// The user annotation associated with this list item.
        /// </summary>
        public string annotation { get; set; }

        /// <summary>
        /// If list_item_type is title, the title contained by this list item.
        /// </summary>
        public Title title { get; set; }

        /// <summary>
        /// If list_item_type is url, the url contained by this list item.
        /// </summary>
        public Url url { get; set; }
    }
}
