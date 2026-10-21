// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SearchResultListDataExecutionSpec : StripeEntity<SearchResultListDataExecutionSpec>, IHasId
    {
        /// <summary>
        /// The canonical run endpoint, e.g. "/v2/data/report_runs" or "/v2/data/query_runs".
        /// </summary>
        [JsonProperty("execution_url")]
        [STJS.JsonPropertyName("execution_url")]
        public string ExecutionUrl { get; set; }

        /// <summary>
        /// The HTTP method for <c>execution_url</c>.
        /// One of: <c>GET</c>, or <c>POST</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("http_method")]
        [STJS.JsonPropertyName("http_method")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// The identifier to submit to <c>execution_url</c>, e.g. "report_123" or "table_123".
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
