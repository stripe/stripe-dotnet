// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Card Design is a logical grouping of a Card Bundle, card logo, and carrier text that
    /// represents a product line.
    /// </summary>
    public class CardDesign : StripeEntity<CardDesign>, IHasId, IHasMetadata, IHasObject
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

        #region Expandable CardBundle

        /// <summary>
        /// (ID of the CardBundle)
        /// The card bundle object belonging to this card design.
        /// </summary>
        [JsonIgnore]
        public string CardBundleId
        {
            get => this.InternalCardBundle?.Id;
            set => this.InternalCardBundle = SetExpandableFieldId(value, this.InternalCardBundle);
        }

        /// <summary>
        /// (Expanded)
        /// The card bundle object belonging to this card design.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public CardBundle CardBundle
        {
            get => this.InternalCardBundle?.ExpandedObject;
            set => this.InternalCardBundle = SetExpandableFieldObject(value, this.InternalCardBundle);
        }

        [JsonProperty("card_bundle")]
        [JsonConverter(typeof(ExpandableFieldConverter<CardBundle>))]
        internal ExpandableField<CardBundle> InternalCardBundle { get; set; }
        #endregion

        /// <summary>
        /// A lookup key used to retrieve card designs dynamically from a static string. This may be
        /// up to 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Friendly display name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether this card design is used to create cards when one is not specified.
        /// One of: <c>default</c>, <c>none</c>, or <c>platform_default</c>.
        /// </summary>
        [JsonProperty("preference")]
        public string Preference { get; set; }

        /// <summary>
        /// Whether this card design can be used to create cards.
        /// One of: <c>active</c>, <c>inactive</c>, <c>rejected</c>, or <c>review</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
