using System.Collections.Generic;

namespace BiblioCommons
{
    /// <summary>
    /// A Title instance resource represents a single BiblioCommons Title.
    /// </summary>
    public class Title
    {
        /// <summary>
        /// The title ID. (Always)
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The title of the title. (Always)
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The subtitle of the title, if one exists. (Sometimes)
        /// </summary>
        public string sub_title { get; set; }

        /// <summary>
        /// The format of the title. (Always)
        /// </summary>
        public Format format { get; set; }

        /// <summary>
        /// The URL for the title details page in the catalog. (Always)
        /// </summary>
        public string details_url { get; set; }

        /// <summary>
        /// The current availability status of the title, across all copies and locations. (Sometimes)
        /// </summary>
        public Availability availability { get; set; }

        /// <summary>
        /// The list of authors. (Sometimes)
        /// </summary>
        public List<Author> authors { get; set; }

        /// <summary>
        /// The list of all ISBN identifiers associated with the title. (Sometimes)
        /// </summary>
        public List<string> isbns { get; set; }

        /// <summary>
        /// The list of all UPC identifiers associated with the title. (Sometimes)
        /// </summary>
        public List<string> upcs { get; set; }

        /// <summary>
        /// The call number associated with the title.  The call number for some copies may be different. (Sometimes)
        /// </summary>
        public string call_number { get; set; }

        /// <summary>
        /// A description of the title. (Sometimes)
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The list of additional contributors. (Sometimes)
        /// </summary>
        public List<AdditionalContributor> additional_contributors { get; set; }

        /// <summary>
        /// The list of publishers. (Sometimes)
        /// </summary>
        public List<Publisher> publishers { get; set; }

        /// <summary>
        /// The number of pages. (Sometimes)
        /// </summary>
        public int pages { get; set; }

        /// <summary>
        /// Series information if this title is part of a series. (Sometimes)
        /// </summary>
        public List<Series> series { get; set; }

        /// <summary>
        /// The specific edition represented by this title. (Sometimes)
        /// </summary>
        public string edition { get; set; }

        /// <summary>
        /// The primary language of the title. (Sometimes)
        /// </summary>
        public Language primary_language { get; set; }

        /// <summary>
        /// The list of all languages for the title. (Sometimes)
        /// </summary>
        public List<Language> lanquages { get; set; }

        /// <summary>
        /// The table of contents. (Sometimes)
        /// </summary>
        public string contents { get; set; }

        /// <summary>
        /// The list of performers in the title. (Sometimes)
        /// </summary>
        public List<Performer> performers { get; set; }

        /// <summary>
        /// A list of audience suitabilities. (Sometimes)
        /// </summary>
        public List<Suitability> suitabilities { get; set; }

        /// <summary>
        /// The list of all notes associated with the title. (Sometimes)
        /// </summary>
        public List<string> notes { get; set; }

        /// <summary>
        /// The statement of responsibility. (Sometimes)
        /// </summary>
        public string statement_of_responsibility { get; set; }

        /// <summary>
        /// The physical description of the title. (Sometimes)
        /// </summary>
        public string physical_description { get; set; }

    }
}
