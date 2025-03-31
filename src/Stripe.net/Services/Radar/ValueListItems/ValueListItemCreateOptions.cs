// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ValueListItemCreateOptions : BaseOptions
    {
        /// <summary>
        /// The value of the item (whose type must match the type of the parent value list).
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }

        /// <summary>
        /// The identifier of the value list which the created item will be added to.
        /// </summary>
        [JsonProperty("value_list")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value_list")]
#endif
        public string ValueList { get; set; }
    }
}
