// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionLineItemAdjustableQuantityOptions : INestedOptions
    {
        /// <summary>
        /// Set to true if the quantity can be adjusted to any positive integer. Setting to false
        /// will remove any previously specified constraints on quantity.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The maximum quantity the customer can purchase for the Checkout Session. By default this
        /// value is 99. You can specify a value up to 999999.
        /// </summary>
        [JsonProperty("maximum")]
        [STJS.JsonPropertyName("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum quantity the customer must purchase for the Checkout Session. By default
        /// this value is 0.
        /// </summary>
        [JsonProperty("minimum")]
        [STJS.JsonPropertyName("minimum")]
        public long? Minimum { get; set; }
    }
}
