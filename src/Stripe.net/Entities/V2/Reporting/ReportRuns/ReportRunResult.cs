// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportRunResult : StripeEntity<ReportRunResult>
    {
        /// <summary>
        /// Contains metadata about the file produced by the <c>ReportRun</c>, including its content
        /// type, size, and a URL to download its contents.
        /// </summary>
        [JsonProperty("file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("file")]
#endif
        public ReportRunResultFile File { get; set; }

        /// <summary>
        /// The type of the <c>ReportRun</c> result.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
