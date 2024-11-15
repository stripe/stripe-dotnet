// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceSourceOrderItem : StripeEntity<SourceSourceOrderItem>
    {
        /// <summary>
        /// The amount (price) for this order item.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long? Amount { get; set; }

        /// <summary>
        /// This currency of this order item. Required when <c>amount</c> is present.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// Human-readable description for this order item.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        /// <summary>
        /// The ID of the associated object for this line item. Expandable if not null (e.g.,
        /// expandable to a SKU).
        /// </summary>
        [JsonProperty("parent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("parent")]
#endif

        public string Parent { get; set; }

        /// <summary>
        /// The quantity of this order item. When type is <c>sku</c>, this is the number of
        /// instances of the SKU to be ordered.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif

        public long Quantity { get; set; }

        /// <summary>
        /// The type of this order item. Must be <c>sku</c>, <c>tax</c>, or <c>shipping</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
