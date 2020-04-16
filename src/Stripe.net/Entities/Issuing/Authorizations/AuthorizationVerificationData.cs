namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;

    public class AuthorizationVerificationData : StripeEntity<AuthorizationVerificationData>
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
    }
}
