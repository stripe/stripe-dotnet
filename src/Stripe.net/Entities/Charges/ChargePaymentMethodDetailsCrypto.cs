// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsCrypto : StripeEntity<ChargePaymentMethodDetailsCrypto>
    {
        /// <summary>
        /// The wallet address of the customer.
        /// </summary>
        [JsonProperty("buyer_address")]
        [STJS.JsonPropertyName("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// The blockchain network that the transaction was sent on.
        /// One of: <c>base</c>, <c>ethereum</c>, <c>polygon</c>, <c>solana</c>, or <c>tempo</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// The token currency that the transaction was sent with.
        /// One of: <c>usdc</c>, <c>usdg</c>, or <c>usdp</c>.
        /// </summary>
        [JsonProperty("token_currency")]
        [STJS.JsonPropertyName("token_currency")]
        public string TokenCurrency { get; set; }

        /// <summary>
        /// The blockchain transaction hash of the crypto payment.
        /// </summary>
        [JsonProperty("transaction_hash")]
        [STJS.JsonPropertyName("transaction_hash")]
        public string TransactionHash { get; set; }
    }
}
