// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionModifyPricingPlanSubscriptionDetails : StripeEntity<IntentActionModifyPricingPlanSubscriptionDetails>
    {
        /// <summary>
        /// New configurations for the components of the Pricing Plan.
        /// </summary>
        [JsonProperty("component_configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("component_configurations")]
#endif
        public List<IntentActionModifyPricingPlanSubscriptionDetailsComponentConfiguration> ComponentConfigurations { get; set; }

        /// <summary>
        /// ID of the new Pricing Plan.
        /// </summary>
        [JsonProperty("new_pricing_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("new_pricing_plan")]
#endif
        public string NewPricingPlan { get; set; }

        /// <summary>
        /// Version of the Pricing Plan to use.
        /// </summary>
        [JsonProperty("new_pricing_plan_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("new_pricing_plan_version")]
#endif
        public string NewPricingPlanVersion { get; set; }

        /// <summary>
        /// ID of the Pricing Plan Subscription to modify.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription")]
#endif
        public string PricingPlanSubscription { get; set; }
    }
}
