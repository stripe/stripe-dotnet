// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderPaymentSettingsPaymentMethodOptionsPaypal : StripeEntity<OrderPaymentSettingsPaymentMethodOptionsPaypal>
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Preferred locale of the PayPal checkout page that the customer is redirected to.
        /// </summary>
        [JsonProperty("preferred_locale")]
        public string PreferredLocale { get; set; }

        /// <summary>
        /// A reference of the PayPal transaction visible to customer which is mapped to PayPal's
        /// invoice ID. This must be a globally unique ID if you have configured in your PayPal
        /// settings to block multiple payments per invoice ID.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// A reference of the PayPal transaction visible to customer which is mapped to PayPal's
        /// invoice ID. This must be a globally unique ID if you have configured in your PayPal
        /// settings to block multiple payments per invoice ID.
        /// </summary>
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// Providing this parameter will <a
        /// href="https://stripe.com/docs/payments/save-during-payment">attach the payment
        /// method</a> to the PaymentIntent's Customer, if present, after the PaymentIntent is
        /// confirmed and any required actions from the user are complete. If no Customer was
        /// provided, the payment method can still be <a
        /// href="https://stripe.com/docs/api/payment_methods/attach">attached</a> to a Customer
        /// after the transaction completes.
        ///
        /// When processing card payments, Stripe also uses <c>setup_future_usage</c> to dynamically
        /// optimize your payment flow and comply with regional legislation and network rules, such
        /// as <a href="https://stripe.com/docs/strong-customer-authentication">SCA</a>.
        /// One of: <c>none</c>, or <c>off_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}
