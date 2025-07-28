// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationFeaturesSubscriptionUpdateProductAdjustableQuantityOptions : INestedOptions
    {
        /// <summary>
        /// Set to true if the quantity can be adjusted to any non-negative integer.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }

        /// <summary>
        /// The maximum quantity that can be set for the product.
        /// </summary>
        [JsonProperty("maximum")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum")]
#endif
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum quantity that can be set for the product.
        /// </summary>
        [JsonProperty("minimum")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum")]
#endif
        public long? Minimum { get; set; }
    }
}
