namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Charge : StripeEntity, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        public string ApplicationId { get; set; }

        [JsonIgnore]
        public Application Application { get; set; }

        [JsonProperty("application")]
        internal object InternalApplication
        {
            set
            {
                StringOrObject<Application>.Map(value, s => this.ApplicationId = s, o => this.Application = o);
            }
        }
        #endregion

        #region Expandable Application Fee
        public string ApplicationFeeId { get; set; }

        /// <summary>
        /// The application fee (if any) for the charge. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public ApplicationFee ApplicationFee { get; set; }

        [JsonProperty("application_fee")]
        internal object InternalApplicationFee
        {
            set
            {
                StringOrObject<ApplicationFee>.Map(value, s => this.ApplicationFeeId = s, o => this.ApplicationFee = o);
            }
        }
        #endregion

        #region Expandable Balance Transaction

        /// <summary>
        /// ID of the balance transaction that describes the impact of this charge on your account balance (not including refunds or disputes).
        /// </summary>
        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            set
            {
                StringOrObject<BalanceTransaction>.Map(value, s => this.BalanceTransactionId = s, o => this.BalanceTransaction = o);
            }
        }
        #endregion

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
        public string CustomerId { get; set; }

        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                StringOrObject<Customer>.Map(value, s => this.CustomerId = s, o => this.Customer = o);
            }
        }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination
        public string DestinationId { get; set; }

        /// <summary>
        /// The account (if any) the charge was made on behalf of, with an automatic transfer. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public Account Destination { get; set; }

        [JsonProperty("destination")]
        internal object InternalDestination
        {
            set
            {
                StringOrObject<Account>.Map(value, s => this.DestinationId = s, o => this.Destination = o);
            }
        }
        #endregion

        #region Expandable Dispute
        public string DisputeId { get; set; }

        /// <summary>
        /// Details about the dispute if the charge has been disputed.
        /// </summary>
        [JsonIgnore]
        public Dispute Dispute { get; set; }

        [JsonProperty("dispute")]
        internal object InternalDispute
        {
            set
            {
                StringOrObject<Dispute>.Map(value, s => this.DisputeId = s, o => this.Dispute = o);
            }
        }
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
        public string InvoiceId { get; set; }

        [JsonIgnore]
        public Invoice Invoice { get; set; }

        [JsonProperty("invoice")]
        internal object InternalInvoice
        {
            set
            {
                StringOrObject<Invoice>.Map(value, s => this.InvoiceId = s, o => this.Invoice = o);
            }
        }
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
        public string OnBehalfOfId { get; set; }

        [JsonIgnore]
        public Account OnBehalfOf { get; set; }

        [JsonProperty("on_behalf_of")]
        internal object InternalOnBehalfOf
        {
            set
            {
                StringOrObject<Account>.Map(value, s => this.OnBehalfOfId = s, o => this.OnBehalfOf = o);
            }
        }
        #endregion

        #region Expandable Order

        /// <summary>
        /// ID of the order this charge is for if one exists.
        /// </summary>
        public string OrderId { get; set; }

        [JsonIgnore]
        public Order Order { get; set; }

        [JsonProperty("order")]
        internal object InternalOrder
        {
            set
            {
                StringOrObject<Order>.Map(value, s => this.OrderId = s, o => this.Order = o);
            }
        }
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
        public string PaymentIntentId { get; set; }

        [JsonIgnore]
        public PaymentIntent PaymentIntent { get; set; }

        [JsonProperty("payment_intent")]
        internal object InternalPaymentIntent
        {
            set
            {
                StringOrObject<PaymentIntent>.Map(value, s => this.PaymentIntentId = s, o => this.PaymentIntent = o);
            }
        }
        #endregion

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
        /// Whether or not the charge has been fully refunded. If the charge is only partially refunded, this attribute will still be false.
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
        public string ReviewId { get; set; }

        [JsonIgnore]
        public Review Review { get; set; }

        [JsonProperty("review")]
        internal object InternalReview
        {
            set
            {
                StringOrObject<Review>.Map(value, s => this.ReviewId = s, o => this.Review = o);
            }
        }
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
        [JsonConverter(typeof(PaymentSourceConverter))]
        public IPaymentSource Source { get; set; }

        #region Expandable Transfer

        /// <summary>
        /// The transfer ID which created this charge. Only present if the charge came from another Stripe account. See the Connect documentation for details.
        /// </summary>
        public string SourceTransferId { get; set; }

        [JsonIgnore]
        public Transfer SourceTransfer { get; set; }

        [JsonProperty("source_transfer")]
        internal object InternalSourceTransfer
        {
            set
            {
                StringOrObject<Transfer>.Map(value, s => this.SourceTransferId = s, o => this.SourceTransfer = o);
            }
        }
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
        public string TransferId { get; set; }

        [JsonIgnore]
        public Transfer Transfer { get; set; }

        [JsonProperty("transfer")]
        internal object InternalTransfer
        {
            set
            {
                StringOrObject<Transfer>.Map(value, s => this.TransferId = s, o => this.Transfer = o);
            }
        }
        #endregion

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
