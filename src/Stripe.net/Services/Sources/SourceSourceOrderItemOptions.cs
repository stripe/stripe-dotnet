namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SourceSourceOrderItemOptions : INestedOptions
    {
        /// <summary>
        /// The amount (price) for this order item.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// This currency of this order item. Required when amount is present.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Human-readable description for this order item.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The quantity of this order item. When type is <c>sku</c>, this is
        /// the number of instances of the SKU to be ordered.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The type of this order item. Must be <c>sku</c>, <c>tax</c>, or
        /// <c>shipping</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
