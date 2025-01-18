// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationTipping : StripeEntity<ConfigurationTipping>
    {
        [JsonProperty("aud")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aud")]
#endif
        public ConfigurationTippingAud Aud { get; set; }

        [JsonProperty("cad")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cad")]
#endif
        public ConfigurationTippingCad Cad { get; set; }

        [JsonProperty("chf")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("chf")]
#endif
        public ConfigurationTippingChf Chf { get; set; }

        [JsonProperty("czk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("czk")]
#endif
        public ConfigurationTippingCzk Czk { get; set; }

        [JsonProperty("dkk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dkk")]
#endif
        public ConfigurationTippingDkk Dkk { get; set; }

        [JsonProperty("eur")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eur")]
#endif
        public ConfigurationTippingEur Eur { get; set; }

        [JsonProperty("gbp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gbp")]
#endif
        public ConfigurationTippingGbp Gbp { get; set; }

        [JsonProperty("hkd")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hkd")]
#endif
        public ConfigurationTippingHkd Hkd { get; set; }

        [JsonProperty("jpy")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jpy")]
#endif
        public ConfigurationTippingJpy Jpy { get; set; }

        [JsonProperty("myr")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("myr")]
#endif
        public ConfigurationTippingMyr Myr { get; set; }

        [JsonProperty("nok")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nok")]
#endif
        public ConfigurationTippingNok Nok { get; set; }

        [JsonProperty("nzd")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nzd")]
#endif
        public ConfigurationTippingNzd Nzd { get; set; }

        [JsonProperty("pln")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pln")]
#endif
        public ConfigurationTippingPln Pln { get; set; }

        [JsonProperty("sek")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sek")]
#endif
        public ConfigurationTippingSek Sek { get; set; }

        [JsonProperty("sgd")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sgd")]
#endif
        public ConfigurationTippingSgd Sgd { get; set; }

        [JsonProperty("usd")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usd")]
#endif
        public ConfigurationTippingUsd Usd { get; set; }
    }
}
