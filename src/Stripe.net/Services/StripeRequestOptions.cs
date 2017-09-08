namespace Stripe
{
    public class StripeRequestOptions
    {
        public string ApiKey { get; set; }
        public string StripeConnectAccountId { get; set; }
        public string IdempotencyKey { get; set; }
        // This is used specifically for Ephemeral Keys as they have to be created
        // with a specific API version. Don't use it for anything else.
        internal string StripeVersion { get; set; }
    }
}