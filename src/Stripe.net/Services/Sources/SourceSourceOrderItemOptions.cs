// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SourceSourceOrderItemOptions : INestedOptions
    {
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the SKU being ordered.
        /// </summary>
        [JsonProperty("parent")]
        [STJS.JsonPropertyName("parent")]
        public string Parent { get; set; }

        /// <summary>
        /// The quantity of this order item. When type is <c>sku</c>, this is the number of
        /// instances of the SKU to be ordered.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// One of: <c>discount</c>, <c>shipping</c>, <c>sku</c>, or <c>tax</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
