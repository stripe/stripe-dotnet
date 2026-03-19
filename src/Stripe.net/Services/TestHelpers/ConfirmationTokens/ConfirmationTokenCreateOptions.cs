// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfirmationTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// ID of an existing PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If provided, this hash will be used to create a PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method_data")]
        [STJS.JsonPropertyName("payment_method_data")]
        public ConfirmationTokenPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Payment-method-specific configuration for this ConfirmationToken.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public ConfirmationTokenPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// Return URL used to confirm the Intent.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this ConfirmationToken's payment
        /// method.
        ///
        /// The presence of this property will <a
        /// href="https://docs.stripe.com/payments/save-during-payment">attach the payment
        /// method</a> to the PaymentIntent's Customer, if present, after the PaymentIntent is
        /// confirmed and any required actions from the user are complete.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        [STJS.JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Shipping information for this ConfirmationToken.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public ConfirmationTokenShippingOptions Shipping { get; set; }
    }
}
