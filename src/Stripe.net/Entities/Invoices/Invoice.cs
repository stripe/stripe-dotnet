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

        [JsonProperty("account_country")]
        public string AccountCountry { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("amount_due")]
        public long AmountDue { get; set; }

        [JsonProperty("amount_paid")]
        public long AmountPaid { get; set; }

        [JsonProperty("amount_remaining")]
        public long AmountRemaining { get; set; }

        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("attempt_count")]
        public long AttemptCount { get; set; }

        [JsonProperty("attempted")]
        public bool Attempted { get; set; }

        [JsonProperty("auto_advance")]
        public bool AutoAdvance { get; set; }

        [JsonProperty("billing_reason")]
        public string BillingReason { get; set; }

        #region Expandable Charge
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        [JsonIgnore]
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("custom_fields")]
        public List<InvoiceCustomField> CustomFields { get; set; }

        #region Expandable Customer
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

        [JsonProperty("customer_address")]
        public Address CustomerAddress { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("customer_shipping")]
        public Shipping CustomerShipping { get; set; }

        [JsonProperty("customer_tax_exempt")]
        public string CustomerTaxExempt { get; set; }

        [JsonProperty("customer_tax_ids")]
        public List<InvoiceCustomerTaxId> CustomerTaxIds { get; set; }

        #region Expandable Default Payment Method
        [JsonIgnore]
        public string DefaultPaymentMethodId
        {
            get => this.InternalDefaultPaymentMethod?.Id;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldId(value, this.InternalDefaultPaymentMethod);
        }

        [JsonIgnore]
        public PaymentMethod DefaultPaymentMethod
        {
            get => this.InternalDefaultPaymentMethod?.ExpandedObject;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldObject(value, this.InternalDefaultPaymentMethod);
        }

        [JsonProperty("default_payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalDefaultPaymentMethod { get; set; }
        #endregion

        #region Expandable Default Source
        [JsonIgnore]
        public string DefaultSourceId
        {
            get => this.InternalDefaultSource?.Id;
            set => this.InternalDefaultSource = SetExpandableFieldId(value, this.InternalDefaultSource);
        }

        [JsonIgnore]
        public IPaymentSource DefaultSource
        {
            get => this.InternalDefaultSource?.ExpandedObject;
            set => this.InternalDefaultSource = SetExpandableFieldObject(value, this.InternalDefaultSource);
        }

        [JsonProperty("default_source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
        internal ExpandableField<IPaymentSource> InternalDefaultSource { get; set; }
        #endregion

        [JsonProperty("default_tax_rates")]
        public List<TaxRate> DefaultTaxRates { get; set; }

        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        [JsonProperty("due_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DueDate { get; set; }

        [JsonProperty("ending_balance")]
        public long? EndingBalance { get; set; }

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

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        #region Expandable Payment Intent
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

        [JsonProperty("period_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime PeriodEnd { get; set; }

        [JsonProperty("period_start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime PeriodStart { get; set; }

        [JsonProperty("post_payment_credit_notes_amount")]
        public long PostPaymentCreditNotesAmount { get; set; }

        [JsonProperty("pre_payment_credit_notes_amount")]
        public long PrePaymentCreditNotesAmount { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("starting_balance")]
        public long StartingBalance { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        public InvoiceStatusTransitions StatusTransitions { get; set; }

        #region Expandable Subscription
        [JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        [JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        [JsonProperty("subscription_proration_date")]
        public long SubscriptionProrationDate { get; set; }

        [JsonProperty("subtotal")]
        public long Subtotal { get; set; }

        [JsonProperty("tax")]
        public long? Tax { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("threshold_reason")]
        public InvoiceThresholdReason ThresholdReason { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("total_tax_amounts")]
        public List<InvoiceTotalTaxAmount> TotalTaxAmounts { get; set; }

        [JsonProperty("transfer_data")]
        public InvoiceTransferData TransferData { get; set; }

        [JsonProperty("webhooks_delivered_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? WebhooksDeliveredAt { get; set; }
    }
}
