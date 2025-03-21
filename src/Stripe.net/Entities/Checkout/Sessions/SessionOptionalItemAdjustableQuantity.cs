// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionOptionalItemAdjustableQuantity : StripeEntity<SessionOptionalItemAdjustableQuantity>
    {
        /// <summary>
        /// Set to true if the quantity can be adjusted to any non-negative integer.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// The maximum quantity of this item the customer can purchase. By default this value is
        /// 99. You can specify a value up to 999999.
        /// </summary>
        [JsonProperty("maximum")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum")]
#endif
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum quantity of this item the customer must purchase, if they choose to purchase
        /// it. Because this item is optional, the customer will always be able to remove it from
        /// their order, even if the <c>minimum</c> configured here is greater than 0. By default
        /// this value is 0.
        /// </summary>
        [JsonProperty("minimum")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum")]
#endif
        public long? Minimum { get; set; }
    }
}
