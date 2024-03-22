// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount intended to be collected by this PaymentIntent. A positive integer representing
        /// how much to charge in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum
        /// amount is $0.50 US or <a
        /// href="https://stripe.com/docs/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. The amount of the
        /// application fee collected will be capped at the total payment amount. For more
        /// information, see the PaymentIntents <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// When you enable this parameter, this PaymentIntent accepts payment methods that you
        /// enable in the Dashboard and that are compatible with this PaymentIntent's other
        /// parameters.
        /// </summary>
        [JsonProperty("automatic_payment_methods")]
        public PaymentIntentAutomaticPaymentMethodsOptions AutomaticPaymentMethods { get; set; }

        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, <c>automatic_async</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Set to <c>true</c> to attempt to <a
        /// href="https://stripe.com/docs/api/payment_intents/confirm">confirm this
        /// PaymentIntent</a> immediately. This parameter defaults to <c>false</c>. When creating
        /// and confirming a PaymentIntent at the same time, you can also provide the parameters
        /// available in the <a href="https://stripe.com/docs/api/payment_intents/confirm">Confirm
        /// API</a>.
        /// </summary>
        [JsonProperty("confirm")]
        public bool? Confirm { get; set; }

        /// <summary>
        /// Describes whether we can confirm this PaymentIntent automatically, or if it requires
        /// customer action to confirm the payment.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("confirmation_method")]
        public string ConfirmationMethod { get; set; }

        /// <summary>
        /// ID of the ConfirmationToken used to confirm this PaymentIntent.
        ///
        /// If the provided ConfirmationToken contains properties that are also being provided in
        /// this request, such as <c>payment_method</c>, then the values in this request will take
        /// precedence.
        /// </summary>
        [JsonProperty("confirmation_token")]
        public string ConfirmationToken { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// ID of the Customer this PaymentIntent belongs to, if one exists.
        ///
        /// Payment methods attached to other Customers cannot be used with this PaymentIntent.
        ///
        /// If present in combination with <a
        /// href="https://stripe.com/docs/api#payment_intent_object-setup_future_usage">setup_future_usage</a>,
        /// this PaymentIntent's payment method will be attached to the Customer after the
        /// PaymentIntent has been confirmed and any required actions from the user are complete.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set to <c>true</c> to fail the payment attempt if the PaymentIntent transitions into
        /// <c>requires_action</c>. Use this parameter for simpler integrations that don't handle
        /// customer actions, such as <a
        /// href="https://stripe.com/docs/payments/save-card-without-authentication">saving cards
        /// without authentication</a>. This parameter can only be used with <a
        /// href="https://stripe.com/docs/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("error_on_requires_action")]
        public bool? ErrorOnRequiresAction { get; set; }

        /// <summary>
        /// ID of the mandate that's used for this payment. This parameter can only be used with <a
        /// href="https://stripe.com/docs/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("mandate")]
        public string Mandate { get; set; }

        /// <summary>
        /// This hash contains details about the Mandate to create. This parameter can only be used
        /// with <a
        /// href="https://stripe.com/docs/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("mandate_data")]
        public PaymentIntentMandateDataOptions MandateData { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Set to <c>true</c> to indicate that the customer isn't in your checkout flow during this
        /// payment attempt and can't authenticate. Use this parameter in scenarios where you
        /// collect card details and <a
        /// href="https://stripe.com/docs/payments/cards/charging-saved-cards">charge them
        /// later</a>. This parameter can only be used with <a
        /// href="https://stripe.com/docs/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        /// <summary>
        /// The Stripe account ID that these funds are intended for. Learn more about the <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, or <a
        /// href="https://stripe.com/docs/payments/payment-methods#compatibility">compatible
        /// Source</a> object) to attach to this PaymentIntent.
        ///
        /// If you don't provide the <c>payment_method</c> parameter or the <c>source</c> parameter
        /// with <c>confirm=true</c>, <c>source</c> automatically populates with
        /// <c>customer.default_source</c> to improve migration for users of the Charges API. We
        /// recommend that you explicitly provide the <c>payment_method</c> moving forward.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The ID of the payment method configuration to use with this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
        public string PaymentMethodConfiguration { get; set; }

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
        /// The list of payment method types (for example, a card) that this PaymentIntent can use.
        /// If you don't provide this, it defaults to ["card"]. Use <c>automatic_payment_methods</c>
        /// to manage payment methods from the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>.
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
        /// Email address to send the receipt to. If you specify <c>receipt_email</c> for a payment
        /// in live mode, you send a receipt regardless of your <a
        /// href="https://dashboard.stripe.com/account/emails">email settings</a>.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method's app or site. If you'd prefer to redirect to a mobile
        /// application, you can alternatively supply an application URI scheme. This parameter can
        /// only be used with <a
        /// href="https://stripe.com/docs/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
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
        /// For card charges, use <a
        /// href="https://stripe.com/docs/payments/account/statement-descriptors#dynamic">statement_descriptor_suffix</a>.
        /// Otherwise, you can use this value as the complete description of a charge on your
        /// customers' statements. It must contain at least one letter and be 1–22 characters long.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card payment that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that’s set
        /// on the account to form the complete statement descriptor. The concatenated descriptor
        /// must contain 1-22 characters.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The parameters that you can use to automatically create a Transfer. Learn more about the
        /// <a href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies the resulting payment as part of a group. Learn more about the
        /// <a href="https://stripe.com/docs/connect/separate-charges-and-transfers">use case for
        /// connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }

        /// <summary>
        /// Set to <c>true</c> when confirming server-side and using Stripe.js, iOS, or Android
        /// client-side SDKs to handle the next actions.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        public bool? UseStripeSdk { get; set; }
    }
}
