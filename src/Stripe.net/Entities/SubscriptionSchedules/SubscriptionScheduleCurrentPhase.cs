namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleCurrentPhase : StripeEntity<SubscriptionScheduleCurrentPhase>
    {
        [JsonProperty("end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EndDate { get; set; }

        [JsonProperty("start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? StartDate { get; set; }
    }
}
