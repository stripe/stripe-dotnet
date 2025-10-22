// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class UsBankAccountVerification : StripeEntity<UsBankAccountVerification>
    {
        /// <summary>
        /// The microdeposit verification details if the status is awaiting verification.
        /// </summary>
        [JsonProperty("microdeposit_verification_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("microdeposit_verification_details")]
#endif
        public UsBankAccountVerificationMicrodepositVerificationDetails MicrodepositVerificationDetails { get; set; }

        /// <summary>
        /// The bank account verification status.
        /// One of: <c>awaiting_verification</c>, <c>unverified</c>, <c>verification_failed</c>, or
        /// <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
