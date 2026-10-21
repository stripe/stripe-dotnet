// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SearchResultListDataReports : StripeEntity<SearchResultListDataReports>
    {
        /// <summary>
        /// Shape of the report output when known.
        /// </summary>
        [JsonProperty("output_columns")]
        [STJS.JsonPropertyName("output_columns")]
        public List<SearchResultListDataReportsOutputColumn> OutputColumns { get; set; }

        /// <summary>
        /// Parameter schema, keyed by parameter name, matching the <c>/v2/data/reports</c>
        /// resource.
        /// </summary>
        [JsonProperty("parameters")]
        [STJS.JsonPropertyName("parameters")]
        public Dictionary<string, SearchResultListDataReportsParameters> Parameters { get; set; }
    }
}
