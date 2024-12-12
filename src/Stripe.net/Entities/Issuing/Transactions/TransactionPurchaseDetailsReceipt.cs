// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionPurchaseDetailsReceipt : StripeEntity<TransactionPurchaseDetailsReceipt>
    {
        /// <summary>
        /// The description of the item. The maximum length of this field is 26 characters.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The quantity of the item.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The total for this line item in cents.
        /// </summary>
        [JsonProperty("total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total")]
#endif
        public long? Total { get; set; }

        /// <summary>
        /// The unit cost of the item in cents.
        /// </summary>
        [JsonProperty("unit_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_cost")]
#endif
        public long? UnitCost { get; set; }
    }
}
