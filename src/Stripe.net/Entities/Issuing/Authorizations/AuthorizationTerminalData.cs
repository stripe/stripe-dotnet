// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationTerminalData : StripeEntity<AuthorizationTerminalData>
    {
        /// <summary>
        /// The method used to confirm the cardholder's identity.
        /// One of: <c>failed</c>, <c>none</c>, <c>pin</c>, <c>pin_and_signature</c>,
        /// <c>signature</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("cardholder_verification_result")]
        [STJS.JsonPropertyName("cardholder_verification_result")]
        public string CardholderVerificationResult { get; set; }
    }
}
