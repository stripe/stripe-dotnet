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
        /// Additional fields to include in the response.
        /// One of: <c>billing_settings</c>, <c>one_time_fees</c>, <c>pricing_lines</c>, or
        /// <c>pricing_overrides</c>.
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

        /// <summary>
        /// Pricing line actions to apply.
        /// </summary>
        [JsonProperty("pricing_line_actions")]
        [STJS.JsonPropertyName("pricing_line_actions")]
        public List<ContractUpdatePricingLineActionOptions> PricingLineActions { get; set; }

        /// <summary>
        /// Pricing override actions to apply.
        /// </summary>
        [JsonProperty("pricing_override_actions")]
        [STJS.JsonPropertyName("pricing_override_actions")]
        public List<ContractUpdatePricingOverrideActionOptions> PricingOverrideActions { get; set; }
    }
}
