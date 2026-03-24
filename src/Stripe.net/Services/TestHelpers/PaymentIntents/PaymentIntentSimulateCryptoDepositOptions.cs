// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentSimulateCryptoDepositOptions : BaseOptions
    {
        /// <summary>
        /// The buyer's wallet address from which the crypto deposit is originating.
        /// </summary>
        [JsonProperty("buyer_wallet")]
        [STJS.JsonPropertyName("buyer_wallet")]
        public string BuyerWallet { get; set; }

        /// <summary>
        /// The blockchain network of the simulated crypto deposit.
        /// One of: <c>base</c>, <c>solana</c>, or <c>tempo</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// The token currency of the simulated crypto deposit.
        /// </summary>
        [JsonProperty("token_currency")]
        [STJS.JsonPropertyName("token_currency")]
        public string TokenCurrency { get; set; }

        /// <summary>
        /// A testmode transaction hash that determines the outcome of the simulated deposit.
        /// </summary>
        [JsonProperty("transaction_hash")]
        [STJS.JsonPropertyName("transaction_hash")]
        public string TransactionHash { get; set; }
    }
}
