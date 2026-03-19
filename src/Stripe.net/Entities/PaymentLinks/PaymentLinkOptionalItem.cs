// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkOptionalItem : StripeEntity<PaymentLinkOptionalItem>
    {
        [JsonProperty("adjustable_quantity")]
        [STJS.JsonPropertyName("adjustable_quantity")]
        public PaymentLinkOptionalItemAdjustableQuantity AdjustableQuantity { get; set; }

        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
