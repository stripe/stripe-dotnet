// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BatchJobStatusDetailsReadyForUpload : StripeEntity<BatchJobStatusDetailsReadyForUpload>
    {
        /// <summary>
        /// The upload file details.
        /// </summary>
        [JsonProperty("upload_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("upload_url")]
#endif
        public BatchJobStatusDetailsReadyForUploadUploadUrl UploadUrl { get; set; }
    }
}
