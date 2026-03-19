// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BatchJobStatusDetailsValidationFailedOutputFile : StripeEntity<BatchJobStatusDetailsValidationFailedOutputFile>
    {
        /// <summary>
        /// The content type of the file.
        /// </summary>
        [JsonProperty("content_type")]
        [STJS.JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// A pre-signed URL that allows secure, time-limited access to download the file.
        /// </summary>
        [JsonProperty("download_url")]
        [STJS.JsonPropertyName("download_url")]
        public BatchJobStatusDetailsValidationFailedOutputFileDownloadUrl DownloadUrl { get; set; }

        /// <summary>
        /// The total size of the file in bytes.
        /// </summary>
        [JsonProperty("size")]
        [STJS.JsonPropertyName("size")]
        public long Size { get; set; }
    }
}
