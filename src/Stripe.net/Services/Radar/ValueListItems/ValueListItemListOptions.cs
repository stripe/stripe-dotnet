// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ValueListItemListOptions : ListOptionsWithCreated
    {
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Return items belonging to the parent list whose value matches the specified value (using
        /// an "is like" match).
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Identifier for the parent value list this item belongs to.
        /// </summary>
        [JsonProperty("value_list")]
        public string ValueList { get; set; }
    }
}
