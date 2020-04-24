namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Invoice : StripeEntity<Invoice>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
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
        /// creating the invoice.
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// Final amount due at this time for this invoice. If the invoice's total is smaller than
        /// the minimum charge amount, for example, or if there is account credit that can be
        /// applied to the invoice, the <see cref="AmountDue" /> may be 0. If there is a positive
        /// <see cref="StartingBalance" /> for the invoice (the customer owes money), the
        /// <see cref="AmountDue" /> will also take that into account. The charge that gets
        /// generated for the invoice will be for the amount specified in <see cref="AmountDue" />.
        /// </summary>
        [JsonProperty("amount_due")]
        public long AmountDue { get; set; }

        /// <summary>
        /// The amount that was paid.
        /// </summary>
        [JsonProperty("amount_paid")]
        public long AmountPaid { get; set; }

        /// <summary>
        /// The amount that was paid.
        /// </summary>
        [JsonProperty("amount_remaining")]
        public long AmountRemaining { get; set; }

        /// <summary>
        /// The fee in that will be applied to the invoice and transferred to the application
        /// owner's Stripe account when the invoice is paid.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Number of payment attempts made for this invoice, from the perspective of the payment
        /// retry schedule. Any payment attempt counts as the first attempt, and subsequently only
        /// automatic retries increment the attempt count. In other words, manual payment attempts
        /// after the first attempt do not affect the retry schedule.
        /// </summary>
        [JsonProperty("attempt_count")]
        public long AttemptCount { get; set; }

        /// <summary>
        /// Whether an attempt has been made to pay the invoice. An invoice is not attempted until 1
        /// hour after the <c>invoice.created</c> webhook, for example, so you might not want to
        /// display that invoice as unpaid to your users.
        /// </summary>
        [JsonProperty("attempted")]
        public bool Attempted { get; set; }

        /// <summary>
        /// Controls whether Stripe will perform automatic collection of the invoice. When
        /// <c>false</c>, the invoice's state will not automatically advance without an explicit
        /// action.
        /// </summary>
        [JsonProperty("auto_advance")]
        public bool AutoAdvance { get; set; }

        /// <summary>
        /// Indicates the reason why the invoice was created. One of
        /// <c>automatic_pending_invoice_item_invoice</c>, <c>manual</c>, <c>subscription</c>,
        /// <c>subscription_create</c>, <c>subscription_cycle</c>, <c>subscription_threshold</c>,
        /// <c>subscription_update</c>, or <c>upcoming</c>.
        /// </summary>
        [JsonProperty("billing_reason")]
        public string BillingReason { get; set; }

        #region Expandable Charge

        /// <summary>
        /// ID of the latest charge generated for this invoice, if any.
        /// </summary>
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded) The latest charge generated for this invoice, if any.
        /// </summary>
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

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Custom fields displayed on the invoice.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<InvoiceCustomField> CustomFields { get; set; }

        #region Expandable Customer

        /// <summary>
        /// The ID of the customer who will be billed.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded) T)he customer who will be billed.
        /// </summary>
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

        /// <summary>
        ///  (Expanded) The default payment method for the invoice. It must belong to the customer
        /// associated with the invoice and be in a chargeable state. If not set, defaults to the
        /// subscription’s default payment method, if any, or to the customer’s default payment
        /// method.
        /// </summary>
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

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// Referenced as 'memo' in the Dashboard.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Describes the current discount applied to this invoice, if there is one.
        /// </summary>
        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        #region Expandable Discounts

        [JsonIgnore]
        public List<string> DiscountIds
        {
            get => this.InternalDiscounts?.Select((x) => x.Id).ToList();
            set => this.InternalDiscounts = SetExpandableArrayIds<Discount>(value);
        }

        [JsonIgnore]
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// The date on which payment for this invoice is due. This value will be null for invoices
        /// where billing=charge_automatically.
        /// </summary>
        [JsonProperty("due_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Ending customer balance after the invoice is finalized. Invoices are finalized
        /// approximately an hour after successful webhook delivery or when payment collection is
        /// attempted for the invoice. If the invoice has not been finalized yet, this will be null.
        /// </summary>
        [JsonProperty("ending_balance")]
        public long? EndingBalance { get; set; }

        /// <summary>
        /// Footer displayed on the invoice.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// The URL for the hosted invoice page, which allows customers to view and pay an invoice.
        /// If the invoice has not been finalized yet, this will be null.
        /// </summary>
        [JsonProperty("hosted_invoice_url")]
        public string HostedInvoiceUrl { get; set; }

        /// <summary>
        /// The link to download the PDF for the invoice. If the invoice has not been finalized yet,
        /// this will be null.
        /// </summary>
        [JsonProperty("invoice_pdf")]
        public string InvoicePdf { get; set; }

        /// <summary>
        /// The individual line items that make up the invoice.
        /// </summary>
        [JsonProperty("lines")]
        public StripeList<InvoiceLineItem> Lines { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The time at which payment will next be attempted. This value will be null for invoices
        /// where <see cref="CollectionMethod" /> is set to <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("next_payment_attempt")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? NextPaymentAttempt { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on emails sent to the customer for this
        /// invoice.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Whether payment was successfully collected for this invoice. An invoice can be paid
        /// (most commonly) with a charge or with credit from the customer's account balance.
        /// </summary>
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
        /// (Expanded) The PaymentIntent associated with this invoice. The PaymentIntent is
        /// generated when the invoice is finalized, and can then be used to pay the invoice. Note
        /// that voiding an invoice will cancel the PaymentIntent.
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

        /// <summary>
        /// End of the usage period during which invoice items were added to this invoice.
        /// </summary>
        [JsonProperty("period_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime PeriodEnd { get; set; }

        /// <summary>
        /// Start of the usage period during which invoice items were added to this invoice.
        /// </summary>
        [JsonProperty("period_start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime PeriodStart { get; set; }

        /// <summary>
        /// Total amount of all post-payment credit notes issued for this invoice.
        /// </summary>
        [JsonProperty("post_payment_credit_notes_amount")]
        public long PostPaymentCreditNotesAmount { get; set; }

        /// <summary>
        /// Total amount of all pre-payment credit notes issued for this invoice.
        /// </summary>
        [JsonProperty("pre_payment_credit_notes_amount")]
        public long PrePaymentCreditNotesAmount { get; set; }

        /// <summary>
        /// This is the transaction number that appears on email receipts sent for this invoice.
        /// </summary>
        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// Starting customer balance before the invoice is finalized. If the invoice has not been
        /// finalized yet, this will be the current customer balance.
        /// </summary>
        [JsonProperty("starting_balance")]
        public long StartingBalance { get; set; }

        /// <summary>
        /// Extra information about an invoice for the customer's credit card statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The status of the invoice, one of <c>draft</c>, <c>open</c>, <c>paid</c>,
        /// <c>uncollectible</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The timestamps at which the invoice status was updated.
        /// </summary>
        [JsonProperty("status_transitions")]
        public InvoiceStatusTransitions StatusTransitions { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// ID of the subscription that this invoice was prepared for, if any.
        /// </summary>
        [JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        /// <summary>
        /// (Expanded) The subscription that this invoice was prepared for, if any.
        /// </summary>
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

        /// <summary>
        /// Only set for upcoming invoices that preview prorations. The time used to calculate
        /// prorations.
        /// </summary>
        [JsonProperty("subscription_proration_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime SubscriptionProrationDate { get; set; }

        /// <summary>
        /// Total of all subscriptions, invoice items, and prorations on the invoice before any
        /// discount or tax is applied.
        /// </summary>
        [JsonProperty("subtotal")]
        public long Subtotal { get; set; }

        /// <summary>
        /// The amount of tax on this invoice. This is the sum of all the tax amounts on this invoice.
        /// </summary>
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
        /// Total after discounts and taxes.
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }

        /// <summary>
        /// The aggregate amounts calculated per tax rate for all line items.
        /// </summary>
        [JsonProperty("total_tax_amounts")]
        public List<InvoiceTaxAmount> TotalTaxAmounts { get; set; }

        /// <summary>
        /// If specified, the funds from the invoice will be transferred to the destination and the
        /// ID of the resulting transfer will be found on the invoice's charge.
        /// </summary>
        [JsonProperty("transfer_data")]
        public InvoiceTransferData TransferData { get; set; }

        /// <summary>
        /// Invoices are automatically paid or sent 1 hour after webhooks are delivered, or until
        /// all webhook delivery attempts have been exhausted. This field tracks the time when
        /// webhooks for this invoice were successfully delivered. If the invoice had no webhooks to
        /// deliver, this will be set while the invoice is being created.
        /// </summary>
        [JsonProperty("webhooks_delivered_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? WebhooksDeliveredAt { get; set; }
    }
}
