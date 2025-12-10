// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionModifyOptions : INestedOptions
    {
        /// <summary>
        /// Allows users to override the collect at behavior.
        /// One of: <c>next_billing_date</c>, or <c>on_effective_at</c>.
        /// </summary>
        [JsonProperty("collect_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collect_at")]
#endif
        public string CollectAt { get; set; }

        /// <summary>
        /// When the modify action will take effect. If not specified, the default behavior is
        /// on_reserve.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif
        public IntentCreateActionModifyEffectiveAtOptions EffectiveAt { get; set; }

        /// <summary>
        /// Details for modifying a pricing plan subscription.
        /// </summary>
        [JsonProperty("pricing_plan_subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription_details")]
#endif
        public IntentCreateActionModifyPricingPlanSubscriptionDetailsOptions PricingPlanSubscriptionDetails { get; set; }

        /// <summary>
        /// Type of the action details.
        /// One of: <c>pricing_plan_subscription_details</c>, or <c>v1_subscription_details</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
