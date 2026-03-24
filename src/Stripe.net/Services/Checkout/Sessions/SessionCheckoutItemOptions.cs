// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionCheckoutItemOptions : INestedOptions
    {
        /// <summary>
        /// One of: <c>rate_card_subscription_item</c>, or <c>pricing_plan_subscription_item</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("rate_card_subscription_item")]
        [STJS.JsonPropertyName("rate_card_subscription_item")]
        public SessionCheckoutItemRateCardSubscriptionItemOptions RateCardSubscriptionItem { get; set; }

        [JsonProperty("pricing_plan_subscription_item")]
        [STJS.JsonPropertyName("pricing_plan_subscription_item")]
        public SessionCheckoutItemPricingPlanSubscriptionItemOptions PricingPlanSubscriptionItem { get; set; }
    }
}
