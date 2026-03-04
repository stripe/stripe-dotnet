// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionDeactivatePricingPlanSubscriptionDetails : StripeEntity<IntentActionDeactivatePricingPlanSubscriptionDetails>
    {
        /// <summary>
        /// Configurations for overriding behaviors related to the subscription.
        /// </summary>
        [JsonProperty("overrides")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("overrides")]
#endif
        public IntentActionDeactivatePricingPlanSubscriptionDetailsOverrides Overrides { get; set; }

        /// <summary>
        /// ID of the Pricing Plan Subscription to deactivate.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription")]
#endif
        public string PricingPlanSubscription { get; set; }
    }
}
