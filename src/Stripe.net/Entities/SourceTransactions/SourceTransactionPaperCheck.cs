// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceTransactionPaperCheck : StripeEntity<SourceTransactionPaperCheck>
    {
        /// <summary>
        /// Time at which the deposited funds will be available for use. Measured in seconds since
        /// the Unix epoch.
        /// </summary>
        [JsonProperty("available_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available_at")]
#endif

        public string AvailableAt { get; set; }

        /// <summary>
        /// Comma-separated list of invoice IDs associated with the paper check.
        /// </summary>
        [JsonProperty("invoices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoices")]
#endif

        public string Invoices { get; set; }
    }
}
