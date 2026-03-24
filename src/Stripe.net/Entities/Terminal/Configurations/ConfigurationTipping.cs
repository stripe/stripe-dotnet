// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationTipping : StripeEntity<ConfigurationTipping>
    {
        [JsonProperty("aed")]
        [STJS.JsonPropertyName("aed")]
        public ConfigurationTippingAed Aed { get; set; }

        [JsonProperty("aud")]
        [STJS.JsonPropertyName("aud")]
        public ConfigurationTippingAud Aud { get; set; }

        [JsonProperty("cad")]
        [STJS.JsonPropertyName("cad")]
        public ConfigurationTippingCad Cad { get; set; }

        [JsonProperty("chf")]
        [STJS.JsonPropertyName("chf")]
        public ConfigurationTippingChf Chf { get; set; }

        [JsonProperty("czk")]
        [STJS.JsonPropertyName("czk")]
        public ConfigurationTippingCzk Czk { get; set; }

        [JsonProperty("dkk")]
        [STJS.JsonPropertyName("dkk")]
        public ConfigurationTippingDkk Dkk { get; set; }

        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public ConfigurationTippingEur Eur { get; set; }

        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public ConfigurationTippingGbp Gbp { get; set; }

        [JsonProperty("gip")]
        [STJS.JsonPropertyName("gip")]
        public ConfigurationTippingGip Gip { get; set; }

        [JsonProperty("hkd")]
        [STJS.JsonPropertyName("hkd")]
        public ConfigurationTippingHkd Hkd { get; set; }

        [JsonProperty("huf")]
        [STJS.JsonPropertyName("huf")]
        public ConfigurationTippingHuf Huf { get; set; }

        [JsonProperty("jpy")]
        [STJS.JsonPropertyName("jpy")]
        public ConfigurationTippingJpy Jpy { get; set; }

        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public ConfigurationTippingMxn Mxn { get; set; }

        [JsonProperty("myr")]
        [STJS.JsonPropertyName("myr")]
        public ConfigurationTippingMyr Myr { get; set; }

        [JsonProperty("nok")]
        [STJS.JsonPropertyName("nok")]
        public ConfigurationTippingNok Nok { get; set; }

        [JsonProperty("nzd")]
        [STJS.JsonPropertyName("nzd")]
        public ConfigurationTippingNzd Nzd { get; set; }

        [JsonProperty("pln")]
        [STJS.JsonPropertyName("pln")]
        public ConfigurationTippingPln Pln { get; set; }

        [JsonProperty("ron")]
        [STJS.JsonPropertyName("ron")]
        public ConfigurationTippingRon Ron { get; set; }

        [JsonProperty("sek")]
        [STJS.JsonPropertyName("sek")]
        public ConfigurationTippingSek Sek { get; set; }

        [JsonProperty("sgd")]
        [STJS.JsonPropertyName("sgd")]
        public ConfigurationTippingSgd Sgd { get; set; }

        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public ConfigurationTippingUsd Usd { get; set; }
    }
}
