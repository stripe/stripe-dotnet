// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    /// <summary>
    /// A Physical Bundle represents the bundle of physical items - card stock, carrier letter,
    /// and envelope - that is shipped to a cardholder when you create a physical card.
    /// </summary>
    public class PhysicalBundle : StripeEntity<PhysicalBundle>, IHasId, IHasObject
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

        [JsonProperty("features")]
        public PhysicalBundleFeatures Features { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Friendly display name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether this physical bundle can be used to create cards.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>review</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Whether this physical bundle is a standard Stripe offering or custom-made for you.
        /// One of: <c>custom</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
