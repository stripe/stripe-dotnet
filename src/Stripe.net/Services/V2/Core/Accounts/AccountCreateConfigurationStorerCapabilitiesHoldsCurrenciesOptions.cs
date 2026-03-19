// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationStorerCapabilitiesHoldsCurrenciesOptions : INestedOptions
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe in EUR.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountCreateConfigurationStorerCapabilitiesHoldsCurrenciesEurOptions Eur { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe in GBP.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountCreateConfigurationStorerCapabilitiesHoldsCurrenciesGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountCreateConfigurationStorerCapabilitiesHoldsCurrenciesUsdOptions Usd { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe in USDC.
        /// </summary>
        [JsonProperty("usdc")]
        [STJS.JsonPropertyName("usdc")]
        public AccountCreateConfigurationStorerCapabilitiesHoldsCurrenciesUsdcOptions Usdc { get; set; }
    }
}
