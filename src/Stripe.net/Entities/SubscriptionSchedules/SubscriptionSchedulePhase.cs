namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhase : StripeEntity<SubscriptionSchedulePhase>
    {
        /// <summary>
        /// A list of prices and quantities that will generate invoice items appended to the next
        /// invoice.
        /// </summary>
        [JsonProperty("add_invoice_items")]
        public List<SubscriptionSchedulePhaseAddInvoiceItem> AddInvoiceItems { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the application owner's Stripe account during this phase of the schedule.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// Possible values are <c>phase_start</c> or <c>automatic</c>. If
        /// <c>phase_start</c> then billing cycle anchor of the
        /// subscription is set to the start of the phase when entering
        /// the phase. If <c>automatic</c> then the billing cycle anchor
        /// is automatically modified as needed when entering the phase.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholds BillingThresholds { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging
        /// automatically, Stripe will attempt to pay this subscription at the
        /// end of the cycle using the default source attached to the customer.
        /// When sending an invoice, Stripe will email your customer an invoice
        /// with payment instructions.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        #region Expandable Coupon

        /// <summary>
        /// ID of the <see cref="Coupon"/> associated with this phase for the subscription schedule.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string CouponId
        {
            get => this.InternalCoupon?.Id;
            set => this.InternalCoupon = SetExpandableFieldId(value, this.InternalCoupon);
        }

        /// <summary>
        /// (Expanded) The <see cref="Coupon"/> associated with this phase for the subscription
        /// schedule.
        /// </summary>
        [JsonIgnore]
        public Coupon Coupon
        {
            get => this.InternalCoupon?.ExpandedObject;
            set => this.InternalCoupon = SetExpandableFieldObject(value, this.InternalCoupon);
        }

        [JsonProperty("coupon")]
        [JsonConverter(typeof(ExpandableFieldConverter<Coupon>))]
        internal ExpandableField<Coupon> InternalCoupon { get; set; }
        #endregion

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// ID of the default payment method for the subscription schedule.
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

        /// <summary>
        /// The default tax rates which apply to the phase of this subscription schedule.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<TaxRate> DefaultTaxRates { get; set; }

        /// <summary>
        /// The end of this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The default invoice settings for this phase.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// Plans to subscribe during this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("plans")]
        public List<SubscriptionSchedulePhaseItem> Plans { get; set; }

        /// <summary>
        /// Controls whether or not the subscription schedule will prorate when transitioning
        /// to this phase. Values are <c>create_prorations</c> and <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// The start of this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// If provided, each invoice created during this phase of the subscription schedule will
        /// apply the tax rate, increasing the amount billed to the customer.
        /// </summary>
        [Obsolete("Use DefaultTaxRates")]
        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        /// <summary>
        /// The account (if any) the subscription's payments will be attributed
        /// to for tax reporting, and where funds from each payment will be
        /// transferred to for each of the subscription's invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SubscriptionTransferData TransferData { get; set; }

        /// <summary>
        /// When the trial ends within the phase.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
