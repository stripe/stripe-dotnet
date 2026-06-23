namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class SubscriptionSchedulePhasePlanBillingThresholds : StripeEntity<SubscriptionSchedulePhasePlanBillingThresholds>
    {
        [JsonProperty("usage_gte")]
        [STJS.JsonPropertyName("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
