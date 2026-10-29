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
        /// Closed Enum. Optionally filter by verification status.
        /// One of: <c>awaiting_verification</c>, <c>unverified</c>, <c>verification_failed</c>, or
        /// <c>verified</c>.
        /// </summary>
        [JsonProperty("verification_status")]
        [STJS.JsonPropertyName("verification_status")]
        public string VerificationStatus { get; set; }
    }
}
