// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using System.Text.Json;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class VerificationNotInitiatedException : StripeException
    {
        private VerificationNotInitiatedException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message,
            string verificationStatus)
            : base(httpStatusCode, stripeError)
        {
            this.VerificationStatus = verificationStatus;
        }

        /// <summary>
        /// Closed Enum. The verification status of the bank account associated with this error.
        /// One of: <c>awaiting_verification</c>, <c>unverified</c>, <c>verification_failed</c>, or
        /// <c>verified</c>.
        /// </summary>
        [JsonProperty("verification_status")]
        [STJS.JsonPropertyName("verification_status")]
        public string VerificationStatus { get; set; }

        internal static VerificationNotInitiatedException Parse(
            HttpStatusCode httpStatusCode,
            JsonElement body)
        {
            var stripeError = VerificationNotInitiatedError.FromJson<VerificationNotInitiatedError>(body);
            return new VerificationNotInitiatedException(httpStatusCode, stripeError, stripeError.Message, stripeError.VerificationStatus);
        }
    }
}