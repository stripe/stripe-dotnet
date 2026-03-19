// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BatchJobStatusDetailsReadyForUpload : StripeEntity<BatchJobStatusDetailsReadyForUpload>
    {
        /// <summary>
        /// The upload file details.
        /// </summary>
        [JsonProperty("upload_url")]
        [STJS.JsonPropertyName("upload_url")]
        public BatchJobStatusDetailsReadyForUploadUploadUrl UploadUrl { get; set; }
    }
}
