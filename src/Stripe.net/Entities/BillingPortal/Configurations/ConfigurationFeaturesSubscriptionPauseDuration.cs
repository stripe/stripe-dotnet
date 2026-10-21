// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationFeaturesSubscriptionPauseDuration : StripeEntity<ConfigurationFeaturesSubscriptionPauseDuration>
    {
        /// <summary>
        /// The preset pause durations customers can choose from.
        /// </summary>
        [JsonProperty("interval_options")]
        [STJS.JsonPropertyName("interval_options")]
        public List<ConfigurationFeaturesSubscriptionPauseDurationIntervalOption> IntervalOptions { get; set; }

        /// <summary>
        /// Whether subscriptions can be paused indefinitely or for a preset duration.
        /// One of: <c>indefinite</c>, or <c>interval_options</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
