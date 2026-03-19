// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionProcessPaymentIntentProcessConfig : StripeEntity<ReaderActionProcessPaymentIntentProcessConfig>
    {
        /// <summary>
        /// Enable customer-initiated cancellation when processing this payment.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
        [STJS.JsonPropertyName("enable_customer_cancellation")]
        public bool EnableCustomerCancellation { get; set; }

        /// <summary>
        /// If the customer doesn't abandon authenticating the payment, they're redirected to this
        /// URL after completion.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Override showing a tipping selection screen on this transaction.
        /// </summary>
        [JsonProperty("skip_tipping")]
        [STJS.JsonPropertyName("skip_tipping")]
        public bool SkipTipping { get; set; }

        /// <summary>
        /// Represents a per-transaction tipping configuration.
        /// </summary>
        [JsonProperty("tipping")]
        [STJS.JsonPropertyName("tipping")]
        public ReaderActionProcessPaymentIntentProcessConfigTipping Tipping { get; set; }
    }
}
