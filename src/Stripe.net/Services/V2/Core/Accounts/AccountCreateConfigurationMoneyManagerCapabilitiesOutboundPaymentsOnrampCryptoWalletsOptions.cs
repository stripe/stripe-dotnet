// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOnrampCryptoWalletsOptions : INestedOptions
    {
        /// <summary>
        /// Can send BRL converted into crypto to a crypto wallet.
        /// </summary>
        [JsonProperty("brl")]
        [STJS.JsonPropertyName("brl")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOnrampCryptoWalletsBrlOptions Brl { get; set; }

        /// <summary>
        /// Can send COP converted into crypto to a crypto wallet.
        /// </summary>
        [JsonProperty("cop")]
        [STJS.JsonPropertyName("cop")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOnrampCryptoWalletsCopOptions Cop { get; set; }

        /// <summary>
        /// Can send EUR converted into crypto to a crypto wallet.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOnrampCryptoWalletsEurOptions Eur { get; set; }

        /// <summary>
        /// Can send GBP converted into crypto to a crypto wallet.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOnrampCryptoWalletsGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can send MXN converted into crypto to a crypto wallet.
        /// </summary>
        [JsonProperty("mxn")]
        [STJS.JsonPropertyName("mxn")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOnrampCryptoWalletsMxnOptions Mxn { get; set; }

        /// <summary>
        /// Can send USD converted into crypto to a crypto wallet.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOnrampCryptoWalletsUsdOptions Usd { get; set; }
    }
}
