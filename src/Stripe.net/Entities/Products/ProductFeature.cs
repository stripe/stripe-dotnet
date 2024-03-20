// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ProductFeature : StripeEntity<ProductFeature>
    {
        #region Expandable Feature

        [JsonIgnore]
        public string FeatureId
        {
            get => this.InternalFeature?.Id;
            set => this.InternalFeature = SetExpandableFieldId(value, this.InternalFeature);
        }

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
        /// The marketing feature name. Up to 80 characters long.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
