namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Invoice : StripeEntity, IHasId, IHasMetadata, IHasObject
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
        public string ChargeId { get; set; }

        [JsonIgnore]
        public Charge Charge { get; set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            get
            {
                return this.Charge ?? (object)this.ChargeId;
            }

            set
            {
                StringOrObject<Charge>.Map(value, s => this.ChargeId = s, o => this.Charge = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("custom_fields")]
        public List<InvoiceCustomField> CustomFields { get; set; }

        #region Expandable Customer
        [JsonIgnore]
        public string CustomerId { get; set; }

        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            get
            {
                return this.Customer ?? (object)this.CustomerId;
            }

            set
            {
                StringOrObject<Customer>.Map(value, s => this.CustomerId = s, o => this.Customer = o);
            }
        }
        #endregion

        /// <summary>
        /// The customer’s address. Until the invoice is finalized, this field will equal
        /// <c>customer.address</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_address")]
        public Address CustomerAddress { get; set; }

        /// <summary>
        /// The customer’s name. Until the invoice is finalized, this field will equal
        /// <c>customer.name</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// The customer’s phone number. Until the invoice is finalized, this field will equal
        /// <c>customer.phone</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_phone")]
        public string CustomerPhone { get; set; }

        /// <summary>
        /// The customer’s shipping information. Until the invoice is finalized, this field will
        /// equal <c>customer.shipping</c>. Once the invoice is finalized, this field will no
        /// longer be updated.
        /// </summary>
        [JsonProperty("customer_shipping")]
        public Shipping CustomerShipping { get; set; }

        /// <summary>
        /// The customer’s tax ids. Until the invoice is finalized, this field will equal
        /// <c>customer.tax_ids</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
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
        public string DefaultPaymentMethodId { get; set; }

        [JsonIgnore]
        public PaymentMethod DefaultPaymentMethod { get; set; }

        [JsonProperty("default_payment_method")]
        internal object InternalDefaultPaymentMethod
        {
            get
            {
                return this.DefaultPaymentMethod ?? (object)this.DefaultPaymentMethodId;
            }

            set
            {
                StringOrObject<PaymentMethod>.Map(value, s => this.DefaultPaymentMethodId = s, o => this.DefaultPaymentMethod = o);
            }
        }

        #endregion

        #region Expandable DefaultSource
        [JsonIgnore]
        public string DefaultSourceId { get; set; }

        [JsonIgnore]
        public IPaymentSource DefaultSource { get; set; }

        [JsonProperty("default_source")]
        internal object InternalDefaultSource
        {
            get
            {
                return this.DefaultSource ?? (object)this.DefaultSourceId;
            }

            set
            {
                StringOrObject<IPaymentSource>.Map(value, s => this.DefaultSourceId = s, o => this.DefaultSource = o);
            }
        }
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
        public string PaymentIntentId { get; set; }

        /// <summary>
        /// The PaymentIntent associated with this invoice. The PaymentIntent is generated when the
        /// invoice is finalized, and can then be used to pay the invoice. Note that voiding an
        /// invoice will cancel the PaymentIntent.
        /// </summary>
        [JsonIgnore]
        public PaymentIntent PaymentIntent { get; set; }

        [JsonProperty("payment_intent")]
        internal object InternalPaymentIntent
        {
            get
            {
                return this.PaymentIntent ?? (object)this.PaymentIntentId;
            }

            set
            {
                StringOrObject<PaymentIntent>.Map(value, s => this.PaymentIntentId = s, o => this.PaymentIntent = o);
            }
        }
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
        public string SubscriptionId { get; set; }

        [JsonIgnore]
        public Subscription Subscription { get; set; }

        [JsonProperty("subscription")]
        internal object InternalSubscription
        {
            get
            {
                return this.Subscription ?? (object)this.SubscriptionId;
            }

            set
            {
                StringOrObject<Subscription>.Map(value, s => this.SubscriptionId = s, o => this.Subscription = o);
            }
        }
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
        /// If <c>billing_reason</c> is set to <c>subscription_threshold</c> this
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
