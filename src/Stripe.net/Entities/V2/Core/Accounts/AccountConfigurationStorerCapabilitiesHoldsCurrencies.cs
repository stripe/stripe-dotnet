// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationStorerCapabilitiesHoldsCurrencies : StripeEntity<AccountConfigurationStorerCapabilitiesHoldsCurrencies>
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe in GBP.
        /// </summary>
        [JsonProperty("gbp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gbp")]
#endif
        public AccountConfigurationStorerCapabilitiesHoldsCurrenciesGbp Gbp { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe in USD.
        /// </summary>
        [JsonProperty("usd")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usd")]
#endif
        public AccountConfigurationStorerCapabilitiesHoldsCurrenciesUsd Usd { get; set; }

        /// <summary>
        /// Can hold storage-type funds on Stripe in USDC.
        /// </summary>
        [JsonProperty("usdc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usdc")]
#endif
        public AccountConfigurationStorerCapabilitiesHoldsCurrenciesUsdc Usdc { get; set; }
    }
}
