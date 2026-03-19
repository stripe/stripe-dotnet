// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportSelfie : StripeEntity<VerificationReportSelfie>
    {
        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/files">File</a> holding the image of the
        /// identity document used in this check.
        /// </summary>
        [JsonProperty("document")]
        [STJS.JsonPropertyName("document")]
        public string Document { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public VerificationReportSelfieError Error { get; set; }

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/files">File</a> holding the image of the
        /// selfie used in this check.
        /// </summary>
        [JsonProperty("selfie")]
        [STJS.JsonPropertyName("selfie")]
        public string Selfie { get; set; }

        /// <summary>
        /// Status of this <c>selfie</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
