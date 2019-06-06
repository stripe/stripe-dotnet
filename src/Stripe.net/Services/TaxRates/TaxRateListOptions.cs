namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

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
        /// A filter on the list based on the object <c>percentage</c> field. The value can be a
        /// <see cref="decimal"/> or a <see cref="TaxRatePercentageRangeOptions"/>.
        /// </summary>
        [JsonProperty("percentage")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<decimal?, TaxRatePercentageRangeOptions> Percentage { get; set; }
    }
}
