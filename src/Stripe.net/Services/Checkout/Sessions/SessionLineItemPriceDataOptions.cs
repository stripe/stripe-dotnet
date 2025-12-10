// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionLineItemPriceDataOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the <a href="https://docs.stripe.com/api/products">Product</a> that this <a
        /// href="https://docs.stripe.com/api/prices">Price</a> will belong to. One of
        /// <c>product</c> or <c>product_data</c> is required.
        /// </summary>
        [JsonProperty("product")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product")]
#endif
        public string Product { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/products">Product</a>
        /// object inline. One of <c>product</c> or <c>product_data</c> is required.
        /// </summary>
        [JsonProperty("product_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_data")]
#endif
        public SessionLineItemPriceDataProductDataOptions ProductData { get; set; }

        /// <summary>
        /// The recurring components of a price such as <c>interval</c> and <c>interval_count</c>.
        /// </summary>
        [JsonProperty("recurring")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recurring")]
#endif
        public SessionLineItemPriceDataRecurringOptions Recurring { get; set; }

        /// <summary>
        /// Only required if a <a
        /// href="https://docs.stripe.com/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)">default
        /// tax behavior</a> was not provided in the Stripe Tax settings. Specifies whether the
        /// price is considered inclusive of taxes or exclusive of taxes. One of <c>inclusive</c>,
        /// <c>exclusive</c>, or <c>unspecified</c>. Once specified as either <c>inclusive</c> or
        /// <c>exclusive</c>, it cannot be changed.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_behavior")]
#endif
        public string TaxBehavior { get; set; }

        /// <summary>
        /// A non-negative integer in cents (or local equivalent) representing how much to charge.
        /// One of <c>unit_amount</c> or <c>unit_amount_decimal</c> is required.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but accepts a decimal value in cents (or local equivalent)
        /// with at most 12 decimal places. Only one of <c>unit_amount</c> and
        /// <c>unit_amount_decimal</c> can be set.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount_decimal")]
#endif
        public decimal? UnitAmountDecimal { get; set; }
    }
}
