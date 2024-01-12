// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionBillingCycleAnchorConfig : StripeEntity<SubscriptionBillingCycleAnchorConfig>
    {
        /// <summary>
        /// The day of the month of the billing_cycle_anchor.
        /// </summary>
        [JsonProperty("day_of_month")]
        public long DayOfMonth { get; set; }

        /// <summary>
        /// The hour of the day of the billing_cycle_anchor.
        /// </summary>
        [JsonProperty("hour")]
        public long? Hour { get; set; }

        /// <summary>
        /// The minute of the hour of the billing_cycle_anchor.
        /// </summary>
        [JsonProperty("minute")]
        public long? Minute { get; set; }

        /// <summary>
        /// The month to start full cycle billing periods.
        /// </summary>
        [JsonProperty("month")]
        public long? Month { get; set; }

        /// <summary>
        /// The second of the minute of the billing_cycle_anchor.
        /// </summary>
        [JsonProperty("second")]
        public long? Second { get; set; }
    }
}
