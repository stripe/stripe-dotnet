namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionPendingUpdate : StripeEntity<SubscriptionPendingUpdate>
    {
        /// <summary>
        /// If the update is applied, determines the date of the first full
        /// invoice, and, for plans with <c>month</c> or <c>year</c> intervals,
        /// the day of the month for subsequent invoices.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? BillingCycleAnchor { get; set; }

        /// <summary>
        /// The point after which the changes reflected by this update will be
        /// discarded and no longer applied.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// List of subscription items, each with an attached plan, that will
        /// be set if the update is applied.
        /// </summary>
        [JsonProperty("subscription_items")]
        public List<SubscriptionItem> SubscriptionItems { get; set; }

        /// <summary>
        /// Unix timestamp representing the end of the trial period the
        /// customer will get before being charged for the first time, if the
        /// update is applied.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        /// <summary>
        /// Indicates if a <see cref="Plan.TrialPeriodDays"/> should
        /// be applied to the subscription. Setting <see cref="TrialEnd"/> per
        /// subscription is preferred, and this defaults to false. Setting this
        /// flag to true together with <see cref="TrialEnd"/> is not allowed.
        /// </summary>
        [JsonProperty("trial_from_plan")]
        public bool? TrialFromPlan { get; set; }
    }
}
