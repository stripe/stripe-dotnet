// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxRateListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Optional flag to filter by tax rates that are either active or inactive (archived).
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Optional flag to filter by tax rates that are inclusive (or those that are not
        /// inclusive).
        /// </summary>
        [JsonProperty("inclusive")]
        public bool? Inclusive { get; set; }
    }
}
