// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionProcessPaymentIntentProcessConfig : StripeEntity<ReaderActionProcessPaymentIntentProcessConfig>
    {
        /// <summary>
        /// Enable customer initiated cancellation when processing this payment.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
        public bool EnableCustomerCancellation { get; set; }

        /// <summary>
        /// Override showing a tipping selection screen on this transaction.
        /// </summary>
        [JsonProperty("skip_tipping")]
        public bool SkipTipping { get; set; }

        /// <summary>
        /// Represents a per-transaction tipping configuration.
        /// </summary>
        [JsonProperty("tipping")]
        public ReaderActionProcessPaymentIntentProcessConfigTipping Tipping { get; set; }
    }
}
