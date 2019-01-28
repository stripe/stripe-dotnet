namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleInvoiceSettings : StripeEntity
    {
        /// <summary>
        /// The number of days from which the invoice is created until it is due.
        /// </summary>
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
