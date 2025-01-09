// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceThreeDSecure : StripeEntity<SourceThreeDSecure>
    {
        [JsonProperty("address_line1_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1_check")]
#endif
        public string AddressLine1Check { get; set; }

        [JsonProperty("address_zip_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_zip_check")]
#endif
        public string AddressZipCheck { get; set; }

        [JsonProperty("authenticated")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authenticated")]
#endif
        public bool? Authenticated { get; set; }

        [JsonProperty("brand")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("brand")]
#endif
        public string Brand { get; set; }

        [JsonProperty("brand_product")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("brand_product")]
#endif
        public string BrandProduct { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public string Card { get; set; }

        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        [JsonProperty("cvc_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_check")]
#endif
        public string CvcCheck { get; set; }

        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        [JsonProperty("dynamic_last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dynamic_last4")]
#endif
        public string DynamicLast4 { get; set; }

        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif
        public long? ExpYear { get; set; }

        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding")]
#endif
        public string Funding { get; set; }

        [JsonProperty("iin")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iin")]
#endif
        public string Iin { get; set; }

        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public string Issuer { get; set; }

        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        [JsonProperty("three_d_secure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("three_d_secure")]
#endif
        public string ThreeDSecure { get; set; }

        [JsonProperty("tokenization_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tokenization_method")]
#endif
        public string TokenizationMethod { get; set; }
    }
}
