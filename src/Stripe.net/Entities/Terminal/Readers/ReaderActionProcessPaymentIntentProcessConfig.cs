// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionProcessPaymentIntentProcessConfig : StripeEntity<ReaderActionProcessPaymentIntentProcessConfig>
    {
        /// <summary>
        /// Enable customer initiated cancellation when processing this payment.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enable_customer_cancellation")]
#endif
        public bool EnableCustomerCancellation { get; set; }

        /// <summary>
        /// If the customer does not abandon authenticating the payment, they will be redirected to
        /// this specified URL after completion.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Override showing a tipping selection screen on this transaction.
        /// </summary>
        [JsonProperty("skip_tipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("skip_tipping")]
#endif
        public bool SkipTipping { get; set; }

        /// <summary>
        /// Represents a per-transaction tipping configuration.
        /// </summary>
        [JsonProperty("tipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tipping")]
#endif
        public ReaderActionProcessPaymentIntentProcessConfigTipping Tipping { get; set; }
    }
}
