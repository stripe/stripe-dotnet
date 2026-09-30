// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class VerificationExpiredError : StripeError
    {
        /// <summary>
        /// Closed Enum. The verification status of the bank account associated with this error.
        /// One of: <c>awaiting_verification</c>, <c>unverified</c>, <c>verification_failed</c>, or
        /// <c>verified</c>.
        /// </summary>
        [JsonProperty("verification_status")]
        [STJS.JsonPropertyName("verification_status")]
        public string VerificationStatus { get; set; }
    }
}