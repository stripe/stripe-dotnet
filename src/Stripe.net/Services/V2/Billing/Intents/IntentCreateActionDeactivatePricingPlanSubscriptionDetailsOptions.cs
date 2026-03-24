// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionDeactivatePricingPlanSubscriptionDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Configurations for overriding behaviors related to the subscription.
        /// </summary>
        [JsonProperty("overrides")]
        [STJS.JsonPropertyName("overrides")]
        public IntentCreateActionDeactivatePricingPlanSubscriptionDetailsOverridesOptions Overrides { get; set; }

        /// <summary>
        /// ID of the pricing plan subscription to deactivate.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
        [STJS.JsonPropertyName("pricing_plan_subscription")]
        public string PricingPlanSubscription { get; set; }
    }
}
