namespace Stripe
{
    public abstract class StripeService
    {
        public string ApiKey { get; set; }

        public StripeService(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}
