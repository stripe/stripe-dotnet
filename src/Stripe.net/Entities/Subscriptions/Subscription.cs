namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Subscription : StripeEntity<Subscription>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the application owner's Stripe account.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholds BillingThresholds { get; set; }

        /// <summary>
        /// A date in the future at which the subscription will automatically get canceled.
        /// </summary>
        [JsonProperty("cancel_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CancelAt { get; set; }

        /// <summary>
        /// If the subscription has been canceled with the
        /// <see cref="CancelAtPeriodEnd" /> flag set to true,
        /// <see cref="CancelAtPeriodEnd" /> on the
        /// subscription will be true.  You can use this attribute to determine
        /// whether a subscription that has a status of active is scheduled to
        /// be canceled at the end of the current period.
        /// </summary>
        [JsonProperty("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// If the subscription has been canceled, the date of that
        /// cancellation. If the subscription was canceled with
        /// <see cref="CancelAtPeriodEnd" />, <see cref="CanceledAt" /> will still reflect the
        /// date of the initial cancellation request, not the end of the
        /// subscription period when the subscription is automatically moved to
        /// a canceled state.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When
        /// charging automatically, Stripe will attempt to pay this subscription
        /// at the end of the cycle using the default source attached to the
        /// customer.  When sending an invoice, Stripe will email your customer
        /// an invoice with payment instructions.
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
        /// End of the current period that the subscription has been invoiced for. At the end of
        /// this period, a new invoice will be created.
        /// </summary>
        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CurrentPeriodEnd { get; set; }

        /// <summary>
        /// Start of the current period that the subscription has been invoiced for.
        /// </summary>
        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CurrentPeriodStart { get; set; }

        #region Expandable Customer

        /// <summary>
        /// ID of the customer who owns the subscription.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// Customer who owns this subscription (if it was expanded).
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
        /// Number of days a customer has to pay invoices generated by this subscription. This value will be null for subscriptions where billing=charge_automatically.
        /// </summary>
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// ID of the default payment method for the subscription.
        /// </summary>
        [JsonIgnore]
        public string DefaultPaymentMethodId
        {
            get => this.InternalDefaultPaymentMethod?.Id;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldId(value, this.InternalDefaultPaymentMethod);
        }

        /// <summary>
        /// Default payment method for the subscription (if it was expanded).
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

        /// <summary>
        /// ID of the default source for the subscription.
        /// </summary>
        [JsonIgnore]
        public string DefaultSourceId
        {
            get => this.InternalDefaultSource?.Id;
            set => this.InternalDefaultSource = SetExpandableFieldId(value, this.InternalDefaultSource);
        }

        /// <summary>
        /// Default source for the subscription (if it was expanded).
        /// </summary>
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
        /// The tax rates that will apply to any subscription item that does not have
        /// <c>tax_rates</c> set. Invoices created will have their <c>default_tax_rates</c>
        /// populated from the subscription.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<TaxRate> DefaultTaxRates { get; set; }

        /// <summary>
        /// Describes the current discount applied to this subscription, if there is one. When
        /// billing, a discount applied to a subscription overrides a discount applied on a
        /// customer-wide basis.
        /// </summary>
        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        /// <summary>
        /// If the subscription has ended, the date the subscription ended.
        /// </summary>
        [JsonProperty("ended_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// List of subscription items, each with an attached plan.
        /// </summary>
        [JsonProperty("items")]
        public StripeList<SubscriptionItem> Items { get; set; }

        #region Expandable LatestInvoice

        /// <summary>
        /// ID of the most recent invoice this subscription has generated.
        /// </summary>
        [JsonIgnore]
        public string LatestInvoiceId
        {
            get => this.InternalLatestInvoice?.Id;
            set => this.InternalLatestInvoice = SetExpandableFieldId(value, this.InternalLatestInvoice);
        }

        /// <summary>
        /// The most recent invoice this subscription has generated (if it was expanded).
        /// </summary>
        [JsonIgnore]
        public Invoice LatestInvoice
        {
            get => this.InternalLatestInvoice?.ExpandedObject;
            set => this.InternalLatestInvoice = SetExpandableFieldObject(value, this.InternalLatestInvoice);
        }

        [JsonProperty("latest_invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalLatestInvoice { get; set; }
        #endregion

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a subscription object.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Specifies the approximate timestamp on which any pending invoice items will be billed
        /// according to the schedule provided at <c>PendingInvoiceItemInterval</c>.
        /// </summary>
        [JsonProperty("next_pending_invoice_item_invoice")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? NextPendingInvoiceItemInvoice { get; set; }

        /// <summary>
        /// If specified, payment collection for this subscription will be paused.
        /// </summary>
        [JsonProperty("pause_collection")]
        public SubscriptionPauseCollection PauseCollection { get; set; }

        /// <summary>
        /// Specifies an interval for how often to bill for any pending invoice items. It is
        /// analogous to creating an invoice for the given subscription at the specified interval.
        /// </summary>
        [JsonProperty("pending_invoice_item_interval")]
        public SubscriptionPendingInvoiceItemInterval PendingInvoiceItemInterval { get; set; }

        #region Expandable PendingSetupIntent

        /// <summary>
        /// ID of the pending SetupIntent associated with this subscription.
        /// </summary>
        [JsonIgnore]
        public string PendingSetupIntentId
        {
            get => this.InternalPendingSetupIntent?.Id;
            set => this.InternalPendingSetupIntent = SetExpandableFieldId(value, this.InternalPendingSetupIntent);
        }

        /// <summary>
        /// The pending SetupIntent associated with this subscription (if it was expanded).
        /// </summary>
        [JsonIgnore]
        public SetupIntent PendingSetupIntent
        {
            get => this.InternalPendingSetupIntent?.ExpandedObject;
            set => this.InternalPendingSetupIntent = SetExpandableFieldObject(value, this.InternalPendingSetupIntent);
        }

        [JsonProperty("pending_setup_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupIntent>))]
        internal ExpandableField<SetupIntent> InternalPendingSetupIntent { get; set; }
        #endregion

        /// <summary>
        /// If specified, deferred upgrade changes that will be applied to the
        /// subscription once the <see cref="LatestInvoice" /> has been paid.
        /// </summary>
        [JsonProperty("pending_update")]
        public SubscriptionPendingUpdate PendingUpdate { get; set; }

        /// <summary>
        /// Plan the customer is subscribed to. Only set if the subscription contains a single plan.
        /// </summary>
        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// The quantity of the plan to which the customer is subscribed. Only set if the
        /// subscription contains a single plan.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        #region Expandable Schedule

        /// <summary>
        /// ID of the schedule attached to the subscription.
        /// </summary>
        [JsonIgnore]
        public string ScheduleId
        {
            get => this.InternalSchedule?.Id;
            set => this.InternalSchedule = SetExpandableFieldId(value, this.InternalSchedule);
        }

        /// <summary>
        /// Schedule attached to the subscription (if it was expanded).
        /// </summary>
        [JsonIgnore]
        public SubscriptionSchedule Schedule
        {
            get => this.InternalSchedule?.ExpandedObject;
            set => this.InternalSchedule = SetExpandableFieldObject(value, this.InternalSchedule);
        }

        [JsonProperty("schedule")]
        [JsonConverter(typeof(ExpandableFieldConverter<SubscriptionSchedule>))]
        internal ExpandableField<SubscriptionSchedule> InternalSchedule { get; set; }
        #endregion

        /// <summary>
        /// Date when the subscription was first created. The date might differ from the
        /// <c>created</c> date due to backdating.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Possible values are <c>incomplete</c>, <c>incomplete_expired</c>, <c>trialing</c>,
        /// <c>active</c>, <c>past_due</c>, <c>canceled</c>, or <c>unpaid</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// If specified, the funds from the subscription's invoices will be transferred to the
        /// destination and the ID of the resulting transfers will be found on the resulting
        /// charges.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SubscriptionTransferData TransferData { get; set; }

        /// <summary>
        /// If the subscription has a trial, the end of that trial.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        /// <summary>
        /// If the subscription has a trial, the beginning of that trial.
        /// </summary>
        [JsonProperty("trial_start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialStart { get; set; }
    }
}
