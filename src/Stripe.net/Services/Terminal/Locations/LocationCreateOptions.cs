// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class LocationCreateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// The full address of the location.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The Kana variation of the full address of the location (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
        [STJS.JsonPropertyName("address_kana")]
        public AddressJapanOptions AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the full address of the location (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
        [STJS.JsonPropertyName("address_kanji")]
        public AddressJapanOptions AddressKanji { get; set; }

        /// <summary>
        /// The ID of a configuration that will be used to customize all readers in this location.
        /// </summary>
        [JsonProperty("configuration_overrides")]
        [STJS.JsonPropertyName("configuration_overrides")]
        public string ConfigurationOverrides { get; set; }

        /// <summary>
        /// A name for the location. Maximum length is 1000 characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The Kana variation of the name for the location (Japan only). Maximum length is 1000
        /// characters.
        /// </summary>
        [JsonProperty("display_name_kana")]
        [STJS.JsonPropertyName("display_name_kana")]
        public string DisplayNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the name for the location (Japan only). Maximum length is 1000
        /// characters.
        /// </summary>
        [JsonProperty("display_name_kanji")]
        [STJS.JsonPropertyName("display_name_kanji")]
        public string DisplayNameKanji { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The phone number for the location.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
