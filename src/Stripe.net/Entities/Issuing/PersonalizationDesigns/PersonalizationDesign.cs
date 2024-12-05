// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A Personalization Design is a logical grouping of a Physical Bundle, card logo, and
    /// carrier text that represents a product line.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class PersonalizationDesign : StripeEntity<PersonalizationDesign>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        #region Expandable CardLogo

        /// <summary>
        /// (ID of the File)
        /// The file for the card logo to use with physical bundles that support card logos. Must
        /// have a <c>purpose</c> value of <c>issuing_logo</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public File CardLogo
        {
            get => this.InternalCardLogo?.ExpandedObject;
            set => this.InternalCardLogo = SetExpandableFieldObject(value, this.InternalCardLogo);
        }

        [JsonProperty("card_logo")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_logo")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
#endif
        internal ExpandableField<File> InternalCardLogo { get; set; }
        #endregion

        /// <summary>
        /// Hash containing carrier text, for use with physical bundles that support carrier text.
        /// </summary>
        [JsonProperty("carrier_text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier_text")]
#endif
        public PersonalizationDesignCarrierText CarrierText { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// A lookup key used to retrieve personalization designs dynamically from a static string.
        /// This may be up to 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Friendly display name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        #region Expandable PhysicalBundle

        /// <summary>
        /// (ID of the PhysicalBundle)
        /// The physical bundle object belonging to this personalization design.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PhysicalBundle PhysicalBundle
        {
            get => this.InternalPhysicalBundle?.ExpandedObject;
            set => this.InternalPhysicalBundle = SetExpandableFieldObject(value, this.InternalPhysicalBundle);
        }

        [JsonProperty("physical_bundle")]
        [JsonConverter(typeof(ExpandableFieldConverter<PhysicalBundle>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("physical_bundle")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PhysicalBundle>))]
#endif
        internal ExpandableField<PhysicalBundle> InternalPhysicalBundle { get; set; }
        #endregion

        [JsonProperty("preferences")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferences")]
#endif
        public PersonalizationDesignPreferences Preferences { get; set; }

        [JsonProperty("rejection_reasons")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rejection_reasons")]
#endif
        public PersonalizationDesignRejectionReasons RejectionReasons { get; set; }

        /// <summary>
        /// Whether this personalization design can be used to create cards.
        /// One of: <c>active</c>, <c>inactive</c>, <c>rejected</c>, or <c>review</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
