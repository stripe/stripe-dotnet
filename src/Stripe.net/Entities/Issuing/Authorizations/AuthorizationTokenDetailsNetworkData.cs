// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationTokenDetailsNetworkData : StripeEntity<AuthorizationTokenDetailsNetworkData>
    {
        [JsonProperty("device")]
        [STJS.JsonPropertyName("device")]
        public AuthorizationTokenDetailsNetworkDataDevice Device { get; set; }

        [JsonProperty("mastercard")]
        [STJS.JsonPropertyName("mastercard")]
        public AuthorizationTokenDetailsNetworkDataMastercard Mastercard { get; set; }

        /// <summary>
        /// The card network for this token.
        /// One of: <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("visa")]
        [STJS.JsonPropertyName("visa")]
        public AuthorizationTokenDetailsNetworkDataVisa Visa { get; set; }

        [JsonProperty("wallet_provider")]
        [STJS.JsonPropertyName("wallet_provider")]
        public AuthorizationTokenDetailsNetworkDataWalletProvider WalletProvider { get; set; }
    }
}
