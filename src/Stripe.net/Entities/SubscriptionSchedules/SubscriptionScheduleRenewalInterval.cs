namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleRenewalInterval : StripeEntity<SubscriptionScheduleRenewalInterval>
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("length")]
        public long Length { get; set; }
    }
}
