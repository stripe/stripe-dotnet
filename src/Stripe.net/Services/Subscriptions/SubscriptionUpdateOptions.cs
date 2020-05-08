namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("add_invoice_items")]
        public List<SubscriptionAddInvoiceItemOptions> AddInvoiceItems { get; set; }

        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholdsOptions BillingThresholds { get; set; }

        [JsonProperty("cancel_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CancelAt { get; set; }

        [JsonProperty("cancel_at_period_end")]
        public bool? CancelAtPeriodEnd { get; set; }

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        [JsonProperty("items")]
        public List<SubscriptionItemOptions> Items { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        [JsonProperty("pause_collection")]
        public SubscriptionPauseCollectionOptions PauseCollection { get; set; }

        [JsonProperty("payment_behavior")]
        public string PaymentBehavior { get; set; }

        [JsonProperty("pending_invoice_item_interval")]
        public SubscriptionPendingInvoiceItemIntervalOptions PendingInvoiceItemInterval { get; set; }

        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [JsonProperty("proration_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ProrationDate { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("transfer_data")]
        public SubscriptionTransferDataOptions TransferData { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, string> TrialEnd { get; set; }

        [JsonProperty("trial_from_plan")]
        public bool? TrialFromPlan { get; set; }
    }
}
