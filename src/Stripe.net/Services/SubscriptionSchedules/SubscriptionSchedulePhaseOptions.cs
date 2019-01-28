namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseOptions : INestedOptions
    {
        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the application owner’s Stripe account.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// The code of the coupon to apply to this subscription. A coupon applied to a
        /// subscription will only affect invoices created for that particular subscription.
        /// </summary>
        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        /// <summary>
        /// The date at which this phase of the subscription schedule ends. If set,
        /// <code>iterations</code> must not be set.
        /// </summary>
        [JsonProperty("end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Integer representing the multiplier applied to the plan interval. For example,
        /// <code>iterations=2</code> applied to a plan with <code>interval=month</code> and
        /// <code>interval_count=3</code> results in a phase of duration 2 * 3 months = 6 months.
        /// If set, <code>end_date</code> must not be set.
        /// </summary>
        [JsonProperty("iterations")]
        public long? Iterations { get; set; }

        /// <summary>
        /// List of configuration items, each with an attached plan, to apply during this phase of
        /// the subscription schedule.
        /// </summary>
        [JsonProperty("plans")]
        public List<SubscriptionSchedulePhaseItemOptions> Plans { get; set; }

        /// <summary>
        /// A non-negative decimal (with at most four decimal places) between 0 and 100. This
        /// represents the percentage of the subscription invoice subtotal that will be calculated
        /// and added as tax to the final amount each billing period. For example, a plan which
        /// charges $10/month with a <code>tax_percent</code> of 20.0 will charge $12 per invoice.
        /// </summary>
        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        /// <summary>
        /// If set to <code>true</code> the entire phase is counted as a trial and the customer
        /// will not be charged for any fees.
        /// </summary>
        [JsonProperty("trial")]
        public bool? Trial { get; set; }

        /// <summary>
        /// Sets the phase to trialing from the start date to this date. Must be before the phase
        /// end date, can not be combined with <code>trial</code>.
        /// </summary>
        [JsonProperty("trial_end")]
        public DateTime? TrialEnd { get; set; }
    }
}
