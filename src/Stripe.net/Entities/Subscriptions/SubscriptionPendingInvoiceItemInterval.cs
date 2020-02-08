namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionPendingInvoiceItemInterval : StripeEntity<SubscriptionPendingInvoiceItemInterval>
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public long IntervalCount { get; set; }
    }
}
