using System;

namespace BiblioCommons
{
    /// <summary>
    /// A Content instance resource represents a single BiblioCommons User Content associated with a title.
    /// </summary>
    public class Content
    {
        /// <summary>
        /// The type of user content, for example comment, rating, tag, etc.
        /// </summary>
        public ContentType content_type { get; set; }

        /// <summary>
        /// The content data.  The Type returned depends on the value of content_type.  
        /// For example if content_type is comment, the return type will be String.  
        /// If content_type is rating, the return type will be Number.  If content_type 
        /// is more complex, the data will be returned as an Object with multiple fields.
        /// </summary>
        public Object content_data { get; set; }

        /// <summary>
        /// The date and time that the content was last updated.
        /// </summary>
        public string updated { get; set; }
    }
}
