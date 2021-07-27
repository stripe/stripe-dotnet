// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationReportIdNumberError : StripeEntity<VerificationReportIdNumberError>
    {
        /// <summary>
        /// A short machine-readable string giving the reason for the verification failure.
        /// One of: <c>id_number_insufficient_document_data</c>, <c>id_number_mismatch</c>, or
        /// <c>id_number_unverified_other</c>.
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
