// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionSchedulePhaseOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// A list of prices and quantities that will generate invoice items appended to the next
        /// invoice for this phase. You may pass up to 20 items.
        /// </summary>
        [JsonProperty("add_invoice_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("add_invoice_items")]
#endif
        public List<SubscriptionSchedulePhaseAddInvoiceItemOptions> AddInvoiceItems { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the application owner's Stripe account. The request must be made by a platform account
        /// on a connected account in order to set an application fee percentage. For more
        /// information, see the application fees <a
        /// href="https://stripe.com/docs/connect/subscriptions#collecting-fees-on-subscriptions">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_percent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_percent")]
#endif
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// Automatic tax settings for this phase.
        /// </summary>
        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public SubscriptionSchedulePhaseAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Can be set to <c>phase_start</c> to set the anchor to the start of the phase or
        /// <c>automatic</c> to automatically change it if needed. Cannot be set to
        /// <c>phase_start</c> if this phase specifies a trial. For more information, see the
        /// billing cycle <a
        /// href="https://stripe.com/docs/billing/subscriptions/billing-cycle">documentation</a>.
        /// One of: <c>automatic</c>, or <c>phase_start</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cycle_anchor")]
#endif
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. Pass an empty string to remove previously-defined thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_thresholds")]
#endif
        public SubscriptionSchedulePhaseBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay the underlying subscription at the end of each billing cycle
        /// using the default source attached to the customer. When sending an invoice, Stripe will
        /// email your customer an invoice with payment instructions and mark the subscription as
        /// <c>active</c>. Defaults to <c>charge_automatically</c> on creation.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_method")]
#endif
        public string CollectionMethod { get; set; }

        /// <summary>
        /// The ID of the coupon to apply to this phase of the subscription schedule. This field has
        /// been deprecated and will be removed in a future API version. Use <c>discounts</c>
        /// instead.
        /// </summary>
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// ID of the default payment method for the subscription schedule. It must belong to the
        /// customer associated with the subscription schedule. If not set, invoices will use the
        /// default payment method in the customer's invoice settings.
        /// </summary>
        [JsonProperty("default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_payment_method")]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_tax_rates")]
#endif
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// Subscription description, meant to be displayable to the customer. Use this field to
        /// optionally store an explanation of the subscription for rendering in Stripe surfaces and
        /// certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the schedule phase. If not specified, inherits
        /// the discount from the subscription's customer. Pass an empty string to avoid inheriting
        /// any discounts.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<SubscriptionSchedulePhaseDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The date at which this phase of the subscription schedule ends. If set,
        /// <c>iterations</c> must not be set.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_date")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, SubscriptionSchedulePhaseEndDate> EndDate { get; set; }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_settings")]
#endif
        public SubscriptionSchedulePhaseInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// List of configuration items, each with an attached price, to apply during this phase of
        /// the subscription schedule.
        /// </summary>
        [JsonProperty("items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("items")]
#endif
        public List<SubscriptionSchedulePhaseItemOptions> Items { get; set; }

        /// <summary>
        /// Integer representing the multiplier applied to the price interval. For example,
        /// <c>iterations=2</c> applied to a price with <c>interval=month</c> and
        /// <c>interval_count=3</c> results in a phase of duration <c>2 * 3 months = 6 months</c>.
        /// If set, <c>end_date</c> must not be set.
        /// </summary>
        [JsonProperty("iterations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iterations")]
#endif
        public long? Iterations { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to a phase. Metadata on a schedule's phase will update the underlying
        /// subscription's <c>metadata</c> when the phase is entered, adding new keys and replacing
        /// existing keys in the subscription's <c>metadata</c>. Individual keys in the
        /// subscription's <c>metadata</c> can be unset by posting an empty value to them in the
        /// phase's <c>metadata</c>. To unset all keys in the subscription's <c>metadata</c>, update
        /// the subscription directly or unset every key individually from the phase's
        /// <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The account on behalf of which to charge, for each of the associated subscription's
        /// invoices.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// If specified, payment collection for this subscription will be paused. Note that the
        /// subscription status will be unchanged and will not be updated to <c>paused</c>. Learn
        /// more about <a href="https://stripe.com/docs/billing/subscriptions/pause-payment">pausing
        /// collection</a>.
        /// </summary>
        [JsonProperty("pause_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pause_collection")]
#endif
        public SubscriptionSchedulePhasePauseCollectionOptions PauseCollection { get; set; }

        /// <summary>
        /// Whether the subscription schedule will create <a
        /// href="https://stripe.com/docs/billing/subscriptions/prorations">prorations</a> when
        /// transitioning to this phase. The default value is <c>create_prorations</c>. This setting
        /// controls prorations when a phase is started asynchronously and it is persisted as a
        /// field on the phase. It's different from the request-level <a
        /// href="https://stripe.com/docs/api/subscription_schedules/update#update_subscription_schedule-proration_behavior">proration_behavior</a>
        /// parameter which controls what happens if the update request affects the billing
        /// configuration of the current phase.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// The date at which this phase of the subscription schedule starts or <c>now</c>. Must be
        /// set on the first phase.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start_date")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, SubscriptionSchedulePhaseStartDate> StartDate { get; set; }

        /// <summary>
        /// The data with which to automatically create a Transfer for each of the associated
        /// subscription's invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public SubscriptionSchedulePhaseTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// If set to true the entire phase is counted as a trial and the customer will not be
        /// charged for any fees.
        /// </summary>
        [JsonProperty("trial")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial")]
#endif
        public bool? Trial { get; set; }

        /// <summary>
        /// Specify trial behavior when crossing phase boundaries.
        /// One of: <c>continue</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("trial_continuation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_continuation")]
#endif
        public string TrialContinuation { get; set; }

        /// <summary>
        /// Sets the phase to trialing from the start date to this date. Must be before the phase
        /// end date, can not be combined with <c>trial</c>.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_end")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, SubscriptionSchedulePhaseTrialEnd> TrialEnd { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_settings")]
#endif
        public SubscriptionSchedulePhaseTrialSettingsOptions TrialSettings { get; set; }
    }
}
