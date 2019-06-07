namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Charge : StripeEntity<Charge>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

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
        public string ApplicationId => this.InternalApplication.Id;

        [JsonIgnore]
        public Application Application => this.InternalApplication.ExpandedObject;

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        #region Expandable Application Fee
        [JsonIgnore]
        public string ApplicationFeeId => this.InternalApplicationFee.Id;

        /// <summary>
        /// The application fee (if any) for the charge. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public ApplicationFee ApplicationFee => this.InternalApplicationFee.ExpandedObject;

        [JsonProperty("application_fee")]
        [JsonConverter(typeof(ExpandableFieldConverter<ApplicationFee>))]
        internal ExpandableField<ApplicationFee> InternalApplicationFee { get; set; }
        #endregion

        /// <summary>
        /// The amount of the application application fee (if any) for the charge. See the Connect documentation for details.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        #region Expandable Balance Transaction

        /// <summary>
        /// ID of the balance transaction that describes the impact of this charge on your account balance (not including refunds or disputes).
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId => this.InternalBalanceTransaction.Id;

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction => this.InternalBalanceTransaction.ExpandedObject;

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
        /// If the charge was created without capturing, this boolean represents whether or not it is still uncaptured or has since been captured.
        /// </summary>
        [JsonProperty("captured")]
        public bool? Captured { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
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
        public string CustomerId => this.InternalCustomer.Id;

        [JsonIgnore]
        public Customer Customer => this.InternalCustomer.ExpandedObject;

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination
        [JsonIgnore]
        public string DestinationId => this.InternalDestination.Id;

        /// <summary>
        /// The account (if any) the charge was made on behalf of, with an automatic transfer. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public Account Destination => this.InternalDestination.ExpandedObject;

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion

        #region Expandable Dispute
        [JsonIgnore]
        public string DisputeId => this.InternalDispute.Id;

        /// <summary>
        /// Details about the dispute if the charge has been disputed.
        /// </summary>
        [JsonIgnore]
        public Dispute Dispute => this.InternalDispute.ExpandedObject;

        [JsonProperty("dispute")]
        [JsonConverter(typeof(ExpandableFieldConverter<Dispute>))]
        internal ExpandableField<Dispute> InternalDispute { get; set; }
        #endregion

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
        /// Hash with information on fraud assessments for the charge. Assessments reported by you have the key user_report and, if set, possible values of safe and fraudulent. Assessments from Stripe have the key stripe_report and, if set, the value fraudulent.
        /// </summary>
        [JsonProperty("fraud_details")]
        public Dictionary<string, string> FraudDetails { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// ID of the invoice this charge is for if one exists.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId => this.InternalInvoice.Id;

        [JsonIgnore]
        public Invoice Invoice => this.InternalInvoice.ExpandedObject;

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for storing additional information about the charge in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable OnBehalfOf (Account)

        /// <summary>
        /// The account (if any) the charge was made on behalf of without triggering an automatic transfer. See the Connect documentation for details.
        /// <para>To populate the OnBehalfOf entity, you need to set ExpandOnBehalfOf to true on your service before invoking a service method.</para>
        /// </summary>
        [JsonIgnore]
        public string OnBehalfOfId => this.InternalOnBehalfOf.Id;

        [JsonIgnore]
        public Account OnBehalfOf => this.InternalOnBehalfOf.ExpandedObject;

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        #region Expandable Order

        /// <summary>
        /// ID of the order this charge is for if one exists.
        /// </summary>
        [JsonIgnore]
        public string OrderId => this.InternalOrder.Id;

        [JsonIgnore]
        public Order Order => this.InternalOrder.ExpandedObject;

        [JsonProperty("order")]
        [JsonConverter(typeof(ExpandableFieldConverter<Order>))]
        internal ExpandableField<Order> InternalOrder { get; set; }
        #endregion

        /// <summary>
        /// Details about the level III data associated with the Charge.
        /// This is a gated property and most integrations can not access it.
        /// </summary>
        [JsonProperty("level3")]
        public ChargeLevel3 Level3 { get; set; }

        /// <summary>
        /// Details about whether the payment was accepted, and why.
        /// </summary>
        [JsonProperty("outcome")]
        public Outcome Outcome { get; set; }

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
        public string PaymentIntentId => this.InternalPaymentIntent.Id;

        [JsonIgnore]
        public PaymentIntent PaymentIntent => this.InternalPaymentIntent.ExpandedObject;

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        /// <summary>
        /// ID of the PaymentMethod associated with this charge.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethodId { get; set; }

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
        public string ReviewId => this.InternalReview.Id;

        [JsonIgnore]
        public Review Review => this.InternalReview.ExpandedObject;

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

        #region Expandable Transfer

        /// <summary>
        /// The transfer ID which created this charge. Only present if the charge came from another Stripe account. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public string SourceTransferId => this.InternalSourceTransfer.Id;

        [JsonIgnore]
        public Transfer SourceTransfer => this.InternalSourceTransfer.ExpandedObject;

        [JsonProperty("source_transfer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transfer>))]
        internal ExpandableField<Transfer> InternalSourceTransfer { get; set; }
        #endregion

        /// <summary>
        /// Extra information about a charge. This will appear on your customer’s credit card statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The status of the payment is either succeeded, pending, or failed
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable Transfer

        /// <summary>
        /// ID of the transfer to the destination account (only applicable if the charge was created using the destination parameter).
        /// </summary>
        [JsonIgnore]
        public string TransferId => this.InternalTransfer.Id;

        [JsonIgnore]
        public Transfer Transfer => this.InternalTransfer.ExpandedObject;

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

        // The properties below are for internal use only and not returned as part of standard API requests.
        [JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }
    }
}
