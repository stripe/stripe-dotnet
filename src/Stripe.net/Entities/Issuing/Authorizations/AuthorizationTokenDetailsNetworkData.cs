// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationTokenDetailsNetworkData : StripeEntity<AuthorizationTokenDetailsNetworkData>
    {
        [JsonProperty("device")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("device")]
#endif
        public AuthorizationTokenDetailsNetworkDataDevice Device { get; set; }

        [JsonProperty("mastercard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mastercard")]
#endif
        public AuthorizationTokenDetailsNetworkDataMastercard Mastercard { get; set; }

        /// <summary>
        /// The card network for this token.
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
        public AuthorizationTokenDetailsNetworkDataVisa Visa { get; set; }

        [JsonProperty("wallet_provider")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallet_provider")]
#endif
        public AuthorizationTokenDetailsNetworkDataWalletProvider WalletProvider { get; set; }
    }
}
