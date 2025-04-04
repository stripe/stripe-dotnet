// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ValueListListOptions : ListOptions
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

        /// <summary>
        /// Only return value lists that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }
    }
}
