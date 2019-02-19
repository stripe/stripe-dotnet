namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleRenewalIntervalOptions : INestedOptions
    {
        /// <summary>
        /// Interval at which to renew the subscription schedule for when it ends. Possible values
        /// are <code>day</code>, <code>week</code>, <code>month</code>, or <code>year</code>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Number of intervals to renew the subscription schedule for when it ends.
        /// </summary>
        [JsonProperty("length")]
        public long? Length { get; set; }
    }
}
