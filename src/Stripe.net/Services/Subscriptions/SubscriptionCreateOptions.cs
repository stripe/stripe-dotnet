namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionCreateOptions : SubscriptionSharedOptions
    {
        /// <summary>
        /// For new subscriptions, a past timestamp to backdate the subscription’s start date to.
        /// If set, the first invoice will contain a proration for the timespan between the start
        /// date and the current time. Can be combined with trials and the billing cycle anchor.
        /// </summary>
        [JsonProperty("backdate_start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? BackdateStartDate { get; set; }

        /// <summary>
        /// A future date to anchor the subscription’s <see href="https://stripe.com/docs/subscriptions/billing-cycle">billing cycle</see>.
        /// This is used to determine the date of the first full invoice, and, for plans with
        /// <c>month</c> or <c>year</c> intervals, the day of the month for subsequent invoices.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? BillingCycleAnchor { get; set; }

        /// <summary>
        /// REQUIRED: The identifier of the customer to subscribe.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// List of subscription items, each with an attached plan.
        /// </summary>
        [JsonProperty("items")]
        public List<SubscriptionItemOption> Items { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
