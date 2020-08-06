namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhasePlanBillingThresholds : StripeEntity<SubscriptionSchedulePhasePlanBillingThresholds>
    {
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
