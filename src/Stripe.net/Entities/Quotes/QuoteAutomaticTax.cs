// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteAutomaticTax : StripeEntity<QuoteAutomaticTax>
    {
        /// <summary>
        /// Automatically calculate taxes.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The status of the most recent automated tax calculation for this quote.
        /// One of: <c>complete</c>, <c>failed</c>, or <c>requires_location_inputs</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
