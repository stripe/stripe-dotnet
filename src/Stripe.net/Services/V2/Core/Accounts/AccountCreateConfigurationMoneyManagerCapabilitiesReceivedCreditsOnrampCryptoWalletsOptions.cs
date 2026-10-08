// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampCryptoWalletsOptions : INestedOptions
    {
        /// <summary>
        /// Can receive crypto converted from BRL through a crypto-wallet-like financial address.
        /// </summary>
        [JsonProperty("brl")]
        [STJS.JsonPropertyName("brl")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampCryptoWalletsBrlOptions Brl { get; set; }

        /// <summary>
        /// Can receive crypto converted from COP through a crypto-wallet-like financial address.
        /// </summary>
        [JsonProperty("cop")]
        [STJS.JsonPropertyName("cop")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampCryptoWalletsCopOptions Cop { get; set; }

        /// <summary>
        /// Can receive crypto converted from EUR through a crypto-wallet-like financial address.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampCryptoWalletsEurOptions Eur { get; set; }

        /// <summary>
        /// Can receive crypto converted from GBP through a crypto-wallet-like financial address.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampCryptoWalletsGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can receive crypto converted from MXN through a crypto-wallet-like financial address.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampCryptoWalletsMxnOptions Mxn { get; set; }

        /// <summary>
        /// Can receive crypto converted from USD through a crypto-wallet-like financial address.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampCryptoWalletsUsdOptions Usd { get; set; }
    }
}
