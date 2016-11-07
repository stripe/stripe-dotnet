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

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("captured")]
        public bool? Captured { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        #region Expandable Review
        public string ReviewId { get; set; }

        [JsonIgnore]
        public StripeReview Review { get; set; }

        [JsonProperty("review")]
        internal object InternalReview
        {
            set
            {
                ExpandableProperty<StripeReview>.Map(value, s => ReviewId = s, o => Review = o);
            }
        }
        #endregion

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("refunds")]
        public StripeList<StripeRefund> StripeRefundList { get; set; }

        [JsonConverter(typeof(SourceConverter))]
        public Source Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }

        #region Expandable Balance Transaction
        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public StripeBalanceTransaction BalanceTransaction { get; set;}

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            set
            {
                ExpandableProperty<StripeBalanceTransaction>.Map(value, s => BalanceTransactionId = s, o => BalanceTransaction = o);
            }
        }
        #endregion

        #region Expandable Customer
        public string CustomerId { get; set; }

        [JsonIgnore]
        public StripeCustomer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                ExpandableProperty<StripeCustomer>.Map(value, s => CustomerId = s, o => Customer = o);
            }
        }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination
        public string DestinationId { get; set; }

        [JsonIgnore]
        public StripeAccount Destination { get; set; }

        [JsonProperty("destination")]
        internal object InternalDestination
        {
            set
            {
                ExpandableProperty<StripeAccount>.Map(value, s => DestinationId = s, o => Destination = o);
            }
        }
        #endregion

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("dispute")]
        public StripeDispute Dispute { get; set; }

        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        [JsonProperty("fraud_details")]
        public Dictionary<string, string> FraudDetails { get; set; }

        #region Expandable Invoice
        public string InvoiceId { get; set; }

        [JsonIgnore]
        public StripeInvoice Invoice { get; set; }

        [JsonProperty("invoice")]
        internal object InternalInvoice
        {
            set
            {
                ExpandableProperty<StripeInvoice>.Map(value, s => InvoiceId = s, o => Invoice = o);
            }
        }
        #endregion

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        // shipping

        #region Expandable Application Fee
        public string ApplicationFeeId { get; set; }

        [JsonIgnore]
        public StripeApplicationFee ApplicationFee { get; set; }

        [JsonProperty("application_fee")]
        internal object InternalApplicationFee
        {
            set
            {
                ExpandableProperty<StripeApplicationFee>.Map(value, s => ApplicationFeeId = s, o => ApplicationFee = o);
            }
        }
        #endregion

        // destination

        // transfer
    }
}