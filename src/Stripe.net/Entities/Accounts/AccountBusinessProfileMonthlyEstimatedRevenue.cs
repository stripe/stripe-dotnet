namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AccountBusinessProfileMonthlyEstimatedRevenue : StripeEntity<AccountBusinessProfileMonthlyEstimatedRevenue>
    {
        /// <summary>
        /// A non-negative integer representing how much to charge in the <a
        /// href="https://stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("amount")]
#else
        [JsonProperty("amount")]
#endif
        public long Amount { get; set; }

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
    }
}
