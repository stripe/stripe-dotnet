// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PriceCurrencyOptionsIskCustomUnitAmount : StripeEntity<PriceCurrencyOptionsIskCustomUnitAmount>
    {
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
