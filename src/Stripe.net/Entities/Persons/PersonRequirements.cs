namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PersonRequirements : StripeEntity<PersonRequirements>
    {
        /// <summary>
        /// Fields that need to be collected to keep the person’s account enabled. If not collected
        /// by the account’s <code>current_deadline</code>, these fields are moved to
        /// <code>past_due</code> and the account is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// Fields that need to be collected assuming all volume thresholds are reached. As fields
        /// are needed, they are moved to <code>currently_due</code> and the account’s
        /// <code>current_deadline</code> is set.
        /// </summary>
        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// Fields that weren’t collected by the account’s <code>current_deadline</code>. These
        /// fields need to be collected to enable payouts for the person’s account.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }
    }
}
