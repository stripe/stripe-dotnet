// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationFeaturesSubscriptionUpdateProduct : StripeEntity<ConfigurationFeaturesSubscriptionUpdateProduct>
    {
        [JsonProperty("adjustable_quantity")]
        [STJS.JsonPropertyName("adjustable_quantity")]
        public ConfigurationFeaturesSubscriptionUpdateProductAdjustableQuantity AdjustableQuantity { get; set; }

        /// <summary>
        /// The list of price IDs which, when subscribed to, a subscription can be updated.
        /// </summary>
        [JsonProperty("prices")]
        [STJS.JsonPropertyName("prices")]
        public List<string> Prices { get; set; }

        /// <summary>
        /// The product ID.
        /// </summary>
        [JsonProperty("product")]
        [STJS.JsonPropertyName("product")]
        public string Product { get; set; }
    }
}
