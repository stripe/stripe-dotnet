// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionDeactivatePricingPlanSubscriptionDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Allows users to override the partial period behavior.
        /// </summary>
        [JsonProperty("overrides")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("overrides")]
#endif
        public IntentCreateActionDeactivatePricingPlanSubscriptionDetailsOverridesOptions Overrides { get; set; }

        /// <summary>
        /// ID of the pricing plan subscription to deactivate.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription")]
#endif
        public string PricingPlanSubscription { get; set; }
    }
}
