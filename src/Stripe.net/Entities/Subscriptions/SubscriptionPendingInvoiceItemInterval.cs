namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionPendingInvoiceItemInterval : StripeEntity<SubscriptionPendingInvoiceItemInterval>
    {
        /// <summary>
        /// Specifies invoicing frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or
        /// <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals between invoices.
        /// </summary>
        [JsonProperty("interval_count")]
        public long IntervalCount { get; set; }
    }
}
