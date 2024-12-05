// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductMarketingFeature : StripeEntity<ProductMarketingFeature>
    {
        /// <summary>
        /// The marketing feature name. Up to 80 characters long.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
