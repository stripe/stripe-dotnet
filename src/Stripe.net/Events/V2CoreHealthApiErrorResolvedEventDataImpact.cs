// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthApiErrorResolvedEventDataImpact : StripeEntity<V2CoreHealthApiErrorResolvedEventDataImpact>
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
        /// The error code.
        /// </summary>
        [JsonProperty("error_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_code")]
#endif
        public string ErrorCode { get; set; }

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
    }
}
