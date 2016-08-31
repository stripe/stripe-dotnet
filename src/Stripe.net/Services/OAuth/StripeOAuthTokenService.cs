using System.Threading.Tasks;

﻿namespace Stripe
{
    public class StripeOAuthTokenService : StripeService
    {
        public StripeOAuthTokenService(string apiKey = null) : base(apiKey) { }

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

        public virtual async Task<StripeOAuthToken> CreateAsync(StripeOAuthTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeOAuthToken>.MapFromJson(
                await Requestor.PostStringBearerAsync(this.ApplyAllParameters(createOptions, Urls.OAuthToken, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeOAuthDeauthorize> DeauthorizeAsync(string clientId, string stripeUserId, StripeRequestOptions requestOptions = null)
        {
            var url = ParameterBuilder.ApplyParameterToUrl(Urls.OAuthDeauthorize, "client_id", clientId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "stripe_user_id", stripeUserId);

            return Mapper<StripeOAuthDeauthorize>.MapFromJson(
                await Requestor.PostStringAsync(url, SetupRequestOptions(requestOptions))
            );
        }
    }
}
