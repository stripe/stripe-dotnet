namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class VerificationData : StripeEntity<VerificationData>
    {
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        [JsonProperty("address_postal_code_check")]
        public string AddressPostalCodeCheck { get; set; }

        [Obsolete("Use AddressPostalCodeCheck instead")]
        [JsonProperty("address_zip_check")]
        public string AddressZipCheck { get; set; }

        [Obsolete("Use ThreeDSecure instead")]
        [JsonProperty("authentication")]
        public string Authentication { get; set; }

        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        [JsonProperty("expiry_check")]
        public string ExpiryCheck { get; set; }

        [JsonProperty("three_d_secure")]
        public AuthorizationVerificationDataThreeDSecure ThreeDSecure { get; set; }
    }
}
