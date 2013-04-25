namespace OAuth2.Configuration
{
    /// <summary>
    /// OAuth2 library configuration.
    /// </summary>
    public interface IOAuth2Configuration
    {
        ServiceCollection Services { get; }

        string RedirectUri { get; }
    }
}