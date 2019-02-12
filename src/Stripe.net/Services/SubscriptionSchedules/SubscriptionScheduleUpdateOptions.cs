namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleUpdateOptions : SubscriptionScheduleSharedOptions
    {
        /// <summary>
        /// If the update changes the current phase, indicates if the changes should be prorated.
        /// Defaults to <code>true</code>.
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }
    }
}
