// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsOptions : INestedOptions
    {
        /// <summary>
        /// Can send BRL converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("brl")]
        [STJS.JsonPropertyName("brl")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsBrlOptions Brl { get; set; }

        /// <summary>
        /// Can send COP converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("cop")]
        [STJS.JsonPropertyName("cop")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsCopOptions Cop { get; set; }

        /// <summary>
        /// Can send EUR converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsEurOptions Eur { get; set; }

        /// <summary>
        /// Can send GBP converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can send MXN converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsMxnOptions Mxn { get; set; }

        /// <summary>
        /// Can send USD converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsUsdOptions Usd { get; set; }
    }
}
