// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionCheckoutItemPricingPlanSubscriptionItemOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("pricing_plan")]
        [STJS.JsonPropertyName("pricing_plan")]
        public string PricingPlan { get; set; }

        [JsonProperty("pricing_plan_version")]
        [STJS.JsonPropertyName("pricing_plan_version")]
        public string PricingPlanVersion { get; set; }

        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("component_configurations")]
        [STJS.JsonPropertyName("component_configurations")]
        public Dictionary<string, SessionCheckoutItemPricingPlanSubscriptionItemComponentConfigurationsOptions> ComponentConfigurations { get; set; }
    }
}
