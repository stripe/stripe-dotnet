// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhase : StripeEntity<SubscriptionSchedulePhase>, IHasMetadata
    {
        /// <summary>
        /// A list of prices and quantities that will generate invoice items appended to the next
        /// invoice for this phase.
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

        [JsonProperty("automatic_tax")]
        public SubscriptionSchedulePhaseAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// Possible values are <c>phase_start</c> or <c>automatic</c>. If <c>phase_start</c> then
        /// billing cycle anchor of the subscription is set to the start of the phase when entering
        /// the phase. If <c>automatic</c> then the billing cycle anchor is automatically modified
        /// as needed when entering the phase. For more information, see the billing cycle <a
        /// href="https://stripe.com/docs/billing/subscriptions/billing-cycle">documentation</a>.
        /// One of: <c>automatic</c>, or <c>phase_start</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionSchedulePhaseBillingThresholds BillingThresholds { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay the underlying subscription at the end of each billing cycle
        /// using the default source attached to the customer. When sending an invoice, Stripe will
        /// email your customer an invoice with payment instructions and mark the subscription as
        /// <c>active</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        #region Expandable Coupon

        /// <summary>
        /// (ID of the Coupon)
        /// ID of the coupon to use during this phase of the subscription schedule.
        /// </summary>
        [JsonIgnore]
        public string CouponId
        {
            get => this.InternalCoupon?.Id;
            set => this.InternalCoupon = SetExpandableFieldId(value, this.InternalCoupon);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the coupon to use during this phase of the subscription schedule.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
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

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the default payment method for the subscription schedule. It must belong to the
        /// customer associated with the subscription schedule. If not set, invoices will use the
        /// default payment method in the customer's invoice settings.
        /// </summary>
        [JsonIgnore]
        public string DefaultPaymentMethodId
        {
            get => this.InternalDefaultPaymentMethod?.Id;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldId(value, this.InternalDefaultPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the default payment method for the subscription schedule. It must belong to the
        /// customer associated with the subscription schedule. If not set, invoices will use the
        /// default payment method in the customer's invoice settings.
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

        /// <summary>
        /// The default tax rates to apply to the subscription during this phase of the subscription
        /// schedule.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<TaxRate> DefaultTaxRates { get; set; }

        /// <summary>
        /// Subscription description, meant to be displayable to the customer. Use this field to
        /// optionally store an explanation of the subscription.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The end of this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EndDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The invoice settings applicable during this phase.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public SubscriptionSchedulePhaseInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// Subscription items to configure the subscription to during this phase of the
        /// subscription schedule.
        /// </summary>
        [JsonProperty("items")]
        public List<SubscriptionSchedulePhaseItem> Items { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to a phase. Metadata on a schedule's phase will update the underlying
        /// subscription's <c>metadata</c> when the phase is entered. Updating the underlying
        /// subscription's <c>metadata</c> directly will not affect the current phase's
        /// <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account (if any) the charge was made on behalf of for charges associated with the
        /// schedule's subscription. See the Connect documentation for details.
        /// </summary>
        [JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        /// <summary>
        /// (Expanded)
        /// The account (if any) the charge was made on behalf of for charges associated with the
        /// schedule's subscription. See the Connect documentation for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        /// <summary>
        /// If the subscription schedule will prorate when transitioning to this phase. Possible
        /// values are <c>create_prorations</c> and <c>none</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// The start of this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The account (if any) the associated subscription's payments will be attributed to for
        /// tax reporting, and where funds from each payment will be transferred to for each of the
        /// subscription's invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SubscriptionSchedulePhaseTransferData TransferData { get; set; }

        /// <summary>
        /// When the trial ends within the phase.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
