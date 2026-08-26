// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardCryptoWallet : StripeEntity<CardCryptoWallet>
    {
        /// <summary>
        /// The public address of the wallet.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// The blockchain network the wallet is on.
        /// </summary>
        [JsonProperty("chain")]
        [STJS.JsonPropertyName("chain")]
        public string Chain { get; set; }

        /// <summary>
        /// The cryptocurrency held in the wallet.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The type of wallet (standard or bridge_wallet).
        /// One of: <c>bridge_wallet</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
