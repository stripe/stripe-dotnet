// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductFeatureCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the <a href="https://stripe.com/docs/api/entitlements/feature">Feature</a>
        /// object attached to this product.
        /// </summary>
        [JsonProperty("entitlement_feature")]
        public string EntitlementFeature { get; set; }
    }
}
