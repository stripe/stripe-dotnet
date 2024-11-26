// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionBillingCycleAnchorConfig : StripeEntity<SubscriptionBillingCycleAnchorConfig>
    {
        /// <summary>
        /// The day of the month of the billing_cycle_anchor.
        /// </summary>
        [JsonProperty("day_of_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("day_of_month")]
#endif
        public long DayOfMonth { get; set; }

        /// <summary>
        /// The hour of the day of the billing_cycle_anchor.
        /// </summary>
        [JsonProperty("hour")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hour")]
#endif
        public long? Hour { get; set; }

        /// <summary>
        /// The minute of the hour of the billing_cycle_anchor.
        /// </summary>
        [JsonProperty("minute")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minute")]
#endif
        public long? Minute { get; set; }

        /// <summary>
        /// The month to start full cycle billing periods.
        /// </summary>
        [JsonProperty("month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("month")]
#endif
        public long? Month { get; set; }

        /// <summary>
        /// The second of the minute of the billing_cycle_anchor.
        /// </summary>
        [JsonProperty("second")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("second")]
#endif
        public long? Second { get; set; }
    }
}
