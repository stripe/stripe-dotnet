namespace Stripe
{
    public abstract class StripeService
    {
        protected StripeService(string apiKey)
        {
            ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        protected StripeRequestOptions SetupRequestOptions(StripeRequestOptions requestOptions)
        {
            if (requestOptions == null)
            {
                requestOptions = new StripeRequestOptions();
            }

            if (!string.IsNullOrEmpty(ApiKey))
            {
                requestOptions.ApiKey = ApiKey;
            }

            return requestOptions;
        }
    }
}
