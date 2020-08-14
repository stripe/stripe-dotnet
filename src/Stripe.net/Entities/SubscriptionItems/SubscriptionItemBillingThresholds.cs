namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemBillingThresholds : StripeEntity<SubscriptionItemBillingThresholds>
    {
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
