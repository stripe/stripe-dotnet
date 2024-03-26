// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;

    public class ConfirmationTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// ID of an existing PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If provided, this hash will be used to create a PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method_data")]
        public ConfirmationTokenPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Return URL used to confirm the Intent.
        /// </summary>
        [JsonProperty("return_url")]
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
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Shipping information for this ConfirmationToken.
        /// </summary>
        [JsonProperty("shipping")]
        public ConfirmationTokenShippingOptions Shipping { get; set; }
    }
}
