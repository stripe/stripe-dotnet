// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportRunResultFile : StripeEntity<ReportRunResultFile>
    {
        /// <summary>
        /// The content type of the file.
        /// One of: <c>csv</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("content_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("content_type")]
#endif
        public string ContentType { get; set; }

        /// <summary>
        /// A pre-signed URL that allows secure, time-limited access to download the file.
        /// </summary>
        [JsonProperty("download_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("download_url")]
#endif
        public ReportRunResultFileDownloadUrl DownloadUrl { get; set; }

        /// <summary>
        /// The total size of the file in bytes.
        /// </summary>
        [JsonProperty("size")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("size")]
#endif
        public long Size { get; set; }
    }
}
