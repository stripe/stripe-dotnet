namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleReleaseOptions : BaseOptions
    {
        [JsonProperty("preserve_cancel_date")]
        public bool? PreserveCancelDate { get; set; }
    }
}
