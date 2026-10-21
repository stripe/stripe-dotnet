// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionItemMetronomeCommitCommitCommitOptionsCustomAmountOptions : INestedOptions
    {
        /// <summary>
        /// Must be <c>true</c> when <c>custom_amount</c> is present. Omit <c>custom_amount</c> to
        /// disable custom amounts.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Maximum <c>access_amount</c> the customer can enter. Defaults to <c>999999999999999</c>
        /// when omitted.
        /// </summary>
        [JsonProperty("maximum")]
        [STJS.JsonPropertyName("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// Minimum <c>access_amount</c> the customer can enter. Defaults to <c>1</c> when omitted.
        /// </summary>
        [JsonProperty("minimum")]
        [STJS.JsonPropertyName("minimum")]
        public long? Minimum { get; set; }
    }
}
