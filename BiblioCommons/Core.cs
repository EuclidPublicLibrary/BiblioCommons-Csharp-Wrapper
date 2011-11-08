using System;
using System.Net;
using System.Reflection;
using System.Runtime.Caching;
using BiblioCommons.Caching;
using BiblioCommons.Exceptions;
using RestSharp;
using RestSharp.Deserializers;

namespace BiblioCommons
{
    public partial class BiblioCommonsRestClient
    {
        /// <summary>
        /// RestSharp Rest Client used to make requests.
        /// </summary>
        private readonly IRestClient _client;

        /// <summary>
        /// Initializes a new client with the specified API Key.
        /// </summary>
        public BiblioCommonsRestClient(bool isCachingEnabled = true, bool isRateLimitingEnable = true)
        {           
            // Enable client services
            IsCachingEnabled = isCachingEnabled;
            IsRateLimitingEnabled = isRateLimitingEnable;

            // silverlight friendly way to get current version
			var assembly = Assembly.GetExecutingAssembly();
			var assemblyName = new AssemblyName(assembly.FullName);
			var version = assemblyName.Version;

            _client = new RestClient
                          {
                              UserAgent = string.Format("{0}{1}", Configuration.Settings.UserAgentPrefix, version),
                              Authenticator = new ApiKeyAuthenticator(Configuration.Settings.ApiKey),
                              BaseUrl = string.Format("{0}/{1}", Configuration.Settings.BaseUrl, Configuration.Settings.ApiVersion)
                          };
        }


        #region Client Services Configuration

        /// <summary>
        /// Controls the caching of query responses.  Query caching is enabled by default.
        /// </summary>
        public bool IsCachingEnabled { get; set; }


        /// <summary>
        /// Controls the rate limiting of queries using a sliding expiration window based
        /// on last access or insert.  Rate limiting is enabled by default.
        /// </summary>
        public bool IsRateLimitingEnabled { get; set; }

        #endregion

        #region FRAMEWORK

        /// <summary>
        /// Execute a manual REST request.  Method is used internally by the wrapper to execute REST API calls.
        /// </summary>
        /// <typeparam name="T">The type of object to create and populate with the returned data.</typeparam>
        /// <param name="request">The RestRequest to execute (will use client credentials)</param>
        internal T Execute<T>(RestRequest request) where T : new()
        {
            T cachedItem;

            var cachekey = _client.BuildUri(request).ToString();

            // When caching is turned on we will first check the cache for
            // a the request.  If a cached response is found then we will
            // return it instead of requesting it from the web service.
            if (IsCachingEnabled && Cache.TryGetValue<T>(cachekey, out cachedItem))
                return cachedItem;

            // When rate limiting is turned on we will ensure that the maximum 
            // QPS is enforced.
            if (IsRateLimitingEnabled)
                RateGateSingleton.Instance.Gate.WaitToProceed();

            // For when the API returns an error we will ensure that the RestException
            // props are populated.
            request.OnBeforeDeserialization = (resp) =>
            {
                // Rethrow any network related errors.
                if (resp.ResponseStatus != ResponseStatus.Completed)
                    throw resp.ErrorException;

                // The BiblioCommons API uses Mashery.com as the underlying provider.
                // When the mashery systems detects an error the content of the response
                // will start with an h1 html tag.
                if (resp.Content.StartsWith("<h1>"))
                {
                    throw new MasheryException(resp.Content, resp.ResponseUri.ToString());
                }

                // Generally if no network related problem or aforementioned speacial error 
                // condition is detected then all other errors should be caught here.
                if (((int)resp.StatusCode) >= 400)
                {
                    try
                    {
                        var ds = new JsonDeserializer { RootElement = "error" };
                        var error = ds.Deserialize<RestError>(resp);

                        throw new RestException(error.message, error.request);
                    }
                    catch (Exception ex)
                    {
                        // In case there is a deserializion error we will wrap and throw the contents
                        // of the response.  This should catch those undocumented error responses we
                        // may recieve.
                        throw ex;
                    }
                }
            };

            // Send the request to the BilioCommons API.
            var response = _client.Execute<T>(request);

            // Rethrow any uncaught errors
            if (response.ErrorException != null)
                throw response.ErrorException;

            // When caching is turned on and the request resulted in
            // no errors we will cache the response.
            if (IsCachingEnabled) 
                Cache.Add(cachekey, response.Data);

            return response.Data;
        }

        #endregion
    }
}
