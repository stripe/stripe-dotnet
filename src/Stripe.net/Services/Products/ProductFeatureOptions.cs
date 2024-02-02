// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductFeatureOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the <a href="docs/api/entitlements/feature">Feature</a> object. This property
        /// is mutually-exclusive with <c>name</c>; either one must be specified, but not both.
        /// </summary>
        [JsonProperty("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// The feature's name. Up to 80 characters long.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
