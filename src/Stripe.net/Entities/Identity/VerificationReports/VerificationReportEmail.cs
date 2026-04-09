// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportEmail : StripeEntity<VerificationReportEmail>
    {
        /// <summary>
        /// Email to be verified.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public VerificationReportEmailError Error { get; set; }

        /// <summary>
        /// Status of this <c>email</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional email verification details.
        /// </summary>
        [JsonProperty("details")]
        [STJS.JsonPropertyName("details")]
        public VerificationReportEmailDetails Details { get; set; }
    }
}
