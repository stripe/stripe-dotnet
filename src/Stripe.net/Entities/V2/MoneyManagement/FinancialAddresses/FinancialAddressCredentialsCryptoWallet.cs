// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressCredentialsCryptoWallet : StripeEntity<FinancialAddressCredentialsCryptoWallet>
    {
        /// <summary>
        /// The blockchain address of the crypto wallet.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Required if the network supports memos (e.g. Stellar).
        /// </summary>
        [JsonProperty("memo")]
        [STJS.JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// The blockchain network of the crypto wallet.
        /// One of: <c>arbitrum</c>, <c>avalanche_c_chain</c>, <c>base</c>, <c>ethereum</c>,
        /// <c>optimism</c>, <c>polygon</c>, <c>solana</c>, <c>stellar</c>, or <c>tempo</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
