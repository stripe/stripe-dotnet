namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhasePlanBillingThresholdsOptions : INestedOptions
    {
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
