// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TokenNetworkData : StripeEntity<TokenNetworkData>
    {
        [JsonProperty("device")]
        [STJS.JsonPropertyName("device")]
        public TokenNetworkDataDevice Device { get; set; }

        [JsonProperty("mastercard")]
        [STJS.JsonPropertyName("mastercard")]
        public TokenNetworkDataMastercard Mastercard { get; set; }

        /// <summary>
        /// The network that the token is associated with. An additional hash is included with a
        /// name matching this value, containing tokenization data specific to the card network.
        /// One of: <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("visa")]
        [STJS.JsonPropertyName("visa")]
        public TokenNetworkDataVisa Visa { get; set; }

        [JsonProperty("wallet_provider")]
        [STJS.JsonPropertyName("wallet_provider")]
        public TokenNetworkDataWalletProvider WalletProvider { get; set; }
    }
}
