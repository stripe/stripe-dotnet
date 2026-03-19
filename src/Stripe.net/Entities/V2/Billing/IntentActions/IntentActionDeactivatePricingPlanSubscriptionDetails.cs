// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionDeactivatePricingPlanSubscriptionDetails : StripeEntity<IntentActionDeactivatePricingPlanSubscriptionDetails>
    {
        /// <summary>
        /// Configurations for overriding behaviors related to the subscription.
        /// </summary>
        [JsonProperty("overrides")]
        [STJS.JsonPropertyName("overrides")]
        public IntentActionDeactivatePricingPlanSubscriptionDetailsOverrides Overrides { get; set; }

        /// <summary>
        /// ID of the Pricing Plan Subscription to deactivate.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
        [STJS.JsonPropertyName("pricing_plan_subscription")]
        public string PricingPlanSubscription { get; set; }
    }
}
