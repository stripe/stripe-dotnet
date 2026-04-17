// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceSubscriptionDetailsOptions : INestedOptions, IHasSetTracking
    {
        private List<InvoiceSubscriptionDetailsBillingScheduleOptions> billingSchedules;
        private AnyOf<DateTime?, InvoiceSubscriptionDetailsCancelAt> cancelAt;
        private List<string> defaultTaxRates;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// For new subscriptions, a future timestamp to anchor the subscription's <a
        /// href="https://docs.stripe.com/subscriptions/billing-cycle">billing cycle</a>. This is
        /// used to determine the date of the first full invoice, and, for plans with <c>month</c>
        /// or <c>year</c> intervals, the day of the month for subsequent invoices. For existing
        /// subscriptions, the value can only be set to <c>now</c> or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, InvoiceSubscriptionDetailsBillingCycleAnchor> BillingCycleAnchor { get; set; }

        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// </summary>
        [JsonProperty("billing_mode")]
        [STJS.JsonPropertyName("billing_mode")]
        public InvoiceSubscriptionDetailsBillingModeOptions BillingMode { get; set; }

        /// <summary>
        /// Sets the billing schedules for the subscription.
        /// </summary>
        [JsonProperty("billing_schedules", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("billing_schedules")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<InvoiceSubscriptionDetailsBillingScheduleOptions> BillingSchedules
        {
            get => this.billingSchedules;
            set
            {
                this.billingSchedules = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A timestamp at which the subscription should cancel. If set to a date before the current
        /// period ends, this will cause a proration if prorations have been enabled using
        /// <c>proration_behavior</c>. If set during a future period, this will always cause a
        /// proration for that period.
        /// </summary>
        [JsonProperty("cancel_at", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("cancel_at")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, InvoiceSubscriptionDetailsCancelAt> CancelAt
        {
            get => this.cancelAt;
            set
            {
                this.cancelAt = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Indicate whether this subscription should cancel at the end of the current period
        /// (<c>current_period_end</c>). Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("cancel_at_period_end")]
        [STJS.JsonPropertyName("cancel_at_period_end")]
        public bool? CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// This simulates the subscription being canceled or expired immediately.
        /// </summary>
        [JsonProperty("cancel_now")]
        [STJS.JsonPropertyName("cancel_now")]
        public bool? CancelNow { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// these default tax rates. The default tax rates will apply to any line item that does not
        /// have <c>tax_rates</c> set.
        /// </summary>
        [JsonProperty("default_tax_rates", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("default_tax_rates")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        /// A list of up to 20 subscription items, each with an attached price.
        /// </summary>
        [JsonProperty("items")]
        [STJS.JsonPropertyName("items")]
        public List<InvoiceSubscriptionDetailsItemOptions> Items { get; set; }

        /// <summary>
        /// The pre-billing to apply to the subscription as a preview.
        /// </summary>
        [JsonProperty("prebilling")]
        [STJS.JsonPropertyName("prebilling")]
        public InvoiceSubscriptionDetailsPrebillingOptions Prebilling { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://docs.stripe.com/billing/subscriptions/prorations">prorations</a> when the
        /// billing cycle changes (e.g., when switching plans, resetting
        /// <c>billing_cycle_anchor=now</c>, or starting a trial), or if an item's <c>quantity</c>
        /// changes. The default value is <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If previewing an update to a subscription, and doing proration,
        /// <c>subscription_details.proration_date</c> forces the proration to be calculated as
        /// though the update was done at the specified time. The time given must be within the
        /// current subscription period and within the current phase of the schedule backing this
        /// subscription, if the schedule exists. If set, <c>subscription</c>, and one of
        /// <c>subscription_details.items</c>, or <c>subscription_details.trial_end</c> are
        /// required. Also, <c>subscription_details.proration_behavior</c> cannot be set to 'none'.
        /// </summary>
        [JsonProperty("proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("proration_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ProrationDate { get; set; }

        /// <summary>
        /// For paused subscriptions, setting <c>subscription_details.resume_at</c> to <c>now</c>
        /// will preview the invoice that will be generated if the subscription is resumed.
        /// </summary>
        [JsonProperty("resume_at")]
        [STJS.JsonPropertyName("resume_at")]
        public string ResumeAt { get; set; }

        /// <summary>
        /// Date a subscription is intended to start (can be future or past).
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("start_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// that trial end. If set, one of <c>subscription_details.items</c> or <c>subscription</c>
        /// is required.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("trial_end")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, InvoiceSubscriptionDetailsTrialEnd> TrialEnd { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
