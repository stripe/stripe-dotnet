// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderPaymentSettingsPaymentMethodOptionsAfterpayClearpayOptions : INestedOptions
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        ///
        /// If provided, this parameter will override the top-level <c>capture_method</c> when
        /// finalizing the payment with this payment method type.
        ///
        /// If <c>capture_method</c> is already set on the PaymentIntent, providing an empty value
        /// for this parameter will unset the stored value for this payment method type.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Order identifier shown to the customer in Afterpay’s online portal. We recommend using a
        /// value that helps you answer any questions a customer might have about the payment. The
        /// identifier is limited to 128 characters and may contain only letters, digits,
        /// underscores, backslashes and dashes.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with the payment method.
        ///
        /// Providing this parameter will <a
        /// href="https://stripe.com/docs/payments/save-during-payment">attach the payment
        /// method</a> to the order's Customer, if present, after the order's PaymentIntent is
        /// confirmed and any required actions from the user are complete. If no Customer was
        /// provided, the payment method can still be <a
        /// href="https://stripe.com/docs/api/payment_methods/attach">attached</a> to a Customer
        /// after the transaction completes.
        ///
        /// When processing card payments, Stripe also uses <c>setup_future_usage</c> to dynamically
        /// optimize your payment flow and comply with regional legislation and network rules, such
        /// as <a href="https://stripe.com/docs/strong-customer-authentication">SCA</a>.
        ///
        /// If <c>setup_future_usage</c> is already set and you are performing a request using a
        /// publishable key, you may only update the value from <c>on_session</c> to
        /// <c>off_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}
