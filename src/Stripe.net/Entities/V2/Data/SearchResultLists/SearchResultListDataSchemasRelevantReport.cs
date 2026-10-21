// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SearchResultListDataSchemasRelevantReport : StripeEntity<SearchResultListDataSchemasRelevantReport>, IHasId
    {
        /// <summary>
        /// A description of the <c>Report</c>.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the <c>Report</c>.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The human-readable name of the <c>Report</c>.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Canonical API path for the <c>Report</c>, e.g. "/v2/data/reports/report_123".
        /// </summary>
        [JsonProperty("reference_url")]
        [STJS.JsonPropertyName("reference_url")]
        public string ReferenceUrl { get; set; }
    }
}
