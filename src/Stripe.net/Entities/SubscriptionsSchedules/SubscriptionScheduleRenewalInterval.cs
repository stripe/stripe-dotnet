namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionScheduleRenewalInterval : StripeEntity<SubscriptionScheduleRenewalInterval>
    {
        /// <summary>
        /// Interval at which to renew the subscription schedule for when it ends.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Number of intervals to renew the subscription schedule for when it ends.
        /// </summary>
        [JsonProperty("length")]
        public long Length { get; set; }
    }
}
