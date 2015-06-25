namespace Stripe
{
    public abstract class StripeService
    {
        public string ApiKey { get; set; }

        public string StripeAccountId { get; set; }

        public StripeService(string apiKey, string stripeAccountId)
        {
            ApiKey = apiKey;
            StripeAccountId = stripeAccountId;
        }
    }
}
