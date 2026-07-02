// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A consumer wallet represents a cryptocurrency wallet address associated with a Crypto
    /// Customer.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerConsumerWallet : StripeEntity<CustomerConsumerWallet>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The blockchain network for this wallet.
        /// One of: <c>aptos</c>, <c>avalanche</c>, <c>base</c>, <c>bitcoin</c>, <c>ethereum</c>,
        /// <c>optimism</c>, <c>polygon</c>, <c>solana</c>, <c>stellar</c>, or <c>worldchain</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// Whether ownership of this wallet has been verified.
        /// </summary>
        [JsonProperty("verified_ownership")]
        [STJS.JsonPropertyName("verified_ownership")]
        public bool VerifiedOwnership { get; set; }

        /// <summary>
        /// The wallet address.
        /// </summary>
        [JsonProperty("wallet_address")]
        [STJS.JsonPropertyName("wallet_address")]
        public string WalletAddress { get; set; }
    }
}
