namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Subscription : StripeEntity<Subscription>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime BillingCycleAnchor { get; set; }

        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholds BillingThresholds { get; set; }

        [JsonProperty("cancel_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CancelAt { get; set; }

        [JsonProperty("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CurrentPeriodEnd { get; set; }

        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CurrentPeriodStart { get; set; }

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

        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        #region Expandable DefaultPaymentMethod

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

        [JsonProperty("default_tax_rates")]
        public List<TaxRate> DefaultTaxRates { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        [JsonProperty("ended_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EndedAt { get; set; }

        [JsonProperty("items")]
        public StripeList<SubscriptionItem> Items { get; set; }

        #region Expandable LatestInvoice

        [JsonIgnore]
        public string LatestInvoiceId
        {
            get => this.InternalLatestInvoice?.Id;
            set => this.InternalLatestInvoice = SetExpandableFieldId(value, this.InternalLatestInvoice);
        }

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

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("next_pending_invoice_item_invoice")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? NextPendingInvoiceItemInvoice { get; set; }

        [JsonProperty("pause_collection")]
        public SubscriptionPauseCollection PauseCollection { get; set; }

        [JsonProperty("pending_invoice_item_interval")]
        public SubscriptionPendingInvoiceItemInterval PendingInvoiceItemInterval { get; set; }

        #region Expandable PendingSetupIntent

        [JsonIgnore]
        public string PendingSetupIntentId
        {
            get => this.InternalPendingSetupIntent?.Id;
            set => this.InternalPendingSetupIntent = SetExpandableFieldId(value, this.InternalPendingSetupIntent);
        }

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

        [JsonProperty("pending_update")]
        public SubscriptionPendingUpdate PendingUpdate { get; set; }

        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        #region Expandable Schedule

        [JsonIgnore]
        public string ScheduleId
        {
            get => this.InternalSchedule?.Id;
            set => this.InternalSchedule = SetExpandableFieldId(value, this.InternalSchedule);
        }

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

        [JsonProperty("start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("transfer_data")]
        public SubscriptionTransferData TransferData { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        [JsonProperty("trial_start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialStart { get; set; }
    }
}
