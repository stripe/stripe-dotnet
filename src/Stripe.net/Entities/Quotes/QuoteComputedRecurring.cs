// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteComputedRecurring : StripeEntity<QuoteComputedRecurring>
    {
        /// <summary>
        /// Total before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
        public long AmountTotal { get; set; }

        /// <summary>
        /// The frequency at which a subscription is billed. One of <c>day</c>, <c>week</c>,
        /// <c>month</c> or <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals (specified in the <c>interval</c> attribute) between
        /// subscription billings. For example, <c>interval=month</c> and <c>interval_count=3</c>
        /// bills every 3 months.
        /// </summary>
        [JsonProperty("interval_count")]
        public long IntervalCount { get; set; }

        [JsonProperty("total_details")]
        public QuoteComputedRecurringTotalDetails TotalDetails { get; set; }
    }
}
