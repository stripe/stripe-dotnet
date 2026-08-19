// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingLinesDataPricingPriceDetailsPricingOverridesData : StripeEntity<ContractPricingLinesDataPricingPriceDetailsPricingOverridesData>, IHasId, IHasMetadata
    {
        /// <summary>
        /// Timestamp when this override ends.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractPricingLinesDataPricingPriceDetailsPricingOverridesDataEndsAt EndsAt { get; set; }

        /// <summary>
        /// The ID of the pricing override.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The user-provided lookup key for this override.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of key-value pairs.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Details for an overwrite_price override.
        /// </summary>
        [JsonProperty("overwrite_price")]
        [STJS.JsonPropertyName("overwrite_price")]
        public ContractPricingLinesDataPricingPriceDetailsPricingOverridesDataOverwritePrice OverwritePrice { get; set; }

        /// <summary>
        /// The priority of this override relative to others. Lower number = higher priority.
        /// </summary>
        [JsonProperty("priority")]
        [STJS.JsonPropertyName("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// Timestamp when this override starts.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractPricingLinesDataPricingPriceDetailsPricingOverridesDataStartsAt StartsAt { get; set; }

        /// <summary>
        /// The type of override.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
