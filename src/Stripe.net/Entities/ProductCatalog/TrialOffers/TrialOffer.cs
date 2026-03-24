// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Resource for the TrialOffer API, used to describe a subscription item's trial period
    /// settings. Renders a TrialOffer object that describes the price, duration, end_behavior
    /// of a trial offer.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TrialOffer : StripeEntity<TrialOffer>, IHasId, IHasObject
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

        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public TrialOfferDuration Duration { get; set; }

        [JsonProperty("end_behavior")]
        [STJS.JsonPropertyName("end_behavior")]
        public TrialOfferEndBehavior EndBehavior { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A brief, user-friendly name for the trial offer-for identification purposes.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        #region Expandable Price

        /// <summary>
        /// (ID of the Price)
        /// The price during the trial offer.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string PriceId
        {
            get => this.InternalPrice?.Id;
            set => this.InternalPrice = SetExpandableFieldId(value, this.InternalPrice);
        }

        /// <summary>
        /// (Expanded)
        /// The price during the trial offer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Price Price
        {
            get => this.InternalPrice?.ExpandedObject;
            set => this.InternalPrice = SetExpandableFieldObject(value, this.InternalPrice);
        }

        [JsonProperty("price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
        [STJS.JsonPropertyName("price")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Price>))]
        internal ExpandableField<Price> InternalPrice { get; set; }
        #endregion
    }
}
