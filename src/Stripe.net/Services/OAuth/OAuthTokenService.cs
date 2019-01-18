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

        public virtual OAuthDeauthorize Deauthorize(string clientId, string stripeUserId, RequestOptions requestOptions = null)
        {
            // TODO: change this method's signature to accept a OAuthTokenDeauthorizeOptions directly
            var options = new OAuthTokenDeauthorizeOptions
            {
                ClientId = clientId,
                StripeUserId = stripeUserId,
            };
            return this.PostRequest<OAuthDeauthorize>($"{Urls.BaseConnectUrl}/oauth/deauthorize", options, requestOptions);
        }

        public virtual Task<OAuthDeauthorize> DeauthorizeAsync(string clientId, string stripeUserId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // TODO: change this method's signature to accept a OAuthTokenDeauthorizeOptions directly
            var options = new OAuthTokenDeauthorizeOptions
            {
                ClientId = clientId,
                StripeUserId = stripeUserId,
            };
            return this.PostRequestAsync<OAuthDeauthorize>($"{Urls.BaseConnectUrl}/oauth/deauthorize", options, requestOptions, cancellationToken);
        }
    }
}
