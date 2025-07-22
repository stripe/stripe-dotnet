// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationTippingOptions : INestedOptions
    {
        /// <summary>
        /// Tipping configuration for AED.
        /// </summary>
        [JsonProperty("aed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aed")]
#endif
        public ConfigurationTippingAedOptions Aed { get; set; }

        /// <summary>
        /// Tipping configuration for AUD.
        /// </summary>
        [JsonProperty("aud")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aud")]
#endif
        public ConfigurationTippingAudOptions Aud { get; set; }

        /// <summary>
        /// Tipping configuration for BGN.
        /// </summary>
        [JsonProperty("bgn")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bgn")]
#endif
        public ConfigurationTippingBgnOptions Bgn { get; set; }

        /// <summary>
        /// Tipping configuration for CAD.
        /// </summary>
        [JsonProperty("cad")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cad")]
#endif
        public ConfigurationTippingCadOptions Cad { get; set; }

        /// <summary>
        /// Tipping configuration for CHF.
        /// </summary>
        [JsonProperty("chf")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("chf")]
#endif
        public ConfigurationTippingChfOptions Chf { get; set; }

        /// <summary>
        /// Tipping configuration for CZK.
        /// </summary>
        [JsonProperty("czk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("czk")]
#endif
        public ConfigurationTippingCzkOptions Czk { get; set; }

        /// <summary>
        /// Tipping configuration for DKK.
        /// </summary>
        [JsonProperty("dkk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dkk")]
#endif
        public ConfigurationTippingDkkOptions Dkk { get; set; }

        /// <summary>
        /// Tipping configuration for EUR.
        /// </summary>
        [JsonProperty("eur")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eur")]
#endif
        public ConfigurationTippingEurOptions Eur { get; set; }

        /// <summary>
        /// Tipping configuration for GBP.
        /// </summary>
        [JsonProperty("gbp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gbp")]
#endif
        public ConfigurationTippingGbpOptions Gbp { get; set; }

        /// <summary>
        /// Tipping configuration for HKD.
        /// </summary>
        [JsonProperty("hkd")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hkd")]
#endif
        public ConfigurationTippingHkdOptions Hkd { get; set; }

        /// <summary>
        /// Tipping configuration for HUF.
        /// </summary>
        [JsonProperty("huf")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("huf")]
#endif
        public ConfigurationTippingHufOptions Huf { get; set; }

        /// <summary>
        /// Tipping configuration for JPY.
        /// </summary>
        [JsonProperty("jpy")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jpy")]
#endif
        public ConfigurationTippingJpyOptions Jpy { get; set; }

        /// <summary>
        /// Tipping configuration for MYR.
        /// </summary>
        [JsonProperty("myr")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("myr")]
#endif
        public ConfigurationTippingMyrOptions Myr { get; set; }

        /// <summary>
        /// Tipping configuration for NOK.
        /// </summary>
        [JsonProperty("nok")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nok")]
#endif
        public ConfigurationTippingNokOptions Nok { get; set; }

        /// <summary>
        /// Tipping configuration for NZD.
        /// </summary>
        [JsonProperty("nzd")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nzd")]
#endif
        public ConfigurationTippingNzdOptions Nzd { get; set; }

        /// <summary>
        /// Tipping configuration for PLN.
        /// </summary>
        [JsonProperty("pln")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pln")]
#endif
        public ConfigurationTippingPlnOptions Pln { get; set; }

        /// <summary>
        /// Tipping configuration for RON.
        /// </summary>
        [JsonProperty("ron")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ron")]
#endif
        public ConfigurationTippingRonOptions Ron { get; set; }

        /// <summary>
        /// Tipping configuration for SEK.
        /// </summary>
        [JsonProperty("sek")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sek")]
#endif
        public ConfigurationTippingSekOptions Sek { get; set; }

        /// <summary>
        /// Tipping configuration for SGD.
        /// </summary>
        [JsonProperty("sgd")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sgd")]
#endif
        public ConfigurationTippingSgdOptions Sgd { get; set; }

        /// <summary>
        /// Tipping configuration for USD.
        /// </summary>
        [JsonProperty("usd")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usd")]
#endif
        public ConfigurationTippingUsdOptions Usd { get; set; }
    }
}
