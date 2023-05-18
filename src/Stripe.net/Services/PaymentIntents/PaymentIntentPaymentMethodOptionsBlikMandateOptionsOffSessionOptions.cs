// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsBlikMandateOptionsOffSessionOptions : INestedOptions
    {
        /// <summary>
        /// Frequency interval of each recurring payment.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Frequency indicator of each recurring payment.
        /// </summary>
        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
