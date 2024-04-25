// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// An active entitlement describes access to a feature for a customer.
    /// </summary>
    public class ActiveEntitlement : StripeEntity<ActiveEntitlement>, IHasId, IHasObject
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

        #region Expandable Feature

        /// <summary>
        /// (ID of the Feature)
        /// The <a href="https://stripe.com/docs/api/entitlements/feature">Feature</a> that the
        /// customer is entitled to.
        /// </summary>
        [JsonIgnore]
        public string FeatureId
        {
            get => this.InternalFeature?.Id;
            set => this.InternalFeature = SetExpandableFieldId(value, this.InternalFeature);
        }

        /// <summary>
        /// (Expanded)
        /// The <a href="https://stripe.com/docs/api/entitlements/feature">Feature</a> that the
        /// customer is entitled to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Feature Feature
        {
            get => this.InternalFeature?.ExpandedObject;
            set => this.InternalFeature = SetExpandableFieldObject(value, this.InternalFeature);
        }

        [JsonProperty("feature")]
        [JsonConverter(typeof(ExpandableFieldConverter<Feature>))]
        internal ExpandableField<Feature> InternalFeature { get; set; }
        #endregion

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
    }
}
