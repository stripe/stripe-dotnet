namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class OAuthTokenService : Service<OAuthToken>,
        ICreatable<OAuthToken, OAuthTokenCreateOptions>
    {
        public OAuthTokenService()
            : base(null)
        {
        }

        public OAuthTokenService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => null;

        public virtual OAuthToken Create(OAuthTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.PostRequest<OAuthToken>($"{Urls.BaseConnectUrl}/oauth/token", options, requestOptions);
        }

        public virtual Task<OAuthToken> CreateAsync(OAuthTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<OAuthToken>($"{Urls.BaseConnectUrl}/oauth/token", options, requestOptions, cancellationToken);
        }

        public virtual OAuthDeauthorize Deauthorize(OAuthTokenDeauthorizeOptions options, RequestOptions requestOptions = null)
        {
            return this.PostRequest<OAuthDeauthorize>($"{Urls.BaseConnectUrl}/oauth/deauthorize", options, requestOptions);
        }

        public virtual Task<OAuthDeauthorize> DeauthorizeAsync(OAuthTokenDeauthorizeOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<OAuthDeauthorize>($"{Urls.BaseConnectUrl}/oauth/deauthorize", options, requestOptions, cancellationToken);
        }
    }
}
