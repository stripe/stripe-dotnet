namespace Stripe
{
    public class StripeRequestOptions
    {
        public string ApiKey { get; set; }
        public string StripeConnectAccountId { get; set; }
        public string IdempotencyKey { get; set; }

        // This is used specifically for Ephemeral Keys as they have to be created
        // with a specific API version. It should not be used for anything else which
        // is why it is set as internal.
        internal string StripeVersion { get; set; }
    }
}