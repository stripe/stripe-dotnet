namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleInvoiceSettingsOptions : INestedOptions
    {
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
