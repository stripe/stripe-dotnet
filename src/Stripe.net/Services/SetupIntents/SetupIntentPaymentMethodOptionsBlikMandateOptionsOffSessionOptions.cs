// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsBlikMandateOptionsOffSessionOptions : INestedOptions
    {
        /// <summary>
        /// Amount of the recurring payments.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three letter ISO Currency-code. <c>PLN</c> only.
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
