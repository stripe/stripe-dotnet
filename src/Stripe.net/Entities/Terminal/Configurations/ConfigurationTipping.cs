// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConfigurationTipping : StripeEntity<ConfigurationTipping>
    {
        [JsonProperty("aud")]
        public ConfigurationTippingAud Aud { get; set; }

        [JsonProperty("cad")]
        public ConfigurationTippingCad Cad { get; set; }

        [JsonProperty("chf")]
        public ConfigurationTippingChf Chf { get; set; }

        [JsonProperty("czk")]
        public ConfigurationTippingCzk Czk { get; set; }

        [JsonProperty("dkk")]
        public ConfigurationTippingDkk Dkk { get; set; }

        [JsonProperty("eur")]
        public ConfigurationTippingEur Eur { get; set; }

        [JsonProperty("gbp")]
        public ConfigurationTippingGbp Gbp { get; set; }

        [JsonProperty("hkd")]
        public ConfigurationTippingHkd Hkd { get; set; }

        [JsonProperty("myr")]
        public ConfigurationTippingMyr Myr { get; set; }

        [JsonProperty("nok")]
        public ConfigurationTippingNok Nok { get; set; }

        [JsonProperty("nzd")]
        public ConfigurationTippingNzd Nzd { get; set; }

        [JsonProperty("sek")]
        public ConfigurationTippingSek Sek { get; set; }

        [JsonProperty("sgd")]
        public ConfigurationTippingSgd Sgd { get; set; }

        [JsonProperty("usd")]
        public ConfigurationTippingUsd Usd { get; set; }
    }
}
