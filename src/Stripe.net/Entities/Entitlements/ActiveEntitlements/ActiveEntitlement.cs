// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An active entitlement describes access to a feature for a customer.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActiveEntitlement : StripeEntity<ActiveEntitlement>, IHasId, IHasObject
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

        #region Expandable Feature

        /// <summary>
        /// (ID of the Feature)
        /// The <a href="https://docs.stripe.com/api/entitlements/feature">Feature</a> that the
        /// customer is entitled to.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string FeatureId
        {
            get => this.InternalFeature?.Id;
            set => this.InternalFeature = SetExpandableFieldId(value, this.InternalFeature);
        }

        /// <summary>
        /// (Expanded)
        /// The <a href="https://docs.stripe.com/api/entitlements/feature">Feature</a> that the
        /// customer is entitled to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Feature Feature
        {
            get => this.InternalFeature?.ExpandedObject;
            set => this.InternalFeature = SetExpandableFieldObject(value, this.InternalFeature);
        }

        [JsonProperty("feature")]
        [JsonConverter(typeof(ExpandableFieldConverter<Feature>))]
        [STJS.JsonPropertyName("feature")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Feature>))]
        internal ExpandableField<Feature> InternalFeature { get; set; }
        #endregion

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A unique key you provide as your own system identifier. This may be up to 80 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }
    }
}
