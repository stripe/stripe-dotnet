// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionLineItemAdjustableQuantityOptions : INestedOptions
    {
        /// <summary>
        /// Set to true if the quantity can be adjusted to any non-negative integer.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The maximum quantity the customer can purchase for the Checkout Session. By default this
        /// value is 99. You can specify a value up to 999999.
        /// </summary>
        [JsonProperty("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum quantity the customer must purchase for the Checkout Session. By default
        /// this value is 0.
        /// </summary>
        [JsonProperty("minimum")]
        public long? Minimum { get; set; }
    }
}
