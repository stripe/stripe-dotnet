using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCharge : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a 0-decimal currency) representing how much to charge. The minimum amount is $0.50 US or equivalent in charge currency.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Amount in cents refunded (can be less than the amount attribute on the charge if a partial refund was issued).
        /// </summary>
        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }

        // application

        #region Expandable Application Fee
        public string ApplicationFeeId { get; set; }

        /// <summary>
        /// The application fee (if any) for the charge. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public StripeApplicationFee ApplicationFee { get; set; }

        [JsonProperty("application_fee")]
        internal object InternalApplicationFee
        {
            set
            {
                StringOrObject<StripeApplicationFee>.Map(value, s => ApplicationFeeId = s, o => ApplicationFee = o);
            }
        }
        #endregion

        #region Expandable Balance Transaction
        /// <summary>
        /// ID of the balance transaction that describes the impact of this charge on your account balance (not including refunds or disputes).
        /// </summary>
        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public StripeBalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            set
            {
                StringOrObject<StripeBalanceTransaction>.Map(value, s => BalanceTransactionId = s, o => BalanceTransaction = o);
            }
        }
        #endregion

        /// <summary>
        /// If the charge was created without capturing, this boolean represents whether or not it is still uncaptured or has since been captured.
        /// </summary>
        [JsonProperty("captured")]
        public bool? Captured { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
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
        public StripeCustomer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                StringOrObject<StripeCustomer>.Map(value, s => CustomerId = s, o => Customer = o);
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
        public StripeAccount Destination { get; set; }

        [JsonProperty("destination")]
        internal object InternalDestination
        {
            set
            {
                StringOrObject<StripeAccount>.Map(value, s => DestinationId = s, o => Destination = o);
            }
        }
        #endregion


        #region Expandable Dispute
        public string DisputeId { get; set; }

        /// <summary>
        /// Details about the dispute if the charge has been disputed.
        /// </summary>
        [JsonIgnore]
        public StripeDispute Dispute { get; set; }

        [JsonProperty("dispute")]
        internal object InternalDispute
        {
            set
            {
                StringOrObject<StripeDispute>.Map(value, s => DisputeId = s, o => Dispute = o);
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
        public StripeInvoice Invoice { get; set; }

        [JsonProperty("invoice")]
        internal object InternalInvoice
        {
            set
            {
                StringOrObject<StripeInvoice>.Map(value, s => InvoiceId = s, o => Invoice = o);
            }
        }
        #endregion

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

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
        public StripeAccount OnBehalfOf { get; set; }

        [JsonProperty("on_behalf_of")]
        internal object InternalOnBehalfOf
        {
            set
            {
                StringOrObject<StripeAccount>.Map(value, s => OnBehalfOfId = s, o => OnBehalfOf = o);
            }
        }
        #endregion

        // order - requires orders to be expandable
        [JsonProperty("order")]
        public string Order { get; set; }

        #region Expandable Outcome
        public string OutcomeId { get; set; }

        [JsonIgnore]
        public StripeOutcome Outcome { get; set; }

        [JsonProperty("outcome")]
        internal object InternalOutcome
        {
            set
            {
                StringOrObject<StripeOutcome>.Map(value, s => OutcomeId = s, o => Outcome = o);
            }
        }
        #endregion

        /// <summary>
        /// true if the charge succeeded, or was successfully authorized for later capture.
        /// </summary>
        [JsonProperty("paid")]
        public bool Paid { get; set; }

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
        public StripeList<StripeRefund> Refunds { get; set; }

        #region Expandable Review
        /// <summary>
        /// ID of the review associated with this charge if one exists.
        /// </summary>
        public string ReviewId { get; set; }

        [JsonIgnore]
        public StripeReview Review { get; set; }

        [JsonProperty("review")]
        internal object InternalReview
        {
            set
            {
                StringOrObject<StripeReview>.Map(value, s => ReviewId = s, o => Review = o);
            }
        }
        #endregion

        /// <summary>
        /// Shipping information for the charge.
        /// </summary>
        [JsonProperty("shipping")]
        public StripeShipping Shipping { get; set; }

        /// <summary>
        /// For most Stripe users, the source of every charge is a credit or debit card. This hash is then the card object describing that card.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        #region Expandable Transfer
        /// <summary>
        /// The transfer ID which created this charge. Only present if the charge came from another Stripe account. See the Connect documentation for details.
        /// </summary>
        public string SourceTransferId { get; set; }

        [JsonIgnore]
        public StripeTransfer SourceTransfer { get; set; }

        [JsonProperty("source_transfer")]
        internal object InternalSourceTransfer
        {
            set
            {
                StringOrObject<StripeTransfer>.Map(value, s => SourceTransferId = s, o => SourceTransfer = o);
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
        public StripeTransfer Transfer { get; set; }

        [JsonProperty("transfer")]
        internal object InternalTransfer
        {
            set
            {
                StringOrObject<StripeTransfer>.Map(value, s => TransferId = s, o => Transfer = o);
            }
        }
        #endregion

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the Connect documentation for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}