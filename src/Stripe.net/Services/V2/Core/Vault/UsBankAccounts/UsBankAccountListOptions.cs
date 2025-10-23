// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class UsBankAccountListOptions : V2.ListOptions
    {
        /// <summary>
        /// Optionally filter by verification status. Mutually exclusive with <c>unverified</c>,
        /// <c>verified</c>, <c>awaiting_verification</c>, and <c>verification_failed</c>.
        /// </summary>
        [JsonProperty("verification_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_status")]
#endif
        public string VerificationStatus { get; set; }
    }
}
