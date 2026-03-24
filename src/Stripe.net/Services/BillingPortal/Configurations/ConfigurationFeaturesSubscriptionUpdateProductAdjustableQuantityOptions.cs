// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationFeaturesSubscriptionUpdateProductAdjustableQuantityOptions : INestedOptions
    {
        /// <summary>
        /// Set to true if the quantity can be adjusted to any non-negative integer.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The maximum quantity that can be set for the product.
        /// </summary>
        [JsonProperty("maximum")]
        [STJS.JsonPropertyName("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum quantity that can be set for the product.
        /// </summary>
        [JsonProperty("minimum")]
        [STJS.JsonPropertyName("minimum")]
        public long? Minimum { get; set; }
    }
}
