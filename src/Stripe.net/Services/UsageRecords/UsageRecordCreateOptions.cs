namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class UsageRecordCreateOptions : BaseOptions
    {
        [FormProperty("action")]
        public string Action { get; set; }

        [FormProperty("-")]
        public string SubscriptionItem { get; set; }

        [FormProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        [FormProperty("quantity")]
        public int? Quantity { get; set; }
    }
}
