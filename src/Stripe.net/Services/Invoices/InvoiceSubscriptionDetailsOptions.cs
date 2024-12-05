// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceSubscriptionDetailsOptions : INestedOptions
    {
        /// <summary>
        /// For new subscriptions, a future timestamp to anchor the subscription's <a
        /// href="https://stripe.com/docs/subscriptions/billing-cycle">billing cycle</a>. This is
        /// used to determine the date of the first full invoice, and, for plans with <c>month</c>
        /// or <c>year</c> intervals, the day of the month for subsequent invoices. For existing
        /// subscriptions, the value can only be set to <c>now</c> or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, InvoiceSubscriptionDetailsBillingCycleAnchor> BillingCycleAnchor { get; set; }

        /// <summary>
        /// A timestamp at which the subscription should cancel. If set to a date before the current
        /// period ends, this will cause a proration if prorations have been enabled using
        /// <c>proration_behavior</c>. If set during a future period, this will always cause a
        /// proration for that period.
        /// </summary>
        [JsonProperty("cancel_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CancelAt { get; set; }

        /// <summary>
        /// Indicate whether this subscription should cancel at the end of the current period
        /// (<c>current_period_end</c>). Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("cancel_at_period_end")]
        public bool? CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// This simulates the subscription being canceled or expired immediately.
        /// </summary>
        [JsonProperty("cancel_now")]
        public bool? CancelNow { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// these default tax rates. The default tax rates will apply to any line item that does not
        /// have <c>tax_rates</c> set.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// A list of up to 20 subscription items, each with an attached price.
        /// </summary>
        [JsonProperty("items")]
        public List<InvoiceSubscriptionDetailsItemOptions> Items { get; set; }

        /// <summary>
        /// The pre-billing to apply to the subscription as a preview.
        /// </summary>
        [JsonProperty("prebilling")]
        public InvoiceSubscriptionDetailsPrebillingOptions Prebilling { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/billing/subscriptions/prorations">prorations</a> when the
        /// billing cycle changes (e.g., when switching plans, resetting
        /// <c>billing_cycle_anchor=now</c>, or starting a trial), or if an item's <c>quantity</c>
        /// changes. The default value is <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
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
        public DateTime? ProrationDate { get; set; }

        /// <summary>
        /// For paused subscriptions, setting <c>subscription_details.resume_at</c> to <c>now</c>
        /// will preview the invoice that will be generated if the subscription is resumed.
        /// </summary>
        [JsonProperty("resume_at")]
        public string ResumeAt { get; set; }

        /// <summary>
        /// Date a subscription is intended to start (can be future or past).
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// that trial end. If set, one of <c>subscription_details.items</c> or <c>subscription</c>
        /// is required.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, InvoiceSubscriptionDetailsTrialEnd> TrialEnd { get; set; }
    }
}
