using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCharge : StripeObject
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

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("refunds")]
        public StripeList<StripeRefund> StripeRefundList { get; set; }

        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }

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

        [JsonProperty("card")]
        public StripeCard StripeCard { get; set; }

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

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dispute")]
        public StripeDispute Dispute { get; set; }

        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

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

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        // todo: hash, fraud details

        // todo: hash, shipping
    }
}