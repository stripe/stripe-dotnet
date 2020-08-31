namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceSourceOrderItem : StripeEntity<SourceSourceOrderItem>
    {
        /// <summary>
        /// The amount (price) for this order item.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// This currency of this order item. Required when <c>amount</c> is present.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Human-readable description for this order item.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the associated object for this line item. Expandable if not null (e.g.,
        /// expandable to a SKU).
        /// </summary>
        [JsonProperty("parent")]
        public string Parent { get; set; }

        /// <summary>
        /// The quantity of this order item. When type is <c>sku</c>, this is the number of
        /// instances of the SKU to be ordered.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The type of this order item. Must be <c>sku</c>, <c>tax</c>, or <c>shipping</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
