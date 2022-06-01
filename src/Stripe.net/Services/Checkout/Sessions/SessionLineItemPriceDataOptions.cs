// File generated from our OpenAPI spec
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
        /// The recurring components of a price such as <c>interval</c> and <c>interval_count</c>.
        /// </summary>
        [JsonProperty("recurring")]
        public SessionLineItemPriceDataRecurringOptions Recurring { get; set; }

        /// <summary>
        /// Specifies whether the price is considered inclusive of taxes or exclusive of taxes. One
        /// of <c>inclusive</c>, <c>exclusive</c>, or <c>unspecified</c>. Once specified as either
        /// <c>inclusive</c> or <c>exclusive</c>, it cannot be changed.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// A non-negative integer in cents (or local equivalent) representing how much to charge.
        /// One of <c>unit_amount</c> or <c>unit_amount_decimal</c> is required.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but accepts a decimal value in cents (or local equivalent)
        /// with at most 12 decimal places. Only one of <c>unit_amount</c> and
        /// <c>unit_amount_decimal</c> can be set.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
