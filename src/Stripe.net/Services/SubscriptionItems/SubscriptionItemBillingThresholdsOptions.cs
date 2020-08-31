namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemBillingThresholdsOptions : INestedOptions
    {
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
