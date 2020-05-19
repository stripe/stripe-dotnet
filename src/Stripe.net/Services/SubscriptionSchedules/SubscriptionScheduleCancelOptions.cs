namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleCancelOptions : BaseOptions
    {
        [JsonProperty("invoice_now")]
        public bool? InvoiceNow { get; set; }

        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }
    }
}
