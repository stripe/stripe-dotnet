// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreatePricingOverrideOptions : INestedOptions
    {
        /// <summary>
        /// When the pricing override ends.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractCreatePricingOverrideEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// A user-provided lookup key to reference this pricing override.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Parameters for a multiplier override. Required if <c>type</c> is <c>multiplier</c>.
        /// </summary>
        [JsonProperty("multiplier")]
        [STJS.JsonPropertyName("multiplier")]
        public ContractCreatePricingOverrideMultiplierOptions Multiplier { get; set; }

        /// <summary>
        /// The priority of this override relative to others. The highest priority is 0 and the
        /// lowest is 100.
        /// </summary>
        [JsonProperty("priority")]
        [STJS.JsonPropertyName("priority")]
        public long? Priority { get; set; }

        /// <summary>
        /// When the pricing override starts.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractCreatePricingOverrideStartsAtOptions StartsAt { get; set; }

        /// <summary>
        /// The type of pricing override.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
