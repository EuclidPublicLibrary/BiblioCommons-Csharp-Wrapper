using System;
using System.Runtime.Caching;
using RestSharp;

namespace BiblioCommons.Caching
{
    internal static class Cache
    {
        private static readonly MemoryCache _memoryCache = MemoryCache.Default;

        /// <summary>
        /// Inserts a key-value pair into the cache.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Add(string key, object value)
        {
            try
            {
                var policy = new CacheItemPolicy();
                policy.SlidingExpiration = TimeSpan.FromSeconds(Configuration.Settings.CacheSlidingExpiration);

                _memoryCache.Set(key, value, policy);
            }
            catch (Exception)
            {
            }
        }

        public static bool TryGetValue<T>(string key, out T restResponse)
        {
            try
            {
                var value = _memoryCache.Get(key);

                if (value != null)
                {
                    restResponse = (T)value;
                    return true;
                }

                restResponse = default(T);
                return false;
            }
            catch (Exception)
            {
                restResponse = default(T);
                return false;
            }
        }
    }
}
