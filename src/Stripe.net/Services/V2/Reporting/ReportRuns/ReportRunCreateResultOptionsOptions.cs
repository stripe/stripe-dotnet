// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportRunCreateResultOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If set, the generated report file will be compressed into a ZIP folder. This is useful
        /// for reducing file size and download time for large reports.
        /// </summary>
        [JsonProperty("compress_file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("compress_file")]
#endif
        public bool? CompressFile { get; set; }
    }
}
