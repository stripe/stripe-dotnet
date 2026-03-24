// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ValueListItemListOptions : ListOptions
    {
        /// <summary>
        /// Only return items that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Return items belonging to the parent list whose value matches the specified value (using
        /// an "is like" match).
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// Identifier for the parent value list this item belongs to.
        /// </summary>
        [JsonProperty("value_list")]
        [STJS.JsonPropertyName("value_list")]
        public string ValueList { get; set; }
    }
}
