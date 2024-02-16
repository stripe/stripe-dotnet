// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TaxRateListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Optional flag to filter by tax rates that are either active or inactive (archived).
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Optional range for filtering created date.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Optional flag to filter by tax rates that are inclusive (or those that are not
        /// inclusive).
        /// </summary>
        [JsonProperty("inclusive")]
        public bool? Inclusive { get; set; }
    }
}
