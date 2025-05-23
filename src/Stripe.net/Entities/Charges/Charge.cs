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
    /// The <c>Charge</c> object represents a single attempt to move money into your Stripe
    /// account. PaymentIntent confirmation is the most common way to create Charges, but
    /// transferring money to a different Stripe account through Connect also creates Charges.
    /// Some legacy payment flows create Charges directly, which is not recommended for new
    /// integrations.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Charge : StripeEntity<Charge>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Amount intended to be collected by this payment. A positive integer representing how
        /// much to charge in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest
        /// currency unit</a> (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal
        /// currency). The minimum amount is $0.50 US or <a
        /// href="https://stripe.com/docs/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Amount in cents (or local equivalent) captured (can be less than the amount attribute on
        /// the charge if a partial capture was made).
        /// </summary>
        [JsonProperty("amount_captured")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_captured")]
#endif
        public long AmountCaptured { get; set; }

        /// <summary>
        /// Amount in cents (or local equivalent) refunded (can be less than the amount attribute on
        /// the charge if a partial refund was issued).
        /// </summary>
        [JsonProperty("amount_refunded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_refunded")]
#endif
        public long AmountRefunded { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect application that created the charge.
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
        /// ID of the Connect application that created the charge.
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

        #region Expandable ApplicationFee

        /// <summary>
        /// (ID of the ApplicationFee)
        /// The application fee (if any) for the charge. <a
        /// href="https://stripe.com/docs/connect/direct-charges#collect-fees">See the Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ApplicationFeeId
        {
            get => this.InternalApplicationFee?.Id;
            set => this.InternalApplicationFee = SetExpandableFieldId(value, this.InternalApplicationFee);
        }

        /// <summary>
        /// (Expanded)
        /// The application fee (if any) for the charge. <a
        /// href="https://stripe.com/docs/connect/direct-charges#collect-fees">See the Connect
        /// documentation</a> for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public ApplicationFee ApplicationFee
        {
            get => this.InternalApplicationFee?.ExpandedObject;
            set => this.InternalApplicationFee = SetExpandableFieldObject(value, this.InternalApplicationFee);
        }

        [JsonProperty("application_fee")]
        [JsonConverter(typeof(ExpandableFieldConverter<ApplicationFee>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<ApplicationFee>))]
#endif
        internal ExpandableField<ApplicationFee> InternalApplicationFee { get; set; }
        #endregion

        /// <summary>
        /// The amount of the application fee (if any) requested for the charge. <a
        /// href="https://stripe.com/docs/connect/direct-charges#collect-fees">See the Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonProperty("application_fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_amount")]
#endif
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Authorization code on the charge.
        /// </summary>
        [JsonProperty("authorization_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_code")]
#endif
        public string AuthorizationCode { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// ID of the balance transaction that describes the impact of this charge on your account
        /// balance (not including refunds or disputes).
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the balance transaction that describes the impact of this charge on your account
        /// balance (not including refunds or disputes).
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BalanceTransaction>))]
#endif
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public ChargeBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The full statement descriptor that is passed to card networks, and that is displayed on
        /// your customers' credit card and bank statements. Allows you to see what the statement
        /// descriptor looks like after the static and dynamic portions are combined. This value
        /// only exists for card payments.
        /// </summary>
        [JsonProperty("calculated_statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("calculated_statement_descriptor")]
#endif
        public string CalculatedStatementDescriptor { get; set; }

        /// <summary>
        /// If the charge was created without capturing, this Boolean represents whether it is still
        /// uncaptured or has since been captured.
        /// </summary>
        [JsonProperty("captured")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("captured")]
#endif
        public bool Captured { get; set; }

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
        /// ID of the customer this charge is for if one exists.
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
        /// ID of the customer this charge is for if one exists.
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
        /// Whether the charge has been disputed.
        /// </summary>
        [JsonProperty("disputed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disputed")]
#endif
        public bool Disputed { get; set; }

        #region Expandable FailureBalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// ID of the balance transaction that describes the reversal of the balance on your account
        /// due to payment failure.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string FailureBalanceTransactionId
        {
            get => this.InternalFailureBalanceTransaction?.Id;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldId(value, this.InternalFailureBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the balance transaction that describes the reversal of the balance on your account
        /// due to payment failure.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public BalanceTransaction FailureBalanceTransaction
        {
            get => this.InternalFailureBalanceTransaction?.ExpandedObject;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldObject(value, this.InternalFailureBalanceTransaction);
        }

        [JsonProperty("failure_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BalanceTransaction>))]
#endif
        internal ExpandableField<BalanceTransaction> InternalFailureBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// Error code explaining reason for charge failure if available (see <a
        /// href="https://stripe.com/docs/error-codes">the errors section</a> for a list of codes).
        /// </summary>
        [JsonProperty("failure_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_code")]
#endif
        public string FailureCode { get; set; }

        /// <summary>
        /// Message to user further explaining reason for charge failure if available.
        /// </summary>
        [JsonProperty("failure_message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_message")]
#endif
        public string FailureMessage { get; set; }

        /// <summary>
        /// Information on fraud assessments for the charge.
        /// </summary>
        [JsonProperty("fraud_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fraud_details")]
#endif
        public ChargeFraudDetails FraudDetails { get; set; }

        [JsonProperty("level3")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("level3")]
#endif
        public ChargeLevel3 Level3 { get; set; }

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
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account (if any) the charge was made on behalf of without triggering an automatic
        /// transfer. See the <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers">Connect
        /// documentation</a> for details.
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
        /// The account (if any) the charge was made on behalf of without triggering an automatic
        /// transfer. See the <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers">Connect
        /// documentation</a> for details.
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

        /// <summary>
        /// Details about whether the payment was accepted, and why. See <a
        /// href="https://stripe.com/docs/declines">understanding declines</a> for details.
        /// </summary>
        [JsonProperty("outcome")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outcome")]
#endif
        public ChargeOutcome Outcome { get; set; }

        /// <summary>
        /// <c>true</c> if the charge succeeded, or was successfully authorized for later capture.
        /// </summary>
        [JsonProperty("paid")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paid")]
#endif
        public bool Paid { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// ID of the PaymentIntent associated with this charge, if one exists.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the PaymentIntent associated with this charge, if one exists.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
#endif
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        /// <summary>
        /// ID of the payment method used in this charge.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Details about the payment method at the time of the transaction.
        /// </summary>
        [JsonProperty("payment_method_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_details")]
#endif
        public ChargePaymentMethodDetails PaymentMethodDetails { get; set; }

        [JsonProperty("presentment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("presentment_details")]
#endif
        public ChargePresentmentDetails PresentmentDetails { get; set; }

        /// <summary>
        /// Options to configure Radar. See <a
        /// href="https://stripe.com/docs/radar/radar-session">Radar Session</a> for more
        /// information.
        /// </summary>
        [JsonProperty("radar_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("radar_options")]
#endif
        public ChargeRadarOptions RadarOptions { get; set; }

        /// <summary>
        /// This is the email address that the receipt for this charge was sent to.
        /// </summary>
        [JsonProperty("receipt_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_email")]
#endif
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// This is the transaction number that appears on email receipts sent for this charge. This
        /// attribute will be <c>null</c> until a receipt has been sent.
        /// </summary>
        [JsonProperty("receipt_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_number")]
#endif
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// This is the URL to view the receipt for this charge. The receipt is kept up-to-date to
        /// the latest state of the charge, including any refunds. If the charge is for an Invoice,
        /// the receipt will be stylized as an Invoice receipt.
        /// </summary>
        [JsonProperty("receipt_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_url")]
#endif
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// Whether the charge has been fully refunded. If the charge is only partially refunded,
        /// this attribute will still be false.
        /// </summary>
        [JsonProperty("refunded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refunded")]
#endif
        public bool Refunded { get; set; }

        /// <summary>
        /// A list of refunds that have been applied to the charge.
        /// </summary>
        [JsonProperty("refunds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refunds")]
#endif
        public StripeList<Refund> Refunds { get; set; }

        #region Expandable Review

        /// <summary>
        /// (ID of the Review)
        /// ID of the review associated with this charge if one exists.
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
        /// ID of the review associated with this charge if one exists.
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
        /// Shipping information for the charge.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public Shipping Shipping { get; set; }

        /// <summary>
        /// This is a legacy field that will be removed in the future. It contains the Source, Card,
        /// or BankAccount object used for the charge. For details about the payment method used for
        /// this charge, refer to <c>payment_method</c> or <c>payment_method_details</c> instead.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(StripeObjectConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
#endif
        public IPaymentSource Source { get; set; }

        #region Expandable SourceTransfer

        /// <summary>
        /// (ID of the Transfer)
        /// The transfer ID which created this charge. Only present if the charge came from another
        /// Stripe account. <a href="https://docs.stripe.com/connect/destination-charges">See the
        /// Connect documentation</a> for details.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SourceTransferId
        {
            get => this.InternalSourceTransfer?.Id;
            set => this.InternalSourceTransfer = SetExpandableFieldId(value, this.InternalSourceTransfer);
        }

        /// <summary>
        /// (Expanded)
        /// The transfer ID which created this charge. Only present if the charge came from another
        /// Stripe account. <a href="https://docs.stripe.com/connect/destination-charges">See the
        /// Connect documentation</a> for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Transfer SourceTransfer
        {
            get => this.InternalSourceTransfer?.ExpandedObject;
            set => this.InternalSourceTransfer = SetExpandableFieldObject(value, this.InternalSourceTransfer);
        }

        [JsonProperty("source_transfer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transfer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_transfer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Transfer>))]
#endif
        internal ExpandableField<Transfer> InternalSourceTransfer { get; set; }
        #endregion

        /// <summary>
        /// For a non-card charge, text that appears on the customer's statement as the statement
        /// descriptor. This value overrides the account's default statement descriptor. For
        /// information about requirements, including the 22-character limit, see <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">the Statement
        /// Descriptor docs</a>.
        ///
        /// For a card charge, this value is ignored unless you don't specify a
        /// <c>statement_descriptor_suffix</c>, in which case this value is used as the suffix.
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
        /// customer's statement. If the account has no prefix value, the suffix is concatenated to
        /// the account's statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
#endif
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The status of the payment is either <c>succeeded</c>, <c>pending</c>, or <c>failed</c>.
        /// One of: <c>failed</c>, <c>pending</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        #region Expandable Transfer

        /// <summary>
        /// (ID of the Transfer)
        /// ID of the transfer to the <c>destination</c> account (only applicable if the charge was
        /// created using the <c>destination</c> parameter).
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string TransferId
        {
            get => this.InternalTransfer?.Id;
            set => this.InternalTransfer = SetExpandableFieldId(value, this.InternalTransfer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the transfer to the <c>destination</c> account (only applicable if the charge was
        /// created using the <c>destination</c> parameter).
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Transfer Transfer
        {
            get => this.InternalTransfer?.ExpandedObject;
            set => this.InternalTransfer = SetExpandableFieldObject(value, this.InternalTransfer);
        }

        [JsonProperty("transfer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transfer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Transfer>))]
#endif
        internal ExpandableField<Transfer> InternalTransfer { get; set; }
        #endregion

        /// <summary>
        /// An optional dictionary including the account to automatically transfer to as part of a
        /// destination charge. <a href="https://stripe.com/docs/connect/destination-charges">See
        /// the Connect documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public ChargeTransferData TransferData { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers#transfer-options">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_group")]
#endif
        public string TransferGroup { get; set; }
    }
}
