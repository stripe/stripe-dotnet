// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationVerificationData : StripeEntity<AuthorizationVerificationData>
    {
        /// <summary>
        /// Whether the cardholder provided an address first line and if it matched the cardholder’s
        /// <c>billing.address.line1</c>.
        /// One of: <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// Whether the cardholder provided a postal code and if it matched the cardholder’s
        /// <c>billing.address.postal_code</c>.
        /// One of: <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("address_postal_code_check")]
        public string AddressPostalCodeCheck { get; set; }

        /// <summary>
        /// The exemption applied to this authorization.
        /// </summary>
        [JsonProperty("authentication_exemption")]
        public AuthorizationVerificationDataAuthenticationExemption AuthenticationExemption { get; set; }

        /// <summary>
        /// Whether the cardholder provided a CVC and if it matched Stripe’s record.
        /// One of: <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        /// <summary>
        /// Whether the cardholder provided an expiry date and if it matched Stripe’s record.
        /// One of: <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("expiry_check")]
        public string ExpiryCheck { get; set; }

        /// <summary>
        /// The postal code submitted as part of the authorization used for postal code
        /// verification.
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// 3D Secure details.
        /// </summary>
        [JsonProperty("three_d_secure")]
        public AuthorizationVerificationDataThreeDSecure ThreeDSecure { get; set; }
    }
}
