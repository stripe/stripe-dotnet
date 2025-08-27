// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionSubscribe : StripeEntity<IntentActionSubscribe>
    {
        /// <summary>
        /// Configuration for the billing details. If not specified, see the default behavior for
        /// individual attributes.
        /// </summary>
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public IntentActionSubscribeBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// When the subscribe action will take effect. If not specified, the default behavior is
        /// on_reserve.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif
        public IntentActionSubscribeEffectiveAt EffectiveAt { get; set; }

        /// <summary>
        /// Type of the action details.
        /// One of: <c>pricing_plan_subscription_details</c>, or <c>v1_subscription_details</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Details for subscribing to a Pricing Plan.
        /// </summary>
        [JsonProperty("pricing_plan_subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription_details")]
#endif
        public IntentActionSubscribePricingPlanSubscriptionDetails PricingPlanSubscriptionDetails { get; set; }

        /// <summary>
        /// Details for subscribing to a V1 subscription.
        /// </summary>
        [JsonProperty("v1_subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("v1_subscription_details")]
#endif
        public IntentActionSubscribeV1SubscriptionDetails V1SubscriptionDetails { get; set; }
    }
}
