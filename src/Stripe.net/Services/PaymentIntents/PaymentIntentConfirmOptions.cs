namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentConfirmOptions : BaseOptions
    {
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
        /// ID of the mandate to be used for this payment.
        /// </summary>
        [JsonProperty("mandate")]
        public string Mandate { get; set; }

        [JsonProperty("mandate_data")]
        public PaymentIntentMandateDataOptions MandateData { get; set; }

        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, or <a
        /// href="https://stripe.com/docs/payments/payment-methods#compatibility">compatible
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
        /// Payment-method-specific configuration for this PaymentIntent.
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
        /// If the PaymentIntent has a <c>payment_method</c> and a <c>customer</c> or if you're
        /// attaching a payment method to the PaymentIntent in this request, you can pass
        /// <c>save_payment_method=true</c> to save the payment method to the customer immediately.
        ///
        /// If the payment method is already saved to a customer, this parameter does nothing. If
        /// this type of payment method cannot be saved to a customer, the request will error.
        ///
        /// Saving a payment method using this parameter is <em>not recommended</em> because it will
        /// save the payment method even if it cannot be charged (e.g. the user made a typo). To
        /// ensure that only payment methods which are likely to be chargeable are saved to a
        /// customer, use the
        /// (setup_future_usage)[#payment_intents/object#payment_intent_object-setup_future_usage]
        /// property, which saves the payment method after the PaymentIntent has been confirmed and
        /// all required actions by the customer are complete.
        /// </summary>
        [JsonProperty("save_payment_method")]
        public bool? SavePaymentMethod { get; set; }

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

        /// <summary>
        /// Shipping information for this PaymentIntent.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// This is a legacy field that will be removed in the future. It is the ID of the Source
        /// object to attach to this PaymentIntent. Please use the <c>payment_method</c> field
        /// instead, which also supports Cards and <a
        /// href="https://stripe.com/docs/payments/payment-methods#compatibility">compatible
        /// Source</a> objects.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Set to <c>true</c> only when using manual confirmation and the iOS or Android SDKs to
        /// handle additional authentication steps.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        public bool? UseStripeSdk { get; set; }
    }
}
