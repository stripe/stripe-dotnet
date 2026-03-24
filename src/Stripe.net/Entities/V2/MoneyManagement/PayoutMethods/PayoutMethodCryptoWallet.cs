// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodCryptoWallet : StripeEntity<PayoutMethodCryptoWallet>
    {
        /// <summary>
        /// Destination wallet address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Whether the crypto wallet was archived. Crypto wallets can be archived through the
        /// /archive API, and they will not be automatically archived by Stripe. Archived crypto
        /// wallets cannot be used as payout method and will not appear in the payout method list.
        /// </summary>
        [JsonProperty("archived")]
        [STJS.JsonPropertyName("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// Optional field, required if network supports memos (only "stellar" currently).
        /// </summary>
        [JsonProperty("memo")]
        [STJS.JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// Which rail is being used to make an outbound money movement to this wallet.
        /// One of: <c>arbitrum</c>, <c>avalanche_c_chain</c>, <c>base</c>, <c>ethereum</c>,
        /// <c>optimism</c>, <c>polygon</c>, <c>solana</c>, or <c>stellar</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
