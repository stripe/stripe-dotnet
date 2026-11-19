// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// Apply all term actions atomically.
        /// </summary>
        [JsonProperty("actions")]
        [STJS.JsonPropertyName("actions")]
        public List<ContractUpdateActionOptions> Actions { get; set; }

        /// <summary>
        /// The billing settings to update on the contract.
        /// </summary>
        [JsonProperty("billing_settings")]
        [STJS.JsonPropertyName("billing_settings")]
        public ContractUpdateBillingSettingsOptions BillingSettings { get; set; }

        /// <summary>
        /// The unique user-provided contract number. This can only be changed while the contract is
        /// in draft.
        /// </summary>
        [JsonProperty("contract_number")]
        [STJS.JsonPropertyName("contract_number")]
        public string ContractNumber { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>billing_settings</c>, <c>one_time_fees</c>, <c>pricing_lines</c>,
        /// <c>pricing_overrides</c>, or <c>terms</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Set of key-value pairs.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        [STJS.JsonConverter(typeof(STJNullPreservingDictionaryConverter))]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }
    }
}
