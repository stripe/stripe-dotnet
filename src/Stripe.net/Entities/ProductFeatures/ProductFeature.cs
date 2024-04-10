// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    /// <summary>
    /// A product_feature represents an attachment between a feature and a product. When a
    /// product is purchased that has a feature attached, Stripe will create an entitlement to
    /// the feature for the purchasing customer.
    /// </summary>
    public class ProductFeature : StripeEntity<ProductFeature>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// A feature represents a monetizable ability or functionality in your system. Features can
        /// be assigned to products, and when those products are purchased, Stripe will create an
        /// entitlement to the feature for the purchasing customer.
        /// </summary>
        [JsonProperty("entitlement_feature")]
        public Entitlements.Feature EntitlementFeature { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }
    }
}
