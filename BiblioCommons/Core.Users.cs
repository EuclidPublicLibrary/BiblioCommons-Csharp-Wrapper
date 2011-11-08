using System;
using RestSharp;

namespace BiblioCommons
{
    public partial class BiblioCommonsRestClient
    {
        /// <summary>
        /// Returns a list of users matching a given set of search criteria, with basic public information about each user.  
        /// Currently only username search is supported.
        /// </summary>
        /// <param name="query">The query string to search for.  Currently only username search is supported.</param>
        /// <param name="libraryId">[Optional] The ID of the library catalog to search.</param>
        /// <param name="limit">[Optional] Sets the limit on the number of results to be returned.  If the limit exceeds the maximum limit 
        /// for a particular request, the maximum limit will be used. </param>
        /// <param name="page">[Optional] Sets the current page within the result set to be returned.  The index of the first page is 1.  
        /// If the page exceeds the total number of pages, the last page will be returned.</param>
        /// <param name="metadata">[Optional] Passing metadata=1 instructs the API to return metadata about the list of results, 
        /// including sorting and narrowing options.</param>
        /// <returns>A List of BiblioCommons Titles</returns>
        public Users SearchUsers(string query, string libraryId = null, int limit = 10, int page = 1, int metadata = 0)
        {
            if (string.IsNullOrEmpty(query))
                throw new ArgumentNullException("query");

            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId;

            var request = new RestRequest();

            request.Resource = "users";
            request.AddParameter("q", query);
            request.AddParameter("library", libraryId);
            request.AddParameter("limit", limit);
            request.AddParameter("page", page);
            request.AddParameter("metadata", metadata);

            return Execute<Users>(request);
        }

        /// <summary>
        /// Returns basic information about a given user, specified by user ID.
        /// </summary>
        /// <param name="userId">The user ID..</param>
        /// <param name="libraryId">[Optional] The ID of the library catalog to search.</param>
        /// <returns>A BiblioCommons User</returns>
        public User GetUser(string userId, string libraryId = null)
        {
            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId;

            var request = new RestRequest();

            request.Resource = "users/{id}";
            request.RootElement = "user";
            request.AddParameter("id", userId, ParameterType.UrlSegment);
            request.AddParameter("library", libraryId);

            return Execute<User>(request);
        }


        /// <summary>
        /// Returns basic information about a given user, specified by user ID.
        /// </summary>
        /// <param name="userId">The user ID..</param>
        /// <param name="libraryId">[Optional] The ID of the library catalog to search.</param>
        /// <returns>A list of BiblioCommonsLists</returns>
        public Lists GetUserLists(string userId, string libraryId = null)
        {
            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId;

            var request = new RestRequest();

            request.Resource = "users/{id}/lists";
            request.AddParameter("id", userId, ParameterType.UrlSegment);
            request.AddParameter("library", libraryId);

            return Execute<Lists>(request);
        }


        /// <summary>
        /// Returns a list of user contributed content for a given user, specified by user ID.
        /// </summary>
        /// <param name="userId">The user ID..</param>
        /// <param name="libraryId">[Optional] The ID of the library catalog to search.</param>
        /// <param name="limit">[Optional] Sets the limit on the number of results to be returned.  If the limit exceeds the maximum limit 
        /// for a particular request, the maximum limit will be used. </param>
        /// <param name="page">[Optional] Sets the current page within the result set to be returned.  The index of the first page is 1.  
        /// If the page exceeds the total number of pages, the last page will be returned.</param>
        /// <param name="metadata">[Optional] Passing metadata=1 instructs the API to return metadata about the list of results, 
        /// including sorting and narrowing options.</param>
        /// <returns>A list of BiblioCommonsLists</returns>
        public UserContent GetUserContent(string userId, string libraryId = null, int limit = 10, int page = 1, int metadata = 0)
        {
            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId;

            var request = new RestRequest();

            request.Resource = "users/{id}/user_content";
            request.AddParameter("id", userId, ParameterType.UrlSegment);
            request.AddParameter("library", libraryId);
            request.AddParameter("limit", limit);
            request.AddParameter("page", page);
            request.AddParameter("metadata", metadata);

            return Execute<UserContent>(request);
        }
    }
}
