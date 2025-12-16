// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthApiLatencyFiringEventDataImpact : StripeEntity<V2CoreHealthApiLatencyFiringEventDataImpact>
    {
        /// <summary>
        /// The canonical path.
        /// </summary>
        [JsonProperty("canonical_path")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canonical_path")]
#endif
        public string CanonicalPath { get; set; }

        /// <summary>
        /// The HTTP method.
        /// One of: <c>DELETE</c>, <c>GET</c>, <c>POST</c>, or <c>PUT</c>.
        /// </summary>
        [JsonProperty("http_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("http_method")]
#endif
        public string HttpMethod { get; set; }

        /// <summary>
        /// The HTTP status.
        /// </summary>
        [JsonProperty("http_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("http_status")]
#endif
        public string HttpStatus { get; set; }

        /// <summary>
        /// The number of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impacted_requests")]
#endif
        public long ImpactedRequests { get; set; }

        /// <summary>
        /// The percentage of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests_percentage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impacted_requests_percentage")]
#endif
        public string ImpactedRequestsPercentage { get; set; }

        /// <summary>
        /// The top impacted connected accounts (only for platforms).
        /// </summary>
        [JsonProperty("top_impacted_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("top_impacted_accounts")]
#endif
        public List<V2CoreHealthApiLatencyFiringEventDataImpactTopImpactedAccount> TopImpactedAccounts { get; set; }
    }
}
