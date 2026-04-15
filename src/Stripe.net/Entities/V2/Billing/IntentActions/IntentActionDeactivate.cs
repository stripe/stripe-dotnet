// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionDeactivate : StripeEntity<IntentActionDeactivate>
    {
        /// <summary>
        /// Details about why the cancellation was requested by the user.
        /// </summary>
        [JsonProperty("cancellation_details")]
        [STJS.JsonPropertyName("cancellation_details")]
        public IntentActionDeactivateCancellationDetails CancellationDetails { get; set; }

        /// <summary>
        /// Allows users to override the collect at behavior.
        /// One of: <c>next_billing_date</c>, or <c>on_effective_at</c>.
        /// </summary>
        [JsonProperty("collect_at")]
        [STJS.JsonPropertyName("collect_at")]
        public string CollectAt { get; set; }

        /// <summary>
        /// When the deactivate action will take effect. If not specified, the default behavior is
        /// on_reserve.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public IntentActionDeactivateEffectiveAt EffectiveAt { get; set; }

        /// <summary>
        /// Details for deactivating a Pricing Plan Subscription.
        /// </summary>
        [JsonProperty("pricing_plan_subscription_details")]
        [STJS.JsonPropertyName("pricing_plan_subscription_details")]
        public IntentActionDeactivatePricingPlanSubscriptionDetails PricingPlanSubscriptionDetails { get; set; }

        /// <summary>
        /// Type of the action details.
        /// One of: <c>pricing_plan_subscription_details</c>, or <c>v1_subscription_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
