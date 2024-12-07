namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionSchedulePhasePlanBillingThresholdsOptions : INestedOptions
    {
        [JsonProperty("usage_gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_gte")]
#endif
        public long? UsageGte { get; set; }
    }
}
