// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportRunResult : StripeEntity<ReportRunResult>
    {
        /// <summary>
        /// The total number of columns in the result.
        /// </summary>
        [JsonProperty("col_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("col_count")]
        public long? ColCount { get; set; }

        /// <summary>
        /// File result with a download URL. This is the default result type.
        /// </summary>
        [JsonProperty("file")]
        [STJS.JsonPropertyName("file")]
        public ReportRunResultFile File { get; set; }

        /// <summary>
        /// Inline result with data returned directly. Only present when requested via
        /// <c>include[0]=result.inline</c>.
        /// </summary>
        [JsonProperty("inline")]
        [STJS.JsonPropertyName("inline")]
        public ReportRunResultInline Inline { get; set; }

        /// <summary>
        /// The total number of data rows in the result, excluding any header row.
        /// </summary>
        [JsonProperty("row_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("row_count")]
        public long? RowCount { get; set; }
    }
}
