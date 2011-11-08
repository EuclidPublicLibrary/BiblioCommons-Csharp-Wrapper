using System.Configuration;

namespace BiblioCommons
{
    internal class Configuration : ConfigurationSection
    {
        private static readonly Configuration settings = ConfigurationManager.GetSection("BiblioCommons") as Configuration;
        public static Configuration Settings { get { return settings; } }

        [ConfigurationProperty("ApiKey", IsRequired=true)]
        public string ApiKey
        {
            get { return (string) this["ApiKey"]; }
        }

        [ConfigurationProperty("ApiVersion", DefaultValue = "v1", IsRequired = false)]
        public string ApiVersion
        {
            get { return (string)this["ApiVersion"]; }
        }

        [ConfigurationProperty("BaseUrl", DefaultValue = "https://api.bibliocommons.com", IsRequired = false)]
        public string BaseUrl
        {
            get { return (string)this["BaseUrl"]; }
        }

        [ConfigurationProperty("ApiQueriesPerSecondLimit", DefaultValue =  2, IsRequired = false)]
        [IntegerValidator(MinValue = 1)]
        public int ApiQueriesPerSecondLimit
        {
            get { return (int)this["ApiQueriesPerSecondLimit"]; }
        }

        [ConfigurationProperty("CacheSlidingExpiration", DefaultValue = 60, IsRequired = false)]
        [IntegerValidator(MinValue = 0)]
        public int CacheSlidingExpiration
        {
            get { return (int)this["CacheSlidingExpiration"]; }
        }

        [ConfigurationProperty("LibraryId", DefaultValue = "euclidlibrary", IsRequired = false)]
        public string LibraryId
        {
            get { return (string)this["LibraryId"]; }
        }

        [ConfigurationProperty("UserAgentPrefix", DefaultValue = "bibliocommons-csharp", IsRequired = false)]
        public string UserAgentPrefix
        {
            get { return (string)this["UserAgentPrefix"]; }
        }
    }
}
