namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionLineItemPriceDataOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the product that this price will belong to. One of <c>product</c> or
        /// <c>product_data</c> is required.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// Data used to generate a new product object inline. One of <c>product</c> or
        /// <c>product_data</c> is required.
        /// </summary>
        [JsonProperty("product_data")]
        public SessionLineItemPriceDataProductDataOptions ProductData { get; set; }

        /// <summary>
        /// The recurring components of a price such as <c>interval</c> and <c>usage_type</c>.
        /// </summary>
        [JsonProperty("recurring")]
        public SessionLineItemPriceDataRecurringOptions Recurring { get; set; }

        /// <summary>
        /// A positive integer in %s representing how much to charge. One of <c>unit_amount</c> or
        /// <c>unit_amount_decimal</c> is required.
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
