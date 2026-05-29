// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingLine : StripeEntity<ContractPricingLine>, IHasMetadata
    {
        /// <summary>
        /// Resolved timestamp when the pricing line ends.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractPricingLineEndsAt EndsAt { get; set; }

        /// <summary>
        /// The user-provided lookup key for the pricing line.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The pricing configuration for the pricing line.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public ContractPricingLinePricing Pricing { get; set; }

        /// <summary>
        /// The ID of the pricing line.
        /// </summary>
        [JsonProperty("pricing_line")]
        [STJS.JsonPropertyName("pricing_line")]
        public string PricingLine { get; set; }

        /// <summary>
        /// Resolved timestamp when the pricing line starts.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractPricingLineStartsAt StartsAt { get; set; }
    }
}
