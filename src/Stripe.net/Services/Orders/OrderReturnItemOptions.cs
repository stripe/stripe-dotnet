namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderReturnItemOptions : INestedOptions
    {
        /// <summary>
        /// The amount (price) for this order item to return.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// If returning a tax item, use description to disambiguate which one
        /// to return.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the SKU, tax, or shipping item being returned.
        /// </summary>
        [JsonProperty("parent")]
        public string Parent { get; set; }

        /// <summary>
        /// When type is sku, this is the number of instances of the SKU to be
        /// returned.
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
