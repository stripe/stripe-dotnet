namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Invoice : StripeEntity<Invoice>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount_due")]
        public long AmountDue { get; set; }

        [JsonProperty("amount_paid")]
        public long AmountPaid { get; set; }

        [JsonProperty("amount_remaining")]
        public long AmountRemaining { get; set; }

        [Obsolete("Use ApplicationFeeAmount")]
        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        /// <summary>
        /// The amount of the application application fee (if any) for the invoice. See the Connect documentation for details.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("attempt_count")]
        public long AttemptCount { get; set; }

        [JsonProperty("attempted")]
        public bool Attempted { get; set; }

        [JsonProperty("auto_advance")]
        public bool AutoAdvance { get; set; }

        /// <summary>
        /// One of <see cref="Billing" />. When charging automatically, Stripe will attempt to pay
        /// this subscription at the end of the cycle using the default source attached to the
        /// customer. When sending an invoice, Stripe will email your customer an invoice with
        /// payment instructions.
        /// </summary>
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        [JsonProperty("billing_reason")]
        public string BillingReason { get; set; }

        #region Expandable Charge
        [JsonIgnore]
        public string ChargeId => this.InternalCharge.Id;

        [JsonIgnore]
        public Charge Charge => this.InternalCharge.ExpandedObject;

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("custom_fields")]
        public List<InvoiceCustomField> CustomFields { get; set; }

        #region Expandable Customer
        [JsonIgnore]
        public string CustomerId => this.InternalCustomer.Id;

        [JsonIgnore]
        public Customer Customer => this.InternalCustomer.ExpandedObject;

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Date { get; set; }

        #region Expandable DefaultSource
        [JsonIgnore]
        public string DefaultSourceId => this.InternalDefaultSource.Id;

        [JsonIgnore]
        public IPaymentSource DefaultSource => this.InternalDefaultSource.ExpandedObject;

        [JsonProperty("default_source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
        internal ExpandableField<IPaymentSource> InternalDefaultSource { get; set; }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        /// <summary>
        /// The date on which payment for this invoice is due. This value will be null for invoices
        /// where billing=charge_automatically.
        /// </summary>
        [JsonProperty("due_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DueDate { get; set; }

        [JsonProperty("ending_balance")]
        public long? EndingBalance { get; set; }

        [JsonProperty("finalized_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? FinalizedAt { get; set; }

        [JsonProperty("footer")]
        public string Footer { get; set; }

        [JsonProperty("hosted_invoice_url")]
        public string HostedInvoiceUrl { get; set; }

        [JsonProperty("invoice_pdf")]
        public string InvoicePdf { get; set; }

        [JsonProperty("lines")]
        public StripeList<InvoiceLineItem> Lines { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("next_payment_attempt")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? NextPaymentAttempt { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on emails sent to the customer for this
        /// invoice.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("period_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime PeriodEnd { get; set; }

        [JsonProperty("period_start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime PeriodStart { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("starting_balance")]
        public long StartingBalance { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable Subscription
        [JsonIgnore]
        public string SubscriptionId => this.InternalSubscription.Id;

        [JsonIgnore]
        public Subscription Subscription => this.InternalSubscription.ExpandedObject;

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        [JsonProperty("subscription_proration_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime SubscriptionProrationDate { get; set; }

        [JsonProperty("subtotal")]
        public long Subtotal { get; set; }

        [JsonProperty("tax")]
        public long? Tax { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        /// <summary>
        /// If <code>billing_reason</code> is set to <code>subscription_threshold</code> this
        /// returns more information on which threshold rules triggered the invoice.
        /// </summary>
        [JsonProperty("threshold_reason")]
        public InvoiceThresholdReason ThresholdReason { get; set; }

        [JsonProperty("transfer_data")]
        public InvoiceTransferData TransferData { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("webhooks_delivered_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? WebhooksDeliveredAt { get; set; }
    }
}
