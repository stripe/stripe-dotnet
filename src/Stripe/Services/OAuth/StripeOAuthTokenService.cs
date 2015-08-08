namespace Stripe
{
    public class StripeOAuthTokenService : StripeService
    {
        public StripeOAuthTokenService(string apiKey = null) : base(apiKey) { }

        public virtual StripeOAuthToken Create(StripeOAuthTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(createOptions, Urls.OAuthToken, false);

            var response = Requestor.PostStringBearer(url, requestOptions);

            return Mapper<StripeOAuthToken>.MapFromJson(response);
        }
    }
}
