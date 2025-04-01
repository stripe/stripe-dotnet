// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// ID of an existing PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If provided, this hash will be used to create a PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_data")]
#endif
        public ConfirmationTokenPaymentMethodDataOptions PaymentMethodData { get; set; }

        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif
        public ConfirmationTokenPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// Return URL used to confirm the Intent.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this ConfirmationToken's payment
        /// method.
        ///
        /// The presence of this property will <a
        /// href="https://stripe.com/docs/payments/save-during-payment">attach the payment
        /// method</a> to the PaymentIntent's Customer, if present, after the PaymentIntent is
        /// confirmed and any required actions from the user are complete.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_future_usage")]
#endif
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Shipping information for this ConfirmationToken.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public ConfirmationTokenShippingOptions Shipping { get; set; }
    }
}
