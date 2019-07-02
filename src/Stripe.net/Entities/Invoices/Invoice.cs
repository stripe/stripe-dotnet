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

        /// <summary>
        /// The country of the business associated with this invoice, most often the business
        /// creating the invoice.
        /// </summary>
        [JsonProperty("account_country")]
        public string AccountCountry { get; set; }

        /// <summary>
        /// The public name of the business associated with this invoice, most often the business
        /// creating the invoice
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("amount_due")]
        public long AmountDue { get; set; }

        [JsonProperty("amount_paid")]
        public long AmountPaid { get; set; }

        [JsonProperty("amount_remaining")]
        public long AmountRemaining { get; set; }

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
        /// This field has been renamed to <c>CollectionMethod</c> and will be removed
        /// in a future API version.
        /// </summary>
        [Obsolete("Use CollectionMethod")]
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

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

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When
        /// charging automatically, Stripe will attempt to pay this invoice
        /// using the default source attached to the customer. When sending an
        /// invoice, Stripe will email this invoice to the customer with payment
        /// instructions. Defaults to <c>charge_automatically</c>.
        /// </summary>
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

        /// <summary>
        /// The customer’s address. Until the invoice is finalized, this field will equal
        /// <see cref="Customer.Address" />. Once the invoice is finalized, this field will no
        /// longer be updated.
        /// </summary>
        [JsonProperty("customer_address")]
        public Address CustomerAddress { get; set; }

        /// <summary>
        /// The customer’s email. Until the invoice is finalized, this field will equal
        /// <see cref="Customer.Email" />. Once the invoice is finalized, this field will no longer
        /// be updated.
        /// </summary>
        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// The customer’s name. Until the invoice is finalized, this field will equal
        /// <see cref="Customer.Name" />. Once the invoice is finalized, this field will no longer
        /// be updated.
        /// </summary>
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// The customer’s phone number. Until the invoice is finalized, this field will equal
        /// <see cref="Customer.Phone" />. Once the invoice is finalized, this field will no longer
        /// be updated.
        /// </summary>
        [JsonProperty("customer_phone")]
        public string CustomerPhone { get; set; }

        /// <summary>
        /// The customer’s shipping information. Until the invoice is finalized, this field will
        /// equal <see cref="Customer.Shipping" />. Once the invoice is finalized, this field will
        /// no longer be updated.
        /// </summary>
        [JsonProperty("customer_shipping")]
        public Shipping CustomerShipping { get; set; }

        /// <summary>
        /// The customer’s tax exempt status. Until the invoice is finalized, this field will equal
        /// <see cref="Customer.TaxExempt" />. Once the invoice is finalized, this field will no
        /// longer be updated.
        /// </summary>
        [JsonProperty("customer_tax_exempt")]
        public string CustomerTaxExempt { get; set; }

        /// <summary>
        /// The customer’s tax ids. Until the invoice is finalized, this field will equal
        /// <see cref="Customer.TaxIds" />. Once the invoice is finalized, this field will no
        /// longer be updated.
        /// </summary>
        [JsonProperty("customer_tax_ids")]
        public List<InvoiceCustomerTaxId> CustomerTaxIds { get; set; }

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// ID of the default payment method for the invoice. It must belong to the customer
        /// associated with the invoice and be in a chargeable state. If not set, defaults to the
        /// subscription’s default payment method, if any, or to the customer’s default payment
        /// method.
        /// </summary>
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

        #region Expandable DefaultSource
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

        /// <summary>
        /// Tax rates applied to the invoice.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<TaxRate> DefaultTaxRates { get; set; }

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

        #region Expandable PaymentIntent

        /// <summary>
        /// ID of the PaymentIntent associated with this invoice.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// The PaymentIntent associated with this invoice. The PaymentIntent is generated when the
        /// invoice is finalized, and can then be used to pay the invoice. Note that voiding an
        /// invoice will cancel the PaymentIntent.
        /// </summary>
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

        /// <summary>
        /// Total amount of all post-payment credit notes issued for this invoice.
        /// </summary>
        [JsonProperty("post_payment_credit_notes_amount")]
        public long? PostPaymentCreditNotesAmount { get; set; }

        /// <summary>
        /// Total amount of all pre-payment credit notes issued for this invoice.
        /// </summary>
        [JsonProperty("pre_payment_credit_notes_amount")]
        public long? PrePaymentCreditNotesAmount { get; set; }

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
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime SubscriptionProrationDate { get; set; }

        [JsonProperty("subtotal")]
        public long Subtotal { get; set; }

        [JsonProperty("tax")]
        public long? Tax { get; set; }

        [Obsolete("Use DefaultTaxRates instead")]
        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        /// <summary>
        /// If <see cref="BillingReason" /> is set to <c>subscription_threshold</c> this
        /// returns more information on which threshold rules triggered the invoice.
        /// </summary>
        [JsonProperty("threshold_reason")]
        public InvoiceThresholdReason ThresholdReason { get; set; }

        /// <summary>
        /// The tax amounts which apply to this invoice.
        /// </summary>
        [JsonProperty("total_tax_amounts")]
        public List<InvoiceTaxAmount> TotalTaxAmounts { get; set; }

        [JsonProperty("transfer_data")]
        public InvoiceTransferData TransferData { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("webhooks_delivered_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? WebhooksDeliveredAt { get; set; }
    }
}
