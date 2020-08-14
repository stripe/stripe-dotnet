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
        public List<SubscriptionSchedulePhaseAddInvoiceItemOptions> AddInvoiceItems { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the application owner's Stripe account. The request must be made by a platform
        /// account on a connected account in order to set an application fee percentage. For more
        /// information, see the application fees <a
        /// href="https://stripe.com/docs/connect/subscriptions#collecting-fees-on-subscriptions">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// Can be set to <c>phase_start</c> to set the anchor to the start of the phase or
        /// <c>automatic</c> to automatically change it if needed. Cannot be set to
        /// <c>phase_start</c> if this phase specifies a trial. For more information, see the
        /// billing cycle <a
        /// href="https://stripe.com/docs/billing/subscriptions/billing-cycle">documentation</a>.
        /// One of: <c>automatic</c>, or <c>phase_start</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. Pass an empty string to remove previously-defined thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionSchedulePhaseBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay the underlying subscription at the end of each billing cycle
        /// using the default source attached to the customer. When sending an invoice, Stripe will
        /// email your customer an invoice with payment instructions. Defaults to
        /// <c>charge_automatically</c> on creation.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// The identifier of the coupon to apply to this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// ID of the default payment method for the subscription schedule. It must belong to the
        /// customer associated with the subscription schedule. If not set, invoices will use the
        /// default payment method in the customer's invoice settings.
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// A list of <a href="https://stripe.com/docs/api/tax_rates">Tax Rate</a> ids. These Tax
        /// Rates will set the Subscription's <a
        /// href="https://stripe.com/docs/api/subscriptions/create#create_subscription-default_tax_rates"><c>default_tax_rates</c></a>,
        /// which means they will be the Invoice's <a
        /// href="https://stripe.com/docs/api/invoices/create#create_invoice-default_tax_rates"><c>default_tax_rates</c></a>
        /// for any Invoices issued by the Subscription during this Phase.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// The date at which this phase of the subscription schedule ends. If set,
        /// <c>iterations</c> must not be set.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public SubscriptionSchedulePhaseInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// Integer representing the multiplier applied to the price interval. For example,
        /// <c>iterations=2</c> applied to a price with <c>interval=month</c> and
        /// <c>interval_count=3</c> results in a phase of duration <c>2 * 3 months = 6 months</c>.
        /// If set, <c>end_date</c> must not be set.
        /// </summary>
        [JsonProperty("iterations")]
        public long? Iterations { get; set; }

        /// <summary>
        /// List of configuration items, each with an attached price, to apply during this phase of
        /// the subscription schedule.
        /// </summary>
        [JsonProperty("plans")]
        public List<SubscriptionSchedulePhaseItemOptions> Plans { get; set; }

        /// <summary>
        /// If a subscription schedule will create prorations when transitioning to this phase.
        /// Possible values are <c>create_prorations</c> or <c>none</c>, and the default value is
        /// <c>create_prorations</c>. See <a
        /// href="https://stripe.com/docs/billing/subscriptions/prorations">Prorations</a>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The data with which to automatically create a Transfer for each of the subscription's
        /// invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SubscriptionSchedulePhaseTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// If set to true the entire phase is counted as a trial and the customer will not be
        /// charged for any fees.
        /// </summary>
        [JsonProperty("trial")]
        public bool? Trial { get; set; }

        /// <summary>
        /// Sets the phase to trialing from the start date to this date. Must be before the phase
        /// end date, can not be combined with <c>trial</c>.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
