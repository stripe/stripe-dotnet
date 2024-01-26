// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountBusinessProfileAnnualRevenue : StripeEntity<AccountBusinessProfileAnnualRevenue>
    {
        /// <summary>
        /// A non-negative integer representing the amount in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
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
        /// The close-out date of the preceding fiscal year in ISO 8601 format. E.g. 2023-12-31 for
        /// the 31st of December, 2023.
        /// </summary>
        [JsonProperty("fiscal_year_end")]
        public string FiscalYearEnd { get; set; }
    }
}
