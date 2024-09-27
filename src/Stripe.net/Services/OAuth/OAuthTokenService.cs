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
            : base()
        {
        }

        internal OAuthTokenService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        [Obsolete("Please use the constructor that accepts an `ApiRequestor` instead.")]
        public OAuthTokenService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Uri AuthorizeUrl(OAuthAuthorizeUrlOptions options, bool express = false)
        {
            string path = "/oauth/authorize";
            if (express)
            {
                path = "/express" + path;
            }

            options = this.SetupOAuthAuthorizeUrlOptions(options);

            return new Uri(this.Requestor.ConnectBase + path + "?" +
                ContentEncoder.CreateQueryString(options));
        }

        public virtual OAuthToken Create(OAuthTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            options = this.SetupOAuthTokenCreateOptions(options);
            return this.Request<OAuthToken>(BaseAddress.Connect, HttpMethod.Post, "/oauth/token", options, requestOptions);
        }

        public virtual Task<OAuthToken> CreateAsync(OAuthTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            options = this.SetupOAuthTokenCreateOptions(options);
            return this.RequestAsync<OAuthToken>(BaseAddress.Connect, HttpMethod.Post, "/oauth/token", options, requestOptions, cancellationToken);
        }

        public virtual OAuthDeauthorize Deauthorize(OAuthDeauthorizeOptions options, RequestOptions requestOptions = null)
        {
            options = this.SetupOAuthDeauthorizeOptions(options);
            return this.Request<OAuthDeauthorize>(BaseAddress.Connect, HttpMethod.Post, "/oauth/deauthorize", options, requestOptions);
        }

        public virtual Task<OAuthDeauthorize> DeauthorizeAsync(OAuthDeauthorizeOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            options = this.SetupOAuthDeauthorizeOptions(options);
            return this.RequestAsync<OAuthDeauthorize>(BaseAddress.Connect, HttpMethod.Post, "/oauth/deauthorize", options, requestOptions, cancellationToken);
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
                options.ClientId = this.Requestor.ClientId;
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
                options.ClientSecret = this.Requestor.ApiKey;
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
                options.ClientId = this.Requestor.ClientId;
            }

            return options;
        }
    }
}
