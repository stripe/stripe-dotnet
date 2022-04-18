// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConfigurationTippingOptions : INestedOptions
    {
        /// <summary>
        /// Tipping configuration for AUD.
        /// </summary>
        [JsonProperty("aud")]
        public ConfigurationTippingAudOptions Aud { get; set; }

        /// <summary>
        /// Tipping configuration for CAD.
        /// </summary>
        [JsonProperty("cad")]
        public ConfigurationTippingCadOptions Cad { get; set; }

        /// <summary>
        /// Tipping configuration for CHF.
        /// </summary>
        [JsonProperty("chf")]
        public ConfigurationTippingChfOptions Chf { get; set; }

        /// <summary>
        /// Tipping configuration for DKK.
        /// </summary>
        [JsonProperty("dkk")]
        public ConfigurationTippingDkkOptions Dkk { get; set; }

        /// <summary>
        /// Tipping configuration for EUR.
        /// </summary>
        [JsonProperty("eur")]
        public ConfigurationTippingEurOptions Eur { get; set; }

        /// <summary>
        /// Tipping configuration for GBP.
        /// </summary>
        [JsonProperty("gbp")]
        public ConfigurationTippingGbpOptions Gbp { get; set; }

        /// <summary>
        /// Tipping configuration for HKD.
        /// </summary>
        [JsonProperty("hkd")]
        public ConfigurationTippingHkdOptions Hkd { get; set; }

        /// <summary>
        /// Tipping configuration for MYR.
        /// </summary>
        [JsonProperty("myr")]
        public ConfigurationTippingMyrOptions Myr { get; set; }

        /// <summary>
        /// Tipping configuration for NOK.
        /// </summary>
        [JsonProperty("nok")]
        public ConfigurationTippingNokOptions Nok { get; set; }

        /// <summary>
        /// Tipping configuration for NZD.
        /// </summary>
        [JsonProperty("nzd")]
        public ConfigurationTippingNzdOptions Nzd { get; set; }

        /// <summary>
        /// Tipping configuration for SEK.
        /// </summary>
        [JsonProperty("sek")]
        public ConfigurationTippingSekOptions Sek { get; set; }

        /// <summary>
        /// Tipping configuration for SGD.
        /// </summary>
        [JsonProperty("sgd")]
        public ConfigurationTippingSgdOptions Sgd { get; set; }

        /// <summary>
        /// Tipping configuration for USD.
        /// </summary>
        [JsonProperty("usd")]
        public ConfigurationTippingUsdOptions Usd { get; set; }
    }
}
