// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Invoices are statements of amounts owed by a customer, and are either generated one-off,
    /// or generated periodically from a subscription.
    ///
    /// They contain <a href="https://api.stripe.com#invoiceitems">invoice items</a>, and
    /// proration adjustments that may be caused by subscription upgrades/downgrades (if
    /// necessary).
    ///
    /// If your invoice is configured to be billed through automatic charges, Stripe
    /// automatically finalizes your invoice and attempts payment. Note that finalizing the
    /// invoice, <a
    /// href="https://docs.stripe.com/invoicing/integration/automatic-advancement-collection">when
    /// automatic</a>, does not happen immediately as the invoice is created. Stripe waits until
    /// one hour after the last webhook was successfully sent (or the last webhook timed out
    /// after failing). If you (and the platforms you may have connected to) have no webhooks
    /// configured, Stripe waits one hour after creation to finalize the invoice.
    ///
    /// If your invoice is configured to be billed by sending an email, then based on your <a
    /// href="https://dashboard.stripe.com/account/billing/automatic">email settings</a>, Stripe
    /// will email the invoice to your customer and await payment. These emails can contain a
    /// link to a hosted page to pay the invoice.
    ///
    /// Stripe applies any customer credit on the account before determining the amount due for
    /// the invoice (i.e., the amount that will be actually charged). If the amount due for the
    /// invoice is less than Stripe's <a
    /// href="https://stripe.com/docs/currencies#minimum-and-maximum-charge-amounts">minimum
    /// allowed charge per currency</a>, the invoice is automatically marked paid, and we add
    /// the amount due to the customer's credit balance which is applied to the next invoice.
    ///
    /// More details on the customer's credit balance are <a
    /// href="https://docs.stripe.com/billing/customer/balance">here</a>.
    ///
    /// Related guide: <a href="https://docs.stripe.com/billing/invoices/sending">Send invoices
    /// to customers</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Invoice : StripeEntity<Invoice>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object. For preview invoices created using the <a
        /// href="https://stripe.com/docs/api/invoices/create_preview">create preview</a> endpoint,
        /// this id will be prefixed with <c>upcoming_in</c>.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The country of the business associated with this invoice, most often the business
        /// creating the invoice.
        /// </summary>
        [JsonProperty("account_country")]
        [STJS.JsonPropertyName("account_country")]
        public string AccountCountry { get; set; }

        /// <summary>
        /// The public name of the business associated with this invoice, most often the business
        /// creating the invoice.
        /// </summary>
        [JsonProperty("account_name")]
        [STJS.JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        #region Expandable AccountTaxIds

        /// <summary>
        /// (IDs of the AccountTaxIds)
        /// The account tax IDs associated with the invoice. Only editable when the invoice is a
        /// draft.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<string> AccountTaxIdIds
        {
            get => this.InternalAccountTaxIds?.Select((x) => x.Id).ToList();
            set => this.InternalAccountTaxIds = SetExpandableArrayIds<TaxId>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The account tax IDs associated with the invoice. Only editable when the invoice is a
        /// draft.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<TaxId> AccountTaxIds
        {
            get => this.InternalAccountTaxIds?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalAccountTaxIds = SetExpandableArrayObjects(value);
        }

        [JsonProperty("account_tax_ids", ItemConverterType = typeof(ExpandableFieldConverter<TaxId>))]
        [STJS.JsonPropertyName("account_tax_ids")]
        internal List<ExpandableField<TaxId>> InternalAccountTaxIds { get; set; }
        #endregion

        /// <summary>
        /// Final amount due at this time for this invoice. If the invoice's total is smaller than
        /// the minimum charge amount, for example, or if there is account credit that can be
        /// applied to the invoice, the <c>amount_due</c> may be 0. If there is a positive
        /// <c>starting_balance</c> for the invoice (the customer owes money), the <c>amount_due</c>
        /// will also take that into account. The charge that gets generated for the invoice will be
        /// for the amount specified in <c>amount_due</c>.
        /// </summary>
        [JsonProperty("amount_due")]
        [STJS.JsonPropertyName("amount_due")]
        public long AmountDue { get; set; }

        /// <summary>
        /// Amount that was overpaid on the invoice. The amount overpaid is credited to the
        /// customer's credit balance.
        /// </summary>
        [JsonProperty("amount_overpaid")]
        [STJS.JsonPropertyName("amount_overpaid")]
        public long AmountOverpaid { get; set; }

        /// <summary>
        /// The amount, in cents (or local equivalent), that was paid.
        /// </summary>
        [JsonProperty("amount_paid")]
        [STJS.JsonPropertyName("amount_paid")]
        public long AmountPaid { get; set; }

        /// <summary>
        /// The difference between amount_due and amount_paid, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount_remaining")]
        [STJS.JsonPropertyName("amount_remaining")]
        public long AmountRemaining { get; set; }

        /// <summary>
        /// This is the sum of all the shipping amounts.
        /// </summary>
        [JsonProperty("amount_shipping")]
        [STJS.JsonPropertyName("amount_shipping")]
        public long AmountShipping { get; set; }

        /// <summary>
        /// List of expected payments and corresponding due dates. This value will be null for
        /// invoices where collection_method=charge_automatically.
        /// </summary>
        [JsonProperty("amounts_due")]
        [STJS.JsonPropertyName("amounts_due")]
        public List<InvoiceAmountsDue> AmountsDue { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect Application that created the invoice.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect Application that created the invoice.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        [STJS.JsonPropertyName("application")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        /// <summary>
        /// Number of payment attempts made for this invoice, from the perspective of the payment
        /// retry schedule. Any payment attempt counts as the first attempt, and subsequently only
        /// automatic retries increment the attempt count. In other words, manual payment attempts
        /// after the first attempt do not affect the retry schedule. If a failure is returned with
        /// a non-retryable return code, the invoice can no longer be retried unless a new payment
        /// method is obtained. Retries will continue to be scheduled, and attempt_count will
        /// continue to increment, but retries will only be executed if a new payment method is
        /// obtained.
        /// </summary>
        [JsonProperty("attempt_count")]
        [STJS.JsonPropertyName("attempt_count")]
        public long AttemptCount { get; set; }

        /// <summary>
        /// Whether an attempt has been made to pay the invoice. An invoice is not attempted until 1
        /// hour after the <c>invoice.created</c> webhook, for example, so you might not want to
        /// display that invoice as unpaid to your users.
        /// </summary>
        [JsonProperty("attempted")]
        [STJS.JsonPropertyName("attempted")]
        public bool Attempted { get; set; }

        /// <summary>
        /// Controls whether Stripe performs <a
        /// href="https://docs.stripe.com/invoicing/integration/automatic-advancement-collection">automatic
        /// collection</a> of the invoice. If <c>false</c>, the invoice's state doesn't
        /// automatically advance without an explicit action.
        /// </summary>
        [JsonProperty("auto_advance")]
        [STJS.JsonPropertyName("auto_advance")]
        public bool AutoAdvance { get; set; }

        [JsonProperty("automatic_tax")]
        [STJS.JsonPropertyName("automatic_tax")]
        public InvoiceAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// The time when this invoice is currently scheduled to be automatically finalized. The
        /// field will be <c>null</c> if the invoice is not scheduled to finalize in the future. If
        /// the invoice is not in the draft state, this field will always be <c>null</c> - see
        /// <c>finalized_at</c> for the time when an already-finalized invoice was finalized.
        /// </summary>
        [JsonProperty("automatically_finalizes_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("automatically_finalizes_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? AutomaticallyFinalizesAt { get; set; }

        /// <summary>
        /// Indicates the reason why the invoice was created.
        ///
        /// * <c>manual</c>: Unrelated to a subscription, for example, created via the invoice
        /// editor. * <c>subscription</c>: No longer in use. Applies to subscriptions from before
        /// May 2018 where no distinction was made between updates, cycles, and thresholds. *
        /// <c>subscription_create</c>: A new subscription was created. * <c>subscription_cycle</c>:
        /// A subscription advanced into a new period. * <c>subscription_threshold</c>: A
        /// subscription reached a billing threshold. * <c>subscription_update</c>: A subscription
        /// was updated. * <c>upcoming</c>: Reserved for upcoming invoices created through the
        /// Create Preview Invoice API or when an <c>invoice.upcoming</c> event is generated for an
        /// upcoming invoice on a subscription.
        /// One of: <c>automatic_pending_invoice_item_invoice</c>, <c>manual</c>,
        /// <c>quote_accept</c>, <c>subscription</c>, <c>subscription_create</c>,
        /// <c>subscription_cycle</c>, <c>subscription_threshold</c>, <c>subscription_update</c>, or
        /// <c>upcoming</c>.
        /// </summary>
        [JsonProperty("billing_reason")]
        [STJS.JsonPropertyName("billing_reason")]
        public string BillingReason { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay this invoice using the default source attached to the
        /// customer. When sending an invoice, Stripe will email this invoice to the customer with
        /// payment instructions.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// The confirmation secret associated with this invoice. Currently, this contains the
        /// client_secret of the PaymentIntent that Stripe creates during invoice finalization.
        /// </summary>
        [JsonProperty("confirmation_secret")]
        [STJS.JsonPropertyName("confirmation_secret")]
        public InvoiceConfirmationSecret ConfirmationSecret { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Custom fields displayed on the invoice.
        /// </summary>
        [JsonProperty("custom_fields")]
        [STJS.JsonPropertyName("custom_fields")]
        public List<InvoiceCustomField> CustomFields { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer to bill.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the customer to bill.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// The ID of the account representing the customer to bill.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// The customer's address. Until the invoice is finalized, this field will equal
        /// <c>customer.address</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_address")]
        [STJS.JsonPropertyName("customer_address")]
        public Address CustomerAddress { get; set; }

        /// <summary>
        /// The customer's email. Until the invoice is finalized, this field will equal
        /// <c>customer.email</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_email")]
        [STJS.JsonPropertyName("customer_email")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// The customer's name. Until the invoice is finalized, this field will equal
        /// <c>customer.name</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_name")]
        [STJS.JsonPropertyName("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// The customer's phone number. Until the invoice is finalized, this field will equal
        /// <c>customer.phone</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_phone")]
        [STJS.JsonPropertyName("customer_phone")]
        public string CustomerPhone { get; set; }

        /// <summary>
        /// The customer's shipping information. Until the invoice is finalized, this field will
        /// equal <c>customer.shipping</c>. Once the invoice is finalized, this field will no longer
        /// be updated.
        /// </summary>
        [JsonProperty("customer_shipping")]
        [STJS.JsonPropertyName("customer_shipping")]
        public Shipping CustomerShipping { get; set; }

        /// <summary>
        /// The customer's tax exempt status. Until the invoice is finalized, this field will equal
        /// <c>customer.tax_exempt</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("customer_tax_exempt")]
        [STJS.JsonPropertyName("customer_tax_exempt")]
        public string CustomerTaxExempt { get; set; }

        /// <summary>
        /// The customer's tax IDs. Until the invoice is finalized, this field will contain the same
        /// tax IDs as <c>customer.tax_ids</c>. Once the invoice is finalized, this field will no
        /// longer be updated.
        /// </summary>
        [JsonProperty("customer_tax_ids")]
        [STJS.JsonPropertyName("customer_tax_ids")]
        public List<InvoiceCustomerTaxId> CustomerTaxIds { get; set; }

        #region Expandable DefaultMargins

        /// <summary>
        /// (IDs of the DefaultMargins)
        /// The margins applied to the invoice. Can be overridden by line item <c>margins</c>. Use
        /// <c>expand[]=default_margins</c> to expand each margin.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<string> DefaultMarginIds
        {
            get => this.InternalDefaultMargins?.Select((x) => x.Id).ToList();
            set => this.InternalDefaultMargins = SetExpandableArrayIds<Margin>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The margins applied to the invoice. Can be overridden by line item <c>margins</c>. Use
        /// <c>expand[]=default_margins</c> to expand each margin.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<Margin> DefaultMargins
        {
            get => this.InternalDefaultMargins?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDefaultMargins = SetExpandableArrayObjects(value);
        }

        [JsonProperty("default_margins", ItemConverterType = typeof(ExpandableFieldConverter<Margin>))]
        [STJS.JsonPropertyName("default_margins")]
        internal List<ExpandableField<Margin>> InternalDefaultMargins { get; set; }
        #endregion

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the default payment method for the invoice. It must belong to the customer
        /// associated with the invoice. If not set, defaults to the subscription's default payment
        /// method, if any, or to the default payment method in the customer's invoice settings.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string DefaultPaymentMethodId
        {
            get => this.InternalDefaultPaymentMethod?.Id;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldId(value, this.InternalDefaultPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the default payment method for the invoice. It must belong to the customer
        /// associated with the invoice. If not set, defaults to the subscription's default payment
        /// method, if any, or to the default payment method in the customer's invoice settings.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public PaymentMethod DefaultPaymentMethod
        {
            get => this.InternalDefaultPaymentMethod?.ExpandedObject;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldObject(value, this.InternalDefaultPaymentMethod);
        }

        [JsonProperty("default_payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        [STJS.JsonPropertyName("default_payment_method")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalDefaultPaymentMethod { get; set; }
        #endregion

        #region Expandable DefaultSource

        /// <summary>
        /// (ID of the IPaymentSource)
        /// ID of the default payment source for the invoice. It must belong to the customer
        /// associated with the invoice and be in a chargeable state. If not set, defaults to the
        /// subscription's default source, if any, or to the customer's default source.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string DefaultSourceId
        {
            get => this.InternalDefaultSource?.Id;
            set => this.InternalDefaultSource = SetExpandableFieldId(value, this.InternalDefaultSource);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the default payment source for the invoice. It must belong to the customer
        /// associated with the invoice and be in a chargeable state. If not set, defaults to the
        /// subscription's default source, if any, or to the customer's default source.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public IPaymentSource DefaultSource
        {
            get => this.InternalDefaultSource?.ExpandedObject;
            set => this.InternalDefaultSource = SetExpandableFieldObject(value, this.InternalDefaultSource);
        }

        [JsonProperty("default_source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
        [STJS.JsonPropertyName("default_source")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<IPaymentSource>))]
        internal ExpandableField<IPaymentSource> InternalDefaultSource { get; set; }
        #endregion

        /// <summary>
        /// The tax rates applied to this invoice, if any.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        [STJS.JsonPropertyName("default_tax_rates")]
        public List<TaxRate> DefaultTaxRates { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// Referenced as 'memo' in the Dashboard.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts applied to the invoice. Line item discounts are applied before invoice
        /// discounts. Use <c>expand[]=discounts</c> to expand each discount.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<string> DiscountIds
        {
            get => this.InternalDiscounts?.Select((x) => x.Id).ToList();
            set => this.InternalDiscounts = SetExpandableArrayIds<Discount>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The discounts applied to the invoice. Line item discounts are applied before invoice
        /// discounts. Use <c>expand[]=discounts</c> to expand each discount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
        [STJS.JsonPropertyName("discounts")]
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// The date on which payment for this invoice is due. This value will be <c>null</c> for
        /// invoices where <c>collection_method=charge_automatically</c>.
        /// </summary>
        [JsonProperty("due_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("due_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The date when this invoice is in effect. Same as <c>finalized_at</c> unless overwritten.
        /// When defined, this value replaces the system-generated 'Date of issue' printed on the
        /// invoice PDF and receipt.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("effective_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// Ending customer balance after the invoice is finalized. Invoices are finalized
        /// approximately an hour after successful webhook delivery or when payment collection is
        /// attempted for the invoice. If the invoice has not been finalized yet, this will be null.
        /// </summary>
        [JsonProperty("ending_balance")]
        [STJS.JsonPropertyName("ending_balance")]
        public long? EndingBalance { get; set; }

        /// <summary>
        /// Footer displayed on the invoice.
        /// </summary>
        [JsonProperty("footer")]
        [STJS.JsonPropertyName("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Details of the invoice that was cloned. See the <a
        /// href="https://docs.stripe.com/invoicing/invoice-revisions">revision documentation</a>
        /// for more details.
        /// </summary>
        [JsonProperty("from_invoice")]
        [STJS.JsonPropertyName("from_invoice")]
        public InvoiceFromInvoice FromInvoice { get; set; }

        /// <summary>
        /// The URL for the hosted invoice page, which allows customers to view and pay an invoice.
        /// If the invoice has not been finalized yet, this will be null.
        /// </summary>
        [JsonProperty("hosted_invoice_url")]
        [STJS.JsonPropertyName("hosted_invoice_url")]
        public string HostedInvoiceUrl { get; set; }

        /// <summary>
        /// The link to download the PDF for the invoice. If the invoice has not been finalized yet,
        /// this will be null.
        /// </summary>
        [JsonProperty("invoice_pdf")]
        [STJS.JsonPropertyName("invoice_pdf")]
        public string InvoicePdf { get; set; }

        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public InvoiceIssuer Issuer { get; set; }

        /// <summary>
        /// The error encountered during the previous attempt to finalize the invoice. This field is
        /// cleared when the invoice is successfully finalized.
        /// </summary>
        [JsonProperty("last_finalization_error")]
        [STJS.JsonPropertyName("last_finalization_error")]
        public StripeError LastFinalizationError { get; set; }

        #region Expandable LatestRevision

        /// <summary>
        /// (ID of the Invoice)
        /// The ID of the most recent non-draft revision of this invoice.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string LatestRevisionId
        {
            get => this.InternalLatestRevision?.Id;
            set => this.InternalLatestRevision = SetExpandableFieldId(value, this.InternalLatestRevision);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the most recent non-draft revision of this invoice.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Invoice LatestRevision
        {
            get => this.InternalLatestRevision?.ExpandedObject;
            set => this.InternalLatestRevision = SetExpandableFieldObject(value, this.InternalLatestRevision);
        }

        [JsonProperty("latest_revision")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        [STJS.JsonPropertyName("latest_revision")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalLatestRevision { get; set; }
        #endregion

        /// <summary>
        /// The individual line items that make up the invoice. <c>lines</c> is sorted as follows:
        /// (1) pending invoice items (including prorations) in reverse chronological order, (2)
        /// subscription items in reverse chronological order, and (3) invoice items added after
        /// invoice creation in chronological order.
        /// </summary>
        [JsonProperty("lines")]
        [STJS.JsonPropertyName("lines")]
        public StripeList<InvoiceLineItem> Lines { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The time at which payment will next be attempted. This value will be <c>null</c> for
        /// invoices where <c>collection_method=send_invoice</c>.
        /// </summary>
        [JsonProperty("next_payment_attempt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("next_payment_attempt")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? NextPaymentAttempt { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on emails sent to the customer for this
        /// invoice. This starts with the customer's unique invoice_prefix if it is specified.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account (if any) for which the funds of the invoice payment are intended. If set,
        /// the invoice will be presented with the branding and support information of the specified
        /// account. See the <a href="https://docs.stripe.com/billing/invoices/connect">Invoices
        /// with Connect</a> documentation for details.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        /// <summary>
        /// (Expanded)
        /// The account (if any) for which the funds of the invoice payment are intended. If set,
        /// the invoice will be presented with the branding and support information of the specified
        /// account. See the <a href="https://docs.stripe.com/billing/invoices/connect">Invoices
        /// with Connect</a> documentation for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        [STJS.JsonPropertyName("on_behalf_of")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        /// <summary>
        /// The parent that generated this invoice.
        /// </summary>
        [JsonProperty("parent")]
        [STJS.JsonPropertyName("parent")]
        public InvoiceParent Parent { get; set; }

        [JsonProperty("payment_settings")]
        [STJS.JsonPropertyName("payment_settings")]
        public InvoicePaymentSettings PaymentSettings { get; set; }

        /// <summary>
        /// Payments for this invoice. Use <a href="https://stripe.com/api/invoice-payment">invoice
        /// payment</a> to get more details.
        /// </summary>
        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public StripeList<InvoicePayment> Payments { get; set; }

        /// <summary>
        /// The latest timestamp at which invoice items can be associated with this invoice. Use the
        /// <a href="https://stripe.com/api/invoices/line_item#invoice_line_item_object-period">line
        /// item period</a> to get the service period for each price.
        /// </summary>
        [JsonProperty("period_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("period_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime PeriodEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The earliest timestamp at which invoice items can be associated with this invoice. Use
        /// the <a
        /// href="https://stripe.com/api/invoices/line_item#invoice_line_item_object-period">line
        /// item period</a> to get the service period for each price.
        /// </summary>
        [JsonProperty("period_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("period_start")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime PeriodStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Total amount of all post-payment credit notes issued for this invoice.
        /// </summary>
        [JsonProperty("post_payment_credit_notes_amount")]
        [STJS.JsonPropertyName("post_payment_credit_notes_amount")]
        public long PostPaymentCreditNotesAmount { get; set; }

        /// <summary>
        /// Total amount of all pre-payment credit notes issued for this invoice.
        /// </summary>
        [JsonProperty("pre_payment_credit_notes_amount")]
        [STJS.JsonPropertyName("pre_payment_credit_notes_amount")]
        public long PrePaymentCreditNotesAmount { get; set; }

        /// <summary>
        /// This is the transaction number that appears on email receipts sent for this invoice.
        /// </summary>
        [JsonProperty("receipt_number")]
        [STJS.JsonPropertyName("receipt_number")]
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// The rendering-related settings that control how the invoice is displayed on
        /// customer-facing surfaces such as PDF and Hosted Invoice Page.
        /// </summary>
        [JsonProperty("rendering")]
        [STJS.JsonPropertyName("rendering")]
        public InvoiceRendering Rendering { get; set; }

        /// <summary>
        /// The details of the cost of shipping, including the ShippingRate applied on the invoice.
        /// </summary>
        [JsonProperty("shipping_cost")]
        [STJS.JsonPropertyName("shipping_cost")]
        public InvoiceShippingCost ShippingCost { get; set; }

        /// <summary>
        /// Shipping details for the invoice. The Invoice PDF will use the <c>shipping_details</c>
        /// value if it is set, otherwise the PDF will render the shipping address from the
        /// customer.
        /// </summary>
        [JsonProperty("shipping_details")]
        [STJS.JsonPropertyName("shipping_details")]
        public InvoiceShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// Starting customer balance before the invoice is finalized. If the invoice has not been
        /// finalized yet, this will be the current customer balance. For revision invoices, this
        /// also includes any customer balance that was applied to the original invoice.
        /// </summary>
        [JsonProperty("starting_balance")]
        [STJS.JsonPropertyName("starting_balance")]
        public long StartingBalance { get; set; }

        /// <summary>
        /// Extra information about an invoice for the customer's credit card statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The status of the invoice, one of <c>draft</c>, <c>open</c>, <c>paid</c>,
        /// <c>uncollectible</c>, or <c>void</c>. <a
        /// href="https://docs.stripe.com/billing/invoices/workflow#workflow-overview">Learn
        /// more</a>.
        /// One of: <c>draft</c>, <c>open</c>, <c>paid</c>, <c>uncollectible</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public InvoiceStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Total of all subscriptions, invoice items, and prorations on the invoice before any
        /// invoice level discount or exclusive tax is applied. Item discounts are already
        /// incorporated.
        /// </summary>
        [JsonProperty("subtotal")]
        [STJS.JsonPropertyName("subtotal")]
        public long Subtotal { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the subtotal of the
        /// invoice before any invoice level discount or tax is applied. Item discounts are already
        /// incorporated.
        /// </summary>
        [JsonProperty("subtotal_excluding_tax")]
        [STJS.JsonPropertyName("subtotal_excluding_tax")]
        public long? SubtotalExcludingTax { get; set; }

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock this invoice belongs to.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string TestClockId
        {
            get => this.InternalTestClock?.Id;
            set => this.InternalTestClock = SetExpandableFieldId(value, this.InternalTestClock);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the test clock this invoice belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public TestHelpers.TestClock TestClock
        {
            get => this.InternalTestClock?.ExpandedObject;
            set => this.InternalTestClock = SetExpandableFieldObject(value, this.InternalTestClock);
        }

        [JsonProperty("test_clock")]
        [JsonConverter(typeof(ExpandableFieldConverter<TestHelpers.TestClock>))]
        [STJS.JsonPropertyName("test_clock")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<TestHelpers.TestClock>))]
        internal ExpandableField<TestHelpers.TestClock> InternalTestClock { get; set; }
        #endregion

        [JsonProperty("threshold_reason")]
        [STJS.JsonPropertyName("threshold_reason")]
        public InvoiceThresholdReason ThresholdReason { get; set; }

        /// <summary>
        /// Total after discounts and taxes.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public long Total { get; set; }

        /// <summary>
        /// The aggregate amounts calculated per discount across all line items.
        /// </summary>
        [JsonProperty("total_discount_amounts")]
        [STJS.JsonPropertyName("total_discount_amounts")]
        public List<InvoiceDiscountAmount> TotalDiscountAmounts { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the total amount of the
        /// invoice including all discounts but excluding all tax.
        /// </summary>
        [JsonProperty("total_excluding_tax")]
        [STJS.JsonPropertyName("total_excluding_tax")]
        public long? TotalExcludingTax { get; set; }

        /// <summary>
        /// The aggregate amounts calculated per margin across all line items.
        /// </summary>
        [JsonProperty("total_margin_amounts")]
        [STJS.JsonPropertyName("total_margin_amounts")]
        public List<InvoiceTotalMarginAmount> TotalMarginAmounts { get; set; }

        /// <summary>
        /// Contains pretax credit amounts (ex: discount, credit grants, etc) that apply to this
        /// invoice. This is a combined list of total_pretax_credit_amounts across all invoice line
        /// items.
        /// </summary>
        [JsonProperty("total_pretax_credit_amounts")]
        [STJS.JsonPropertyName("total_pretax_credit_amounts")]
        public List<InvoiceTotalPretaxCreditAmount> TotalPretaxCreditAmounts { get; set; }

        /// <summary>
        /// The aggregate tax information of all line items.
        /// </summary>
        [JsonProperty("total_taxes")]
        [STJS.JsonPropertyName("total_taxes")]
        public List<InvoiceTotalTax> TotalTaxes { get; set; }

        /// <summary>
        /// Invoices are automatically paid or sent 1 hour after webhooks are delivered, or until
        /// all webhook delivery attempts have <a
        /// href="https://docs.stripe.com/billing/webhooks#understand">been exhausted</a>. This
        /// field tracks the time when webhooks for this invoice were successfully delivered. If the
        /// invoice had no webhooks to deliver, this will be set while the invoice is being created.
        /// </summary>
        [JsonProperty("webhooks_delivered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("webhooks_delivered_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? WebhooksDeliveredAt { get; set; }
    }
}
