// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateContractLineOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// Timestamp to indicate when the contract line ends.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractCreateContractLineEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// List of overrides. Later overrides in the list override earlier ones.
        /// </summary>
        [JsonProperty("overrides")]
        [STJS.JsonPropertyName("overrides")]
        public List<ContractCreateContractLineOverrideOptions> Overrides { get; set; }

        /// <summary>
        /// The pricing configuration for the contract line.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public ContractCreateContractLinePricingOptions Pricing { get; set; }

        /// <summary>
        /// Timestamp to indicate when the contract line starts.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractCreateContractLineStartsAtOptions StartsAt { get; set; }
    }
}
