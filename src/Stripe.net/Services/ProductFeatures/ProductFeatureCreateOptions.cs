// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProductFeatureCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the <a href="https://stripe.com/docs/api/entitlements/feature">Feature</a>
        /// object attached to this product.
        /// </summary>
        [JsonProperty("entitlement_feature")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entitlement_feature")]
#endif
        public string EntitlementFeature { get; set; }
    }
}
