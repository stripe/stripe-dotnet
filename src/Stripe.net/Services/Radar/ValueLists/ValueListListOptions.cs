// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ValueListListOptions : ListOptions
    {
        /// <summary>
        /// The alias used to reference the value list when writing rules.
        /// </summary>
        [JsonProperty("alias")]
        [STJS.JsonPropertyName("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// A value contained within a value list - returns all value lists containing this value.
        /// </summary>
        [JsonProperty("contains")]
        [STJS.JsonPropertyName("contains")]
        public string Contains { get; set; }

        /// <summary>
        /// Only return value lists that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }
    }
}
