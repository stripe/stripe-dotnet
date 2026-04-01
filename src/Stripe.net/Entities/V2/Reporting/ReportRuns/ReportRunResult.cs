// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportRunResult : StripeEntity<ReportRunResult>
    {
        /// <summary>
        /// The type of the <c>ReportRun</c> or <c>QueryRun</c> result.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Contains metadata about the file produced by the <c>ReportRun</c> or <c>QueryRun</c>,
        /// including its content type, size, and a URL to download its contents.
        /// </summary>
        [JsonProperty("file")]
        [STJS.JsonPropertyName("file")]
        public ReportRunResultFile File { get; set; }
    }
}
