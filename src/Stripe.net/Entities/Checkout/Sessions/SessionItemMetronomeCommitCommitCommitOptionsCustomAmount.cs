// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemMetronomeCommitCommitCommitOptionsCustomAmount : StripeEntity<SessionItemMetronomeCommitCommitCommitOptionsCustomAmount>
    {
        /// <summary>
        /// Whether custom amount input is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Maximum <c>access_amount</c> the customer can enter. <c>null</c> means the effective
        /// maximum is <c>999999999999999</c>.
        /// </summary>
        [JsonProperty("maximum")]
        [STJS.JsonPropertyName("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// Minimum <c>access_amount</c> the customer can enter. <c>null</c> means the effective
        /// minimum is <c>1</c>.
        /// </summary>
        [JsonProperty("minimum")]
        [STJS.JsonPropertyName("minimum")]
        public long? Minimum { get; set; }
    }
}
