// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationFeaturesSubscriptionPauseDurationOptions : INestedOptions, IHasSetTracking
    {
        private List<ConfigurationFeaturesSubscriptionPauseDurationIntervalOptionOptions> intervalOptions;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The preset pause durations customers can choose from. Required when <c>type</c> is
        /// <c>interval_options</c>.
        /// </summary>
        [JsonProperty("interval_options", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("interval_options")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<ConfigurationFeaturesSubscriptionPauseDurationIntervalOptionOptions> IntervalOptions
        {
            get => this.intervalOptions;
            set
            {
                this.intervalOptions = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Whether subscriptions can be paused indefinitely or for a preset duration.
        /// One of: <c>indefinite</c>, or <c>interval_options</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
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
