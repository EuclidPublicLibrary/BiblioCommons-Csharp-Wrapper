using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioCommons
{
    /// <summary>
    /// An Url instance resource represents a single BiblioCommons Url from a BiblioCommons List
    /// when the list_item_type is url.
    /// </summary>
    public class Url
    {
        /// <summary>
        /// The title of the page referred to by this url.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The URL to the page.
        /// </summary>
        public string url { get; set; }
    }
}
