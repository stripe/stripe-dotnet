// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TokenNetworkData : StripeEntity<TokenNetworkData>
    {
        [JsonProperty("device")]
        public TokenNetworkDataDevice Device { get; set; }

        [JsonProperty("mastercard")]
        public TokenNetworkDataMastercard Mastercard { get; set; }

        /// <summary>
        /// The network that the token is associated with. An additional hash is included with a
        /// name matching this value, containing tokenization data specific to the card network.
        /// One of: <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visa")]
        public TokenNetworkDataVisa Visa { get; set; }

        [JsonProperty("wallet_provider")]
        public TokenNetworkDataWalletProvider WalletProvider { get; set; }
    }
}
