// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCheckoutItemPricingPlanSubscriptionItemOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("pricing_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan")]
#endif
        public string PricingPlan { get; set; }

        [JsonProperty("pricing_plan_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_version")]
#endif
        public string PricingPlanVersion { get; set; }

        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("component_configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("component_configurations")]
#endif
        public Dictionary<string, SessionCheckoutItemPricingPlanSubscriptionItemComponentConfigurationsOptions> ComponentConfigurations { get; set; }
    }
}
