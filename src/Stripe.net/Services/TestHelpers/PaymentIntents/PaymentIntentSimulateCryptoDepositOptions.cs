// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentSimulateCryptoDepositOptions : BaseOptions
    {
        /// <summary>
        /// The buyer's wallet address from which the crypto deposit is originating.
        /// </summary>
        [JsonProperty("buyer_wallet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("buyer_wallet")]
#endif
        public string BuyerWallet { get; set; }

        /// <summary>
        /// The blockchain network of the simulated crypto deposit.
        /// One of: <c>base</c>, <c>solana</c>, or <c>tempo</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }

        /// <summary>
        /// The token currency of the simulated crypto deposit.
        /// </summary>
        [JsonProperty("token_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_currency")]
#endif
        public string TokenCurrency { get; set; }

        /// <summary>
        /// A testmode transaction hash that determines the outcome of the simulated deposit.
        /// </summary>
        [JsonProperty("transaction_hash")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_hash")]
#endif
        public string TransactionHash { get; set; }
    }
}
