// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class UsBankAccountListOptions : V2.ListOptions
    {
        /// <summary>
        /// Optionally filter by verification status. Mutually exclusive with <c>unverified</c>,
        /// <c>verified</c>, <c>awaiting_verification</c>, and <c>verification_failed</c>.
        /// </summary>
        [JsonProperty("verification_status")]
        [STJS.JsonPropertyName("verification_status")]
        public string VerificationStatus { get; set; }
    }
}
