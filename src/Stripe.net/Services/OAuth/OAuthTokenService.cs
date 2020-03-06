namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure.FormEncoding;

    public class OAuthTokenService : Service<OAuthToken>,
        ICreatable<OAuthToken, OAuthTokenCreateOptions>
    {
        public OAuthTokenService()
            : base(null)
        {
        }

        public OAuthTokenService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/oauth/token";

        public override string BaseUrl => this.Client.ConnectBase;

        public virtual Uri AuthorizeUrl(OAuthAuthorizeUrlOptions options, bool express = false)
        {
            string path = "/oauth/authorize";
            if (express)
            {
                path = "/express" + path;
            }

            options = this.SetupOAuthAuthorizeUrlOptions(options);

            return new Uri(this.Client.ConnectBase + path + "?" +
                FormEncoder.CreateQueryString(options));
        }

        public virtual OAuthToken Create(OAuthTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            options = this.SetupOAuthTokenCreateOptions(options);
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<OAuthToken> CreateAsync(OAuthTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            options = this.SetupOAuthTokenCreateOptions(options);
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual OAuthDeauthorize Deauthorize(OAuthDeauthorizeOptions options, RequestOptions requestOptions = null)
        {
            options = this.SetupOAuthDeauthorizeOptions(options);
            return this.Request<OAuthDeauthorize>(HttpMethod.Post, "/oauth/deauthorize", options, requestOptions);
        }

        public virtual Task<OAuthDeauthorize> DeauthorizeAsync(OAuthDeauthorizeOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            options = this.SetupOAuthDeauthorizeOptions(options);
            return this.RequestAsync<OAuthDeauthorize>(HttpMethod.Post, "/oauth/deauthorize", options, requestOptions, cancellationToken);
        }

        private OAuthAuthorizeUrlOptions SetupOAuthAuthorizeUrlOptions(
            OAuthAuthorizeUrlOptions options)
        {
            if (options == null)
            {
                options = new OAuthAuthorizeUrlOptions();
            }

            if (options.ClientId == null)
            {
                options.ClientId = this.Client.ClientId;
            }

            return options;
        }

        private OAuthTokenCreateOptions SetupOAuthTokenCreateOptions(
            OAuthTokenCreateOptions options)
        {
            if (options == null)
            {
                options = new OAuthTokenCreateOptions();
            }

            if (options.ClientSecret == null)
            {
                options.ClientSecret = this.Client.ApiKey;
            }

            return options;
        }

        private OAuthDeauthorizeOptions SetupOAuthDeauthorizeOptions(
            OAuthDeauthorizeOptions options)
        {
            if (options == null)
            {
                options = new OAuthDeauthorizeOptions();
            }

            if (options.ClientId == null)
            {
                options.ClientId = this.Client.ClientId;
            }

            return options;
        }
    }
}
