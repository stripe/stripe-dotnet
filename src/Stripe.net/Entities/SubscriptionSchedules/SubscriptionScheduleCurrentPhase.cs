namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleCurrentPhase : StripeEntity<SubscriptionScheduleCurrentPhase>
    {
        /// <summary>
        /// The end of this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The start of this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartDate { get; set; }
    }
}
