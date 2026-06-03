// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionAddOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The end time for the pricing line.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractUpdatePricingLineActionAddEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// A lookup key for the pricing line.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Metadata for the pricing line.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The pricing configuration for the pricing line.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public ContractUpdatePricingLineActionAddPricingOptions Pricing { get; set; }

        /// <summary>
        /// The start time for the pricing line.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractUpdatePricingLineActionAddStartsAtOptions StartsAt { get; set; }
    }
}
