// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditCryptoWalletTransferCryptoWallet : StripeEntity<ReceivedCreditCryptoWalletTransferCryptoWallet>
    {
        /// <summary>
        /// The address of the wallet the crypto was received from.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public string Address { get; set; }

        /// <summary>
        /// A memo also for identifying the recipient for memo-based blockchains (e.g., Stellar),.
        /// </summary>
        [JsonProperty("memo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("memo")]
#endif
        public string Memo { get; set; }

        /// <summary>
        /// The network the crypto was received from.
        /// One of: <c>arbitrum</c>, <c>avalanche_c_chain</c>, <c>base</c>, <c>ethereum</c>,
        /// <c>optimism</c>, <c>polygon</c>, <c>solana</c>, or <c>stellar</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }
    }
}
