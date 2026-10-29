// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class UsBankAccountVerification : StripeEntity<UsBankAccountVerification>
    {
        /// <summary>
        /// The microdeposit verification details if the status is awaiting verification.
        /// </summary>
        [JsonProperty("microdeposit_verification_details")]
        [STJS.JsonPropertyName("microdeposit_verification_details")]
        public UsBankAccountVerificationMicrodepositVerificationDetails MicrodepositVerificationDetails { get; set; }

        /// <summary>
        /// The bank account verification status.
        /// One of: <c>awaiting_verification</c>, <c>unverified</c>, <c>verification_failed</c>, or
        /// <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
