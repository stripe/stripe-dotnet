// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsPaypalOptions : INestedOptions
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
        /// A reference of the PayPal transaction visible to customer which is mapped to PayPal's
        /// invoice ID. This must be a globally unique ID if you have configured in your PayPal
        /// settings to block multiple payments per invoice ID.
        /// </summary>
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The risk correlation ID for an on-session payment using a saved PayPal payment method.
        /// </summary>
        [JsonProperty("risk_correlation_id")]
        public string RiskCorrelationId { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a
        /// href="https://stripe.com/payments/save-during-payment">attach the payment method</a> to
        /// the Customer after the PaymentIntent is confirmed and the customer completes any
        /// required actions. If you don't provide a Customer, you can still <a
        /// href="https://stripe.com/api/payment_methods/attach">attach</a> the payment method to a
        /// Customer after the transaction completes.
        ///
        /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates
        /// and attaches a <a
        /// href="https://stripe.com/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a>
        /// payment method representing the card to the Customer instead.
        ///
        /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply
        /// with regional legislation and network rules, such as <a
        /// href="https://stripe.com/strong-customer-authentication">SCA</a>.
        ///
        /// If you've already set <c>setup_future_usage</c> and you're performing a request using a
        /// publishable key, you can only update the value from <c>on_session</c> to
        /// <c>off_session</c>.
        /// One of: <c>none</c>, or <c>off_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// The Stripe connected account IDs of the sellers on the platform for this transaction
        /// (optional). Only allowed when <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers">separate charges
        /// and transfers</a> are used.
        /// </summary>
        [JsonProperty("subsellers")]
        public List<string> Subsellers { get; set; }
    }
}
