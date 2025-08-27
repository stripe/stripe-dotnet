// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCheckoutItem : StripeEntity<SessionCheckoutItem>
    {
        /// <summary>
        /// One of: <c>rate_card_subscription_item</c>, or <c>pricing_plan_subscription_item</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("rate_card_subscription_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_subscription_item")]
#endif
        public SessionCheckoutItemRateCardSubscriptionItem RateCardSubscriptionItem { get; set; }

        [JsonProperty("pricing_plan_subscription_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription_item")]
#endif
        public SessionCheckoutItemPricingPlanSubscriptionItem PricingPlanSubscriptionItem { get; set; }
    }
}
