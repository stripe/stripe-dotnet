namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class SubscriptionCreateOptions : SubscriptionSharedOptions
    {
        /// <summary>
        /// A future date to anchor the subscription’s <see href="https://stripe.com/docs/subscriptions/billing-cycle">billing cycle</see>. This is used to determine the date of the first full invoice, and, for plans with <c>month</c> or <c>year</c> intervals, the day of the month for subsequent invoices.
        /// </summary>
        [FormProperty("billing_cycle_anchor")]
        public DateTime? BillingCycleAnchor { get; set; }

        /// <summary>
        /// REQUIRED: The identifier of the customer to subscribe.
        /// </summary>
        [FormProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// List of subscription items, each with an attached plan.
        /// </summary>
        [FormProperty("items")]
        public List<SubscriptionItemOption> Items { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for the first time.
        /// </summary>
        [FormProperty("trial_period_days")]
        public int? TrialPeriodDays { get; set; }
    }
}
