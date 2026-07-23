// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OnrampSessionTransactionDetailsWalletAddresses : StripeEntity<OnrampSessionTransactionDetailsWalletAddresses>
    {
        /// <summary>
        /// An avalanche address.
        /// </summary>
        [JsonProperty("avalanche")]
        [STJS.JsonPropertyName("avalanche")]
        public string Avalanche { get; set; }

        /// <summary>
        /// A base address.
        /// </summary>
        [JsonProperty("base_network")]
        [STJS.JsonPropertyName("base_network")]
        public string BaseNetwork { get; set; }

        /// <summary>
        /// A bitcoin address.
        /// </summary>
        [JsonProperty("bitcoin")]
        [STJS.JsonPropertyName("bitcoin")]
        public string Bitcoin { get; set; }

        /// <summary>
        /// The end customer's crypto wallet destination tag (for each network) to use for this
        /// transaction.
        /// </summary>
        [JsonProperty("destination_tags")]
        [STJS.JsonPropertyName("destination_tags")]
        public OnrampSessionTransactionDetailsWalletAddressesDestinationTags DestinationTags { get; set; }

        /// <summary>
        /// An ethereum address.
        /// </summary>
        [JsonProperty("ethereum")]
        [STJS.JsonPropertyName("ethereum")]
        public string Ethereum { get; set; }

        /// <summary>
        /// An optimism address.
        /// </summary>
        [JsonProperty("optimism")]
        [STJS.JsonPropertyName("optimism")]
        public string Optimism { get; set; }

        /// <summary>
        /// A polygon address.
        /// </summary>
        [JsonProperty("polygon")]
        [STJS.JsonPropertyName("polygon")]
        public string Polygon { get; set; }

        /// <summary>
        /// A solana address.
        /// </summary>
        [JsonProperty("solana")]
        [STJS.JsonPropertyName("solana")]
        public string Solana { get; set; }

        /// <summary>
        /// A stellar address.
        /// </summary>
        [JsonProperty("stellar")]
        [STJS.JsonPropertyName("stellar")]
        public string Stellar { get; set; }

        /// <summary>
        /// A Sui address.
        /// </summary>
        [JsonProperty("sui")]
        [STJS.JsonPropertyName("sui")]
        public string Sui { get; set; }

        /// <summary>
        /// A worldchain address.
        /// </summary>
        [JsonProperty("worldchain")]
        [STJS.JsonPropertyName("worldchain")]
        public string Worldchain { get; set; }
    }
}
