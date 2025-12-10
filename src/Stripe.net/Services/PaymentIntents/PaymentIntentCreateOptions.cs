// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount intended to be collected by this PaymentIntent. A positive integer representing
        /// how much to charge in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum
        /// amount is $0.50 US or <a
        /// href="https://docs.stripe.com/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Provides industry-specific information about the amount.
        /// </summary>
        [JsonProperty("amount_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_details")]
#endif
        public PaymentIntentAmountDetailsOptions AmountDetails { get; set; }

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. The amount of the
        /// application fee collected will be capped at the total amount captured. For more
        /// information, see the PaymentIntents <a
        /// href="https://docs.stripe.com/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_amount")]
#endif
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// When you enable this parameter, this PaymentIntent accepts payment methods that you
        /// enable in the Dashboard and that are compatible with this PaymentIntent's other
        /// parameters.
        /// </summary>
        [JsonProperty("automatic_payment_methods")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_payment_methods")]
#endif
        public PaymentIntentAutomaticPaymentMethodsOptions AutomaticPaymentMethods { get; set; }

        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, <c>automatic_async</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_method")]
#endif
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Set to <c>true</c> to attempt to <a
        /// href="https://docs.stripe.com/api/payment_intents/confirm">confirm this
        /// PaymentIntent</a> immediately. This parameter defaults to <c>false</c>. When creating
        /// and confirming a PaymentIntent at the same time, you can also provide the parameters
        /// available in the <a href="https://docs.stripe.com/api/payment_intents/confirm">Confirm
        /// API</a>.
        /// </summary>
        [JsonProperty("confirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirm")]
#endif
        public bool? Confirm { get; set; }

        /// <summary>
        /// Describes whether we can confirm this PaymentIntent automatically, or if it requires
        /// customer action to confirm the payment.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("confirmation_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirmation_method")]
#endif
        public string ConfirmationMethod { get; set; }

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
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// ID of the Customer this PaymentIntent belongs to, if one exists.
        ///
        /// Payment methods attached to other Customers cannot be used with this PaymentIntent.
        ///
        /// If <a
        /// href="https://api.stripe.com#payment_intent_object-setup_future_usage">setup_future_usage</a>
        /// is set and this PaymentIntent's payment method is not <c>card_present</c>, then the
        /// payment method attaches to the Customer after the PaymentIntent has been confirmed and
        /// any required actions from the user are complete. If the payment method is
        /// <c>card_present</c> and isn't a digital wallet, then a <a
        /// href="https://docs.stripe.com/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a>
        /// payment method representing the card is created and attached to the Customer instead.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// ID of the Account representing the customer that this PaymentIntent belongs to, if one
        /// exists.
        ///
        /// Payment methods attached to other Accounts cannot be used with this PaymentIntent.
        ///
        /// If <a
        /// href="https://api.stripe.com#payment_intent_object-setup_future_usage">setup_future_usage</a>
        /// is set and this PaymentIntent's payment method is not <c>card_present</c>, then the
        /// payment method attaches to the Account after the PaymentIntent has been confirmed and
        /// any required actions from the user are complete. If the payment method is
        /// <c>card_present</c> and isn't a digital wallet, then a <a
        /// href="https://docs.stripe.com/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a>
        /// payment method representing the card is created and attached to the Account instead.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Set to <c>true</c> to fail the payment attempt if the PaymentIntent transitions into
        /// <c>requires_action</c>. Use this parameter for simpler integrations that don't handle
        /// customer actions, such as <a
        /// href="https://docs.stripe.com/payments/save-card-without-authentication">saving cards
        /// without authentication</a>. This parameter can only be used with <a
        /// href="https://docs.stripe.com/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("error_on_requires_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_on_requires_action")]
#endif
        public bool? ErrorOnRequiresAction { get; set; }

        /// <summary>
        /// The list of payment method types to exclude from use with this payment.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>billie</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>cashapp</c>, <c>crypto</c>, <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>,
        /// <c>giropay</c>, <c>gopay</c>, <c>grabpay</c>, <c>id_bank_transfer</c>, <c>ideal</c>,
        /// <c>kakao_pay</c>, <c>klarna</c>, <c>konbini</c>, <c>kr_card</c>, <c>mb_way</c>,
        /// <c>mobilepay</c>, <c>multibanco</c>, <c>naver_pay</c>, <c>nz_bank_account</c>,
        /// <c>oxxo</c>, <c>p24</c>, <c>pay_by_bank</c>, <c>payco</c>, <c>paynow</c>, <c>paypal</c>,
        /// <c>paypay</c>, <c>payto</c>, <c>pix</c>, <c>promptpay</c>, <c>qris</c>, <c>rechnung</c>,
        /// <c>revolut_pay</c>, <c>samsung_pay</c>, <c>satispay</c>, <c>sepa_debit</c>,
        /// <c>shopeepay</c>, <c>sofort</c>, <c>stripe_balance</c>, <c>swish</c>, <c>twint</c>,
        /// <c>us_bank_account</c>, <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("excluded_payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("excluded_payment_method_types")]
#endif
        public List<string> ExcludedPaymentMethodTypes { get; set; }

        /// <summary>
        /// The FX rate in the quote is validated and used to convert the presentment amount to the
        /// settlement amount.
        /// </summary>
        [JsonProperty("fx_quote")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fx_quote")]
#endif
        public string FxQuote { get; set; }

        /// <summary>
        /// Automations to be run during the PaymentIntent lifecycle.
        /// </summary>
        [JsonProperty("hooks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hooks")]
#endif
        public PaymentIntentHooksOptions Hooks { get; set; }

        /// <summary>
        /// ID of the mandate that's used for this payment. This parameter can only be used with <a
        /// href="https://docs.stripe.com/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("mandate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate")]
#endif
        public string Mandate { get; set; }

        /// <summary>
        /// This hash contains details about the Mandate to create. This parameter can only be used
        /// with <a
        /// href="https://docs.stripe.com/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("mandate_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_data")]
#endif
        public PaymentIntentMandateDataOptions MandateData { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Set to <c>true</c> to indicate that the customer isn't in your checkout flow during this
        /// payment attempt and can't authenticate. Use this parameter in scenarios where you
        /// collect card details and <a
        /// href="https://docs.stripe.com/payments/cards/charging-saved-cards">charge them
        /// later</a>. This parameter can only be used with <a
        /// href="https://docs.stripe.com/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("off_session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("off_session")]
#endif
        public bool? OffSession { get; set; }

        /// <summary>
        /// The Stripe account ID that these funds are intended for. Learn more about the <a
        /// href="https://docs.stripe.com/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

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
        /// href="https://docs.stripe.com/payments/payment-methods#compatibility">compatible
        /// Source</a> object) to attach to this PaymentIntent.
        ///
        /// If you don't provide the <c>payment_method</c> parameter or the <c>source</c> parameter
        /// with <c>confirm=true</c>, <c>source</c> automatically populates with
        /// <c>customer.default_source</c> to improve migration for users of the Charges API. We
        /// recommend that you explicitly provide the <c>payment_method</c> moving forward. If the
        /// payment method is attached to a Customer, you must also provide the ID of that Customer
        /// as the <a href="https://api.stripe.com#create_payment_intent-customer">customer</a>
        /// parameter of this PaymentIntent. end.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The ID of the <a
        /// href="https://docs.stripe.com/api/payment_method_configurations">payment method
        /// configuration</a> to use with this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_configuration")]
#endif
        public string PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// If provided, this hash will be used to create a PaymentMethod. The new PaymentMethod
        /// will appear in the <a
        /// href="https://docs.stripe.com/api/payment_intents/object#payment_intent_object-payment_method">payment_method</a>
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
        /// If you don't provide this, Stripe will dynamically show relevant payment methods from
        /// your <a href="https://dashboard.stripe.com/settings/payment_methods">payment method
        /// settings</a>. A list of valid payment method types can be found <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-type">here</a>.
        /// </summary>
        [JsonProperty("payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_types")]
#endif
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Options to configure Radar. Learn more about <a
        /// href="https://docs.stripe.com/radar/radar-session">Radar Sessions</a>.
        /// </summary>
        [JsonProperty("radar_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("radar_options")]
#endif
        public PaymentIntentRadarOptionsOptions RadarOptions { get; set; }

        /// <summary>
        /// Email address to send the receipt to. If you specify <c>receipt_email</c> for a payment
        /// in live mode, you send a receipt regardless of your <a
        /// href="https://dashboard.stripe.com/account/emails">email settings</a>.
        /// </summary>
        [JsonProperty("receipt_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_email")]
#endif
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method's app or site. If you'd prefer to redirect to a mobile
        /// application, you can alternatively supply an application URI scheme. This parameter can
        /// only be used with <a
        /// href="https://docs.stripe.com/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Indicates whether confirmation for this PaymentIntent using a secret key is
        /// <c>required</c> or <c>optional</c>.
        /// One of: <c>optional</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("secret_key_confirmation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secret_key_confirmation")]
#endif
        public string SecretKeyConfirmation { get; set; }

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
        /// Text that appears on the customer's statement as the statement descriptor for a non-card
        /// charge. This value overrides the account's default statement descriptor. For information
        /// about requirements, including the 22-character limit, see <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">the Statement
        /// Descriptor docs</a>.
        ///
        /// Setting this value for a card charge returns an error. For card charges, set the <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#dynamic">statement_descriptor_suffix</a>
        /// instead.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account's <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer's statement.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
#endif
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The parameters that you can use to automatically create a Transfer. Learn more about the
        /// <a href="https://docs.stripe.com/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public PaymentIntentTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies the resulting payment as part of a group. Learn more about the
        /// <a href="https://docs.stripe.com/connect/separate-charges-and-transfers">use case for
        /// connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_group")]
#endif
        public string TransferGroup { get; set; }

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
