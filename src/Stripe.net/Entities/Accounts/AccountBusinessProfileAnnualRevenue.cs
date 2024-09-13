namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AccountBusinessProfileAnnualRevenue : StripeEntity<AccountBusinessProfileAnnualRevenue>
    {
        /// <summary>
        /// A non-negative integer representing the amount in the <a
        /// href="https://stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("amount")]
#else
        [JsonProperty("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("currency")]
#else
        [JsonProperty("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The close-out date of the preceding fiscal year in ISO 8601 format. E.g. 2023-12-31 for
        /// the 31st of December, 2023.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("fiscal_year_end")]
#else
        [JsonProperty("fiscal_year_end")]
#endif
        public string FiscalYearEnd { get; set; }
    }
}
