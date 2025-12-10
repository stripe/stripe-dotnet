// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationReportSelfie : StripeEntity<VerificationReportSelfie>
    {
        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/files">File</a> holding the image of the
        /// identity document used in this check.
        /// </summary>
        [JsonProperty("document")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("document")]
#endif
        public string Document { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error")]
#endif
        public VerificationReportSelfieError Error { get; set; }

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/files">File</a> holding the image of the
        /// selfie used in this check.
        /// </summary>
        [JsonProperty("selfie")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("selfie")]
#endif
        public string Selfie { get; set; }

        /// <summary>
        /// Status of this <c>selfie</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
