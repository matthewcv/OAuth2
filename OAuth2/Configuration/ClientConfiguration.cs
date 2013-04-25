using System.Configuration;
using OAuth2.Infrastructure;

namespace OAuth2.Configuration
{
    /// <summary>
    /// Contains settings for service client.
    /// </summary>
    public class ClientConfiguration : ConfigurationElement, IClientConfiguration
    {
        private const string ProviderNameKey = "providerName";
        private const string ClientIdKey = "clientId";
        private const string EnabledKey = "enabled";
        private const string ClientSecretKey = "clientSecret";
        private const string ClientPublicKey = "clientPublic";
        private const string ScopeKey = "scope";
        private const string RedirectUriKey = "redirectUri";

        /// <summary>
        /// Name of client type.
        /// </summary>
        [ConfigurationProperty(ProviderNameKey, IsRequired = true, IsKey = true)]
        public string ProviderName
        {
            get { return (string)this[ProviderNameKey]; }
        }
        
        /// <summary>
        /// Client ID (ID of your application).
        /// </summary>
        [ConfigurationProperty(ClientIdKey, IsRequired = true)]
        public string ClientId
        {
            get { return (string) this[ClientIdKey]; }
        }

        /// <summary>
        /// Client state: enabled or disabled.
        /// </summary>
        [ConfigurationProperty(EnabledKey, DefaultValue = true)]
        public bool IsEnabled
        {
            get { return (bool)this[EnabledKey]; }
        }

        /// <summary>
        /// Client secret.
        /// </summary>
        [ConfigurationProperty(ClientSecretKey, IsRequired = true)]
        public string ClientSecret
        {
            get { return (string) this[ClientSecretKey]; }
        }

        /// <summary>
        /// Client secret.
        /// </summary>
        [ConfigurationProperty(ClientPublicKey)]
        public string ClientPublic
        {
            get { return (string)this[ClientPublicKey]; }
        }

        /// <summary>
        /// Scope - contains set of permissions which user should give to your application.
        /// </summary>
        [ConfigurationProperty(ScopeKey)]
        public string Scope
        {
            get { return (string) this[ScopeKey]; }
        }


    }
}