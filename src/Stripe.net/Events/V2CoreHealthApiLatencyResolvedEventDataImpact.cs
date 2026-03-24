// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2CoreHealthApiLatencyResolvedEventDataImpact : StripeEntity<V2CoreHealthApiLatencyResolvedEventDataImpact>
    {
        /// <summary>
        /// The canonical path.
        /// </summary>
        [JsonProperty("canonical_path")]
        [STJS.JsonPropertyName("canonical_path")]
        public string CanonicalPath { get; set; }

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
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("impacted_requests_percentage")]
        public decimal? ImpactedRequestsPercentage { get; set; }

        /// <summary>
        /// The top impacted connected accounts (only for platforms).
        /// </summary>
        [JsonProperty("top_impacted_accounts")]
        [STJS.JsonPropertyName("top_impacted_accounts")]
        public List<V2CoreHealthApiLatencyResolvedEventDataImpactTopImpactedAccount> TopImpactedAccounts { get; set; }
    }
}
