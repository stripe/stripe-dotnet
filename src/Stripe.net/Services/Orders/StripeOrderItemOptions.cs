using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOrderItemOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the SKU being ordered.
        /// </summary>
        [JsonProperty("parent")]
        public string Parent { get; set; }

        /// <summary>
        /// The quantity of this order item. When type is sku, this is the number of instances of the SKU to be ordered.
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
