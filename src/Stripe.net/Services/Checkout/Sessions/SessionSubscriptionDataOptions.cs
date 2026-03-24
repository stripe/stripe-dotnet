// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionSubscriptionDataOptions : INestedOptions, IHasMetadata, IHasSetTracking
    {
        private SessionSubscriptionDataPendingInvoiceItemIntervalOptions pendingInvoiceItemInterval;
        private long? trialPeriodDays;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the application owner's Stripe account. To use an application fee percent, the request
        /// must be made on behalf of another account, using the <c>Stripe-Account</c> header or an
        /// OAuth key. For more information, see the application fees <a
        /// href="https://stripe.com/docs/connect/subscriptions#collecting-fees-on-subscriptions">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        [STJS.JsonPropertyName("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// A future timestamp to anchor the subscription's billing cycle for new subscriptions. You
        /// can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? BillingCycleAnchor { get; set; }

        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// </summary>
        [JsonProperty("billing_mode")]
        [STJS.JsonPropertyName("billing_mode")]
        public SessionSubscriptionDataBillingModeOptions BillingMode { get; set; }

        /// <summary>
        /// The tax rates that will apply to any subscription item that does not have
        /// <c>tax_rates</c> set. Invoices created will have their <c>default_tax_rates</c>
        /// populated from the subscription.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        [STJS.JsonPropertyName("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in the <a
        /// href="https://docs.stripe.com/customer-management">customer portal</a>.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        [STJS.JsonPropertyName("invoice_settings")]
        public SessionSubscriptionDataInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The account on behalf of which to charge, for each of the subscription's invoices.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        [STJS.JsonPropertyName("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Specifies an interval for how often to bill for any pending invoice items. It is
        /// analogous to calling <a href="https://docs.stripe.com/api#create_invoice">Create an
        /// invoice</a> for the given subscription at the specified interval.
        /// </summary>
        [JsonProperty("pending_invoice_item_interval")]
        [STJS.JsonPropertyName("pending_invoice_item_interval")]
        public SessionSubscriptionDataPendingInvoiceItemIntervalOptions PendingInvoiceItemInterval
        {
            get => this.pendingInvoiceItemInterval;
            set
            {
                this.pendingInvoiceItemInterval = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Determines how to handle prorations resulting from the <c>billing_cycle_anchor</c>. If
        /// no value is passed, the default is <c>create_prorations</c>.
        /// One of: <c>create_prorations</c>, or <c>none</c>.
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
        public SessionSubscriptionDataTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// Unix timestamp representing the end of the trial period the customer will get before
        /// being charged for the first time. Has to be at least 48 hours in the future.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("trial_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time. Has to be at least 1.
        /// </summary>
        [JsonProperty("trial_period_days")]
        [STJS.JsonPropertyName("trial_period_days")]
        public long? TrialPeriodDays
        {
            get => this.trialPeriodDays;
            set
            {
                this.trialPeriodDays = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
        [STJS.JsonPropertyName("trial_settings")]
        public SessionSubscriptionDataTrialSettingsOptions TrialSettings { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
