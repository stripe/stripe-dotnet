// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportPhoneError : StripeEntity<VerificationReportPhoneError>
    {
        /// <summary>
        /// A short machine-readable string giving the reason for the verification failure.
        /// One of: <c>phone_address_mismatch</c>, <c>phone_invalid</c>,
        /// <c>phone_invalid_line_type</c>, <c>phone_name_mismatch</c>,
        /// <c>phone_ownership_unverified</c>, <c>phone_short_tenure</c>,
        /// <c>phone_unsupported_country</c>, <c>phone_unverified_other</c>, or
        /// <c>phone_verification_declined</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
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
