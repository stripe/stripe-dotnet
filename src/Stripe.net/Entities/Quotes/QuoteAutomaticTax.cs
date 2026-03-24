// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteAutomaticTax : StripeEntity<QuoteAutomaticTax>
    {
        /// <summary>
        /// Automatically calculate taxes.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
        [STJS.JsonPropertyName("liability")]
        public QuoteAutomaticTaxLiability Liability { get; set; }

        /// <summary>
        /// The tax provider powering automatic tax.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// The status of the most recent automated tax calculation for this quote.
        /// One of: <c>complete</c>, <c>failed</c>, or <c>requires_location_inputs</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
