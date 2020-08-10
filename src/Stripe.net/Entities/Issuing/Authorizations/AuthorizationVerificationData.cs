namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationVerificationData : StripeEntity<AuthorizationVerificationData>
    {
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        [JsonProperty("address_postal_code_check")]
        public string AddressPostalCodeCheck { get; set; }

        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        [JsonProperty("expiry_check")]
        public string ExpiryCheck { get; set; }
    }
}
