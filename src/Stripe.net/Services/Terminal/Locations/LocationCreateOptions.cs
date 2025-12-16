// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class LocationCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The full address of the location.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The Kana variation of the full address of the location (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kana")]
#endif
        public AddressJapanOptions AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the full address of the location (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kanji")]
#endif
        public AddressJapanOptions AddressKanji { get; set; }

        /// <summary>
        /// The ID of a configuration that will be used to customize all readers in this location.
        /// </summary>
        [JsonProperty("configuration_overrides")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configuration_overrides")]
#endif
        public string ConfigurationOverrides { get; set; }

        /// <summary>
        /// A name for the location. Maximum length is 1000 characters.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// The Kana variation of the name for the location (Japan only). Maximum length is 1000
        /// characters.
        /// </summary>
        [JsonProperty("display_name_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name_kana")]
#endif
        public string DisplayNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the name for the location (Japan only). Maximum length is 1000
        /// characters.
        /// </summary>
        [JsonProperty("display_name_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name_kanji")]
#endif
        public string DisplayNameKanji { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The phone number for the location.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }
    }
}
