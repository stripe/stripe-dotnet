// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductFeatureOptions : INestedOptions
    {
        [JsonProperty("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// The marketing feature name. Up to 80 characters long.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
