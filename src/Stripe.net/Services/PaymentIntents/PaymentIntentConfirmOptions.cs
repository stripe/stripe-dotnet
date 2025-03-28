// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentConfirmOptions : BaseOptions
    {
        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. The amount of the
        /// application fee collected will be capped at the total amount captured. For more
        /// information, see the PaymentIntents <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_amount")]
#endif
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Automations to be run during the PaymentIntent lifecycle.
        /// </summary>
        [JsonProperty("async_workflows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("async_workflows")]
#endif
        public PaymentIntentAsyncWorkflowsOptions AsyncWorkflows { get; set; }

        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, <c>automatic_async</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_method")]
#endif
        public string CaptureMethod { get; set; }

        [JsonProperty("client_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_secret")]
#endif
        public string ClientSecret { get; set; }

        /// <summary>
        /// ID of the ConfirmationToken used to confirm this PaymentIntent.
        ///
        /// If the provided ConfirmationToken contains properties that are also being provided in
        /// this request, such as <c>payment_method</c>, then the values in this request will take
        /// precedence.
        /// </summary>
        [JsonProperty("confirmation_token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirmation_token")]
#endif
        public string ConfirmationToken { get; set; }

        /// <summary>
        /// Set to <c>true</c> to fail the payment attempt if the PaymentIntent transitions into
        /// <c>requires_action</c>. This parameter is intended for simpler integrations that do not
        /// handle customer actions, like <a
        /// href="https://stripe.com/docs/payments/save-card-without-authentication">saving cards
        /// without authentication</a>.
        /// </summary>
        [JsonProperty("error_on_requires_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_on_requires_action")]
#endif
        public bool? ErrorOnRequiresAction { get; set; }

        /// <summary>
        /// ID of the mandate that's used for this payment.
        /// </summary>
        [JsonProperty("mandate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate")]
#endif
        public string Mandate { get; set; }

        [JsonProperty("mandate_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_data")]
#endif
        public PaymentIntentMandateDataOptions MandateData { get; set; }

        /// <summary>
        /// Set to <c>true</c> to indicate that the customer isn't in your checkout flow during this
        /// payment attempt and can't authenticate. Use this parameter in scenarios where you
        /// collect card details and <a
        /// href="https://stripe.com/docs/payments/cards/charging-saved-cards">charge them
        /// later</a>.
        /// </summary>
        [JsonProperty("off_session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("off_session")]
#endif
        public bool? OffSession { get; set; }

        /// <summary>
        /// Provides industry-specific information about the charge.
        /// </summary>
        [JsonProperty("payment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_details")]
#endif
        public PaymentIntentPaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, or <a
        /// href="https://stripe.com/docs/payments/payment-methods/transitioning#compatibility">compatible
        /// Source</a> object) to attach to this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If provided, this hash will be used to create a PaymentMethod. The new PaymentMethod
        /// will appear in the <a
        /// href="https://stripe.com/docs/api/payment_intents/object#payment_intent_object-payment_method">payment_method</a>
        /// property on the PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_data")]
#endif
        public PaymentIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Payment method-specific configuration for this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif
        public PaymentIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (for example, a card) that this PaymentIntent can use.
        /// Use <c>automatic_payment_methods</c> to manage payment methods from the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>.
        /// </summary>
        [JsonProperty("payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_types")]
#endif
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Options to configure Radar. Learn more about <a
        /// href="https://stripe.com/docs/radar/radar-session">Radar Sessions</a>.
        /// </summary>
        [JsonProperty("radar_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("radar_options")]
#endif
        public PaymentIntentRadarOptionsOptions RadarOptions { get; set; }

        /// <summary>
        /// Email address that the receipt for the resulting payment will be sent to. If
        /// <c>receipt_email</c> is specified for a payment in live mode, a receipt will be sent
        /// regardless of your <a href="https://dashboard.stripe.com/account/emails">email
        /// settings</a>.
        /// </summary>
        [JsonProperty("receipt_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_email")]
#endif
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method's app or site. If you'd prefer to redirect to a mobile
        /// application, you can alternatively supply an application URI scheme. This parameter is
        /// only used for cards and other redirect-based payment methods.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }

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
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_future_usage")]
#endif
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Shipping information for this PaymentIntent.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// Set to <c>true</c> when confirming server-side and using Stripe.js, iOS, or Android
        /// client-side SDKs to handle the next actions.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("use_stripe_sdk")]
#endif
        public bool? UseStripeSdk { get; set; }
    }
}
