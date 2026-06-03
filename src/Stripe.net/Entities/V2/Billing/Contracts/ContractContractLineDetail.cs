// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractContractLineDetail : StripeEntity<ContractContractLineDetail>, IHasMetadata
    {
        /// <summary>
        /// The ID of the contract line.
        /// </summary>
        [JsonProperty("contract_line")]
        [STJS.JsonPropertyName("contract_line")]
        public string ContractLine { get; set; }

        /// <summary>
        /// The computed value details for the contract line.
        /// </summary>
        [JsonProperty("contract_line_value_details")]
        [STJS.JsonPropertyName("contract_line_value_details")]
        public ContractContractLineDetailContractLineValueDetails ContractLineValueDetails { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp to indicate when the contract line ends.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractContractLineDetailEndsAt EndsAt { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// List of overrides applied to the contract line.
        /// </summary>
        [JsonProperty("overrides")]
        [STJS.JsonPropertyName("overrides")]
        public List<ContractContractLineDetailOverride> Overrides { get; set; }

        /// <summary>
        /// The pricing configuration for the contract line.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public ContractContractLineDetailPricing Pricing { get; set; }

        /// <summary>
        /// Timestamp to indicate when the contract line starts.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractContractLineDetailStartsAt StartsAt { get; set; }
    }
}
