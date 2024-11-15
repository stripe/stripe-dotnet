// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationVerificationData : StripeEntity<AuthorizationVerificationData>
    {
        /// <summary>
        /// Whether the cardholder provided an address first line and if it matched the cardholder’s
        /// <c>billing.address.line1</c>.
        /// One of: <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1_check")]
#endif

        public string AddressLine1Check { get; set; }

        /// <summary>
        /// Whether the cardholder provided a postal code and if it matched the cardholder’s
        /// <c>billing.address.postal_code</c>.
        /// One of: <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("address_postal_code_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_postal_code_check")]
#endif

        public string AddressPostalCodeCheck { get; set; }

        /// <summary>
        /// The exemption applied to this authorization.
        /// </summary>
        [JsonProperty("authentication_exemption")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authentication_exemption")]
#endif

        public AuthorizationVerificationDataAuthenticationExemption AuthenticationExemption { get; set; }

        /// <summary>
        /// Whether the cardholder provided a CVC and if it matched Stripe’s record.
        /// One of: <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("cvc_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_check")]
#endif

        public string CvcCheck { get; set; }

        /// <summary>
        /// Whether the cardholder provided an expiry date and if it matched Stripe’s record.
        /// One of: <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("expiry_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expiry_check")]
#endif

        public string ExpiryCheck { get; set; }

        /// <summary>
        /// The postal code submitted as part of the authorization used for postal code
        /// verification.
        /// </summary>
        [JsonProperty("postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("postal_code")]
#endif

        public string PostalCode { get; set; }

        /// <summary>
        /// 3D Secure details.
        /// </summary>
        [JsonProperty("three_d_secure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("three_d_secure")]
#endif

        public AuthorizationVerificationDataThreeDSecure ThreeDSecure { get; set; }
    }
}
