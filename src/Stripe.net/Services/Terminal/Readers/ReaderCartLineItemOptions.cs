// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderCartLineItemOptions : INestedOptions
    {
        /// <summary>
        /// The price of the item in cents.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The description or name of the item.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The quantity of the line item being purchased.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
