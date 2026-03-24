// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundSetupIntentCreatePayoutMethodDataCryptoWalletOptions : INestedOptions
    {
        /// <summary>
        /// Crypto wallet address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Optional field, required if network supports memos (only "stellar" currently).
        /// </summary>
        [JsonProperty("memo")]
        [STJS.JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// Which rail we should use to make an Outbound money movement to this wallet.
        /// One of: <c>arbitrum</c>, <c>avalanche_c_chain</c>, <c>base</c>, <c>ethereum</c>,
        /// <c>optimism</c>, <c>polygon</c>, <c>solana</c>, or <c>stellar</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
