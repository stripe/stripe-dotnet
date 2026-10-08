// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWallets : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWallets>
    {
        /// <summary>
        /// Can send BRL converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("brl")]
        [STJS.JsonPropertyName("brl")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsBrl Brl { get; set; }

        /// <summary>
        /// Can send COP converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("cop")]
        [STJS.JsonPropertyName("cop")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsCop Cop { get; set; }

        /// <summary>
        /// Can send EUR converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsEur Eur { get; set; }

        /// <summary>
        /// Can send GBP converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsGbp Gbp { get; set; }

        /// <summary>
        /// Can send MXN converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsMxn Mxn { get; set; }

        /// <summary>
        /// Can send USD converted into crypto to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountConfigurationMoneyManagerCapabilitiesOutboundTransfersOnrampCryptoWalletsUsd Usd { get; set; }
    }
}
