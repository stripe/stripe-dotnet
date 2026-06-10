// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingOverrideActionAddOptions : INestedOptions
    {
        /// <summary>
        /// The end time for the pricing override.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractUpdatePricingOverrideActionAddEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// A lookup key for the pricing override.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// A multiplier override to add.
        /// </summary>
        [JsonProperty("multiplier")]
        [STJS.JsonPropertyName("multiplier")]
        public ContractUpdatePricingOverrideActionAddMultiplierOptions Multiplier { get; set; }

        /// <summary>
        /// An overwrite price override to add.
        /// </summary>
        [JsonProperty("overwrite_price")]
        [STJS.JsonPropertyName("overwrite_price")]
        public ContractUpdatePricingOverrideActionAddOverwritePriceOptions OverwritePrice { get; set; }

        /// <summary>
        /// The priority for the pricing override. The highest priority is 0 and the lowest is 100.
        /// </summary>
        [JsonProperty("priority")]
        [STJS.JsonPropertyName("priority")]
        public long? Priority { get; set; }

        /// <summary>
        /// The start time for the pricing override.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractUpdatePricingOverrideActionAddStartsAtOptions StartsAt { get; set; }

        /// <summary>
        /// The type of pricing override to add.
        /// One of: <c>multiplier</c>, or <c>overwrite_price</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
