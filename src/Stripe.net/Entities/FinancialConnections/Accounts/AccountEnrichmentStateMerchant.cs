// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEnrichmentStateMerchant : StripeEntity<AccountEnrichmentStateMerchant>
    {
        /// <summary>
        /// The merchant enrichment status for this account. One of 'pending' or 'completed'.
        /// One of: <c>completed</c>, or <c>pending</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
