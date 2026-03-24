// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportIdNumberError : StripeEntity<VerificationReportIdNumberError>
    {
        /// <summary>
        /// A short machine-readable string giving the reason for the verification failure.
        /// One of: <c>id_number_insufficient_document_data</c>, <c>id_number_mismatch</c>, or
        /// <c>id_number_unverified_other</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// A human-readable message giving the reason for the failure. These messages can be shown
        /// to your users.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
