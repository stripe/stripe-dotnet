// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ValueListItemListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Return items belonging to the parent list whose value matches the specified value (using
        /// an "is like" match).
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }

        /// <summary>
        /// Identifier for the parent value list this item belongs to.
        /// </summary>
        [JsonProperty("value_list")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value_list")]
#endif
        public string ValueList { get; set; }
    }
}
