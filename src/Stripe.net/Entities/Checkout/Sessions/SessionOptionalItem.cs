// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionOptionalItem : StripeEntity<SessionOptionalItem>
    {
        [JsonProperty("adjustable_quantity")]
        [STJS.JsonPropertyName("adjustable_quantity")]
        public SessionOptionalItemAdjustableQuantity AdjustableQuantity { get; set; }

        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
