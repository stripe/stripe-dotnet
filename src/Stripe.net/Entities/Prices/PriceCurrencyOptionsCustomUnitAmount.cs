// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PriceCurrencyOptionsCustomUnitAmount : StripeEntity<PriceCurrencyOptionsCustomUnitAmount>
    {
        /// <summary>
        /// The maximum unit amount the customer can specify for this item.
        /// </summary>
        [JsonProperty("maximum")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum")]
#endif

        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum unit amount the customer can specify for this item. Must be at least the
        /// minimum charge amount.
        /// </summary>
        [JsonProperty("minimum")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum")]
#endif

        public long? Minimum { get; set; }

        /// <summary>
        /// The starting unit amount which can be updated by the customer.
        /// </summary>
        [JsonProperty("preset")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preset")]
#endif

        public long? Preset { get; set; }
    }
}
