// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorerCapabilitiesHoldsCurrencies : StripeEntity<AccountConfigurationStorerCapabilitiesHoldsCurrencies>
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe in EUR.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountConfigurationStorerCapabilitiesHoldsCurrenciesEur Eur { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe in GBP.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountConfigurationStorerCapabilitiesHoldsCurrenciesGbp Gbp { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountConfigurationStorerCapabilitiesHoldsCurrenciesUsd Usd { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe in USDC.
        /// </summary>
        [JsonProperty("usdc")]
        [STJS.JsonPropertyName("usdc")]
        public AccountConfigurationStorerCapabilitiesHoldsCurrenciesUsdc Usdc { get; set; }
    }
}
