namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleCancelOptions : BaseOptions
    {
        /// <summary>
        /// Will generate a final invoice that invoices for any un-invoiced metered usage and new/pending proration invoice items.
        /// </summary>
        [JsonProperty("invoice_now")]
        public bool? InvoiceNow { get; set; }

        /// <summary>
        /// If the subscription schedule is <code>active</code>, indicates if the cancellation
        /// should be prorated. Defaults to <code>true</code>.
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }
    }
}
