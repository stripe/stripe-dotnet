// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A Location represents a grouping of readers.
    ///
    /// Related guide: <a href="https://docs.stripe.com/terminal/fleet/locations">Fleet
    /// management</a>.
    /// </summary>
    public class Location : StripeEntity<Location>, IHasId, IHasMetadata, IHasObject
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

        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public Address Address { get; set; }

        [JsonProperty("address_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kana")]
#endif
        public LocationAddressKana AddressKana { get; set; }

        [JsonProperty("address_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kanji")]
#endif
        public LocationAddressKanji AddressKanji { get; set; }

        /// <summary>
        /// The ID of a configuration that will be used to customize all readers in this location.
        /// </summary>
        [JsonProperty("configuration_overrides")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configuration_overrides")]
#endif
        public string ConfigurationOverrides { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif
        public bool? Deleted { get; set; }

        /// <summary>
        /// The display name of the location.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// The Kana variation of the display name of the location.
        /// </summary>
        [JsonProperty("display_name_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name_kana")]
#endif
        public string DisplayNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the display name of the location.
        /// </summary>
        [JsonProperty("display_name_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name_kanji")]
#endif
        public string DisplayNameKanji { get; set; }

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
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The phone number of the location.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }
    }
}
