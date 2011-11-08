using System.Collections.Generic;
using RestSharp;

namespace BiblioCommons
{
    public partial class BiblioCommonsRestClient
    {
        /// <summary>
        /// Returns basic information about a given library, specified by library ID.
        /// </summary>
        /// <param name="libraryId">The library ID.  Each library's BiblioCommons catalog will have a 
        ///                  hostname of the form {id}.bibliocommons.com.  The {id} portion of 
        ///                  the hostname is the library's ID.</param>
        /// <returns>A library instance for the provided library id.</returns>
        public Library GetLibrary(string libraryId = null)
        {
            //if (string.IsNullOrEmpty(libraryId))
            //    libraryId = Configuration.Settings.LibraryId;

            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId;

            var request = new RestRequest();
            request.Resource = "libraries/{id}";
            request.RootElement = "library";
            request.AddParameter("id", libraryId, ParameterType.UrlSegment);

            return Execute<Library>(request);
        }


        /// <summary>
        /// Returns the list of locations for a given library, specified by library ID, with basic information about each location.
        /// </summary>
        /// <param name="libraryId">The library ID.  Each library's BiblioCommons catalog will have a 
        ///                  hostname of the form {id}.bibliocommons.com.  The {id} portion of 
        ///                  the hostname is the library's ID.</param>
        /// <returns>A list of locations for the provided library id.</returns>
        public Locations GetLibraryLocations(string libraryId = null)
        {
            // If no Library Id is provided then use the default Library Id.
            if (string.IsNullOrEmpty(libraryId))
                libraryId = Configuration.Settings.LibraryId;

            var request = new RestRequest();
            request.Resource = "libraries/{id}/locations";
            request.AddParameter("id", libraryId, ParameterType.UrlSegment);
            request.AddParameter("metadata", 1);

            return Execute<Locations>(request);
        }
    }
}
