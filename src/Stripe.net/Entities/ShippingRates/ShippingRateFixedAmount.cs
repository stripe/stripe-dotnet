// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ShippingRateFixedAmount : StripeEntity<ShippingRateFixedAmount>
    {
        /// <summary>
        /// A non-negative integer in cents representing how much to charge.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currency_options")]
        public ShippingRateFixedAmountCurrencyOptions CurrencyOptions { get; set; }
    }
}
