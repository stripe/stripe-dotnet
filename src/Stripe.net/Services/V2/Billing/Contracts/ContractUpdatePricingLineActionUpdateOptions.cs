// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionUpdateOptions : INestedOptions, IHasId, IHasMetadata, IHasSetTracking
    {
        private Dictionary<string, string> metadata;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Updated end time.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractUpdatePricingLineActionUpdateEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// The id of the pricing line.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Metadata mutations to apply to the pricing line.
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
        /// Updated pricing configuration.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public ContractUpdatePricingLineActionUpdatePricingOptions Pricing { get; set; }

        /// <summary>
        /// Updated start time.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractUpdatePricingLineActionUpdateStartsAtOptions StartsAt { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
