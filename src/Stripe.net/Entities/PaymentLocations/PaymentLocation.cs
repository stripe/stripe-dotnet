// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Payment Location represents a physical location where payments take place.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLocation : StripeEntity<PaymentLocation>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Identification numbers associated with the location.
        /// </summary>
        [JsonProperty("business_registration")]
        [STJS.JsonPropertyName("business_registration")]
        public PaymentLocationBusinessRegistration BusinessRegistration { get; set; }

        /// <summary>
        /// The capability settings for the location. Only applicable for locations with requested
        /// payment location capabilities.
        /// </summary>
        [JsonProperty("capability_settings")]
        [STJS.JsonPropertyName("capability_settings")]
        public PaymentLocationCapabilitySettings CapabilitySettings { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The display name of the location.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }
    }
}
