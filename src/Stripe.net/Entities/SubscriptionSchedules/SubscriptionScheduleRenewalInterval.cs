namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionScheduleRenewalInterval : StripeEntity<SubscriptionScheduleRenewalInterval>
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("length")]
        public long Length { get; set; }
    }
}
