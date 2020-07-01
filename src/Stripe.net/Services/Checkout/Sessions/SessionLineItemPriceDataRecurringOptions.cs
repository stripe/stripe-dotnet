namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionLineItemPriceDataRecurringOptions : INestedOptions
    {
        /// <summary>
        /// he frequency at which a subscription is billed. One of <c>day</c>, <c>week</c>,
        /// <c>month</c> or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals (specified in the <see cref="Interval"/> property) between
        /// subscription billings.
        /// </summary>
        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
