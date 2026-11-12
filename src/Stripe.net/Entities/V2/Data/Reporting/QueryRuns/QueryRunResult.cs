// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Reporting
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QueryRunResult : StripeEntity<QueryRunResult>
    {
        /// <summary>
        /// The number of columns in the file.
        /// </summary>
        [JsonProperty("col_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("col_count")]
        public long? ColCount { get; set; }

        /// <summary>
        /// Contains metadata about the file produced by the <c>ReportRun</c> or <c>QueryRun</c>,
        /// including its content type, size, and a URL to download its contents.
        /// </summary>
        [JsonProperty("file")]
        [STJS.JsonPropertyName("file")]
        public QueryRunResultFile File { get; set; }

        /// <summary>
        /// The number of data rows in the file, excluding the column header row.
        /// </summary>
        [JsonProperty("row_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("row_count")]
        public long? RowCount { get; set; }

        /// <summary>
        /// The type of the <c>ReportRun</c> or <c>QueryRun</c> result.
        /// One of: <c>file</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
