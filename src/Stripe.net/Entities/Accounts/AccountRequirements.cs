// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountRequirements : StripeEntity<AccountRequirements>
    {
        /// <summary>
        /// Fields that are due and can be satisfied by providing the corresponding alternative
        /// fields instead.
        /// </summary>
        [JsonProperty("alternatives")]
        public List<AccountRequirementsAlternative> Alternatives { get; set; }

        /// <summary>
        /// Date by which the fields in <c>currently_due</c> must be collected to keep the account
        /// enabled. These fields may disable the account sooner if the next threshold is reached
        /// before they are collected.
        /// </summary>
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// Fields that need to be collected to keep the account enabled. If not collected by
        /// <c>current_deadline</c>, these fields appear in <c>past_due</c> as well, and the account
        /// is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// If the account is disabled, this enum describes why. <a
        /// href="https://stripe.com/docs/connect/handling-api-verification">Learn more about
        /// handling verification issues</a>.
        /// One of: <c>action_required.requested_capabilities</c>, <c>listed</c>, <c>other</c>,
        /// <c>platform_paused</c>, <c>rejected.fraud</c>, <c>rejected.incomplete_verification</c>,
        /// <c>rejected.listed</c>, <c>rejected.other</c>, <c>rejected.platform_fraud</c>,
        /// <c>rejected.platform_other</c>, <c>rejected.platform_terms_of_service</c>,
        /// <c>rejected.terms_of_service</c>, <c>requirements.past_due</c>,
        /// <c>requirements.pending_verification</c>, or <c>under_review</c>.
        /// </summary>
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        /// <summary>
        /// Fields that are <c>currently_due</c> and need to be collected again because validation
        /// or verification failed.
        /// </summary>
        [JsonProperty("errors")]
        public List<AccountRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields you must collect when all thresholds are reached. As they become required, they
        /// appear in <c>currently_due</c> as well, and <c>current_deadline</c> becomes set.
        /// </summary>
        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// Fields that weren't collected by <c>current_deadline</c>. These fields need to be
        /// collected to enable the account.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }

        /// <summary>
        /// Fields that might become required depending on the results of verification or review.
        /// It's an empty array unless an asynchronous verification is pending. If verification
        /// fails, these fields move to <c>eventually_due</c>, <c>currently_due</c>, or
        /// <c>past_due</c>. Fields might appear in <c>eventually_due</c>, <c>currently_due</c>, or
        /// <c>past_due</c> and in <c>pending_verification</c> if verification fails but another
        /// verification is still pending.
        /// </summary>
        [JsonProperty("pending_verification")]
        public List<string> PendingVerification { get; set; }
    }
}
