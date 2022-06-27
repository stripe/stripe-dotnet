// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PriceCurrencyOptionsPgkCustomUnitAmountOptions : INestedOptions
    {
        /// <summary>
        /// Pass in <c>true</c> to enable <c>custom_unit_amount</c>, otherwise omit
        /// <c>custom_unit_amount</c>.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The maximum unit amount the customer can specify for this item.
        /// </summary>
        [JsonProperty("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum unit amount the customer can specify for this item. Must be at least the
        /// minimum charge amount.
        /// </summary>
        [JsonProperty("minimum")]
        public long? Minimum { get; set; }

        /// <summary>
        /// The starting unit amount which can be updated by the customer.
        /// </summary>
        [JsonProperty("preset")]
        public long? Preset { get; set; }
    }
}
