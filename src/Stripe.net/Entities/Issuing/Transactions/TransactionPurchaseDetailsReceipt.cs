namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionPurchaseDetailsReceipt : StripeEntity<TransactionPurchaseDetailsReceipt>
    {
        /// <summary>
        /// The description of the item. The maximum length of this field is 26 characters.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The quantity of the item.
        /// </summary>
        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The total for this line item in cents.
        /// </summary>
        [JsonProperty("total")]
        public long? Total { get; set; }

        /// <summary>
        /// The unit cost of the item in cents.
        /// </summary>
        [JsonProperty("unit_cost")]
        public long? UnitCost { get; set; }
    }
}
