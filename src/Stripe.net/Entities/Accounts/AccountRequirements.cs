namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountRequirements : StripeEntity<AccountRequirements>
    {
        /// <summary>
        /// The date the fields in <c>currently_due</c> must be collected by to keep payouts
        /// enabled for the account. These fields might block payouts sooner if the next threshold
        /// is reached before these fields are collected.
        /// </summary>
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// The fields that need to be collected to keep the account enabled. If not collected by
        /// the <c>current_deadline</c>, these fields are moved to <c>past_due</c> and
        /// the account is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// If the account is disabled, this string describes why the account can't create charges
        /// or receive payouts.
        /// </summary>
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        /// <summary>
        /// The fields that need to be collected again because validation or verification failed
        /// for some reason.
        /// </summary>
        [JsonProperty("errors")]
        public List<AccountRequirementsError> Errors { get; set; }

        /// <summary>
        /// The fields that need to be collected assuming all volume thresholds are reached. As
        /// fields are needed, they are moved to <c>currently_due</c> and the
        /// <c>current_deadline</c> is set.
        /// </summary>
        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// The fields that weren't collected by the <c>currently_due</c>. These fields need
        /// to be collected to enable payouts for the account.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }

        /// <summary>
        /// Additional fields that may be required depending on the results of verification or
        /// review for provided requirements. If any of these fields become required, they appear in
        /// <see cref="CurrentlyDue"/> or <see cref="PastDue"/>.
        /// </summary>
        [JsonProperty("pending_verification")]
        public List<string> PendingVerification { get; set; }
    }
}
