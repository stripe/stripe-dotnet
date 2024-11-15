// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ValueListListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// The alias used to reference the value list when writing rules.
        /// </summary>
        [JsonProperty("alias")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alias")]
#endif

        public string Alias { get; set; }

        /// <summary>
        /// A value contained within a value list - returns all value lists containing this value.
        /// </summary>
        [JsonProperty("contains")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("contains")]
#endif

        public string Contains { get; set; }
    }
}
