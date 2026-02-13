// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionBillForOptions : INestedOptions
    {
        /// <summary>
        /// Controls when to bill for metered usage in the current period. Defaults to <c>{ type:
        /// "now" }</c>.
        /// </summary>
        [JsonProperty("outstanding_usage_through")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outstanding_usage_through")]
#endif
        public SubscriptionBillForOutstandingUsageThroughOptions OutstandingUsageThrough { get; set; }

        /// <summary>
        /// Controls when to credit for unused time on licensed items. Defaults to <c>{ type: "now"
        /// }</c>.
        /// </summary>
        [JsonProperty("unused_time_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unused_time_from")]
#endif
        public SubscriptionBillForUnusedTimeFromOptions UnusedTimeFrom { get; set; }
    }
}
