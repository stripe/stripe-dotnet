// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionUpdateTermOptions : INestedOptions, IHasMetadata, IHasSetTracking
    {
        private Dictionary<string, string> metadata;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Must match the existing term's type.
        /// </summary>
        [JsonProperty("ad_hoc_product")]
        [STJS.JsonPropertyName("ad_hoc_product")]
        public ContractUpdateActionUpdateTermAdHocProductOptions AdHocProduct { get; set; }

        /// <summary>
        /// Metadata changes to apply immediately.
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
        /// Only validity dates can change; pricing, criteria, and priority are immutable.
        /// </summary>
        [JsonProperty("pricing_override")]
        [STJS.JsonPropertyName("pricing_override")]
        public ContractUpdateActionUpdateTermPricingOverrideOptions PricingOverride { get; set; }

        /// <summary>
        /// Must match the existing term's type.
        /// </summary>
        [JsonProperty("recurring_price")]
        [STJS.JsonPropertyName("recurring_price")]
        public ContractUpdateActionUpdateTermRecurringPriceOptions RecurringPrice { get; set; }

        /// <summary>
        /// Select a term by ID or its unique lookup key.
        /// </summary>
        [JsonProperty("term")]
        [STJS.JsonPropertyName("term")]
        public ContractUpdateActionUpdateTermTermOptions Term { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
