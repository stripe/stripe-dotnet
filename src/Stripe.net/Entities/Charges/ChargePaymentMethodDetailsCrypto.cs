// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsCrypto : StripeEntity<ChargePaymentMethodDetailsCrypto>
    {
        /// <summary>
        /// The wallet address of the customer.
        /// </summary>
        [JsonProperty("buyer_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("buyer_address")]
#endif
        public string BuyerAddress { get; set; }

        /// <summary>
        /// The blockchain network that the transaction was sent on.
        /// One of: <c>base</c>, <c>ethereum</c>, <c>polygon</c>, or <c>solana</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }

        /// <summary>
        /// The token currency that the transaction was sent with.
        /// One of: <c>usdc</c>, <c>usdg</c>, or <c>usdp</c>.
        /// </summary>
        [JsonProperty("token_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_currency")]
#endif
        public string TokenCurrency { get; set; }

        /// <summary>
        /// The blockchain transaction hash of the crypto payment.
        /// </summary>
        [JsonProperty("transaction_hash")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_hash")]
#endif
        public string TransactionHash { get; set; }
    }
}
