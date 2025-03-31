// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TaxRateListOptions : ListOptions
    {
        /// <summary>
        /// Optional flag to filter by tax rates that are either active or inactive (archived).
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool? Active { get; set; }

        /// <summary>
        /// Optional range for filtering created date.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Optional flag to filter by tax rates that are inclusive (or those that are not
        /// inclusive).
        /// </summary>
        [JsonProperty("inclusive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inclusive")]
#endif
        public bool? Inclusive { get; set; }
    }
}
