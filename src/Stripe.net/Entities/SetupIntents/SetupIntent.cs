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
    /// A SetupIntent guides you through the process of setting up and saving a customer's
    /// payment credentials for future payments. For example, you can use a SetupIntent to set
    /// up and save your customer's card without immediately collecting a payment. Later, you
    /// can use <a href="https://stripe.com/docs/api#payment_intents">PaymentIntents</a> to
    /// drive the payment flow.
    ///
    /// Create a SetupIntent when you're ready to collect your customer's payment credentials.
    /// Don't maintain long-lived, unconfirmed SetupIntents because they might not be valid. The
    /// SetupIntent transitions through multiple <a
    /// href="https://docs.stripe.com/payments/intents#intent-statuses">statuses</a> as it
    /// guides you through the setup process.
    ///
    /// Successful SetupIntents result in payment credentials that are optimized for future
    /// payments. For example, cardholders in <a
    /// href="https://stripe.com/guides/strong-customer-authentication">certain regions</a>
    /// might need to be run through <a
    /// href="https://docs.stripe.com/strong-customer-authentication">Strong Customer
    /// Authentication</a> during payment method collection to streamline later <a
    /// href="https://docs.stripe.com/payments/setup-intents">off-session payments</a>. If you
    /// use the SetupIntent with a <a
    /// href="https://stripe.com/docs/api#setup_intent_object-customer">Customer</a>, it
    /// automatically attaches the resulting payment method to that Customer after successful
    /// setup. We recommend using SetupIntents or <a
    /// href="https://stripe.com/docs/api#payment_intent_object-setup_future_usage">setup_future_usage</a>
    /// on PaymentIntents to save payment methods to prevent saving invalid or unoptimized
    /// payment methods.
    ///
    /// By using SetupIntents, you can reduce friction for your customers, even as regulations
    /// change over time.
    ///
    /// Related guide: <a href="https://docs.stripe.com/payments/setup-intents">Setup Intents
    /// API</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class SetupIntent : StripeEntity<SetupIntent>, IHasId, IHasMetadata, IHasObject
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

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect application that created the SetupIntent.
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
        /// ID of the Connect application that created the SetupIntent.
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
        /// If present, the SetupIntent's payment method will be attached to the in-context Stripe
        /// Account.
        ///
        /// It can only be used for this Stripe Account’s own money movement flows like
        /// InboundTransfer and OutboundTransfers. It cannot be set to true when setting up a
        /// PaymentMethod for a Customer, and defaults to false when attaching a PaymentMethod to a
        /// Customer.
        /// </summary>
        [JsonProperty("attach_to_self")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("attach_to_self")]
#endif
        public bool AttachToSelf { get; set; }

        /// <summary>
        /// Settings for dynamic payment methods compatible with this Setup Intent.
        /// </summary>
        [JsonProperty("automatic_payment_methods")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_payment_methods")]
#endif
        public SetupIntentAutomaticPaymentMethods AutomaticPaymentMethods { get; set; }

        /// <summary>
        /// Reason for cancellation of this SetupIntent, one of <c>abandoned</c>,
        /// <c>requested_by_customer</c>, or <c>duplicate</c>.
        /// One of: <c>abandoned</c>, <c>duplicate</c>, or <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_reason")]
#endif
        public string CancellationReason { get; set; }

        /// <summary>
        /// The client secret of this SetupIntent. Used for client-side retrieval using a
        /// publishable key.
        ///
        /// The client secret can be used to complete payment setup from your frontend. It should
        /// not be stored, logged, or exposed to anyone other than the customer. Make sure that you
        /// have TLS enabled on any page that includes the client secret.
        /// </summary>
        [JsonProperty("client_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_secret")]
#endif
        public string ClientSecret { get; set; }

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

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the Customer this SetupIntent belongs to, if one exists.
        ///
        /// If present, the SetupIntent's payment method will be attached to the Customer on
        /// successful setup. Payment methods attached to other Customers cannot be used with this
        /// SetupIntent.
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
        /// ID of the Customer this SetupIntent belongs to, if one exists.
        ///
        /// If present, the SetupIntent's payment method will be attached to the Customer on
        /// successful setup. Payment methods attached to other Customers cannot be used with this
        /// SetupIntent.
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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Payment method types that are excluded from this SetupIntent.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>billie</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>cashapp</c>, <c>crypto</c>, <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>,
        /// <c>giropay</c>, <c>grabpay</c>, <c>ideal</c>, <c>kakao_pay</c>, <c>klarna</c>,
        /// <c>konbini</c>, <c>kr_card</c>, <c>mb_way</c>, <c>mobilepay</c>, <c>multibanco</c>,
        /// <c>naver_pay</c>, <c>nz_bank_account</c>, <c>oxxo</c>, <c>p24</c>, <c>pay_by_bank</c>,
        /// <c>payco</c>, <c>paynow</c>, <c>paypal</c>, <c>pix</c>, <c>promptpay</c>,
        /// <c>revolut_pay</c>, <c>samsung_pay</c>, <c>satispay</c>, <c>sepa_debit</c>,
        /// <c>sofort</c>, <c>swish</c>, <c>twint</c>, <c>us_bank_account</c>, <c>wechat_pay</c>, or
        /// <c>zip</c>.
        /// </summary>
        [JsonProperty("excluded_payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("excluded_payment_method_types")]
#endif
        public List<string> ExcludedPaymentMethodTypes { get; set; }

        /// <summary>
        /// Indicates the directions of money movement for which this payment method is intended to
        /// be used.
        ///
        /// Include <c>inbound</c> if you intend to use the payment method as the origin to pull
        /// funds from. Include <c>outbound</c> if you intend to use the payment method as the
        /// destination to send funds to. You can include both if you intend to use the payment
        /// method for both purposes.
        /// One of: <c>inbound</c>, or <c>outbound</c>.
        /// </summary>
        [JsonProperty("flow_directions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow_directions")]
#endif
        public List<string> FlowDirections { get; set; }

        /// <summary>
        /// The error encountered in the previous SetupIntent confirmation.
        /// </summary>
        [JsonProperty("last_setup_error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_setup_error")]
#endif
        public StripeError LastSetupError { get; set; }

        #region Expandable LatestAttempt

        /// <summary>
        /// (ID of the SetupAttempt)
        /// The most recent SetupAttempt for this SetupIntent.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string LatestAttemptId
        {
            get => this.InternalLatestAttempt?.Id;
            set => this.InternalLatestAttempt = SetExpandableFieldId(value, this.InternalLatestAttempt);
        }

        /// <summary>
        /// (Expanded)
        /// The most recent SetupAttempt for this SetupIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public SetupAttempt LatestAttempt
        {
            get => this.InternalLatestAttempt?.ExpandedObject;
            set => this.InternalLatestAttempt = SetExpandableFieldObject(value, this.InternalLatestAttempt);
        }

        [JsonProperty("latest_attempt")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupAttempt>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_attempt")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<SetupAttempt>))]
#endif
        internal ExpandableField<SetupAttempt> InternalLatestAttempt { get; set; }
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

        #region Expandable Mandate

        /// <summary>
        /// (ID of the Mandate)
        /// ID of the multi use Mandate generated by the SetupIntent.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string MandateId
        {
            get => this.InternalMandate?.Id;
            set => this.InternalMandate = SetExpandableFieldId(value, this.InternalMandate);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the multi use Mandate generated by the SetupIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Mandate Mandate
        {
            get => this.InternalMandate?.ExpandedObject;
            set => this.InternalMandate = SetExpandableFieldObject(value, this.InternalMandate);
        }

        [JsonProperty("mandate")]
        [JsonConverter(typeof(ExpandableFieldConverter<Mandate>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Mandate>))]
#endif
        internal ExpandableField<Mandate> InternalMandate { get; set; }
        #endregion

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If present, this property tells you what actions you need to take in order for your
        /// customer to continue payment setup.
        /// </summary>
        [JsonProperty("next_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("next_action")]
#endif
        public SetupIntentNextAction NextAction { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account (if any) for which the setup is intended.
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
        /// The account (if any) for which the setup is intended.
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

        #region Expandable PaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the payment method used with this SetupIntent. If the payment method is
        /// <c>card_present</c> and isn't a digital wallet, then the <a
        /// href="https://docs.stripe.com/api/setup_attempts/object#setup_attempt_object-payment_method_details-card_present-generated_card">generated_card</a>
        /// associated with the <c>latest_attempt</c> is attached to the Customer instead.
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
        /// ID of the payment method used with this SetupIntent. If the payment method is
        /// <c>card_present</c> and isn't a digital wallet, then the <a
        /// href="https://docs.stripe.com/api/setup_attempts/object#setup_attempt_object-payment_method_details-card_present-generated_card">generated_card</a>
        /// associated with the <c>latest_attempt</c> is attached to the Customer instead.
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
        /// href="https://stripe.com/docs/api/payment_method_configurations">payment method
        /// configuration</a> used for this Setup Intent.
        /// </summary>
        [JsonProperty("payment_method_configuration_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_configuration_details")]
#endif
        public SetupIntentPaymentMethodConfigurationDetails PaymentMethodConfigurationDetails { get; set; }

        /// <summary>
        /// Payment method-specific configuration for this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif
        public SetupIntentPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) that this SetupIntent is allowed to set up.
        /// A list of valid payment method types can be found <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-type">here</a>.
        /// </summary>
        [JsonProperty("payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_types")]
#endif
        public List<string> PaymentMethodTypes { get; set; }

        #region Expandable SingleUseMandate

        /// <summary>
        /// (ID of the Mandate)
        /// ID of the single_use Mandate generated by the SetupIntent.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SingleUseMandateId
        {
            get => this.InternalSingleUseMandate?.Id;
            set => this.InternalSingleUseMandate = SetExpandableFieldId(value, this.InternalSingleUseMandate);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the single_use Mandate generated by the SetupIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Mandate SingleUseMandate
        {
            get => this.InternalSingleUseMandate?.ExpandedObject;
            set => this.InternalSingleUseMandate = SetExpandableFieldObject(value, this.InternalSingleUseMandate);
        }

        [JsonProperty("single_use_mandate")]
        [JsonConverter(typeof(ExpandableFieldConverter<Mandate>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("single_use_mandate")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Mandate>))]
#endif
        internal ExpandableField<Mandate> InternalSingleUseMandate { get; set; }
        #endregion

        /// <summary>
        /// <a href="https://stripe.com/docs/payments/intents#intent-statuses">Status</a> of this
        /// SetupIntent, one of <c>requires_payment_method</c>, <c>requires_confirmation</c>,
        /// <c>requires_action</c>, <c>processing</c>, <c>canceled</c>, or <c>succeeded</c>.
        /// One of: <c>canceled</c>, <c>processing</c>, <c>requires_action</c>,
        /// <c>requires_confirmation</c>, <c>requires_payment_method</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Indicates how the payment method is intended to be used in the future.
        ///
        /// Use <c>on_session</c> if you intend to only reuse the payment method when the customer
        /// is in your checkout flow. Use <c>off_session</c> if your customer may or may not be in
        /// your checkout flow. If not provided, this value defaults to <c>off_session</c>.
        /// </summary>
        [JsonProperty("usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage")]
#endif
        public string Usage { get; set; }
    }
}
