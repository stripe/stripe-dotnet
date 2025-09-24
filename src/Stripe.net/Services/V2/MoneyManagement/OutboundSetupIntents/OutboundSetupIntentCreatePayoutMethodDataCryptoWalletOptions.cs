// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundSetupIntentCreatePayoutMethodDataCryptoWalletOptions : INestedOptions
    {
        /// <summary>
        /// Crypto wallet address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public string Address { get; set; }

        /// <summary>
        /// Optional field, required if network supports memos (only "stellar" currently).
        /// </summary>
        [JsonProperty("memo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("memo")]
#endif
        public string Memo { get; set; }

        /// <summary>
        /// Which rail we should use to make an Outbound money movement to this wallet.
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
