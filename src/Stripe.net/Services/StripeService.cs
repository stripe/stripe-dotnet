namespace Stripe
{
    public abstract class StripeService
    {
        protected StripeService(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        protected StripeRequestOptions SetupRequestOptions(StripeRequestOptions requestOptions)
        {
            if (requestOptions == null)
            {
                requestOptions = new StripeRequestOptions();
            }

            if (!string.IsNullOrEmpty(this.ApiKey))
            {
                requestOptions.ApiKey = this.ApiKey;
            }

            return requestOptions;
        }
    }
}
