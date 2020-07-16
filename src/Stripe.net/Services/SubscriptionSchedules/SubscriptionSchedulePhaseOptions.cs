namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhaseOptions : INestedOptions
    {
        /// <summary>
        /// A list of prices and quantities that will generate invoice items appended to the next
        /// invoice. You may pass up to 10 items.
        /// </summary>
        [JsonProperty("add_invoice_items")]
        public List<SubscriptionAddInvoiceItemOptions> AddInvoiceItems { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the application owner's Stripe account.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// Can be set to <c>phase_start</c> to set the anchor to the
        /// start of the phase or <c>automatic</c> to automatically
        /// change it if needed. Cannot be set to <c>phase_start</c> if
        /// this phase specifies a trial.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. Pass an empty string to remove previously-defined thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When
        /// charging automatically, Stripe will attempt to pay the underlying
        /// subscription at the end of each billing cycle using the default
        /// source attached to the customer. When sending an invoice, Stripe
        /// will email your customer an invoice with payment instructions.
        /// Defaults to <c>charge_automatically</c> on creation.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// The code of the coupon to apply to this subscription. A coupon applied to a
        /// subscription will only affect invoices created for that particular subscription.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// ID of the default payment method for the subscription schedule.
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Ids of the tax rates to apply to this phase on the subscription schedule.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// The date at which this phase of the subscription schedule ends. If set,
        /// <c>iterations</c> must not be set.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Define the default settings applied to invoices created by this subscription schedule.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// Integer representing the multiplier applied to the plan interval. For example,
        /// <c>iterations=2</c> applied to a plan with <c>interval=month</c> and
        /// <c>interval_count=3</c> results in a phase of duration 2 * 3 months = 6 months.
        /// If set, <c>end_date</c> must not be set.
        /// </summary>
        [JsonProperty("iterations")]
        public long? Iterations { get; set; }

        /// <summary>
        /// List of configuration items, each with an attached plan, to apply during this phase of
        /// the subscription schedule.
        /// </summary>
        [JsonProperty("plans")]
        public List<SubscriptionSchedulePhaseItemOptions> Plans { get; set; }

        /// <summary>
        /// If the update changes the current phase, indicates if the changes should be prorated.
        /// Valid values are <c>create_prorations</c> or <c>none</c>, and the default value is
        /// <c>create_prorations</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// The date at which this phase of the subscription schedule starts.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The account (if any) the subscription's payments will be attributed
        /// to for tax reporting, and where funds from each payment will be
        /// transferred to for each of the subscription's invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SubscriptionTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// If set to <c>true</c> the entire phase is counted as a trial and the customer will not
        /// be charged for any fees.
        /// </summary>
        [JsonProperty("trial")]
        public bool? Trial { get; set; }

        /// <summary>
        /// Sets the phase to trialing from the start date to this date. Must be before the phase
        /// end date, can not be combined with <c>trial</c>.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
