namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleCurrentPhase : StripeEntity
    {
        /// <summary>
        /// The end of the this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The start of this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? StartDate { get; set; }
    }
}
