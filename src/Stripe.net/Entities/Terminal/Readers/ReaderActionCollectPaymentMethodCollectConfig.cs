// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionCollectPaymentMethodCollectConfig : StripeEntity<ReaderActionCollectPaymentMethodCollectConfig>
    {
        /// <summary>
        /// Enable customer-initiated cancellation when processing this payment.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enable_customer_cancellation")]
#endif
        public bool EnableCustomerCancellation { get; set; }

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
        public ReaderActionCollectPaymentMethodCollectConfigTipping Tipping { get; set; }
    }
}
