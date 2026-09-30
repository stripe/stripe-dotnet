// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePauseSchedulePauseSettingsBillForOptions : INestedOptions
    {
        /// <summary>
        /// Controls whether to collect metered usage accrued up to the pause date.
        /// </summary>
        [JsonProperty("outstanding_usage_through")]
        [STJS.JsonPropertyName("outstanding_usage_through")]
        public SubscriptionSchedulePauseSchedulePauseSettingsBillForOutstandingUsageThroughOptions OutstandingUsageThrough { get; set; }

        /// <summary>
        /// Controls how unused time on subscription items is credited when pausing.
        /// </summary>
        [JsonProperty("unused_time_from")]
        [STJS.JsonPropertyName("unused_time_from")]
        public SubscriptionSchedulePauseSchedulePauseSettingsBillForUnusedTimeFromOptions UnusedTimeFrom { get; set; }
    }
}
