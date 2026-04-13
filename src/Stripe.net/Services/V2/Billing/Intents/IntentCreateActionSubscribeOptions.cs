// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionSubscribeOptions : INestedOptions
    {
        /// <summary>
        /// When the invoice will be collected. If not specified, defaults to on_effective_at.
        /// One of: <c>next_billing_date</c>, or <c>on_effective_at</c>.
        /// </summary>
        [JsonProperty("collect_at")]
        [STJS.JsonPropertyName("collect_at")]
        public string CollectAt { get; set; }

        /// <summary>
        /// When the subscribe action will take effect. If not specified, the default behavior is
        /// on_reserve.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public IntentCreateActionSubscribeEffectiveAtOptions EffectiveAt { get; set; }

        /// <summary>
        /// Details for subscribing to a pricing plan.
        /// </summary>
        [JsonProperty("pricing_plan_subscription_details")]
        [STJS.JsonPropertyName("pricing_plan_subscription_details")]
        public IntentCreateActionSubscribePricingPlanSubscriptionDetailsOptions PricingPlanSubscriptionDetails { get; set; }

        /// <summary>
        /// Type of the action details.
        /// One of: <c>pricing_plan_subscription_details</c>, or <c>v1_subscription_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Details for subscribing to a v1 subscription.
        /// </summary>
        [JsonProperty("v1_subscription_details")]
        [STJS.JsonPropertyName("v1_subscription_details")]
        public IntentCreateActionSubscribeV1SubscriptionDetailsOptions V1SubscriptionDetails { get; set; }
    }
}
