namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountRequirements : StripeEntity<AccountRequirements>
    {
        /// <summary>
        /// The date the fields in <c>currently_due</c> must be collected by to keep payouts enabled
        /// for the account. These fields might block payouts sooner if the next threshold is
        /// reached before these fields are collected.
        /// </summary>
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// The fields that need to be collected to keep the account enabled. If not collected by
        /// the <c>current_deadline</c>, these fields appear in <c>past_due</c> as well, and the
        /// account is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// If the account is disabled, this string describes why the account can’t create charges
        /// or receive payouts. Can be <c>requirements.past_due</c>,
        /// <c>requirements.pending_verification</c>, <c>rejected.fraud</c>,
        /// <c>rejected.terms_of_service</c>, <c>rejected.listed</c>, <c>rejected.other</c>,
        /// <c>listed</c>, <c>under_review</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        /// <summary>
        /// The fields that are <c>currently_due</c> and need to be collected again because
        /// validation or verification failed for some reason.
        /// </summary>
        [JsonProperty("errors")]
        public List<AccountRequirementsError> Errors { get; set; }

        /// <summary>
        /// The fields that need to be collected assuming all volume thresholds are reached. As they
        /// become required, these fields appear in <c>currently_due</c> as well, and the
        /// <c>current_deadline</c> is set.
        /// </summary>
        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// The fields that weren't collected by the <c>current_deadline</c>. These fields need to
        /// be collected to re-enable the account.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }

        /// <summary>
        /// Fields that may become required depending on the results of verification or review. An
        /// empty array unless an asynchronous verification is pending. If verification fails, the
        /// fields in this array become required and move to <c>currently_due</c> or
        /// <c>past_due</c>.
        /// </summary>
        [JsonProperty("pending_verification")]
        public List<string> PendingVerification { get; set; }
    }
}
