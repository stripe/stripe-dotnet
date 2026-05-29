// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderLineItemTotals : StripeEntity<OrderLineItemTotals>
    {
        /// <summary>
        /// The base amount for the line item.
        /// </summary>
        [JsonProperty("base_amount")]
        [STJS.JsonPropertyName("base_amount")]
        public long? BaseAmount { get; set; }

        /// <summary>
        /// The discount amount for the line item.
        /// </summary>
        [JsonProperty("discount")]
        [STJS.JsonPropertyName("discount")]
        public long? Discount { get; set; }

        /// <summary>
        /// The subtotal amount for the line item.
        /// </summary>
        [JsonProperty("subtotal")]
        [STJS.JsonPropertyName("subtotal")]
        public long? Subtotal { get; set; }

        /// <summary>
        /// The tax amount for the line item.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public long? Tax { get; set; }

        /// <summary>
        /// The total amount for the line item.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public long? Total { get; set; }
    }
}
