// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportRunResultInline : StripeEntity<ReportRunResultInline>
    {
        /// <summary>
        /// The schema of the result data.
        /// </summary>
        [JsonProperty("columns")]
        [STJS.JsonPropertyName("columns")]
        public List<ReportRunResultInlineColumn> Columns { get; set; }

        /// <summary>
        /// Token for the next page of rows.
        /// </summary>
        [JsonProperty("next_page_url")]
        [STJS.JsonPropertyName("next_page_url")]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// Token for the previous page of rows.
        /// </summary>
        [JsonProperty("previous_page_url")]
        [STJS.JsonPropertyName("previous_page_url")]
        public string PreviousPageUrl { get; set; }

        /// <summary>
        /// The result rows, each represented as a map of column name to value.
        /// </summary>
        [JsonProperty("rows")]
        [STJS.JsonPropertyName("rows")]
        public List<ReportRunResultInlineRow> Rows { get; set; }
    }
}
