// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionBillingCycleAnchorConfigOptions : INestedOptions
    {
        /// <summary>
        /// The day of the month the billing_cycle_anchor should be. Ranges from 1 to 31.
        /// </summary>
        [JsonProperty("day_of_month")]
        public long? DayOfMonth { get; set; }

        /// <summary>
        /// The hour of the day the billing_cycle_anchor should be. Ranges from 0 to 23.
        /// </summary>
        [JsonProperty("hour")]
        public long? Hour { get; set; }

        /// <summary>
        /// The minute of the hour the billing_cycle_anchor should be. Ranges from 0 to 59.
        /// </summary>
        [JsonProperty("minute")]
        public long? Minute { get; set; }

        /// <summary>
        /// The month to start full cycle billing periods. Ranges from 1 to 12.
        /// </summary>
        [JsonProperty("month")]
        public long? Month { get; set; }

        /// <summary>
        /// The second of the minute the billing_cycle_anchor should be. Ranges from 0 to 59.
        /// </summary>
        [JsonProperty("second")]
        public long? Second { get; set; }
    }
}
