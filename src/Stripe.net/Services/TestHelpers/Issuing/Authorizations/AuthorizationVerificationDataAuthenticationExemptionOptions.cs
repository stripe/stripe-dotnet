// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationVerificationDataAuthenticationExemptionOptions : INestedOptions
    {
        /// <summary>
        /// The entity that requested the exemption, either the acquiring merchant or the Issuing
        /// user.
        /// One of: <c>acquirer</c>, or <c>issuer</c>.
        /// </summary>
        [JsonProperty("claimed_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("claimed_by")]
#endif

        public string ClaimedBy { get; set; }

        /// <summary>
        /// The specific exemption claimed for this authorization.
        /// One of: <c>low_value_transaction</c>, <c>transaction_risk_analysis</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
