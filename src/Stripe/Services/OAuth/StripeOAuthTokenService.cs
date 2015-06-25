namespace Stripe
{
    public class StripeOAuthTokenService : StripeService
    {
        public StripeOAuthTokenService(string apiKey = null, string stripeAccountId = null) : base(apiKey, stripeAccountId) { }

        public virtual StripeOAuthToken Create(StripeOAuthTokenCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.OAuthToken, false);

            var response = Requestor.PostStringBearer(url, ApiKey, StripeAccountId);

            return Mapper<StripeOAuthToken>.MapFromJson(response);
        }
    }
}
