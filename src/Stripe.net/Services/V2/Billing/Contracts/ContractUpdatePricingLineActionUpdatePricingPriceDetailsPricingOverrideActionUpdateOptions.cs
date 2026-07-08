// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionUpdateOptions : INestedOptions, IHasId, IHasMetadata
    {
        /// <summary>
        /// Updated end time.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionUpdateEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// The id of the pricing override to update.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Updated lookup key.
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
        /// Updated start time.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionUpdateStartsAtOptions StartsAt { get; set; }
    }
}
