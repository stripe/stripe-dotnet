namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class VerificationData : StripeEntity<VerificationData>
    {
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        [JsonProperty("address_zip_check")]
        public string AddressZipCheck { get; set; }

        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }
    }
}
