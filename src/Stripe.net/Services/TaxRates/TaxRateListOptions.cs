namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class TaxRateListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Optional flag to filter by tax rates that are either active or not active (archived).
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Optional flag to filter by tax rates that are inclusive or not.
        /// </summary>
        [JsonProperty("inclusive")]
        public bool? Inclusive { get; set; }

        /// <summary>
        /// A filter on the list based on the object percentage field.
        /// </summary>
        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// A filter on the list based on the object percentage field.
        /// </summary>
        [JsonProperty("percentage")]
        public TaxRatePercentageRangeOptions PercentageRange { get; set; }
    }
}
