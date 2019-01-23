namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountRequirements : StripeEntity<AccountRequirements>
    {
        /// <summary>
        /// The date the fields in <code>currently_due</code> must be collected by to keep payouts
        /// enabled for the account. These fields might block payouts sooner if the next threshold
        /// is reached before these fields are collected.
        /// </summary>
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// The fields that need to be collected to keep the account enabled. If not collected by
        /// the <code>current_deadline</code>, these fields are moved to <code>past_due</code> and
        /// the account is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// If the account is disabled, this string describes why the account can’t create charges
        /// or receive payouts.
        /// </summary>
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        /// <summary>
        /// The fields that need to be collected assuming all volume thresholds are reached. As
        /// fields are needed, they are moved to <code>currently_due</code> and the
        /// <code>current_deadline</code> is set.
        /// </summary>
        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// The fields that weren’t collected by the <code>currently_due</code>. These fields need
        /// to be collected to enable payouts for the account.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }
    }
}
