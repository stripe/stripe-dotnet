// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodCryptoWallet : StripeEntity<PayoutMethodCryptoWallet>
    {
        /// <summary>
        /// Destination wallet address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public string Address { get; set; }

        /// <summary>
        /// Whether the crypto wallet was archived. Crypto wallets can be archived through the
        /// /archive API, and they will not be automatically archived by Stripe. Archived crypto
        /// wallets cannot be used as payout method and will not appear in the payout method list.
        /// </summary>
        [JsonProperty("archived")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("archived")]
#endif
        public bool Archived { get; set; }

        /// <summary>
        /// Optional field, required if network supports memos (only "stellar" currently).
        /// </summary>
        [JsonProperty("memo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("memo")]
#endif
        public string Memo { get; set; }

        /// <summary>
        /// Which rail is being used to make an outbound money movement to this wallet.
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
