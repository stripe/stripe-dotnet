// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionSubscribePricingPlanSubscriptionDetailsComponentConfigurationOptions : INestedOptions
    {
        /// <summary>
        /// Quantity of the component to be used.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        /// <summary>
        /// Lookup key for the pricing plan component.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }

        /// <summary>
        /// ID of the pricing plan component.
        /// </summary>
        [JsonProperty("pricing_plan_component")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_component")]
#endif
        public string PricingPlanComponent { get; set; }
    }
}
