namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleReleaseOptions : BaseOptions
    {
        /// <summary>
        /// Keep any cancellation on the subscription that the schedule has set.
        /// </summary>
        [JsonProperty("preserve_cancel_date")]
        public bool? PreserveCancelDate { get; set; }
    }
}
