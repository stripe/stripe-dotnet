// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenNetworkData : StripeEntity<TokenNetworkData>
    {
        [JsonProperty("device")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("device")]
#endif

        public TokenNetworkDataDevice Device { get; set; }

        [JsonProperty("mastercard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mastercard")]
#endif

        public TokenNetworkDataMastercard Mastercard { get; set; }

        /// <summary>
        /// The network that the token is associated with. An additional hash is included with a
        /// name matching this value, containing tokenization data specific to the card network.
        /// One of: <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        [JsonProperty("visa")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("visa")]
#endif

        public TokenNetworkDataVisa Visa { get; set; }

        [JsonProperty("wallet_provider")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallet_provider")]
#endif

        public TokenNetworkDataWalletProvider WalletProvider { get; set; }
    }
}
