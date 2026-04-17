// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleAmendmentMetadataActionOptions : INestedOptions, IHasSetTracking
    {
        private Dictionary<string, string> set;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Key-value pairs to add to schedule phase metadata. These values will merge with existing
        /// schedule phase metadata.
        /// </summary>
        [JsonProperty("add")]
        [STJS.JsonPropertyName("add")]
        public Dictionary<string, string> Add { get; set; }

        /// <summary>
        /// Keys to remove from schedule phase metadata.
        /// </summary>
        [JsonProperty("remove")]
        [STJS.JsonPropertyName("remove")]
        public List<string> Remove { get; set; }

        /// <summary>
        /// Key-value pairs to set as schedule phase metadata. Existing schedule phase metadata will
        /// be overwritten.
        /// </summary>
        [JsonProperty("set", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("set")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Set
        {
            get => this.set;
            set
            {
                this.set = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Select one of three ways to update phase-level <c>metadata</c> on subscription
        /// schedules.
        /// One of: <c>add</c>, <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
