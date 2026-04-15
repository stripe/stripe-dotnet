// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionSubscribePricingPlanSubscriptionDetailsComponentConfiguration : StripeEntity<IntentActionSubscribePricingPlanSubscriptionDetailsComponentConfiguration>
    {
        /// <summary>
        /// Lookup key for the pricing plan component.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// ID of the pricing plan component.
        /// </summary>
        [JsonProperty("pricing_plan_component")]
        [STJS.JsonPropertyName("pricing_plan_component")]
        public string PricingPlanComponent { get; set; }

        /// <summary>
        /// Quantity of the component to be used.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }
    }
}
