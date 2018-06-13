using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeInvoice : StripeEntityWithId, ISupportMetadata
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount_due")]
        public int AmountDue { get; set; }

        [JsonProperty("amount_paid")]
        public int AmountPaid { get; set; }

        [JsonProperty("amount_remaining")]
        public int AmountRemaining { get; set; }

        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        [JsonProperty("attempt_count")]
        public int AttemptCount { get; set; }

        [JsonProperty("attempted")]
        public bool Attempted { get; set; }

        /// <summary>
        /// One of <see cref="StripeBilling" />. When charging automatically, Stripe will attempt to pay this subscription at the end of the cycle using the default source attached to the customer. When sending an invoice, Stripe will email your customer an invoice with payment instructions.
        /// </summary>
        [JsonProperty("billing")]
        public StripeBilling? Billing { get; set; }

        public string BillingReason { get; set; }

        #region Expandable Charge
        public string ChargeId { get; set; }

        [JsonIgnore]
        public StripeCharge Charge { get; set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            set
            {
                StringOrObject<StripeCharge>.Map(value, s => ChargeId = s, o => Charge = o);
            }
        }
        #endregion

        [JsonProperty("closed")]
        public bool? Closed { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer
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

        [JsonProperty("date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount")]
        public StripeDiscount StripeDiscount { get; set; }

        /// <summary>
        /// The date on which payment for this invoice is due. This value will be null for invoices where billing=charge_automatically.
        /// </summary>
        [JsonProperty("due_date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? DueDate { get; set; }

        [JsonProperty("ending_balance")]
        public int? EndingBalance { get; set; }

        [JsonProperty("forgiven")]
        public bool? Forgiven { get; set; }

        [JsonProperty("hosted_invoice_url")]
        public string HostedInvoiceUrl { get; set; }

        [JsonProperty("invoice_pdf")]
        public string InvoicePdf { get; set; }

        [JsonProperty("lines")]
        public StripeList<StripeInvoiceLineItem> StripeInvoiceLineItems { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("next_payment_attempt")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? NextPaymentAttempt { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on emails sent to the customer for this invoice.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("period_end")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime PeriodEnd { get; set; }

        [JsonProperty("period_start")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime PeriodStart { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("starting_balance")]
        public int StartingBalance { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        #region Expandable Subscription
        public string SubscriptionId { get; set; }

        [JsonIgnore]
        public StripeSubscription Subscription { get; set; }

        [JsonProperty("subscription")]
        internal object InternalSubscription
        {
            set
            {
                StringOrObject<StripeSubscription>.Map(value, s => SubscriptionId = s, o => Subscription = o);
            }
        }
        #endregion

        [JsonProperty("subscription_proration_date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime SubscriptionProrationDate { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("tax")]
        public int? Tax { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("webhooks_delivered_at")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? WebhooksDeliveredAt { get; set; }
    }
}