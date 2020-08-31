namespace Stripe
{
    using Newtonsoft.Json;

    public class SkuInventory : StripeEntity<SkuInventory>
    {
        /// <summary>
        /// The count of inventory available. Will be present if and only if <c>type</c> is
        /// <c>finite</c>.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Inventory type. Possible values are <c>finite</c>, <c>bucket</c> (not quantified), and
        /// <c>infinite</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// An indicator of the inventory available. Possible values are <c>in_stock</c>,
        /// <c>limited</c>, and <c>out_of_stock</c>. Will be present if and only if <c>type</c> is
        /// <c>bucket</c>.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
