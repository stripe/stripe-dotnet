// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewSubscriptionSchedulePauseSchedulePauseSettingsBillFor : StripeEntity<QuotePreviewSubscriptionSchedulePauseSchedulePauseSettingsBillFor>
    {
        [JsonProperty("outstanding_usage_through")]
        [STJS.JsonPropertyName("outstanding_usage_through")]
        public QuotePreviewSubscriptionSchedulePauseSchedulePauseSettingsBillForOutstandingUsageThrough OutstandingUsageThrough { get; set; }

        [JsonProperty("unused_time_from")]
        [STJS.JsonPropertyName("unused_time_from")]
        public QuotePreviewSubscriptionSchedulePauseSchedulePauseSettingsBillForUnusedTimeFrom UnusedTimeFrom { get; set; }
    }
}
