// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TaxRateListOptions : ListOptions
    {
        /// <summary>
        /// Optional flag to filter by tax rates that are either active or inactive (archived).
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Optional range for filtering created date.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Optional flag to filter by tax rates that are inclusive (or those that are not
        /// inclusive).
        /// </summary>
        [JsonProperty("inclusive")]
        [STJS.JsonPropertyName("inclusive")]
        public bool? Inclusive { get; set; }
    }
}
