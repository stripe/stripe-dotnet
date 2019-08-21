namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

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
        public string Coupon { get; set; }

        /// <summary>
        /// Ids of the tax rates to apply to this phase on the subscription schedule.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// The date at which this phase of the subscription schedule ends. If set,
        /// <c>iterations</c> must not be set.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Integer representing the multiplier applied to the plan interval. For example,
        /// <c>iterations=2</c> applied to a plan with <c>interval=month</c> and
        /// <c>interval_count=3</c> results in a phase of duration 2 * 3 months = 6 months.
        /// If set, <c>end_date</c> must not be set.
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
        /// charges $10/month with a <c>tax_percent</c> of 20.0 will charge $12 per invoice.
        /// </summary>
        [Obsolete("Use DefaultTaxRates")]
        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        /// <summary>
        /// If set to <c>true</c> the entire phase is counted as a trial and the customer will not
        /// be charged for any fees.
        /// </summary>
        [JsonProperty("trial")]
        public bool? Trial { get; set; }

        /// <summary>
        /// Sets the phase to trialing from the start date to this date. Must be before the phase
        /// end date, can not be combined with <c>trial</c>.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
