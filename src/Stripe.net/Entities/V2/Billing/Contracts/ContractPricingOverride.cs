// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingOverride : StripeEntity<ContractPricingOverride>
    {
        /// <summary>
        /// Resolved timestamp when the pricing override ends.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractPricingOverrideEndsAt EndsAt { get; set; }

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
        public ContractPricingOverrideMultiplier Multiplier { get; set; }

        /// <summary>
        /// Details for an overwrite_price override.
        /// </summary>
        [JsonProperty("overwrite_price")]
        [STJS.JsonPropertyName("overwrite_price")]
        public ContractPricingOverrideOverwritePrice OverwritePrice { get; set; }

        /// <summary>
        /// The ID of the pricing override.
        /// </summary>
        [JsonProperty("pricing_override")]
        [STJS.JsonPropertyName("pricing_override")]
        public string PricingOverride { get; set; }

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
        public ContractPricingOverrideStartsAt StartsAt { get; set; }

        /// <summary>
        /// The type of pricing override.
        /// One of: <c>multiplier</c>, or <c>overwrite_price</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
