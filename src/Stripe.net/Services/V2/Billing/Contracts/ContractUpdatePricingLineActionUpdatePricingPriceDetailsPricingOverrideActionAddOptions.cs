// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The end time for the override.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// A lookup key for the override.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Metadata for the pricing override.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Parameters for an overwrite_price override. Required if <c>type</c> is
        /// <c>overwrite_price</c>.
        /// </summary>
        [JsonProperty("overwrite_price")]
        [STJS.JsonPropertyName("overwrite_price")]
        public ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddOverwritePriceOptions OverwritePrice { get; set; }

        /// <summary>
        /// The priority of this override relative to others. 0 is highest, 100 is lowest. Defaults
        /// to 50.
        /// </summary>
        [JsonProperty("priority")]
        [STJS.JsonPropertyName("priority")]
        public long? Priority { get; set; }

        /// <summary>
        /// The start time for the override.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddStartsAtOptions StartsAt { get; set; }

        /// <summary>
        /// The type of override to add.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
