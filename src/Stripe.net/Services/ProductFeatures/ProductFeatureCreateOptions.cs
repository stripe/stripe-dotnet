// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProductFeatureCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the <a href="https://docs.stripe.com/api/entitlements/feature">Feature</a>
        /// object attached to this product.
        /// </summary>
        [JsonProperty("entitlement_feature")]
        [STJS.JsonPropertyName("entitlement_feature")]
        public string EntitlementFeature { get; set; }
    }
}
