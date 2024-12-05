// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteAutomaticTax : StripeEntity<QuoteAutomaticTax>
    {
        /// <summary>
        /// Automatically calculate taxes.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("liability")]
#endif
        public QuoteAutomaticTaxLiability Liability { get; set; }

        /// <summary>
        /// The status of the most recent automated tax calculation for this quote.
        /// One of: <c>complete</c>, <c>failed</c>, or <c>requires_location_inputs</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
