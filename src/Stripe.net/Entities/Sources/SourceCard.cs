// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceCard : StripeEntity<SourceCard>
    {
        [JsonProperty("address_line1_check")]
        [STJS.JsonPropertyName("address_line1_check")]
        public string AddressLine1Check { get; set; }

        [JsonProperty("address_zip_check")]
        [STJS.JsonPropertyName("address_zip_check")]
        public string AddressZipCheck { get; set; }

        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonProperty("cvc_check")]
        [STJS.JsonPropertyName("cvc_check")]
        public string CvcCheck { get; set; }

        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("dynamic_last4")]
        [STJS.JsonPropertyName("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public string Funding { get; set; }

        [JsonProperty("iin")]
        [STJS.JsonPropertyName("iin")]
        public string Iin { get; set; }

        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("three_d_secure")]
        [STJS.JsonPropertyName("three_d_secure")]
        public string ThreeDSecure { get; set; }

        [JsonProperty("tokenization_method")]
        [STJS.JsonPropertyName("tokenization_method")]
        public string TokenizationMethod { get; set; }
    }
}
