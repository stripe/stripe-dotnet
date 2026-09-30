// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePauseSchedulePauseSettingsBillFor : StripeEntity<SubscriptionSchedulePauseSchedulePauseSettingsBillFor>
    {
        [JsonProperty("outstanding_usage_through")]
        [STJS.JsonPropertyName("outstanding_usage_through")]
        public SubscriptionSchedulePauseSchedulePauseSettingsBillForOutstandingUsageThrough OutstandingUsageThrough { get; set; }

        [JsonProperty("unused_time_from")]
        [STJS.JsonPropertyName("unused_time_from")]
        public SubscriptionSchedulePauseSchedulePauseSettingsBillForUnusedTimeFrom UnusedTimeFrom { get; set; }
    }
}
