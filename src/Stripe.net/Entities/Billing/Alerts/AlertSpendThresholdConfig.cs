// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class AlertSpendThresholdConfig : StripeEntity<AlertSpendThresholdConfig>
    {
        /// <summary>
        /// Defines if the alert will fire on spend aggregated across a subscription, or on
        /// individual subscription items.
        /// One of: <c>subscription</c>, or <c>subscription_item</c>.
        /// </summary>
        [JsonProperty("aggregation")]
        public string Aggregation { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The value at which this alert will trigger.
        /// </summary>
        [JsonProperty("gte")]
        public long Gte { get; set; }

        /// <summary>
        /// Defines how the alert will behave.
        /// </summary>
        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }
    }
}
