// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsPaypalOptions : INestedOptions
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// <a href="https://stripe.com/docs/payments/paypal/supported-locales">Preferred locale</a>
        /// of the PayPal checkout page that the customer is redirected to.
        /// One of: <c>cs-CZ</c>, <c>da-DK</c>, <c>de-AT</c>, <c>de-DE</c>, <c>de-LU</c>,
        /// <c>el-GR</c>, <c>en-GB</c>, <c>en-US</c>, <c>es-ES</c>, <c>fi-FI</c>, <c>fr-BE</c>,
        /// <c>fr-FR</c>, <c>fr-LU</c>, <c>hu-HU</c>, <c>it-IT</c>, <c>nl-BE</c>, <c>nl-NL</c>,
        /// <c>pl-PL</c>, <c>pt-PT</c>, <c>sk-SK</c>, or <c>sv-SE</c>.
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
        /// The risk correlation ID for an on-session payment using a saved PayPal payment method.
        /// </summary>
        [JsonProperty("risk_correlation_id")]
        public string RiskCorrelationId { get; set; }

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
        ///
        /// If <c>setup_future_usage</c> is already set and you are performing a request using a
        /// publishable key, you may only update the value from <c>on_session</c> to
        /// <c>off_session</c>.
        /// One of: <c>none</c>, or <c>off_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}
