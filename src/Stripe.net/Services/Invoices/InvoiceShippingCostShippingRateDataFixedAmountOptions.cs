// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceShippingCostShippingRateDataFixedAmountOptions : INestedOptions
    {
        /// <summary>
        /// A non-negative integer in cents representing how much to charge.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Shipping rates defined in each available currency option. Each key must be a
        /// three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a> and a <a href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency_options")]
        public Dictionary<string, InvoiceShippingCostShippingRateDataFixedAmountCurrencyOptionsOptions> CurrencyOptions { get; set; }
    }
}
