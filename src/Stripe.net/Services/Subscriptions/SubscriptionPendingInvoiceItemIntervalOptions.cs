namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionPendingInvoiceItemIntervalOptions : INestedOptions
    {
        /// <summary>
        /// Specifies invoicing frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or
        /// <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals between invoices. For example, <c>interval=month</c> and
        /// <c>interval_count=3</c> bills every 3 months. Maximum of one year interval allowed (1
        /// year, 12 months, or 52 weeks).
        /// </summary>
        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
