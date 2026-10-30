// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemSubscriptionItemAdjustableQuantity : StripeEntity<SessionItemSubscriptionItemAdjustableQuantity>
    {
        /// <summary>
        /// Whether the quantity is adjustable.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The maximum quantity the customer can purchase.
        /// </summary>
        [JsonProperty("maximum")]
        [STJS.JsonPropertyName("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum quantity the customer can purchase.
        /// </summary>
        [JsonProperty("minimum")]
        [STJS.JsonPropertyName("minimum")]
        public long? Minimum { get; set; }
    }
}
