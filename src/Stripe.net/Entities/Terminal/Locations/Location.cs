// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Location represents a grouping of readers.
    ///
    /// Related guide: <a href="https://docs.stripe.com/terminal/fleet/locations">Fleet
    /// management</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Location : StripeEntity<Location>, IHasId, IHasMetadata, IHasObject
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

        [JsonProperty("address_kana")]
        [STJS.JsonPropertyName("address_kana")]
        public LocationAddressKana AddressKana { get; set; }

        [JsonProperty("address_kanji")]
        [STJS.JsonPropertyName("address_kanji")]
        public LocationAddressKanji AddressKanji { get; set; }

        /// <summary>
        /// The ID of a configuration that will be used to customize all readers in this location.
        /// </summary>
        [JsonProperty("configuration_overrides")]
        [STJS.JsonPropertyName("configuration_overrides")]
        public string ConfigurationOverrides { get; set; }

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
        /// The Kana variation of the display name of the location.
        /// </summary>
        [JsonProperty("display_name_kana")]
        [STJS.JsonPropertyName("display_name_kana")]
        public string DisplayNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the display name of the location.
        /// </summary>
        [JsonProperty("display_name_kanji")]
        [STJS.JsonPropertyName("display_name_kanji")]
        public string DisplayNameKanji { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The phone number of the location.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
