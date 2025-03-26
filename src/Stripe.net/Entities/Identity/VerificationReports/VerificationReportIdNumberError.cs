// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationReportIdNumberError : StripeEntity<VerificationReportIdNumberError>
    {
        /// <summary>
        /// A short machine-readable string giving the reason for the verification failure.
        /// One of: <c>id_number_insufficient_document_data</c>, <c>id_number_mismatch</c>, or
        /// <c>id_number_unverified_other</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// A human-readable message giving the reason for the failure. These messages can be shown
        /// to your users.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
