// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnrampTransactionLimitsGetOptions : BaseOptions
    {
        /// <summary>
        /// The IP address of the customer requesting transaction limits. We support IPv4 and IPv6
        /// addresses.
        /// </summary>
        [JsonProperty("customer_ip_address")]
        [STJS.JsonPropertyName("customer_ip_address")]
        public string CustomerIpAddress { get; set; }

        /// <summary>
        /// The destination blockchain network to use for limit calculations.
        /// One of: <c>avalanche</c>, <c>base</c>, <c>bitcoin</c>, <c>ethereum</c>, <c>optimism</c>,
        /// <c>polygon</c>, <c>solana</c>, <c>stellar</c>, or <c>worldchain</c>.
        /// </summary>
        [JsonProperty("destination_network")]
        [STJS.JsonPropertyName("destination_network")]
        public string DestinationNetwork { get; set; }

        /// <summary>
        /// The destination tag for the wallet address, if applicable for the network.
        /// </summary>
        [JsonProperty("destination_tag")]
        [STJS.JsonPropertyName("destination_tag")]
        public string DestinationTag { get; set; }

        /// <summary>
        /// The wallet address to use for destination-specific limit calculations.
        /// </summary>
        [JsonProperty("wallet_address")]
        [STJS.JsonPropertyName("wallet_address")]
        public string WalletAddress { get; set; }
    }
}
