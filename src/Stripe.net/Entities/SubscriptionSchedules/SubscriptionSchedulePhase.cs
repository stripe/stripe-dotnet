namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhase : StripeEntity<SubscriptionSchedulePhase>
    {
        [JsonProperty("add_invoice_items")]
        public List<SubscriptionSchedulePhaseAddInvoiceItem> AddInvoiceItems { get; set; }

        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        [JsonProperty("billing_thresholds")]
        public SubscriptionSchedulePhaseBillingThresholds BillingThresholds { get; set; }

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        #region Expandable Coupon

        [JsonIgnore]
        public string CouponId
        {
            get => this.InternalCoupon?.Id;
            set => this.InternalCoupon = SetExpandableFieldId(value, this.InternalCoupon);
        }

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

        [JsonProperty("default_tax_rates")]
        public List<TaxRate> DefaultTaxRates { get; set; }

        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EndDate { get; set; }

        [JsonProperty("invoice_settings")]
        public SubscriptionSchedulePhaseInvoiceSettings InvoiceSettings { get; set; }

        [JsonProperty("plans")]
        public List<SubscriptionSchedulePhaseItem> Plans { get; set; }

        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartDate { get; set; }

        [JsonProperty("transfer_data")]
        public SubscriptionSchedulePhaseTransferData TransferData { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
