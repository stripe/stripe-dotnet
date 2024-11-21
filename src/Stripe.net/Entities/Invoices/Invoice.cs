// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Invoices are statements of amounts owed by a customer, and are either generated one-off,
    /// or generated periodically from a subscription.
    ///
    /// They contain <a href="https://stripe.com/docs/api#invoiceitems">invoice items</a>, and
    /// proration adjustments that may be caused by subscription upgrades/downgrades (if
    /// necessary).
    ///
    /// If your invoice is configured to be billed through automatic charges, Stripe
    /// automatically finalizes your invoice and attempts payment. Note that finalizing the
    /// invoice, <a
    /// href="https://stripe.com/docs/invoicing/integration/automatic-advancement-collection">when
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
    /// href="https://stripe.com/docs/billing/customer/balance">here</a>.
    ///
    /// Related guide: <a href="https://stripe.com/docs/billing/invoices/sending">Send invoices
    /// to customers</a>.
    /// </summary>
    public class Invoice : StripeEntity<Invoice>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object. This property is always present unless the invoice is
        /// an upcoming invoice. See <a
        /// href="https://stripe.com/docs/api/invoices/upcoming">Retrieve an upcoming invoice</a>
        /// for more details.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// The country of the business associated with this invoice, most often the business
        /// creating the invoice.
        /// </summary>
        [JsonProperty("account_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_country")]
#endif

        public string AccountCountry { get; set; }

        /// <summary>
        /// The public name of the business associated with this invoice, most often the business
        /// creating the invoice.
        /// </summary>
        [JsonProperty("account_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_name")]
#endif

        public string AccountName { get; set; }

        #region Expandable AccountTaxIds

        /// <summary>
        /// (IDs of the AccountTaxIds)
        /// The account tax IDs associated with the invoice. Only editable when the invoice is a
        /// draft.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public List<TaxId> AccountTaxIds
        {
            get => this.InternalAccountTaxIds?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalAccountTaxIds = SetExpandableArrayObjects(value);
        }

        [JsonProperty("account_tax_ids", ItemConverterType = typeof(ExpandableFieldConverter<TaxId>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_tax_ids")]
        [STJS.JsonInclude]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_due")]
#endif

        public long AmountDue { get; set; }

        /// <summary>
        /// The amount, in cents (or local equivalent), that was paid.
        /// </summary>
        [JsonProperty("amount_paid")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_paid")]
#endif

        public long AmountPaid { get; set; }

        /// <summary>
        /// The difference between amount_due and amount_paid, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount_remaining")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_remaining")]
#endif

        public long AmountRemaining { get; set; }

        /// <summary>
        /// This is the sum of all the shipping amounts.
        /// </summary>
        [JsonProperty("amount_shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_shipping")]
#endif

        public long AmountShipping { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect Application that created the invoice.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Application>))]
#endif

        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        /// <summary>
        /// The fee in cents (or local equivalent) that will be applied to the invoice and
        /// transferred to the application owner's Stripe account when the invoice is paid.
        /// </summary>
        [JsonProperty("application_fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_amount")]
#endif

        public long? ApplicationFeeAmount { get; set; }

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("attempt_count")]
#endif

        public long AttemptCount { get; set; }

        /// <summary>
        /// Whether an attempt has been made to pay the invoice. An invoice is not attempted until 1
        /// hour after the <c>invoice.created</c> webhook, for example, so you might not want to
        /// display that invoice as unpaid to your users.
        /// </summary>
        [JsonProperty("attempted")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("attempted")]
#endif

        public bool Attempted { get; set; }

        /// <summary>
        /// Controls whether Stripe performs <a
        /// href="https://stripe.com/docs/invoicing/integration/automatic-advancement-collection">automatic
        /// collection</a> of the invoice. If <c>false</c>, the invoice's state doesn't
        /// automatically advance without an explicit action.
        /// </summary>
        [JsonProperty("auto_advance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("auto_advance")]
#endif

        public bool AutoAdvance { get; set; }

        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif

        public InvoiceAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// The time when this invoice is currently scheduled to be automatically finalized. The
        /// field will be <c>null</c> if the invoice is not scheduled to finalize in the future. If
        /// the invoice is not in the draft state, this field will always be <c>null</c> - see
        /// <c>finalized_at</c> for the time when an already-finalized invoice was finalized.
        /// </summary>
        [JsonProperty("automatically_finalizes_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatically_finalizes_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

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
        /// was updated. * <c>upcoming</c>: Reserved for simulated invoices, per the upcoming
        /// invoice endpoint.
        /// One of: <c>automatic_pending_invoice_item_invoice</c>, <c>manual</c>,
        /// <c>quote_accept</c>, <c>subscription</c>, <c>subscription_create</c>,
        /// <c>subscription_cycle</c>, <c>subscription_threshold</c>, <c>subscription_update</c>, or
        /// <c>upcoming</c>.
        /// </summary>
        [JsonProperty("billing_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_reason")]
#endif

        public string BillingReason { get; set; }

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the latest charge generated for this invoice, if any.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the latest charge generated for this invoice, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
#endif

        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay this invoice using the default source attached to the
        /// customer. When sending an invoice, Stripe will email this invoice to the customer with
        /// payment instructions.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_method")]
#endif

        public string CollectionMethod { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// Custom fields displayed on the invoice.
        /// </summary>
        [JsonProperty("custom_fields")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_fields")]
#endif

        public List<InvoiceCustomField> CustomFields { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer who will be billed.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the customer who will be billed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
#endif

        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// The customer's address. Until the invoice is finalized, this field will equal
        /// <c>customer.address</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_address")]
#endif

        public Address CustomerAddress { get; set; }

        /// <summary>
        /// The customer's email. Until the invoice is finalized, this field will equal
        /// <c>customer.email</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_email")]
#endif

        public string CustomerEmail { get; set; }

        /// <summary>
        /// The customer's name. Until the invoice is finalized, this field will equal
        /// <c>customer.name</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_name")]
#endif

        public string CustomerName { get; set; }

        /// <summary>
        /// The customer's phone number. Until the invoice is finalized, this field will equal
        /// <c>customer.phone</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// </summary>
        [JsonProperty("customer_phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_phone")]
#endif

        public string CustomerPhone { get; set; }

        /// <summary>
        /// The customer's shipping information. Until the invoice is finalized, this field will
        /// equal <c>customer.shipping</c>. Once the invoice is finalized, this field will no longer
        /// be updated.
        /// </summary>
        [JsonProperty("customer_shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_shipping")]
#endif

        public Shipping CustomerShipping { get; set; }

        /// <summary>
        /// The customer's tax exempt status. Until the invoice is finalized, this field will equal
        /// <c>customer.tax_exempt</c>. Once the invoice is finalized, this field will no longer be
        /// updated.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("customer_tax_exempt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_tax_exempt")]
#endif

        public string CustomerTaxExempt { get; set; }

        /// <summary>
        /// The customer's tax IDs. Until the invoice is finalized, this field will contain the same
        /// tax IDs as <c>customer.tax_ids</c>. Once the invoice is finalized, this field will no
        /// longer be updated.
        /// </summary>
        [JsonProperty("customer_tax_ids")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_tax_ids")]
#endif

        public List<InvoiceCustomerTaxId> CustomerTaxIds { get; set; }

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the default payment method for the invoice. It must belong to the customer
        /// associated with the invoice. If not set, defaults to the subscription's default payment
        /// method, if any, or to the default payment method in the customer's invoice settings.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public PaymentMethod DefaultPaymentMethod
        {
            get => this.InternalDefaultPaymentMethod?.ExpandedObject;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldObject(value, this.InternalDefaultPaymentMethod);
        }

        [JsonProperty("default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_payment_method")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentMethod>))]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public IPaymentSource DefaultSource
        {
            get => this.InternalDefaultSource?.ExpandedObject;
            set => this.InternalDefaultSource = SetExpandableFieldObject(value, this.InternalDefaultSource);
        }

        [JsonProperty("default_source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_source")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<IPaymentSource>))]
#endif

        internal ExpandableField<IPaymentSource> InternalDefaultSource { get; set; }
        #endregion

        /// <summary>
        /// The tax rates applied to this invoice, if any.
        /// </summary>
        [JsonProperty("default_tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_tax_rates")]
#endif

        public List<TaxRate> DefaultTaxRates { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
#endif

        public bool? Deleted { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// Referenced as 'memo' in the Dashboard.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        /// <summary>
        /// Describes the current discount applied to this invoice, if there is one. Not populated
        /// if there are multiple discounts.
        /// </summary>
        [JsonProperty("discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount")]
#endif

        public Discount Discount { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts applied to the invoice. Line item discounts are applied before invoice
        /// discounts. Use <c>expand[]=discounts</c> to expand each discount.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
        [STJS.JsonInclude]
#endif

        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// The date on which payment for this invoice is due. This value will be <c>null</c> for
        /// invoices where <c>collection_method=charge_automatically</c>.
        /// </summary>
        [JsonProperty("due_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("due_date")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The date when this invoice is in effect. Same as <c>finalized_at</c> unless overwritten.
        /// When defined, this value replaces the system-generated 'Date of issue' printed on the
        /// invoice PDF and receipt.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// Ending customer balance after the invoice is finalized. Invoices are finalized
        /// approximately an hour after successful webhook delivery or when payment collection is
        /// attempted for the invoice. If the invoice has not been finalized yet, this will be null.
        /// </summary>
        [JsonProperty("ending_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ending_balance")]
#endif

        public long? EndingBalance { get; set; }

        /// <summary>
        /// Footer displayed on the invoice.
        /// </summary>
        [JsonProperty("footer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("footer")]
#endif

        public string Footer { get; set; }

        /// <summary>
        /// Details of the invoice that was cloned. See the <a
        /// href="https://stripe.com/docs/invoicing/invoice-revisions">revision documentation</a>
        /// for more details.
        /// </summary>
        [JsonProperty("from_invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from_invoice")]
#endif

        public InvoiceFromInvoice FromInvoice { get; set; }

        /// <summary>
        /// The URL for the hosted invoice page, which allows customers to view and pay an invoice.
        /// If the invoice has not been finalized yet, this will be null.
        /// </summary>
        [JsonProperty("hosted_invoice_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_invoice_url")]
#endif

        public string HostedInvoiceUrl { get; set; }

        /// <summary>
        /// The link to download the PDF for the invoice. If the invoice has not been finalized yet,
        /// this will be null.
        /// </summary>
        [JsonProperty("invoice_pdf")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_pdf")]
#endif

        public string InvoicePdf { get; set; }

        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif

        public InvoiceIssuer Issuer { get; set; }

        /// <summary>
        /// The error encountered during the previous attempt to finalize the invoice. This field is
        /// cleared when the invoice is successfully finalized.
        /// </summary>
        [JsonProperty("last_finalization_error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_finalization_error")]
#endif

        public StripeError LastFinalizationError { get; set; }

        #region Expandable LatestRevision

        /// <summary>
        /// (ID of the Invoice)
        /// The ID of the most recent non-draft revision of this invoice.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Invoice LatestRevision
        {
            get => this.InternalLatestRevision?.ExpandedObject;
            set => this.InternalLatestRevision = SetExpandableFieldObject(value, this.InternalLatestRevision);
        }

        [JsonProperty("latest_revision")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_revision")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Invoice>))]
#endif

        internal ExpandableField<Invoice> InternalLatestRevision { get; set; }
        #endregion

        /// <summary>
        /// The individual line items that make up the invoice. <c>lines</c> is sorted as follows:
        /// (1) pending invoice items (including prorations) in reverse chronological order, (2)
        /// subscription items in reverse chronological order, and (3) invoice items added after
        /// invoice creation in chronological order.
        /// </summary>
        [JsonProperty("lines")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lines")]
#endif

        public StripeList<InvoiceLineItem> Lines { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The time at which payment will next be attempted. This value will be <c>null</c> for
        /// invoices where <c>collection_method=send_invoice</c>.
        /// </summary>
        [JsonProperty("next_payment_attempt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("next_payment_attempt")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? NextPaymentAttempt { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on emails sent to the customer for this
        /// invoice. This starts with the customer's unique invoice_prefix if it is specified.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif

        public string Number { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account (if any) for which the funds of the invoice payment are intended. If set,
        /// the invoice will be presented with the branding and support information of the specified
        /// account. See the <a href="https://stripe.com/docs/billing/invoices/connect">Invoices
        /// with Connect</a> documentation for details.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        /// <summary>
        /// (Expanded)
        /// The account (if any) for which the funds of the invoice payment are intended. If set,
        /// the invoice will be presented with the branding and support information of the specified
        /// account. See the <a href="https://stripe.com/docs/billing/invoices/connect">Invoices
        /// with Connect</a> documentation for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
#endif

        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        /// <summary>
        /// Whether payment was successfully collected for this invoice. An invoice can be paid
        /// (most commonly) with a charge or with credit from the customer's account balance.
        /// </summary>
        [JsonProperty("paid")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paid")]
#endif

        public bool Paid { get; set; }

        /// <summary>
        /// Returns true if the invoice was manually marked paid, returns false if the invoice
        /// hasn't been paid yet or was paid on Stripe.
        /// </summary>
        [JsonProperty("paid_out_of_band")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paid_out_of_band")]
#endif

        public bool PaidOutOfBand { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// The PaymentIntent associated with this invoice. The PaymentIntent is generated when the
        /// invoice is finalized, and can then be used to pay the invoice. Note that voiding an
        /// invoice will cancel the PaymentIntent.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The PaymentIntent associated with this invoice. The PaymentIntent is generated when the
        /// invoice is finalized, and can then be used to pay the invoice. Note that voiding an
        /// invoice will cancel the PaymentIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
#endif

        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        [JsonProperty("payment_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_settings")]
#endif

        public InvoicePaymentSettings PaymentSettings { get; set; }

        /// <summary>
        /// End of the usage period during which invoice items were added to this invoice. This
        /// looks back one period for a subscription invoice. Use the <a
        /// href="https://stripe.com/api/invoices/line_item#invoice_line_item_object-period">line
        /// item period</a> to get the service period for each price.
        /// </summary>
        [JsonProperty("period_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("period_end")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime PeriodEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Start of the usage period during which invoice items were added to this invoice. This
        /// looks back one period for a subscription invoice. Use the <a
        /// href="https://stripe.com/api/invoices/line_item#invoice_line_item_object-period">line
        /// item period</a> to get the service period for each price.
        /// </summary>
        [JsonProperty("period_start")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("period_start")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime PeriodStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Total amount of all post-payment credit notes issued for this invoice.
        /// </summary>
        [JsonProperty("post_payment_credit_notes_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("post_payment_credit_notes_amount")]
#endif

        public long PostPaymentCreditNotesAmount { get; set; }

        /// <summary>
        /// Total amount of all pre-payment credit notes issued for this invoice.
        /// </summary>
        [JsonProperty("pre_payment_credit_notes_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pre_payment_credit_notes_amount")]
#endif

        public long PrePaymentCreditNotesAmount { get; set; }

        #region Expandable Quote

        /// <summary>
        /// (ID of the Quote)
        /// The quote this invoice was generated from.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string QuoteId
        {
            get => this.InternalQuote?.Id;
            set => this.InternalQuote = SetExpandableFieldId(value, this.InternalQuote);
        }

        /// <summary>
        /// (Expanded)
        /// The quote this invoice was generated from.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Quote Quote
        {
            get => this.InternalQuote?.ExpandedObject;
            set => this.InternalQuote = SetExpandableFieldObject(value, this.InternalQuote);
        }

        [JsonProperty("quote")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quote")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Quote>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Quote>))]
#endif

        internal ExpandableField<Quote> InternalQuote { get; set; }
        #endregion

        /// <summary>
        /// This is the transaction number that appears on email receipts sent for this invoice.
        /// </summary>
        [JsonProperty("receipt_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_number")]
#endif

        public string ReceiptNumber { get; set; }

        /// <summary>
        /// The rendering-related settings that control how the invoice is displayed on
        /// customer-facing surfaces such as PDF and Hosted Invoice Page.
        /// </summary>
        [JsonProperty("rendering")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rendering")]
#endif

        public InvoiceRendering Rendering { get; set; }

        /// <summary>
        /// The details of the cost of shipping, including the ShippingRate applied on the invoice.
        /// </summary>
        [JsonProperty("shipping_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_cost")]
#endif

        public InvoiceShippingCost ShippingCost { get; set; }

        /// <summary>
        /// Shipping details for the invoice. The Invoice PDF will use the <c>shipping_details</c>
        /// value if it is set, otherwise the PDF will render the shipping address from the
        /// customer.
        /// </summary>
        [JsonProperty("shipping_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_details")]
#endif

        public InvoiceShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// Starting customer balance before the invoice is finalized. If the invoice has not been
        /// finalized yet, this will be the current customer balance. For revision invoices, this
        /// also includes any customer balance that was applied to the original invoice.
        /// </summary>
        [JsonProperty("starting_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("starting_balance")]
#endif

        public long StartingBalance { get; set; }

        /// <summary>
        /// Extra information about an invoice for the customer's credit card statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif

        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The status of the invoice, one of <c>draft</c>, <c>open</c>, <c>paid</c>,
        /// <c>uncollectible</c>, or <c>void</c>. <a
        /// href="https://stripe.com/docs/billing/invoices/workflow#workflow-overview">Learn
        /// more</a>.
        /// One of: <c>draft</c>, <c>open</c>, <c>paid</c>, <c>uncollectible</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        [JsonProperty("status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_transitions")]
#endif

        public InvoiceStatusTransitions StatusTransitions { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The subscription that this invoice was prepared for, if any.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        /// <summary>
        /// (Expanded)
        /// The subscription that this invoice was prepared for, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Subscription>))]
#endif

        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        /// <summary>
        /// Details about the subscription that created this invoice.
        /// </summary>
        [JsonProperty("subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_details")]
#endif

        public InvoiceSubscriptionDetails SubscriptionDetails { get; set; }

        /// <summary>
        /// Only set for upcoming invoices that preview prorations. The time used to calculate
        /// prorations.
        /// </summary>
        [JsonProperty("subscription_proration_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_proration_date")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime SubscriptionProrationDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Total of all subscriptions, invoice items, and prorations on the invoice before any
        /// invoice level discount or exclusive tax is applied. Item discounts are already
        /// incorporated.
        /// </summary>
        [JsonProperty("subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subtotal")]
#endif

        public long Subtotal { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the subtotal of the
        /// invoice before any invoice level discount or tax is applied. Item discounts are already
        /// incorporated.
        /// </summary>
        [JsonProperty("subtotal_excluding_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subtotal_excluding_tax")]
#endif

        public long? SubtotalExcludingTax { get; set; }

        /// <summary>
        /// The amount of tax on this invoice. This is the sum of all the tax amounts on this
        /// invoice.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif

        public long? Tax { get; set; }

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock this invoice belongs to.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public TestHelpers.TestClock TestClock
        {
            get => this.InternalTestClock?.ExpandedObject;
            set => this.InternalTestClock = SetExpandableFieldObject(value, this.InternalTestClock);
        }

        [JsonProperty("test_clock")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("test_clock")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<TestHelpers.TestClock>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<TestHelpers.TestClock>))]
#endif

        internal ExpandableField<TestHelpers.TestClock> InternalTestClock { get; set; }
        #endregion

        [JsonProperty("threshold_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("threshold_reason")]
#endif

        public InvoiceThresholdReason ThresholdReason { get; set; }

        /// <summary>
        /// Total after discounts and taxes.
        /// </summary>
        [JsonProperty("total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total")]
#endif

        public long Total { get; set; }

        /// <summary>
        /// The aggregate amounts calculated per discount across all line items.
        /// </summary>
        [JsonProperty("total_discount_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_discount_amounts")]
#endif

        public List<InvoiceDiscountAmount> TotalDiscountAmounts { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the total amount of the
        /// invoice including all discounts but excluding all tax.
        /// </summary>
        [JsonProperty("total_excluding_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_excluding_tax")]
#endif

        public long? TotalExcludingTax { get; set; }

        /// <summary>
        /// Contains pretax credit amounts (ex: discount, credit grants, etc) that apply to this
        /// invoice. This is a combined list of total_pretax_credit_amounts across all invoice line
        /// items.
        /// </summary>
        [JsonProperty("total_pretax_credit_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_pretax_credit_amounts")]
#endif

        public List<InvoiceTotalPretaxCreditAmount> TotalPretaxCreditAmounts { get; set; }

        /// <summary>
        /// The aggregate amounts calculated per tax rate for all line items.
        /// </summary>
        [JsonProperty("total_tax_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_tax_amounts")]
#endif

        public List<InvoiceTaxAmount> TotalTaxAmounts { get; set; }

        /// <summary>
        /// The account (if any) the payment will be attributed to for tax reporting, and where
        /// funds from the payment will be transferred to for the invoice.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif

        public InvoiceTransferData TransferData { get; set; }

        /// <summary>
        /// Invoices are automatically paid or sent 1 hour after webhooks are delivered, or until
        /// all webhook delivery attempts have <a
        /// href="https://stripe.com/docs/billing/webhooks#understand">been exhausted</a>. This
        /// field tracks the time when webhooks for this invoice were successfully delivered. If the
        /// invoice had no webhooks to deliver, this will be set while the invoice is being created.
        /// </summary>
        [JsonProperty("webhooks_delivered_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("webhooks_delivered_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? WebhooksDeliveredAt { get; set; }
    }
}
