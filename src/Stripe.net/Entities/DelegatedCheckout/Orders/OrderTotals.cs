// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderTotals : StripeEntity<OrderTotals>
    {
        /// <summary>
        /// The discount amount for the order.
        /// </summary>
        [JsonProperty("discount")]
        [STJS.JsonPropertyName("discount")]
        public long? Discount { get; set; }

        /// <summary>
        /// The fulfillment amount for the order.
        /// </summary>
        [JsonProperty("fulfillment")]
        [STJS.JsonPropertyName("fulfillment")]
        public long? Fulfillment { get; set; }

        /// <summary>
        /// The subtotal amount for the order.
        /// </summary>
        [JsonProperty("subtotal")]
        [STJS.JsonPropertyName("subtotal")]
        public long? Subtotal { get; set; }

        /// <summary>
        /// The tax amount for the order.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public long? Tax { get; set; }

        /// <summary>
        /// The total amount for the order.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public long? Total { get; set; }
    }
}
