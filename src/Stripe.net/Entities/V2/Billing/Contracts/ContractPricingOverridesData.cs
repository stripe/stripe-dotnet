// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingOverridesData : StripeEntity<ContractPricingOverridesData>, IHasId
    {
        /// <summary>
        /// Resolved timestamp when the pricing override ends.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractPricingOverridesDataEndsAt EndsAt { get; set; }

        /// <summary>
        /// The ID of the pricing override.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The user-provided lookup key for the pricing override.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Details for a multiplier override.
        /// </summary>
        [JsonProperty("multiplier")]
        [STJS.JsonPropertyName("multiplier")]
        public ContractPricingOverridesDataMultiplier Multiplier { get; set; }

        /// <summary>
        /// The priority of this override relative to others. Lower number = higher priority.
        /// </summary>
        [JsonProperty("priority")]
        [STJS.JsonPropertyName("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// Resolved timestamp when the pricing override starts.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractPricingOverridesDataStartsAt StartsAt { get; set; }

        /// <summary>
        /// The type of pricing override.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
