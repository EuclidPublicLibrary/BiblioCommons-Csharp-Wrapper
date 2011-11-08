using System;
using RestSharp;

namespace BiblioCommons
{
    public partial class BiblioCommonsRestClient
    {
        /// <summary>
        /// Returns a list of user lists, for a given set of criteria, with basic information 
        /// about each user list.  Currently the only supported criteria is most recently created.
        /// </summary>
        /// <param name="libraryId">[Optional] The library ID.  Each library's BiblioCommons catalog will have a 
        /// hostname of the form {id}.bibliocommons.com.  The {id} portion of the hostname is the library's ID.</param>
        /// <param name="limit">[Optional] Sets the limit on the number of results to be returned.  If the limit exceeds the maximum limit 
        /// for a particular request, the maximum limit will be used. </param>
        /// <param name="page">[Optional] Sets the current page within the result set to be returned.  The index of the first page is 1.  
        /// If the page exceeds the total number of pages, the last page will be returned.</param>
        /// <param name="metadata">[Optional] Passing metadata=1 instructs the API to return metadata about the list of results, 
        /// including sorting and narrowing options.</param>
        /// <returns></returns>
        public Lists GetLists(string libraryId = null, int limit = 10, int page = 1, int metadata = 0)
        {
            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId;

            var request = new RestRequest();
            request.Resource = "lists";
            request.AddParameter("library", libraryId);
            request.AddParameter("limit", limit);
            request.AddParameter("page", page);
            request.AddParameter("metadata", metadata);

            return Execute<Lists>(request);
        }


        /// <summary>
        /// Returns information about a given list, specified by list ID.
        /// </summary>
        /// <param name="listId">The id of the list to return information about.</param>
        /// <param name="libraryId"> [Optional] The library ID.  Each library's BiblioCommons catalog will have a hostname of the form {id}.bibliocommons.com.  
        /// The {id} portion of the hostname is the library's ID.</param>
        /// <returns>A BiblioCommons List instance.</returns>
        public List GetList(string listId, string libraryId = null)
        {
            if (string.IsNullOrEmpty(listId))
                throw new ArgumentNullException("listId");

            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId; 

            var request = new RestRequest();
            request.Resource = "lists/{id}";
            request.RootElement = "list";
            request.AddParameter("id", listId, ParameterType.UrlSegment);
            request.AddParameter("libraryId", libraryId);

            return Execute<List>(request);
        }
    }
}
