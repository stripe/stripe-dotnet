// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentConfirmOptions : BaseOptions
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, <c>automatic_async</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Set to <c>true</c> to fail the payment attempt if the PaymentIntent transitions into
        /// <c>requires_action</c>. This parameter is intended for simpler integrations that do not
        /// handle customer actions, like <a
        /// href="https://stripe.com/docs/payments/save-card-without-authentication">saving cards
        /// without authentication</a>.
        /// </summary>
        [JsonProperty("error_on_requires_action")]
        public bool? ErrorOnRequiresAction { get; set; }

        /// <summary>
        /// ID of the mandate that's used for this payment.
        /// </summary>
        [JsonProperty("mandate")]
        public string Mandate { get; set; }

        [JsonProperty("mandate_data")]
        public PaymentIntentMandateDataOptions MandateData { get; set; }

        /// <summary>
        /// Set to <c>true</c> to indicate that the customer isn't in your checkout flow during this
        /// payment attempt and can't authenticate. Use this parameter in scenarios where you
        /// collect card details and <a
        /// href="https://stripe.com/docs/payments/cards/charging-saved-cards">charge them
        /// later</a>.
        /// </summary>
        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, or <a
        /// href="https://stripe.com/docs/payments/payment-methods/transitioning#compatibility">compatible
        /// Source</a> object) to attach to this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If provided, this hash will be used to create a PaymentMethod. The new PaymentMethod
        /// will appear in the <a
        /// href="https://stripe.com/docs/api/payment_intents/object#payment_intent_object-payment_method">payment_method</a>
        /// property on the PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_data")]
        public PaymentIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Payment method-specific configuration for this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public PaymentIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) that this PaymentIntent is allowed to use.
        /// If this is not provided, defaults to ["card"].
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Options to configure Radar. Learn more about <a
        /// href="https://stripe.com/docs/radar/radar-session">Radar Sessions</a>.
        /// </summary>
        [JsonProperty("radar_options")]
        public PaymentIntentRadarOptionsOptions RadarOptions { get; set; }

        /// <summary>
        /// Email address that the receipt for the resulting payment will be sent to. If
        /// <c>receipt_email</c> is specified for a payment in live mode, a receipt will be sent
        /// regardless of your <a href="https://dashboard.stripe.com/account/emails">email
        /// settings</a>.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method's app or site. If you'd prefer to redirect to a mobile
        /// application, you can alternatively supply an application URI scheme. This parameter is
        /// only used for cards and other redirect-based payment methods.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

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
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Shipping information for this PaymentIntent.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// Set to <c>true</c> when confirming server-side and using Stripe.js, iOS, or Android
        /// client-side SDKs to handle the next actions.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        public bool? UseStripeSdk { get; set; }
    }
}
