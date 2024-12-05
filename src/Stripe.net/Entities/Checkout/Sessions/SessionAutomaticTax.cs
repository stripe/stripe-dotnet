// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionAutomaticTax : StripeEntity<SessionAutomaticTax>
    {
        /// <summary>
        /// Indicates whether automatic tax is enabled for the session.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
        public SessionAutomaticTaxLiability Liability { get; set; }

        /// <summary>
        /// The status of the most recent automated tax calculation for this session.
        /// One of: <c>complete</c>, <c>failed</c>, or <c>requires_location_inputs</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
