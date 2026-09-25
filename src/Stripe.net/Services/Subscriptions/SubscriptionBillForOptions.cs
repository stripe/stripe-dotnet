// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionBillForOptions : INestedOptions
    {
        /// <summary>
        /// Controls when to bill for metered usage in the current period. Defaults to <c>{ type:
        /// "now" }</c>.
        /// </summary>
        [JsonProperty("outstanding_usage_through")]
        [STJS.JsonPropertyName("outstanding_usage_through")]
        public SubscriptionBillForOutstandingUsageThroughOptions OutstandingUsageThrough { get; set; }

        /// <summary>
        /// Controls when to credit for unused time on licensed items. Defaults to <c>{ type: "now"
        /// }</c>.
        /// </summary>
        [JsonProperty("unused_time_from")]
        [STJS.JsonPropertyName("unused_time_from")]
        public SubscriptionBillForUnusedTimeFromOptions UnusedTimeFrom { get; set; }
    }
}
