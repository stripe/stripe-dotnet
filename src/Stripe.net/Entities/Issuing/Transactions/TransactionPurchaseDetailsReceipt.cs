// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionPurchaseDetailsReceipt : StripeEntity<TransactionPurchaseDetailsReceipt>
    {
        /// <summary>
        /// The description of the item. The maximum length of this field is 26 characters.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The quantity of the item.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The total for this line item in cents.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public long? Total { get; set; }

        /// <summary>
        /// The unit cost of the item in cents.
        /// </summary>
        [JsonProperty("unit_cost")]
        [STJS.JsonPropertyName("unit_cost")]
        public long? UnitCost { get; set; }
    }
}
