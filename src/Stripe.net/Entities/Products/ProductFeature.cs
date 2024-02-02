// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ProductFeature : StripeEntity<ProductFeature>
    {
        #region Expandable Feature

        /// <summary>
        /// (ID of the Entitlements.Feature)
        /// The ID of the <a href="docs/api/entitlements/feature">Feature</a> object. This property
        /// is mutually-exclusive with <c>name</c>; either one must be specified, but not both.
        /// </summary>
        [JsonIgnore]
        public string FeatureId
        {
            get => this.InternalFeature?.Id;
            set => this.InternalFeature = SetExpandableFieldId(value, this.InternalFeature);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the <a href="docs/api/entitlements/feature">Feature</a> object. This property
        /// is mutually-exclusive with <c>name</c>; either one must be specified, but not both.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Entitlements.Feature Feature
        {
            get => this.InternalFeature?.ExpandedObject;
            set => this.InternalFeature = SetExpandableFieldObject(value, this.InternalFeature);
        }

        [JsonProperty("feature")]
        [JsonConverter(typeof(ExpandableFieldConverter<Entitlements.Feature>))]
        internal ExpandableField<Entitlements.Feature> InternalFeature { get; set; }
        #endregion

        /// <summary>
        /// The feature's name. Up to 80 characters long.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
