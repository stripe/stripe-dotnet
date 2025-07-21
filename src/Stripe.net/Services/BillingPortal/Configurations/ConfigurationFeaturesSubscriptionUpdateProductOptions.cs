// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationFeaturesSubscriptionUpdateProductOptions : INestedOptions
    {
        /// <summary>
        /// Control whether the quantity of the product can be adjusted.
        /// </summary>
        [JsonProperty("adjustable_quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adjustable_quantity")]
#endif
        public ConfigurationFeaturesSubscriptionUpdateProductAdjustableQuantityOptions AdjustableQuantity { get; set; }

        /// <summary>
        /// The list of price IDs for the product that a subscription can be updated to.
        /// </summary>
        [JsonProperty("prices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prices")]
#endif
        public List<string> Prices { get; set; }

        /// <summary>
        /// The product id.
        /// </summary>
        [JsonProperty("product")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product")]
#endif
        public string Product { get; set; }
    }
}
