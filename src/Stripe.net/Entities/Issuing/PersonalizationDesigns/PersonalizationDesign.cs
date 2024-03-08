// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Personalization Design is a logical grouping of a Physical Bundle, card logo, and
    /// carrier text that represents a product line.
    /// </summary>
    public class PersonalizationDesign : StripeEntity<PersonalizationDesign>, IHasId, IHasMetadata, IHasObject
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

        #region Expandable CardLogo

        /// <summary>
        /// (ID of the File)
        /// The file for the card logo to use with physical bundles that support card logos. Must
        /// have a <c>purpose</c> value of <c>issuing_logo</c>.
        /// </summary>
        [JsonIgnore]
        public string CardLogoId
        {
            get => this.InternalCardLogo?.Id;
            set => this.InternalCardLogo = SetExpandableFieldId(value, this.InternalCardLogo);
        }

        /// <summary>
        /// (Expanded)
        /// The file for the card logo to use with physical bundles that support card logos. Must
        /// have a <c>purpose</c> value of <c>issuing_logo</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File CardLogo
        {
            get => this.InternalCardLogo?.ExpandedObject;
            set => this.InternalCardLogo = SetExpandableFieldObject(value, this.InternalCardLogo);
        }

        [JsonProperty("card_logo")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalCardLogo { get; set; }
        #endregion

        /// <summary>
        /// Hash containing carrier text, for use with physical bundles that support carrier text.
        /// </summary>
        [JsonProperty("carrier_text")]
        public PersonalizationDesignCarrierText CarrierText { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A lookup key used to retrieve personalization designs dynamically from a static string.
        /// This may be up to 200 characters.
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

        #region Expandable PhysicalBundle

        /// <summary>
        /// (ID of the PhysicalBundle)
        /// The physical bundle object belonging to this personalization design.
        /// </summary>
        [JsonIgnore]
        public string PhysicalBundleId
        {
            get => this.InternalPhysicalBundle?.Id;
            set => this.InternalPhysicalBundle = SetExpandableFieldId(value, this.InternalPhysicalBundle);
        }

        /// <summary>
        /// (Expanded)
        /// The physical bundle object belonging to this personalization design.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PhysicalBundle PhysicalBundle
        {
            get => this.InternalPhysicalBundle?.ExpandedObject;
            set => this.InternalPhysicalBundle = SetExpandableFieldObject(value, this.InternalPhysicalBundle);
        }

        [JsonProperty("physical_bundle")]
        [JsonConverter(typeof(ExpandableFieldConverter<PhysicalBundle>))]
        internal ExpandableField<PhysicalBundle> InternalPhysicalBundle { get; set; }
        #endregion

        [JsonProperty("preferences")]
        public PersonalizationDesignPreferences Preferences { get; set; }

        [JsonProperty("rejection_reasons")]
        public PersonalizationDesignRejectionReasons RejectionReasons { get; set; }

        /// <summary>
        /// Whether this personalization design can be used to create cards.
        /// One of: <c>active</c>, <c>inactive</c>, <c>rejected</c>, or <c>review</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
