// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionModifyPricingPlanSubscriptionDetailsOptions : INestedOptions
    {
        /// <summary>
        /// New configurations for the components of the pricing plan.
        /// </summary>
        [JsonProperty("component_configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("component_configurations")]
#endif
        public List<IntentCreateActionModifyPricingPlanSubscriptionDetailsComponentConfigurationOptions> ComponentConfigurations { get; set; }

        /// <summary>
        /// ID of the new pricing plan, if changing plans.
        /// </summary>
        [JsonProperty("new_pricing_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("new_pricing_plan")]
#endif
        public string NewPricingPlan { get; set; }

        /// <summary>
        /// Version of the pricing plan to use.
        /// </summary>
        [JsonProperty("new_pricing_plan_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("new_pricing_plan_version")]
#endif
        public string NewPricingPlanVersion { get; set; }

        /// <summary>
        /// ID of the pricing plan subscription to modify.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription")]
#endif
        public string PricingPlanSubscription { get; set; }
    }
}
