using System.Configuration;
using OAuth2.Infrastructure;

namespace OAuth2.Configuration
{
    /// <summary>
    /// Library configuration section handler.
    /// </summary>
    public class OAuth2ConfigurationSection : ConfigurationSection, IOAuth2Configuration
    {
        private const string RedirectUriKey = "redirectUri";

        private const string CollectionName = "services";

        /// <summary>
        /// Redirect URI (URI user will be redirected to 
        /// after authentication using third-party service).
        /// </summary>
        [ConfigurationProperty(RedirectUriKey, IsRequired = true)]
        public string RedirectUri
        {
            get
            {
                return UriUtility.ToAbsolute((string) this[RedirectUriKey]);
            }
        }


        [ConfigurationProperty(CollectionName), ConfigurationCollection(typeof(ServiceCollection))]
        public ServiceCollection Services
        {
            get { return (ServiceCollection) base[CollectionName]; }
        }
    }
}