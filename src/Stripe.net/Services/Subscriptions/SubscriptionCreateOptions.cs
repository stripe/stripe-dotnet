// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionCreateOptions : BaseOptions, IHasMetadata
    {
        private decimal? applicationFeePercent;
        private SubscriptionBillingThresholdsOptions billingThresholds;
        private List<string> defaultTaxRates;
        private List<SubscriptionDiscountOptions> discounts;
        private Dictionary<string, string> metadata;
        private string onBehalfOf;
        private SubscriptionPendingInvoiceItemIntervalOptions pendingInvoiceItemInterval;

        /// <summary>
        /// A list of prices and quantities that will generate invoice items appended to the next
        /// invoice for this subscription. You may pass up to 20 items.
        /// </summary>
        [JsonProperty("add_invoice_items")]
        [STJS.JsonPropertyName("add_invoice_items")]
        public List<SubscriptionAddInvoiceItemOptions> AddInvoiceItems { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the application owner's Stripe account. The request must be made by a platform account
        /// on a connected account in order to set an application fee percentage. For more
        /// information, see the application fees <a
        /// href="https://stripe.com/docs/connect/subscriptions#collecting-fees-on-subscriptions">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        [STJS.JsonPropertyName("application_fee_percent")]
        public decimal? ApplicationFeePercent
        {
            get => this.applicationFeePercent;
            set
            {
                this.applicationFeePercent = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Automatic tax settings for this subscription.
        /// </summary>
        [JsonProperty("automatic_tax")]
        [STJS.JsonPropertyName("automatic_tax")]
        public SubscriptionAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// A past timestamp to backdate the subscription's start date to. If set, the first invoice
        /// will contain line items for the timespan between the start date and the current time.
        /// Can be combined with trials and the billing cycle anchor.
        /// </summary>
        [JsonProperty("backdate_start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("backdate_start_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? BackdateStartDate { get; set; }

        /// <summary>
        /// The Billing Cadence which controls the timing of recurring invoice generation for this
        /// subscription. If unset, the subscription will bill according to its own configured
        /// schedule and create its own invoices. If set, this subscription will be billed by the
        /// cadence instead, potentially sharing invoices with the other subscriptions linked to
        /// that Cadence.
        /// </summary>
        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }

        /// <summary>
        /// A future timestamp in UTC format to anchor the subscription's <a
        /// href="https://docs.stripe.com/subscriptions/billing-cycle">billing cycle</a>. The anchor
        /// is the reference point that aligns future billing cycle dates. It sets the day of week
        /// for <c>week</c> intervals, the day of month for <c>month</c> and <c>year</c> intervals,
        /// and the month of year for <c>year</c> intervals.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? BillingCycleAnchor { get; set; }

        /// <summary>
        /// Mutually exclusive with billing_cycle_anchor and only valid with monthly and yearly
        /// price intervals. When provided, the billing_cycle_anchor is set to the next occurrence
        /// of the day_of_month at the hour, minute, and second UTC.
        /// </summary>
        [JsonProperty("billing_cycle_anchor_config")]
        [STJS.JsonPropertyName("billing_cycle_anchor_config")]
        public SubscriptionBillingCycleAnchorConfigOptions BillingCycleAnchorConfig { get; set; }

        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// </summary>
        [JsonProperty("billing_mode")]
        [STJS.JsonPropertyName("billing_mode")]
        public SubscriptionBillingModeOptions BillingMode { get; set; }

        /// <summary>
        /// Sets the billing schedules for the subscription.
        /// </summary>
        [JsonProperty("billing_schedules")]
        [STJS.JsonPropertyName("billing_schedules")]
        public List<SubscriptionBillingScheduleOptions> BillingSchedules { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. When updating, pass an empty string to remove previously-defined
        /// thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        [STJS.JsonPropertyName("billing_thresholds")]
        public SubscriptionBillingThresholdsOptions BillingThresholds
        {
            get => this.billingThresholds;
            set
            {
                this.billingThresholds = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A timestamp at which the subscription should cancel. If set to a date before the current
        /// period ends, this will cause a proration if prorations have been enabled using
        /// <c>proration_behavior</c>. If set during a future period, this will always cause a
        /// proration for that period.
        /// </summary>
        [JsonProperty("cancel_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("cancel_at")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionCancelAt> CancelAt { get; set; }

        /// <summary>
        /// Indicate whether this subscription should cancel at the end of the current period
        /// (<c>current_period_end</c>). Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("cancel_at_period_end")]
        [STJS.JsonPropertyName("cancel_at_period_end")]
        public bool? CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay this subscription at the end of the cycle using the default
        /// source attached to the customer. When sending an invoice, Stripe will email your
        /// customer an invoice with payment instructions and mark the subscription as
        /// <c>active</c>. Defaults to <c>charge_automatically</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The identifier of the customer to subscribe.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The identifier of the account representing the customer to subscribe.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Number of days a customer has to pay invoices generated by this subscription. Valid only
        /// for subscriptions where <c>collection_method</c> is set to <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("days_until_due")]
        [STJS.JsonPropertyName("days_until_due")]
        public long? DaysUntilDue { get; set; }

        /// <summary>
        /// ID of the default payment method for the subscription. It must belong to the customer
        /// associated with the subscription. This takes precedence over <c>default_source</c>. If
        /// neither are set, invoices will use the customer's <a
        /// href="https://docs.stripe.com/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// or <a
        /// href="https://docs.stripe.com/api/customers/object#customer_object-default_source">default_source</a>.
        /// </summary>
        [JsonProperty("default_payment_method")]
        [STJS.JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// ID of the default payment source for the subscription. It must belong to the customer
        /// associated with the subscription and be in a chargeable state. If
        /// <c>default_payment_method</c> is also set, <c>default_payment_method</c> will take
        /// precedence. If neither are set, invoices will use the customer's <a
        /// href="https://docs.stripe.com/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// or <a
        /// href="https://docs.stripe.com/api/customers/object#customer_object-default_source">default_source</a>.
        /// </summary>
        [JsonProperty("default_source")]
        [STJS.JsonPropertyName("default_source")]
        public string DefaultSource { get; set; }

        /// <summary>
        /// The tax rates that will apply to any subscription item that does not have
        /// <c>tax_rates</c> set. Invoices created will have their <c>default_tax_rates</c>
        /// populated from the subscription.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        [STJS.JsonPropertyName("default_tax_rates")]
        public List<string> DefaultTaxRates
        {
            get => this.defaultTaxRates;
            set
            {
                this.defaultTaxRates = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the subscription. If not specified or empty,
        /// inherits the discount from the subscription's customer.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<SubscriptionDiscountOptions> Discounts
        {
            get => this.discounts;
            set
            {
                this.discounts = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        [STJS.JsonPropertyName("invoice_settings")]
        public SubscriptionInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// A list of up to 20 subscription items, each with an attached price.
        /// </summary>
        [JsonProperty("items")]
        [STJS.JsonPropertyName("items")]
        public List<SubscriptionItemOptions> Items { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Indicates if a customer is on or off-session while an invoice payment is attempted.
        /// Defaults to <c>false</c> (on-session).
        /// </summary>
        [JsonProperty("off_session")]
        [STJS.JsonPropertyName("off_session")]
        public bool? OffSession { get; set; }

        /// <summary>
        /// The account on behalf of which to charge, for each of the subscription's invoices.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        [STJS.JsonPropertyName("on_behalf_of")]
        public string OnBehalfOf
        {
            get => this.onBehalfOf;
            set
            {
                this.onBehalfOf = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Only applies to subscriptions with <c>collection_method=charge_automatically</c>.
        ///
        /// Use <c>allow_incomplete</c> to create Subscriptions with <c>status=incomplete</c> if the
        /// first invoice can't be paid. Creating Subscriptions with this status allows you to
        /// manage scenarios where additional customer actions are needed to pay a subscription's
        /// invoice. For example, SCA regulation may require 3DS authentication to complete payment.
        /// See the <a
        /// href="https://docs.stripe.com/billing/migration/strong-customer-authentication">SCA
        /// Migration Guide</a> for Billing to learn more. This is the default behavior.
        ///
        /// Use <c>default_incomplete</c> to create Subscriptions with <c>status=incomplete</c> when
        /// the first invoice requires payment, otherwise start as active. Subscriptions transition
        /// to <c>status=active</c> when successfully confirming the PaymentIntent on the first
        /// invoice. This allows simpler management of scenarios where additional customer actions
        /// are needed to pay a subscription’s invoice, such as failed payments, <a
        /// href="https://docs.stripe.com/billing/migration/strong-customer-authentication">SCA
        /// regulation</a>, or collecting a mandate for a bank debit payment method. If the
        /// PaymentIntent is not confirmed within 23 hours Subscriptions transition to
        /// <c>status=incomplete_expired</c>, which is a terminal state.
        ///
        /// Use <c>error_if_incomplete</c> if you want Stripe to return an HTTP 402 status code if a
        /// subscription's first invoice can't be paid. For example, if a payment method requires
        /// 3DS authentication due to SCA regulation and further customer action is needed, this
        /// parameter doesn't create a Subscription and returns an error instead. This was the
        /// default behavior for API versions prior to 2019-03-14. See the <a
        /// href="https://docs.stripe.com/upgrades#2019-03-14">changelog</a> to learn more.
        ///
        /// <c>pending_if_incomplete</c> is only used with updates and cannot be passed when
        /// creating a Subscription.
        ///
        /// Subscriptions with <c>collection_method=send_invoice</c> are automatically activated
        /// regardless of the first Invoice status.
        /// One of: <c>allow_incomplete</c>, <c>default_incomplete</c>, <c>error_if_incomplete</c>,
        /// or <c>pending_if_incomplete</c>.
        /// </summary>
        [JsonProperty("payment_behavior")]
        [STJS.JsonPropertyName("payment_behavior")]
        public string PaymentBehavior { get; set; }

        /// <summary>
        /// Payment settings to pass to invoices created by the subscription.
        /// </summary>
        [JsonProperty("payment_settings")]
        [STJS.JsonPropertyName("payment_settings")]
        public SubscriptionPaymentSettingsOptions PaymentSettings { get; set; }

        /// <summary>
        /// Specifies an interval for how often to bill for any pending invoice items. It is
        /// analogous to calling <a href="https://docs.stripe.com/api#create_invoice">Create an
        /// invoice</a> for the given subscription at the specified interval.
        /// </summary>
        [JsonProperty("pending_invoice_item_interval")]
        [STJS.JsonPropertyName("pending_invoice_item_interval")]
        public SubscriptionPendingInvoiceItemIntervalOptions PendingInvoiceItemInterval
        {
            get => this.pendingInvoiceItemInterval;
            set
            {
                this.pendingInvoiceItemInterval = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If specified, the invoicing for the given billing cycle iterations will be processed
        /// now.
        /// </summary>
        [JsonProperty("prebilling")]
        [STJS.JsonPropertyName("prebilling")]
        public SubscriptionPrebillingOptions Prebilling { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://docs.stripe.com/billing/subscriptions/prorations">prorations</a> resulting
        /// from the <c>billing_cycle_anchor</c>. If no value is passed, the default is
        /// <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If specified, the funds from the subscription's invoices will be transferred to the
        /// destination and the ID of the resulting transfers will be found on the resulting
        /// charges.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public SubscriptionTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// Unix timestamp representing the end of the trial period the customer will get before
        /// being charged for the first time. If set, trial_end will override the default trial
        /// period of the plan the customer is being subscribed to. The special value <c>now</c> can
        /// be provided to end the customer's trial immediately. Can be at most two years from
        /// <c>billing_cycle_anchor</c>. See <a
        /// href="https://docs.stripe.com/billing/subscriptions/trials">Using trial periods on
        /// subscriptions</a> to learn more.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("trial_end")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionTrialEnd> TrialEnd { get; set; }

        /// <summary>
        /// Indicates if a plan's <c>trial_period_days</c> should be applied to the subscription.
        /// Setting <c>trial_end</c> per subscription is preferred, and this defaults to
        /// <c>false</c>. Setting this flag to <c>true</c> together with <c>trial_end</c> is not
        /// allowed. See <a href="https://docs.stripe.com/billing/subscriptions/trials">Using trial
        /// periods on subscriptions</a> to learn more.
        /// </summary>
        [JsonProperty("trial_from_plan")]
        [STJS.JsonPropertyName("trial_from_plan")]
        public bool? TrialFromPlan { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time. This will always overwrite any trials that might apply via a subscribed
        /// plan. See <a href="https://docs.stripe.com/billing/subscriptions/trials">Using trial
        /// periods on subscriptions</a> to learn more.
        /// </summary>
        [JsonProperty("trial_period_days")]
        [STJS.JsonPropertyName("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
        [STJS.JsonPropertyName("trial_settings")]
        public SubscriptionTrialSettingsOptions TrialSettings { get; set; }
    }
}
