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

        public virtual OAuthToken Create(OAuthTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseConnectUrl}/oauth/token", requestOptions, options);
        }

        public virtual Task<OAuthToken> CreateAsync(OAuthTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseConnectUrl}/oauth/token", requestOptions, cancellationToken, options);
        }

        public virtual OAuthDeauthorize Deauthorize(string clientId, string stripeUserId, RequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.BaseConnectUrl}/oauth/deauthorize", "client_id", clientId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "stripe_user_id", stripeUserId);

            return this.PostRequest<OAuthDeauthorize>(url, null, requestOptions);
        }

        public virtual Task<OAuthDeauthorize> DeauthorizeAsync(string clientId, string stripeUserId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl($"{Urls.BaseConnectUrl}/oauth/deauthorize", "client_id", clientId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "stripe_user_id", stripeUserId);

            return this.PostRequestAsync<OAuthDeauthorize>(url, null, requestOptions, cancellationToken);
        }
    }
}
