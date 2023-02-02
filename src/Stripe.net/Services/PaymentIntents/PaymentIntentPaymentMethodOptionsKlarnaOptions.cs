// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        ///
        /// If provided, this parameter will override the top-level <c>capture_method</c> when
        /// finalizing the payment with this payment method type.
        ///
        /// If <c>capture_method</c> is already set on the PaymentIntent, providing an empty value
        /// for this parameter will unset the stored value for this payment method type.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Preferred language of the Klarna authorization page that the customer is redirected to.
        /// One of: <c>cs-CZ</c>, <c>da-DK</c>, <c>de-AT</c>, <c>de-CH</c>, <c>de-DE</c>,
        /// <c>el-GR</c>, <c>en-AT</c>, <c>en-AU</c>, <c>en-BE</c>, <c>en-CA</c>, <c>en-CH</c>,
        /// <c>en-CZ</c>, <c>en-DE</c>, <c>en-DK</c>, <c>en-ES</c>, <c>en-FI</c>, <c>en-FR</c>,
        /// <c>en-GB</c>, <c>en-GR</c>, <c>en-IE</c>, <c>en-IT</c>, <c>en-NL</c>, <c>en-NO</c>,
        /// <c>en-NZ</c>, <c>en-PL</c>, <c>en-PT</c>, <c>en-SE</c>, <c>en-US</c>, <c>es-ES</c>,
        /// <c>es-US</c>, <c>fi-FI</c>, <c>fr-BE</c>, <c>fr-CA</c>, <c>fr-CH</c>, <c>fr-FR</c>,
        /// <c>it-CH</c>, <c>it-IT</c>, <c>nb-NO</c>, <c>nl-BE</c>, <c>nl-NL</c>, <c>pl-PL</c>,
        /// <c>pt-PT</c>, <c>sv-FI</c>, or <c>sv-SE</c>.
        /// </summary>
        [JsonProperty("preferred_locale")]
        public string PreferredLocale { get; set; }

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
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}
