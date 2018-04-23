using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSubscriptionCreateOptions : SubscriptionSharedOptions
    {
        /// <summary>
        /// A future date to anchor the subscription’s <see href="https://stripe.com/docs/subscriptions/billing-cycle">billing cycle</see>. This is used to determine the date of the first full invoice, and, for plans with <c>month</c> or <c>year</c> intervals, the day of the month for subsequent invoices.
        /// </summary>
        public DateTime? BillingCycleAnchor { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        internal long? BillingCycleAnchorInternal
        {
            get
            {
                if (!BillingCycleAnchor.HasValue) return null;

                return EpochTime.ConvertDateTimeToEpoch(BillingCycleAnchor.Value);
            }
        }

        /// <summary>
        /// REQUIRED: The identifier of the customer to subscribe.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// List of subscription items, each with an attached plan.
        /// </summary>
        // this will actually send `items`. this is to flag it for the middleware
        // to process it as a plugin
        [JsonProperty("subscription_items_array")]
        public List<StripeSubscriptionItemOption> Items { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public int? TrialPeriodDays { get; set; }
    }
}
