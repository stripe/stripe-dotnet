namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhaseOptions : INestedOptions
    {
        [JsonProperty("add_invoice_items")]
        public List<SubscriptionSchedulePhaseAddInvoiceItemOptions> AddInvoiceItems { get; set; }

        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        [JsonProperty("billing_thresholds")]
        public SubscriptionSchedulePhaseBillingThresholdsOptions BillingThresholds { get; set; }

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndDate { get; set; }

        [JsonProperty("invoice_settings")]
        public SubscriptionSchedulePhaseInvoiceSettingsOptions InvoiceSettings { get; set; }

        [JsonProperty("iterations")]
        public long? Iterations { get; set; }

        [JsonProperty("plans")]
        public List<SubscriptionSchedulePhaseItemOptions> Plans { get; set; }

        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartDate { get; set; }

        [JsonProperty("transfer_data")]
        public SubscriptionSchedulePhaseTransferDataOptions TransferData { get; set; }

        [JsonProperty("trial")]
        public bool? Trial { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
