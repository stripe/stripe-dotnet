// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;

    public class FeatureCreateOptions : BaseOptions
    {
        /// <summary>
        /// A unique key you provide as your own system identifier. This may be up to 80 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// The feature's name, for your own purpose, not meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Contains information about type=quantity features. This is required when type=quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public FeatureQuantityOptions Quantity { get; set; }

        /// <summary>
        /// The type of feature.
        /// One of: <c>quantity</c>, or <c>switch</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
