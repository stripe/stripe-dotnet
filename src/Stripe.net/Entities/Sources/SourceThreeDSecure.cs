namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceThreeDSecure : StripeEntity<SourceThreeDSecure>
    {
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        [JsonProperty("address_zip_check")]
        public string AddressZipCheck { get; set; }

        [JsonProperty("authenticated")]
        public bool? Authenticated { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
        public string Funding { get; set; }

        [JsonProperty("iin")]
        public string Iin { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("three_d_secure")]
        public string ThreeDSecure { get; set; }

        [JsonProperty("tokenization_method")]
        public string TokenizationMethod { get; set; }
    }
}
