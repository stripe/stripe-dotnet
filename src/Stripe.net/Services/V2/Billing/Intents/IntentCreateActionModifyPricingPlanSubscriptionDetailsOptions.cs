// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionModifyPricingPlanSubscriptionDetailsOptions : INestedOptions
    {
        /// <summary>
        /// New configurations for the components of the pricing plan.
        /// </summary>
        [JsonProperty("component_configurations")]
        [STJS.JsonPropertyName("component_configurations")]
        public List<IntentCreateActionModifyPricingPlanSubscriptionDetailsComponentConfigurationOptions> ComponentConfigurations { get; set; }

        /// <summary>
        /// The ID of the new Pricing Plan, if changing plans.
        /// </summary>
        [JsonProperty("new_pricing_plan")]
        [STJS.JsonPropertyName("new_pricing_plan")]
        public string NewPricingPlan { get; set; }

        /// <summary>
        /// The ID of the new Pricing Plan Version to use.
        /// </summary>
        [JsonProperty("new_pricing_plan_version")]
        [STJS.JsonPropertyName("new_pricing_plan_version")]
        public string NewPricingPlanVersion { get; set; }

        /// <summary>
        /// Configurations for overriding behaviors related to the subscription.
        /// </summary>
        [JsonProperty("overrides")]
        [STJS.JsonPropertyName("overrides")]
        public IntentCreateActionModifyPricingPlanSubscriptionDetailsOverridesOptions Overrides { get; set; }

        /// <summary>
        /// The ID of the Pricing Plan Subscription to modify.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
        [STJS.JsonPropertyName("pricing_plan_subscription")]
        public string PricingPlanSubscription { get; set; }
    }
}
