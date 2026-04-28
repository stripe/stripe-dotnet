// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentUpdateOptions : BaseOptions, IHasMetadata
    {
        private PaymentIntentAmountDetailsOptions amountDetails;
        private long? applicationFeeAmount;
        private List<string> excludedPaymentMethodTypes;
        private Dictionary<string, string> metadata;
        private PaymentIntentPaymentDetailsOptions paymentDetails;
        private string receiptEmail;
        private string setupFutureUsage;
        private ChargeShippingOptions shipping;

        /// <summary>
        /// Allocated Funds configuration for this PaymentIntent.
        /// </summary>
        [JsonProperty("allocated_funds")]
        [STJS.JsonPropertyName("allocated_funds")]
        public PaymentIntentAllocatedFundsOptions AllocatedFunds { get; set; }

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
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Provides industry-specific information about the amount.
        /// </summary>
        [JsonProperty("amount_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("amount_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public PaymentIntentAmountDetailsOptions AmountDetails
        {
            get => this.amountDetails;
            set
            {
                this.amountDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. The amount of the
        /// application fee collected will be capped at the total amount captured. For more
        /// information, see the PaymentIntents <a
        /// href="https://docs.stripe.com/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("application_fee_amount")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public long? ApplicationFeeAmount
        {
            get => this.applicationFeeAmount;
            set
            {
                this.applicationFeeAmount = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, <c>automatic_async</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        [STJS.JsonPropertyName("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
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
        [STJS.JsonPropertyName("customer")]
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
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

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
        /// <c>shopeepay</c>, <c>sofort</c>, <c>stripe_balance</c>, <c>sunbit</c>, <c>swish</c>,
        /// <c>twint</c>, <c>upi</c>, <c>us_bank_account</c>, <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("excluded_payment_method_types", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("excluded_payment_method_types")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> ExcludedPaymentMethodTypes
        {
            get => this.excludedPaymentMethodTypes;
            set
            {
                this.excludedPaymentMethodTypes = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The FX rate in the quote is validated and used to convert the presentment amount to the
        /// settlement amount.
        /// </summary>
        [JsonProperty("fx_quote")]
        [STJS.JsonPropertyName("fx_quote")]
        public string FxQuote { get; set; }

        /// <summary>
        /// Automations to be run during the PaymentIntent lifecycle.
        /// </summary>
        [JsonProperty("hooks")]
        [STJS.JsonPropertyName("hooks")]
        public PaymentIntentHooksOptions Hooks { get; set; }

        /// <summary>
        /// This hash contains details about the Mandate to create.
        /// </summary>
        [JsonProperty("mandate_data")]
        [STJS.JsonPropertyName("mandate_data")]
        public PaymentIntentMandateDataOptions MandateData { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Provides industry-specific information about the charge.
        /// </summary>
        [JsonProperty("payment_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("payment_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public PaymentIntentPaymentDetailsOptions PaymentDetails
        {
            get => this.paymentDetails;
            set
            {
                this.paymentDetails = value;
                this.SetTracker.Track();
            }
        }

        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The ID of the <a
        /// href="https://docs.stripe.com/api/payment_method_configurations">payment method
        /// configuration</a> to use with this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
        [STJS.JsonPropertyName("payment_method_configuration")]
        public string PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// If provided, this hash will be used to create a PaymentMethod. The new PaymentMethod
        /// will appear in the <a
        /// href="https://docs.stripe.com/api/payment_intents/object#payment_intent_object-payment_method">payment_method</a>
        /// property on the PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_data")]
        [STJS.JsonPropertyName("payment_method_data")]
        public PaymentIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Payment-method-specific configuration for this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public PaymentIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (for example, card) that this PaymentIntent can use.
        /// Use <c>automatic_payment_methods</c> to manage payment methods from the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>. A
        /// list of valid payment method types can be found <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-type">here</a>.
        /// </summary>
        [JsonProperty("payment_method_types")]
        [STJS.JsonPropertyName("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Email address that the receipt for the resulting payment will be sent to. If
        /// <c>receipt_email</c> is specified for a payment in live mode, a receipt will be sent
        /// regardless of your <a href="https://dashboard.stripe.com/account/emails">email
        /// settings</a>.
        /// </summary>
        [JsonProperty("receipt_email", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("receipt_email")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ReceiptEmail
        {
            get => this.receiptEmail;
            set
            {
                this.receiptEmail = value;
                this.SetTracker.Track();
            }
        }

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
        [JsonProperty("setup_future_usage", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("setup_future_usage")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string SetupFutureUsage
        {
            get => this.setupFutureUsage;
            set
            {
                this.setupFutureUsage = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Shipping information for this PaymentIntent.
        /// </summary>
        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("shipping")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ChargeShippingOptions Shipping
        {
            get => this.shipping;
            set
            {
                this.shipping = value;
                this.SetTracker.Track();
            }
        }

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
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account's <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer's statement.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// Use this parameter to automatically create a Transfer when the payment succeeds. Learn
        /// more about the <a href="https://docs.stripe.com/payments/connected-accounts">use case
        /// for connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies the resulting payment as part of a group. You can only provide
        /// <c>transfer_group</c> if it hasn't been set. Learn more about the <a
        /// href="https://docs.stripe.com/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("transfer_group")]
        [STJS.JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
