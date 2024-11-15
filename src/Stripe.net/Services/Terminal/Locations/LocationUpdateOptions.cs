// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class LocationUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The full address of the location. If you're updating the <c>address</c> field, avoid
        /// changing the <c>country</c>. If you need to modify the <c>country</c> field, create a
        /// new <c>Location</c> object and re-register any existing readers to that location.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif

        public AddressOptions Address { get; set; }

        /// <summary>
        /// The ID of a configuration that will be used to customize all readers in this location.
        /// </summary>
        [JsonProperty("configuration_overrides")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configuration_overrides")]
#endif

        public string ConfigurationOverrides { get; set; }

        /// <summary>
        /// A name for the location.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif

        public string DisplayName { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }
    }
}
