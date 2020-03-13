namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;

    public class VerificationData : StripeEntity<VerificationData>
    {
        /// <summary>
        /// One of <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// One of <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("address_postal_code_check")]
        public string AddressPostalCodeCheck { get; set; }

        [Obsolete("Use AddressPostalCodeCheck instead")]
        [JsonProperty("address_zip_check")]
        public string AddressZipCheck { get; set; }

        /// <summary>
        /// One of <c>success</c>, <c>failure</c>, <c>exempt</c>, or <c>none</c>.
        /// </summary>
        [Obsolete("Use ThreeDSecure instead")]
        [JsonProperty("authentication")]
        public string Authentication { get; set; }

        /// <summary>
        /// One of <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        /// <summary>
        /// One of <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("expiry_check")]
        public string ExpiryCheck { get; set; }

        /// <summary>
        /// 3D Secure details on this authorization.
        /// </summary>
        [JsonProperty("three_d_secure")]
        public AuthorizationVerificationDataThreeDSecure ThreeDSecure { get; set; }
    }
}
