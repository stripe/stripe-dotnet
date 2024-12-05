// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsPaypal : StripeEntity<SessionPaymentMethodOptionsPaypal>
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
