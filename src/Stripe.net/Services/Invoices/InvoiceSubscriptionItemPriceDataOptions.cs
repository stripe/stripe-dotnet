namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceSubscriptionItemPriceDataOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the product that this price will belong to.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// The recurring components of a price such as <c>interval</c> and <c>usage_type</c>.
        /// </summary>
        [JsonProperty("recurring")]
        public InvoiceSubscriptionItemPriceDataRecurringOptions Recurring { get; set; }

        /// <summary>
        /// A positive integer in %s (or 0 for a free price) representing how much to charge.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but accepts a decimal value with at most 12 decimal places.
        /// Only one of <c>unit_amount</c> and <c>unit_amount_decimal</c> can be set, but at least
        /// one is required.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
