// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreHealthApiErrorFiringEventDataImpact : StripeEntity<V2CoreHealthApiErrorFiringEventDataImpact>
    {
        /// <summary>
        /// The canonical path.
        /// </summary>
        [JsonProperty("canonical_path")]
        [STJS.JsonPropertyName("canonical_path")]
        public string CanonicalPath { get; set; }

        /// <summary>
        /// The error code.
        /// </summary>
        [JsonProperty("error_code")]
        [STJS.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP method.
        /// One of: <c>DELETE</c>, <c>GET</c>, <c>POST</c>, or <c>PUT</c>.
        /// </summary>
        [JsonProperty("http_method")]
        [STJS.JsonPropertyName("http_method")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// The HTTP status.
        /// </summary>
        [JsonProperty("http_status")]
        [STJS.JsonPropertyName("http_status")]
        public string HttpStatus { get; set; }

        /// <summary>
        /// The number of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests")]
        [STJS.JsonPropertyName("impacted_requests")]
        public long ImpactedRequests { get; set; }

        /// <summary>
        /// The percentage of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests_percentage")]
        [STJS.JsonPropertyName("impacted_requests_percentage")]
        public string ImpactedRequestsPercentage { get; set; }

        /// <summary>
        /// The top impacted connected accounts (only for platforms).
        /// </summary>
        [JsonProperty("top_impacted_accounts")]
        [STJS.JsonPropertyName("top_impacted_accounts")]
        public List<V2CoreHealthApiErrorFiringEventDataImpactTopImpactedAccount> TopImpactedAccounts { get; set; }
    }
}
