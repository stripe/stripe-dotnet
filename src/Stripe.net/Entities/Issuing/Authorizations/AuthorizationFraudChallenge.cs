// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationFraudChallenge : StripeEntity<AuthorizationFraudChallenge>
    {
        /// <summary>
        /// The method by which the fraud challenge was delivered to the cardholder.
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// The status of the fraud challenge.
        /// One of: <c>expired</c>, <c>pending</c>, <c>rejected</c>, <c>undeliverable</c>, or
        /// <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// If the challenge is not deliverable, the reason why.
        /// One of: <c>no_phone_number</c>, or <c>unsupported_phone_number</c>.
        /// </summary>
        [JsonProperty("undeliverable_reason")]
        public string UndeliverableReason { get; set; }
    }
}
