#region License
// Copyright (c) 2011 Euclid Public Library
#endregion

using RestSharp;

namespace BiblioCommons
{
    /// <summary>
    /// Adds the ApiKey to all BiblioCommons API requests.
    /// </summary>
    internal class ApiKeyAuthenticator : IAuthenticator
    {
        private string _apiKey;

        public ApiKeyAuthenticator(string apiKey)
        {
            _apiKey = apiKey;
        }

        #region Implementation of IAuthenticator

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddParameter("api_Key", _apiKey);
        }

        #endregion
    }
}
