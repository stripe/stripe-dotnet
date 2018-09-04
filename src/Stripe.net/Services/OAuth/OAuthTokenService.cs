namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class OAuthTokenService : StripeService,
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

        public virtual OAuthToken Create(OAuthTokenCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<OAuthToken>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.OAuthToken, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual OAuthDeauthorize Deauthorize(string clientId, string stripeUserId, RequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.OAuthDeauthorize, "client_id", clientId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "stripe_user_id", stripeUserId);

            return Mapper<OAuthDeauthorize>.MapFromJson(
                Requestor.PostString(url, this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<OAuthToken> CreateAsync(OAuthTokenCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<OAuthToken>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.OAuthToken, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<OAuthDeauthorize> DeauthorizeAsync(string clientId, string stripeUserId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.OAuthDeauthorize, "client_id", clientId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "stripe_user_id", stripeUserId);

            return Mapper<OAuthDeauthorize>.MapFromJson(
                await Requestor.PostStringAsync(
                    url,
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
