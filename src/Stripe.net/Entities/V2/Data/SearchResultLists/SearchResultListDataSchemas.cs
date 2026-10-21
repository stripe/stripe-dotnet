// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SearchResultListDataSchemas : StripeEntity<SearchResultListDataSchemas>
    {
        /// <summary>
        /// Compact schema projection.
        /// </summary>
        [JsonProperty("columns")]
        [STJS.JsonPropertyName("columns")]
        public List<SearchResultListDataSchemasColumn> Columns { get; set; }

        /// <summary>
        /// The dataset used when submitting an ad-hoc query run.
        /// One of: <c>analytical</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("dataset")]
        [STJS.JsonPropertyName("dataset")]
        public string Dataset { get; set; }

        /// <summary>
        /// Stripe-defined reports that are relevant to this schema.
        /// </summary>
        [JsonProperty("relevant_reports")]
        [STJS.JsonPropertyName("relevant_reports")]
        public List<SearchResultListDataSchemasRelevantReport> RelevantReports { get; set; }
    }
}
