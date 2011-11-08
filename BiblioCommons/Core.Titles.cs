using System;
using System.Collections.Generic;
using RestSharp;

namespace BiblioCommons
{
    public partial class BiblioCommonsRestClient
    {
        /// <summary>
        /// Returns a list of titles from a given library catalog and matching a given set of search criteria, with basic information about each title.
        /// </summary>
        /// <param name="query">The query string to search for.</param>
        /// <param name="libraryId">[Optional] The ID of the library catalog to search.</param>
        /// <param name="searchType">The type of search to perform.  Supported search types are keyword, author, subject, tag, series, and custom.</param>
        /// <param name="limit">[Optional] Sets the limit on the number of results to be returned.  If the limit exceeds the maximum limit 
        /// for a particular request, the maximum limit will be used. </param>
        /// <param name="page">[Optional] Sets the current page within the result set to be returned.  The index of the first page is 1.  
        /// If the page exceeds the total number of pages, the last page will be returned.</param>
        /// <param name="metadata">[Optional] Passing metadata=1 instructs the API to return metadata about the list of results, 
        /// including sorting and narrowing options.</param>
        /// <returns>A List of BiblioCommons Titles</returns>
        public Titles SearchTitles(string query, SearchType searchType = SearchType.Keyword, string libraryId = null, int limit = 10, int page = 1, int metadata = 0)
        {
            if (string.IsNullOrEmpty(query))
                throw new ArgumentNullException("query");

            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId;

            var request = new RestRequest();

            request.Resource = "titles";
            request.AddParameter("q", query);
            request.AddParameter("library", libraryId);
            request.AddParameter("search_type", searchType.GetStringValue());
            request.AddParameter("limit", limit);
            request.AddParameter("page", page);
            request.AddParameter("metadata", metadata);

            return Execute<Titles>(request);
        }


        /// <summary>
        /// Returns detailed information about a given title from a library catalog, specified by title ID.
        /// </summary>
        /// <param name="titleId">The ID of the title to return.</param>
        /// <param name="libraryId">[Optional] The ID of the library catalog to search.</param>
        /// <returns>A BiblioCommons Title</returns>
        public Title GetTitle(string titleId, string libraryId = null)
        {
            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId;

            var request = new RestRequest();

            request.Resource = "titles/{id}";
            request.RootElement = "title";
            request.AddParameter("id", titleId, ParameterType.UrlSegment);
            request.AddParameter("library", libraryId);

            return Execute<Title>(request);
        }


        /// <summary>
        /// Returns the list of copies for a given title, specified by title ID, with basic information about each copy.
        /// </summary>
        /// <param name="titleId">The title ID.</param>
        /// <param name="libraryId">[Optional] The ID of the library catalog to search.</param>
        /// <returns>A list of BiblioCommons Copy instances for the specified title Id</returns>
        public Copies GetCopies(string titleId, string libraryId = null)
        {
            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId;

            var request = new RestRequest();

            request.Resource = "titles/{id}/copies";
            request.AddParameter("id", titleId, ParameterType.UrlSegment);
            request.AddParameter("library", libraryId);

            return Execute<Copies>(request);
        }
    }
}
