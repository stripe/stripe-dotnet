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

        /// <summary>
        /// Determines the date of the first full invoice, and, for plans with <c>month</c> or
        /// <c>year</c> intervals, the day of the month for subsequent invoices.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime BillingCycleAnchor { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CancelAt { get; set; }

        /// <summary>
        /// If the subscription has been canceled with the <c>at_period_end</c> flag set to
        /// <c>true</c>, <c>cancel_at_period_end</c> on the subscription will be true. You can use
        /// this attribute to determine whether a subscription that has a status of active is
        /// scheduled to be canceled at the end of the current period.
        /// </summary>
        [JsonProperty("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// If the subscription has been canceled, the date of that cancellation. If the
        /// subscription was canceled with <c>cancel_at_period_end</c>, <c>canceled_at</c> will
        /// still reflect the date of the initial cancellation request, not the end of the
        /// subscription period when the subscription is automatically moved to a canceled state.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay this subscription at the end of the cycle using the default
        /// source attached to the customer. When sending an invoice, Stripe will email your
        /// customer an invoice with payment instructions.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// End of the current period that the subscription has been invoiced for. At the end of
        /// this period, a new invoice will be created.
        /// </summary>
        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CurrentPeriodEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Start of the current period that the subscription has been invoiced for.
        /// </summary>
        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CurrentPeriodStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the customer who owns the subscription.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the customer who owns the subscription.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
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
        /// Number of days a customer has to pay invoices generated by this subscription. This value
        /// will be <c>null</c> for subscriptions where
        /// <c>collection_method=charge_automatically</c>.
        /// </summary>
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the default payment method for the subscription. It must belong to the customer
        /// associated with the subscription. If not set, invoices will use the default payment
        /// method in the customer's invoice settings.
        /// </summary>
        [JsonIgnore]
        public string DefaultPaymentMethodId
        {
            get => this.InternalDefaultPaymentMethod?.Id;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldId(value, this.InternalDefaultPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the default payment method for the subscription. It must belong to the customer
        /// associated with the subscription. If not set, invoices will use the default payment
        /// method in the customer's invoice settings.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
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
        /// (ID of the IPaymentSource)
        /// ID of the default payment source for the subscription. It must belong to the customer
        /// associated with the subscription and be in a chargeable state. If not set, defaults to
        /// the customer's default source.
        /// </summary>
        [JsonIgnore]
        public string DefaultSourceId
        {
            get => this.InternalDefaultSource?.Id;
            set => this.InternalDefaultSource = SetExpandableFieldId(value, this.InternalDefaultSource);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the default payment source for the subscription. It must belong to the customer
        /// associated with the subscription and be in a chargeable state. If not set, defaults to
        /// the customer's default source.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
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
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// List of subscription items, each with an attached price.
        /// </summary>
        [JsonProperty("items")]
        public StripeList<SubscriptionItem> Items { get; set; }

        #region Expandable LatestInvoice

        /// <summary>
        /// (ID of the Invoice)
        /// The most recent invoice this subscription has generated.
        /// </summary>
        [JsonIgnore]
        public string LatestInvoiceId
        {
            get => this.InternalLatestInvoice?.Id;
            set => this.InternalLatestInvoice = SetExpandableFieldId(value, this.InternalLatestInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// The most recent invoice this subscription has generated.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Specifies the approximate timestamp on which any pending invoice items will be billed
        /// according to the schedule provided at <c>pending_invoice_item_interval</c>.
        /// </summary>
        [JsonProperty("next_pending_invoice_item_invoice")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? NextPendingInvoiceItemInvoice { get; set; }

        /// <summary>
        /// If specified, payment collection for this subscription will be paused.
        /// </summary>
        [JsonProperty("pause_collection")]
        public SubscriptionPauseCollection PauseCollection { get; set; }

        /// <summary>
        /// Specifies an interval for how often to bill for any pending invoice items. It is
        /// analogous to calling <a href="https://stripe.com/docs/api#create_invoice">Create an
        /// invoice</a> for the given subscription at the specified interval.
        /// </summary>
        [JsonProperty("pending_invoice_item_interval")]
        public SubscriptionPendingInvoiceItemInterval PendingInvoiceItemInterval { get; set; }

        #region Expandable PendingSetupIntent

        /// <summary>
        /// (ID of the SetupIntent)
        /// You can use this <a href="https://stripe.com/docs/api/setup_intents">SetupIntent</a> to
        /// collect user authentication when creating a subscription without immediate payment or
        /// updating a subscription's payment method, allowing you to optimize for off-session
        /// payments. Learn more in the <a
        /// href="https://stripe.com/docs/billing/migration/strong-customer-authentication#scenario-2">SCA
        /// Migration Guide</a>.
        /// </summary>
        [JsonIgnore]
        public string PendingSetupIntentId
        {
            get => this.InternalPendingSetupIntent?.Id;
            set => this.InternalPendingSetupIntent = SetExpandableFieldId(value, this.InternalPendingSetupIntent);
        }

        /// <summary>
        /// (Expanded)
        /// You can use this <a href="https://stripe.com/docs/api/setup_intents">SetupIntent</a> to
        /// collect user authentication when creating a subscription without immediate payment or
        /// updating a subscription's payment method, allowing you to optimize for off-session
        /// payments. Learn more in the <a
        /// href="https://stripe.com/docs/billing/migration/strong-customer-authentication#scenario-2">SCA
        /// Migration Guide</a>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
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
        /// If specified, <a
        /// href="https://stripe.com/docs/billing/subscriptions/pending-updates">pending updates</a>
        /// that will be applied to the subscription once the <c>latest_invoice</c> has been paid.
        /// </summary>
        [JsonProperty("pending_update")]
        public SubscriptionPendingUpdate PendingUpdate { get; set; }

        /// <summary>
        /// Hash describing the plan the customer is subscribed to. Only set if the subscription
        /// contains a single plan.
        /// </summary>
        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// The quantity of the plan to which the customer is subscribed. For example, if your plan
        /// is $10/user/month, and your customer has 5 users, you could pass 5 as the quantity to
        /// have the customer charged $50 (5 x $10) monthly. Only set if the subscription contains a
        /// single plan.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        #region Expandable Schedule

        /// <summary>
        /// (ID of the SubscriptionSchedule)
        /// The schedule attached to the subscription.
        /// </summary>
        [JsonIgnore]
        public string ScheduleId
        {
            get => this.InternalSchedule?.Id;
            set => this.InternalSchedule = SetExpandableFieldId(value, this.InternalSchedule);
        }

        /// <summary>
        /// (Expanded)
        /// The schedule attached to the subscription.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
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
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Possible values are <c>incomplete</c>, <c>incomplete_expired</c>, <c>trialing</c>,
        /// <c>active</c>, <c>past_due</c>, <c>canceled</c>, or <c>unpaid</c>.
        ///
        /// For <c>collection_method=charge_automatically</c> a subscription moves into
        /// <c>incomplete</c> if the initial payment attempt fails. A subscription in this state can
        /// only have metadata and default_source updated. Once the first invoice is paid, the
        /// subscription moves into an <c>active</c> state. If the first invoice is not paid within
        /// 23 hours, the subscription transitions to <c>incomplete_expired</c>. This is a terminal
        /// state, the open invoice will be voided and no further invoices will be generated.
        ///
        /// A subscription that is currently in a trial period is <c>trialing</c> and moves to
        /// <c>active</c> when the trial period is over.
        ///
        /// If subscription <c>collection_method=charge_automatically</c> it becomes <c>past_due</c>
        /// when payment to renew it fails and <c>canceled</c> or <c>unpaid</c> (depending on your
        /// subscriptions settings) when Stripe has exhausted all payment retry attempts.
        ///
        /// If subscription <c>collection_method=send_invoice</c> it becomes <c>past_due</c> when
        /// its invoice is not paid by the due date, and <c>canceled</c> or <c>unpaid</c> if it is
        /// still not paid by an additional deadline after that. Note that when a subscription has a
        /// status of <c>unpaid</c>, no subsequent invoices will be attempted (invoices will be
        /// created, but then immediately automatically closed). After receiving updated payment
        /// information from a customer, you may choose to reopen and pay their closed invoices.
        /// One of: <c>active</c>, <c>canceled</c>, <c>incomplete</c>, <c>incomplete_expired</c>,
        /// <c>past_due</c>, <c>trialing</c>, or <c>unpaid</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The account (if any) the subscription's payments will be attributed to for tax
        /// reporting, and where funds from each payment will be transferred to for each of the
        /// subscription's invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SubscriptionTransferData TransferData { get; set; }

        /// <summary>
        /// If the subscription has a trial, the end of that trial.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        /// <summary>
        /// If the subscription has a trial, the beginning of that trial.
        /// </summary>
        [JsonProperty("trial_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TrialStart { get; set; }
    }
}
