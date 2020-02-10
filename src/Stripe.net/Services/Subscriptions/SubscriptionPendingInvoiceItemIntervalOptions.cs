namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionPendingInvoiceItemIntervalOptions : INestedOptions
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
