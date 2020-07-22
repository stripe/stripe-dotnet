namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Charge : StripeEntity<Charge>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a 0-decimal currency) representing how much to charge. The minimum amount is $0.50 US or equivalent in charge currency.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Amount in cents refunded (can be less than the amount attribute on the charge if a partial refund was issued).
        /// </summary>
        [JsonProperty("amount_refunded")]
        public long AmountRefunded { get; set; }

        #region Expandable Application

        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        [JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        #region Expandable ApplicationFee

        [JsonIgnore]
        public string ApplicationFeeId
        {
            get => this.InternalApplicationFee?.Id;
            set => this.InternalApplicationFee = SetExpandableFieldId(value, this.InternalApplicationFee);
        }

        /// <summary>
        /// The application fee (if any) for the charge. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public ApplicationFee ApplicationFee
        {
            get => this.InternalApplicationFee?.ExpandedObject;
            set => this.InternalApplicationFee = SetExpandableFieldObject(value, this.InternalApplicationFee);
        }

        [JsonProperty("application_fee")]
        [JsonConverter(typeof(ExpandableFieldConverter<ApplicationFee>))]
        internal ExpandableField<ApplicationFee> InternalApplicationFee { get; set; }
        #endregion

        /// <summary>
        /// The amount of the application application fee (if any) for the charge. See the Connect documentation for details.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Authorization code on the charge. This property is not returned as part of standard API
        /// requests.
        /// </summary>
        [JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// ID of the balance transaction that describes the impact of this charge on your account balance (not including refunds or disputes).
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// Billing details of the payment method used in the payment.
        /// </summary>
        [JsonProperty("billing_details")]
        public BillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The full statement descriptor that is passed to card networks, and that is displayed on
        /// your customers' credit card and bank statements. Allows you to see what the statement
        /// descriptor looks like after the static and dynamic portions are combined.
        /// </summary>
        [JsonProperty("calculated_statement_descriptor")]
        public string CalculatedStatementDescriptor { get; set; }

        /// <summary>
        /// If the charge was created without capturing, this boolean represents whether or not it is still uncaptured or has since been captured.
        /// </summary>
        [JsonProperty("captured")]
        public bool Captured { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code representing the currency in which the charge was made.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// ID of the customer this charge is for if one exists.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination

        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// The account (if any) the charge was made on behalf of, with an automatic transfer. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public Account Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion

        #region Expandable Dispute

        [JsonIgnore]
        public string DisputeId
        {
            get => this.InternalDispute?.Id;
            set => this.InternalDispute = SetExpandableFieldId(value, this.InternalDispute);
        }

        /// <summary>
        /// Details about the dispute if the charge has been disputed.
        /// </summary>
        [JsonIgnore]
        public Dispute Dispute
        {
            get => this.InternalDispute?.ExpandedObject;
            set => this.InternalDispute = SetExpandableFieldObject(value, this.InternalDispute);
        }

        [JsonProperty("dispute")]
        [JsonConverter(typeof(ExpandableFieldConverter<Dispute>))]
        internal ExpandableField<Dispute> InternalDispute { get; set; }
        #endregion

        /// <summary>
        /// Whether the charge has been disputed. More than one dispute may exist on this charge.
        /// </summary>
        [JsonProperty("disputed")]
        public bool Disputed { get; set; }

        /// <summary>
        /// Error code explaining reason for charge failure if available (see the errors section for a list of codes).
        /// </summary>
        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// Message to user further explaining reason for charge failure if available.
        /// </summary>
        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Information on fraud assessments for the charge.
        /// </summary>
        [JsonProperty("fraud_details")]
        public ChargeFraudDetails FraudDetails { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// ID of the invoice this charge is for if one exists.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        [JsonIgnore]
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// Details about the level III data associated with the Charge.
        /// This is a gated property and most integrations can not access it.
        /// </summary>
        [JsonProperty("level3")]
        public ChargeLevel3 Level3 { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for storing additional information about the charge in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// The account (if any) the charge was made on behalf of without triggering an automatic transfer. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        [JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        #region Expandable Order

        /// <summary>
        /// ID of the order this charge is for if one exists.
        /// </summary>
        [JsonIgnore]
        public string OrderId
        {
            get => this.InternalOrder?.Id;
            set => this.InternalOrder = SetExpandableFieldId(value, this.InternalOrder);
        }

        [JsonIgnore]
        public Order Order
        {
            get => this.InternalOrder?.ExpandedObject;
            set => this.InternalOrder = SetExpandableFieldObject(value, this.InternalOrder);
        }

        [JsonProperty("order")]
        [JsonConverter(typeof(ExpandableFieldConverter<Order>))]
        internal ExpandableField<Order> InternalOrder { get; set; }
        #endregion

        /// <summary>
        /// Details about whether the payment was accepted, and why.
        /// </summary>
        [JsonProperty("outcome")]
        public ChargeOutcome Outcome { get; set; }

        /// <summary>
        /// true if the charge succeeded, or was successfully authorized for later capture.
        /// </summary>
        [JsonProperty("paid")]
        public bool Paid { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// ID of the payment intent this charge is for if one exists.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        [JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        /// <summary>
        /// ID of the PaymentMethod associated with this charge.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Transaction-specific details of the payment method used in the payment.
        /// </summary>
        [JsonProperty("payment_method_details")]
        public ChargePaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// This is the email address that the receipt for this charge was sent to.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// This is the transaction number that appears on email receipts sent for this charge.
        /// </summary>
        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// This is the URL to view the receipt for this charge. The receipt is kept up-to-date to
        /// the latest state of the charge, including any refunds. If the charge is for an Invoice,
        /// the receipt will be stylized as an Invoice receipt.
        /// </summary>
        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// Whether or not the charge has been fully refunded. If the charge is only partially
        /// refunded, this attribute will still be false.
        /// </summary>
        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        /// <summary>
        /// A list of refunds that have been applied to the charge.
        /// </summary>
        [JsonProperty("refunds")]
        public StripeList<Refund> Refunds { get; set; }

        #region Expandable Review

        /// <summary>
        /// ID of the review associated with this charge if one exists.
        /// </summary>
        [JsonIgnore]
        public string ReviewId
        {
            get => this.InternalReview?.Id;
            set => this.InternalReview = SetExpandableFieldId(value, this.InternalReview);
        }

        [JsonIgnore]
        public Review Review
        {
            get => this.InternalReview?.ExpandedObject;
            set => this.InternalReview = SetExpandableFieldObject(value, this.InternalReview);
        }

        [JsonProperty("review")]
        [JsonConverter(typeof(ExpandableFieldConverter<Review>))]
        internal ExpandableField<Review> InternalReview { get; set; }
        #endregion

        /// <summary>
        /// Shipping information for the charge.
        /// </summary>
        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// For most Stripe users, the source of every charge is a credit or debit card. This hash is then the card object describing that card.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(StripeObjectConverter))]
        public IPaymentSource Source { get; set; }

        #region Expandable SourceTransfer

        /// <summary>
        /// The transfer ID which created this charge. Only present if the charge came from another Stripe account. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public string SourceTransferId
        {
            get => this.InternalSourceTransfer?.Id;
            set => this.InternalSourceTransfer = SetExpandableFieldId(value, this.InternalSourceTransfer);
        }

        [JsonIgnore]
        public Transfer SourceTransfer
        {
            get => this.InternalSourceTransfer?.ExpandedObject;
            set => this.InternalSourceTransfer = SetExpandableFieldObject(value, this.InternalSourceTransfer);
        }

        [JsonProperty("source_transfer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transfer>))]
        internal ExpandableField<Transfer> InternalSourceTransfer { get; set; }
        #endregion

        /// <summary>
        /// Extra information about a charge. This will appear on your customer's credit card statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about the charge that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that's set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The status of the payment is either <c>succeeded</c>, <c>pending</c>, or <c>failed</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable Transfer

        /// <summary>
        /// ID of the transfer to the destination account (only applicable if the charge was created using the destination parameter).
        /// </summary>
        [JsonIgnore]
        public string TransferId
        {
            get => this.InternalTransfer?.Id;
            set => this.InternalTransfer = SetExpandableFieldId(value, this.InternalTransfer);
        }

        [JsonIgnore]
        public Transfer Transfer
        {
            get => this.InternalTransfer?.ExpandedObject;
            set => this.InternalTransfer = SetExpandableFieldObject(value, this.InternalTransfer);
        }

        [JsonProperty("transfer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transfer>))]
        internal ExpandableField<Transfer> InternalTransfer { get; set; }
        #endregion

        [JsonProperty("transfer_data")]
        public ChargeTransferData TransferData { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the Connect documentation for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
