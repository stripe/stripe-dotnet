// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionOptionalItem : StripeEntity<SessionOptionalItem>
    {
        [JsonProperty("adjustable_quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adjustable_quantity")]
#endif
        public SessionOptionalItemAdjustableQuantity AdjustableQuantity { get; set; }

        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }

        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long Quantity { get; set; }
    }
}
