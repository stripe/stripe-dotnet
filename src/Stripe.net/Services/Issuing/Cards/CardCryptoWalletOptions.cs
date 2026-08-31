// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardCryptoWalletOptions : INestedOptions
    {
        /// <summary>
        /// The public address of the crypto wallet.
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
        /// Updates the crypto wallet's funding currency for subsequent card movements. This doesn't
        /// convert existing balances or change the wallet's address, chain, or type.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The type of wallet (standard or bridge_wallet).
        /// One of: <c>bridge_wallet</c>, or <c>standard</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
