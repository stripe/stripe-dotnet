namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionCancelOptions : BaseOptions
    {
        /// <summary>
        /// Will generate a final invoice that invoices for any un-invoiced metered usage and new/pending proration invoice items.
        /// </summary>
        [JsonProperty("invoice_now")]
        public bool? InvoiceNow { get; set; }

        /// <summary>
        /// Boolean (default <c>true</c>). Use with a <c>billing_cycle_anchor</c> timestamp to determine whether the customer will be invoiced a prorated amount until the anchor date. If <c>false</c>, the anchor period will be free (similar to a trial).
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }
    }
}
