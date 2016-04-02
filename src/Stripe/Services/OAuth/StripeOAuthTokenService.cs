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

#if !PORTABLE
        public virtual async Task<StripeOAuthToken> CreateAsync(StripeOAuthTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeOAuthToken>.MapFromJson(
                await Requestor.PostStringBearerAsync(this.ApplyAllParameters(createOptions, Urls.OAuthToken, false),
                SetupRequestOptions(requestOptions))
            );
        }
#endif
    }
}
