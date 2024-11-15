// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationFeaturesSubscriptionUpdateProduct : StripeEntity<ConfigurationFeaturesSubscriptionUpdateProduct>
    {
        /// <summary>
        /// The list of price IDs which, when subscribed to, a subscription can be updated.
        /// </summary>
        [JsonProperty("prices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prices")]
#endif

        public List<string> Prices { get; set; }

        /// <summary>
        /// The product ID.
        /// </summary>
        [JsonProperty("product")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product")]
#endif

        public string Product { get; set; }
    }
}
