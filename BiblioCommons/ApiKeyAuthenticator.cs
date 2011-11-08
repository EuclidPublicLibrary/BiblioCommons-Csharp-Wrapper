using RestSharp;

namespace BiblioCommons
{
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
