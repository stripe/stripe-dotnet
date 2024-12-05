// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationVerificationDataAuthenticationExemption : StripeEntity<AuthorizationVerificationDataAuthenticationExemption>
    {
        /// <summary>
        /// The entity that requested the exemption, either the acquiring merchant or the Issuing
        /// user.
        /// One of: <c>acquirer</c>, or <c>issuer</c>.
        /// </summary>
        [JsonProperty("claimed_by")]
        public string ClaimedBy { get; set; }

        /// <summary>
        /// The specific exemption claimed for this authorization.
        /// One of: <c>low_value_transaction</c>, <c>transaction_risk_analysis</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
