using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeOAuthTokenService : StripeService
    {
        public StripeOAuthTokenService(string apiKey = null) : base(apiKey) { }



        //Sync
        public virtual StripeOAuthToken Create(StripeOAuthTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeOAuthToken>.MapFromJson(
                Requestor.PostStringBearer(this.ApplyAllParameters(createOptions, Urls.OAuthToken, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeOAuthDeauthorize Deauthorize(string clientId, string stripeUserId, StripeRequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.OAuthDeauthorize, "client_id", clientId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "stripe_user_id", stripeUserId);

            return Mapper<StripeOAuthDeauthorize>.MapFromJson(
                Requestor.PostString(url, SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeOAuthToken> CreateAsync(StripeOAuthTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeOAuthToken>.MapFromJson(
                await Requestor.PostStringBearerAsync(this.ApplyAllParameters(createOptions, Urls.OAuthToken, false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeOAuthDeauthorize> DeauthorizeAsync(string clientId, string stripeUserId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.OAuthDeauthorize, "client_id", clientId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "stripe_user_id", stripeUserId);

            return Mapper<StripeOAuthDeauthorize>.MapFromJson(
                await Requestor.PostStringAsync(url, SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
    }
}
