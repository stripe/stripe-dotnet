// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderProcessConfigOptions : INestedOptions
    {
        /// <summary>
        /// This field indicates whether this payment method can be shown again to its customer in a
        /// checkout flow. Stripe products such as Checkout and Elements use this field to determine
        /// whether a payment method can be shown as a saved payment method in a checkout flow.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_redisplay")]
#endif

        public string AllowRedisplay { get; set; }

        /// <summary>
        /// Enables cancel button on transaction screens.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enable_customer_cancellation")]
#endif

        public bool? EnableCustomerCancellation { get; set; }

        /// <summary>
        /// Override showing a tipping selection screen on this transaction.
        /// </summary>
        [JsonProperty("skip_tipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("skip_tipping")]
#endif

        public bool? SkipTipping { get; set; }

        /// <summary>
        /// Tipping configuration for this transaction.
        /// </summary>
        [JsonProperty("tipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tipping")]
#endif

        public ReaderProcessConfigTippingOptions Tipping { get; set; }
    }
}
