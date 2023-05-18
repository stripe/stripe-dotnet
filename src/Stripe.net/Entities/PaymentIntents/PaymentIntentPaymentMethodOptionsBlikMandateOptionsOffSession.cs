// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsBlikMandateOptionsOffSession : StripeEntity<PaymentIntentPaymentMethodOptionsBlikMandateOptionsOffSession>
    {
        /// <summary>
        /// Amount of each recurring payment.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Currency of each recurring payment.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

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
