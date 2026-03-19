// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceTransactionPaperCheck : StripeEntity<SourceTransactionPaperCheck>
    {
        /// <summary>
        /// Time at which the deposited funds will be available for use. Measured in seconds since
        /// the Unix epoch.
        /// </summary>
        [JsonProperty("available_at")]
        [STJS.JsonPropertyName("available_at")]
        public string AvailableAt { get; set; }

        /// <summary>
        /// Comma-separated list of invoice IDs associated with the paper check.
        /// </summary>
        [JsonProperty("invoices")]
        [STJS.JsonPropertyName("invoices")]
        public string Invoices { get; set; }
    }
}
