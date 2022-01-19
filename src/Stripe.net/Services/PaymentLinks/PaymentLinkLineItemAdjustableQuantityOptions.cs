// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkLineItemAdjustableQuantityOptions : INestedOptions
    {
        /// <summary>
        /// Set to true if the quantity can be adjusted to any non-negative Integer.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The maximum quantity the customer can purchase. By default this value is 99. You can
        /// specify a value up to 99.
        /// </summary>
        [JsonProperty("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum quantity the customer can purchase. By default this value is 0. You can
        /// specify a value up to 98.
        /// </summary>
        [JsonProperty("minimum")]
        public long? Minimum { get; set; }
    }
}
