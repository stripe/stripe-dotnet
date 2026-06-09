// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentUpdateCryptoRefundAddressOptions : BaseOptions
    {
        /// <summary>
        /// The blockchain network for the refund address.
        /// One of: <c>base</c>, <c>ethereum</c>, <c>polygon</c>, <c>solana</c>, <c>sui</c>, or
        /// <c>tempo</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// The wallet address that should receive refunds for deposits on the specified network.
        /// </summary>
        [JsonProperty("refund_address")]
        [STJS.JsonPropertyName("refund_address")]
        public string RefundAddress { get; set; }
    }
}
