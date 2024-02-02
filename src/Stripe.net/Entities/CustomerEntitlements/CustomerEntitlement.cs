// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    /// <summary>
    /// A entitlement for a customer describes access to a feature.
    /// </summary>
    public class CustomerEntitlement : StripeEntity<CustomerEntitlement>, IHasId, IHasObject
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
        /// The feature that the customer is entitled to.
        /// </summary>
        [JsonProperty("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A unique key you provide as your own system identifier. This may be up to 80 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Contains information about entitlements relating to features with type=quantity.
        /// Required when the feature has type=quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public CustomerEntitlementQuantity Quantity { get; set; }

        /// <summary>
        /// The type of feature.
        /// One of: <c>quantity</c>, or <c>switch</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
