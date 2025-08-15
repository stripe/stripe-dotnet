// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCheckoutItemOptions : INestedOptions
    {
        [JsonProperty("key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("key")]
#endif
        public string Key { get; set; }

        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("rate_card_subscription_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_subscription_item")]
#endif
        public SessionCheckoutItemRateCardSubscriptionItemOptions RateCardSubscriptionItem { get; set; }
    }
}
