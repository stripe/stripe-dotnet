// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A PaymentIntent guides you through the process of collecting a payment from your
    /// customer. We recommend that you create exactly one PaymentIntent for each order or
    /// customer session in your system. You can reference the PaymentIntent later to see the
    /// history of payment attempts for a particular session.
    ///
    /// A PaymentIntent transitions through <a
    /// href="https://stripe.com/payments/paymentintents/lifecycle">multiple statuses</a>
    /// throughout its lifetime as it interfaces with Stripe.js to perform authentication flows
    /// and ultimately creates at most one successful charge.
    ///
    /// Related guide: <a href="https://docs.stripe.com/payments/payment-intents">Payment
    /// Intents API</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class PaymentIntent : StripeEntity<PaymentIntent>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Allocated Funds configuration for this PaymentIntent.
        /// </summary>
        [JsonProperty("allocated_funds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allocated_funds")]
#endif
        public PaymentIntentAllocatedFunds AllocatedFunds { get; set; }

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
        public long Amount { get; set; }

        /// <summary>
        /// Amount that can be captured from this PaymentIntent.
        /// </summary>
        [JsonProperty("amount_capturable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_capturable")]
#endif
        public long AmountCapturable { get; set; }

        [JsonProperty("amount_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_details")]
#endif
        public PaymentIntentAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Amount that this PaymentIntent collects.
        /// </summary>
        [JsonProperty("amount_received")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_received")]
#endif
        public long AmountReceived { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect application that created the PaymentIntent.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect application that created the PaymentIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Application>))]
#endif
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

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

        [JsonProperty("async_workflows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("async_workflows")]
#endif
        public PaymentIntentAsyncWorkflows AsyncWorkflows { get; set; }

        /// <summary>
        /// Settings to configure compatible payment methods from the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>.
        /// </summary>
        [JsonProperty("automatic_payment_methods")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_payment_methods")]
#endif
        public PaymentIntentAutomaticPaymentMethods AutomaticPaymentMethods { get; set; }

        /// <summary>
        /// Populated when <c>status</c> is <c>canceled</c>, this is the time at which the
        /// PaymentIntent was canceled. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Reason for cancellation of this PaymentIntent, either user-provided (<c>duplicate</c>,
        /// <c>fraudulent</c>, <c>requested_by_customer</c>, or <c>abandoned</c>) or generated by
        /// Stripe internally (<c>failed_invoice</c>, <c>void_invoice</c>, <c>automatic</c>, or
        /// <c>expired</c>).
        /// One of: <c>abandoned</c>, <c>automatic</c>, <c>duplicate</c>, <c>expired</c>,
        /// <c>failed_invoice</c>, <c>fraudulent</c>, <c>requested_by_customer</c>, or
        /// <c>void_invoice</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_reason")]
#endif
        public string CancellationReason { get; set; }

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
        /// The client secret of this PaymentIntent. Used for client-side retrieval using a
        /// publishable key.
        ///
        /// The client secret can be used to complete a payment from your frontend. It should not be
        /// stored, logged, or exposed to anyone other than the customer. Make sure that you have
        /// TLS enabled on any page that includes the client secret.
        ///
        /// Refer to our docs to <a
        /// href="https://docs.stripe.com/payments/accept-a-payment?ui=elements">accept a
        /// payment</a> and learn about how <c>client_secret</c> should be handled.
        /// </summary>
        [JsonProperty("client_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_secret")]
#endif
        public string ClientSecret { get; set; }

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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
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
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
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
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
#endif
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

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
        /// The FX Quote used for the PaymentIntent.
        /// </summary>
        [JsonProperty("fx_quote")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fx_quote")]
#endif
        public string FxQuote { get; set; }

        [JsonProperty("hooks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hooks")]
#endif
        public PaymentIntentHooks Hooks { get; set; }

        /// <summary>
        /// The payment error encountered in the previous PaymentIntent confirmation. It will be
        /// cleared if the PaymentIntent is later updated for any reason.
        /// </summary>
        [JsonProperty("last_payment_error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_payment_error")]
#endif
        public StripeError LastPaymentError { get; set; }

        #region Expandable LatestCharge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the latest <a href="https://docs.stripe.com/api/charges">Charge object</a> created
        /// by this PaymentIntent. This property is <c>null</c> until PaymentIntent confirmation is
        /// attempted.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string LatestChargeId
        {
            get => this.InternalLatestCharge?.Id;
            set => this.InternalLatestCharge = SetExpandableFieldId(value, this.InternalLatestCharge);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the latest <a href="https://docs.stripe.com/api/charges">Charge object</a> created
        /// by this PaymentIntent. This property is <c>null</c> until PaymentIntent confirmation is
        /// attempted.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Charge LatestCharge
        {
            get => this.InternalLatestCharge?.ExpandedObject;
            set => this.InternalLatestCharge = SetExpandableFieldObject(value, this.InternalLatestCharge);
        }

        [JsonProperty("latest_charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_charge")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
#endif
        internal ExpandableField<Charge> InternalLatestCharge { get; set; }
        #endregion

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Learn more about <a
        /// href="https://docs.stripe.com/payments/payment-intents/creating-payment-intents#storing-information-in-metadata">storing
        /// information in metadata</a>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If present, this property tells you what actions you need to take in order for your
        /// customer to fulfill a payment using the provided source.
        /// </summary>
        [JsonProperty("next_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("next_action")]
#endif
        public PaymentIntentNextAction NextAction { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// You can specify the settlement merchant as the connected account using the
        /// <c>on_behalf_of</c> attribute on the charge. See the PaymentIntents <a
        /// href="https://stripe.com/payments/connected-accounts">use case for connected
        /// accounts</a> for details.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        /// <summary>
        /// (Expanded)
        /// You can specify the settlement merchant as the connected account using the
        /// <c>on_behalf_of</c> attribute on the charge. See the PaymentIntents <a
        /// href="https://stripe.com/payments/connected-accounts">use case for connected
        /// accounts</a> for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
#endif
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        [JsonProperty("payment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_details")]
#endif
        public PaymentIntentPaymentDetails PaymentDetails { get; set; }

        #region Expandable PaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the payment method used in this PaymentIntent.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the payment method used in this PaymentIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentMethod PaymentMethod
        {
            get => this.InternalPaymentMethod?.ExpandedObject;
            set => this.InternalPaymentMethod = SetExpandableFieldObject(value, this.InternalPaymentMethod);
        }

        [JsonProperty("payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentMethod>))]
#endif
        internal ExpandableField<PaymentMethod> InternalPaymentMethod { get; set; }
        #endregion

        /// <summary>
        /// Information about the <a
        /// href="https://docs.stripe.com/api/payment_method_configurations">payment method
        /// configuration</a> used for this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_configuration_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_configuration_details")]
#endif
        public PaymentIntentPaymentMethodConfigurationDetails PaymentMethodConfigurationDetails { get; set; }

        /// <summary>
        /// Payment-method-specific configuration for this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif
        public PaymentIntentPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) that this PaymentIntent is allowed to use.
        /// A comprehensive list of valid payment method types can be found <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-type">here</a>.
        /// </summary>
        [JsonProperty("payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_types")]
#endif
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// When you enable this parameter, this PaymentIntent will route your payment to processors
        /// that you configure in the dashboard.
        /// </summary>
        [JsonProperty("payments_orchestration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments_orchestration")]
#endif
        public PaymentIntentPaymentsOrchestration PaymentsOrchestration { get; set; }

        [JsonProperty("presentment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("presentment_details")]
#endif
        public PaymentIntentPresentmentDetails PresentmentDetails { get; set; }

        /// <summary>
        /// If present, this property tells you about the processing state of the payment.
        /// </summary>
        [JsonProperty("processing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("processing")]
#endif
        public PaymentIntentProcessing Processing { get; set; }

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

        #region Expandable Review

        /// <summary>
        /// (ID of the Review)
        /// ID of the review associated with this PaymentIntent, if any.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ReviewId
        {
            get => this.InternalReview?.Id;
            set => this.InternalReview = SetExpandableFieldId(value, this.InternalReview);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the review associated with this PaymentIntent, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Review Review
        {
            get => this.InternalReview?.ExpandedObject;
            set => this.InternalReview = SetExpandableFieldObject(value, this.InternalReview);
        }

        [JsonProperty("review")]
        [JsonConverter(typeof(ExpandableFieldConverter<Review>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("review")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Review>))]
#endif
        internal ExpandableField<Review> InternalReview { get; set; }
        #endregion

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
        public Shipping Shipping { get; set; }

        #region Expandable Source

        /// <summary>
        /// (ID of the IPaymentSource)
        /// This is a legacy field that will be removed in the future. It is the ID of the Source
        /// object that is associated with this PaymentIntent, if one was supplied.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SourceId
        {
            get => this.InternalSource?.Id;
            set => this.InternalSource = SetExpandableFieldId(value, this.InternalSource);
        }

        /// <summary>
        /// (Expanded)
        /// This is a legacy field that will be removed in the future. It is the ID of the Source
        /// object that is associated with this PaymentIntent, if one was supplied.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public IPaymentSource Source
        {
            get => this.InternalSource?.ExpandedObject;
            set => this.InternalSource = SetExpandableFieldObject(value, this.InternalSource);
        }

        [JsonProperty("source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<IPaymentSource>))]
#endif
        internal ExpandableField<IPaymentSource> InternalSource { get; set; }
        #endregion

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
        /// Status of this PaymentIntent, one of <c>requires_payment_method</c>,
        /// <c>requires_confirmation</c>, <c>requires_action</c>, <c>processing</c>,
        /// <c>requires_capture</c>, <c>canceled</c>, or <c>succeeded</c>. Read more about each
        /// PaymentIntent <a
        /// href="https://docs.stripe.com/payments/intents#intent-statuses">status</a>.
        /// One of: <c>canceled</c>, <c>processing</c>, <c>requires_action</c>,
        /// <c>requires_capture</c>, <c>requires_confirmation</c>, <c>requires_payment_method</c>,
        /// or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// The data that automatically creates a Transfer after the payment finalizes. Learn more
        /// about the <a href="https://docs.stripe.com/payments/connected-accounts">use case for
        /// connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public PaymentIntentTransferData TransferData { get; set; }

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
    }
}
