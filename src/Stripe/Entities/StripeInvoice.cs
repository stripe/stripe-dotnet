using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeInvoice : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("amount_due")]
        public int AmountDue { get; set; }

        [JsonProperty("attempt_count")]
        public int AttemptCount { get; set; }

        [JsonProperty("attempted")]
        public bool Attempted { get; set; }

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
                ExpandableProperty<StripeCustomer>.Map(value, s => CustomerId = s, o => Customer = o);
            }
        }
        #endregion

        [JsonProperty("date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Date { get; set; }

        [JsonProperty("forgiven")]
        public bool? Forgiven { get; set; }

        [JsonProperty("lines")]
        public StripeList<StripeInvoiceLineItem> StripeInvoiceLineItems { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("period_end")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime PeriodEnd { get; set; }

        [JsonProperty("period_start")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime PeriodStart { get; set; }

        [JsonProperty("starting_balance")]
        public int StartingBalance { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        #region Expandable Charge
        public string ChargeId { get; set; }

        [JsonIgnore]
        public StripeCharge Charge { get; set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            set
            {
                ExpandableProperty<StripeCharge>.Map(value, s => ChargeId = s, o => Charge = o);
            }
        }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount")]
        public StripeDiscount StripeDiscount { get; set; }

        [JsonProperty("ending_balance")]
        public int? EndingBalance { get; set; }

        [JsonProperty("next_payment_attempt")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? NextPaymentAttempt { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("webhooks_delivered_at")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? WebhooksDeliveredAt { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("tax")]
        public int? Tax { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }
    }
}