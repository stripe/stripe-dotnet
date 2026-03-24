// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationTippingOptions : INestedOptions
    {
        /// <summary>
        /// Tipping configuration for AED.
        /// </summary>
        [JsonProperty("aed")]
        [STJS.JsonPropertyName("aed")]
        public ConfigurationTippingAedOptions Aed { get; set; }

        /// <summary>
        /// Tipping configuration for AUD.
        /// </summary>
        [JsonProperty("aud")]
        [STJS.JsonPropertyName("aud")]
        public ConfigurationTippingAudOptions Aud { get; set; }

        /// <summary>
        /// Tipping configuration for CAD.
        /// </summary>
        [JsonProperty("cad")]
        [STJS.JsonPropertyName("cad")]
        public ConfigurationTippingCadOptions Cad { get; set; }

        /// <summary>
        /// Tipping configuration for CHF.
        /// </summary>
        [JsonProperty("chf")]
        [STJS.JsonPropertyName("chf")]
        public ConfigurationTippingChfOptions Chf { get; set; }

        /// <summary>
        /// Tipping configuration for CZK.
        /// </summary>
        [JsonProperty("czk")]
        [STJS.JsonPropertyName("czk")]
        public ConfigurationTippingCzkOptions Czk { get; set; }

        /// <summary>
        /// Tipping configuration for DKK.
        /// </summary>
        [JsonProperty("dkk")]
        [STJS.JsonPropertyName("dkk")]
        public ConfigurationTippingDkkOptions Dkk { get; set; }

        /// <summary>
        /// Tipping configuration for EUR.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public ConfigurationTippingEurOptions Eur { get; set; }

        /// <summary>
        /// Tipping configuration for GBP.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public ConfigurationTippingGbpOptions Gbp { get; set; }

        /// <summary>
        /// Tipping configuration for GIP.
        /// </summary>
        [JsonProperty("gip")]
        [STJS.JsonPropertyName("gip")]
        public ConfigurationTippingGipOptions Gip { get; set; }

        /// <summary>
        /// Tipping configuration for HKD.
        /// </summary>
        [JsonProperty("hkd")]
        [STJS.JsonPropertyName("hkd")]
        public ConfigurationTippingHkdOptions Hkd { get; set; }

        /// <summary>
        /// Tipping configuration for HUF.
        /// </summary>
        [JsonProperty("huf")]
        [STJS.JsonPropertyName("huf")]
        public ConfigurationTippingHufOptions Huf { get; set; }

        /// <summary>
        /// Tipping configuration for JPY.
        /// </summary>
        [JsonProperty("jpy")]
        [STJS.JsonPropertyName("jpy")]
        public ConfigurationTippingJpyOptions Jpy { get; set; }

        /// <summary>
        /// Tipping configuration for MXN.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public ConfigurationTippingMxnOptions Mxn { get; set; }

        /// <summary>
        /// Tipping configuration for MYR.
        /// </summary>
        [JsonProperty("myr")]
        [STJS.JsonPropertyName("myr")]
        public ConfigurationTippingMyrOptions Myr { get; set; }

        /// <summary>
        /// Tipping configuration for NOK.
        /// </summary>
        [JsonProperty("nok")]
        [STJS.JsonPropertyName("nok")]
        public ConfigurationTippingNokOptions Nok { get; set; }

        /// <summary>
        /// Tipping configuration for NZD.
        /// </summary>
        [JsonProperty("nzd")]
        [STJS.JsonPropertyName("nzd")]
        public ConfigurationTippingNzdOptions Nzd { get; set; }

        /// <summary>
        /// Tipping configuration for PLN.
        /// </summary>
        [JsonProperty("pln")]
        [STJS.JsonPropertyName("pln")]
        public ConfigurationTippingPlnOptions Pln { get; set; }

        /// <summary>
        /// Tipping configuration for RON.
        /// </summary>
        [JsonProperty("ron")]
        [STJS.JsonPropertyName("ron")]
        public ConfigurationTippingRonOptions Ron { get; set; }

        /// <summary>
        /// Tipping configuration for SEK.
        /// </summary>
        [JsonProperty("sek")]
        [STJS.JsonPropertyName("sek")]
        public ConfigurationTippingSekOptions Sek { get; set; }

        /// <summary>
        /// Tipping configuration for SGD.
        /// </summary>
        [JsonProperty("sgd")]
        [STJS.JsonPropertyName("sgd")]
        public ConfigurationTippingSgdOptions Sgd { get; set; }

        /// <summary>
        /// Tipping configuration for USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public ConfigurationTippingUsdOptions Usd { get; set; }
    }
}
