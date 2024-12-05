// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationReportSelfieError : StripeEntity<VerificationReportSelfieError>
    {
        /// <summary>
        /// A short machine-readable string giving the reason for the verification failure.
        /// One of: <c>selfie_document_missing_photo</c>, <c>selfie_face_mismatch</c>,
        /// <c>selfie_manipulated</c>, or <c>selfie_unverified_other</c>.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// A human-readable message giving the reason for the failure. These messages can be shown
        /// to your users.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
