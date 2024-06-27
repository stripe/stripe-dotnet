// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CapabilityFutureRequirements : StripeEntity<CapabilityFutureRequirements>
    {
        /// <summary>
        /// Fields that are due and can be satisfied by providing the corresponding alternative
        /// fields instead.
        /// </summary>
        [JsonProperty("alternatives")]
        public List<CapabilityFutureRequirementsAlternative> Alternatives { get; set; }

        /// <summary>
        /// Date on which <c>future_requirements</c> merges with the main <c>requirements</c> hash
        /// and <c>future_requirements</c> becomes empty. After the transition, <c>currently_due</c>
        /// requirements may immediately become <c>past_due</c>, but the account may also be given a
        /// grace period depending on the capability's enablement state prior to transitioning.
        /// </summary>
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// Fields that need to be collected to keep the capability enabled. If not collected by
        /// <c>future_requirements[current_deadline]</c>, these fields will transition to the main
        /// <c>requirements</c> hash.
        /// </summary>
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// This is typed as an enum for consistency with <c>requirements.disabled_reason</c>, but
        /// it safe to assume <c>future_requirements.disabled_reason</c> is null because fields in
        /// <c>future_requirements</c> will never disable the account.
        /// One of: <c>other</c>, <c>paused.inactivity</c>, <c>pending.onboarding</c>,
        /// <c>pending.review</c>, <c>platform_disabled</c>, <c>platform_paused</c>,
        /// <c>rejected.inactivity</c>, <c>rejected.other</c>, <c>rejected.unsupported_business</c>,
        /// or <c>requirements.fields_needed</c>.
        /// </summary>
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        /// <summary>
        /// Fields that are <c>currently_due</c> and need to be collected again because validation
        /// or verification failed.
        /// </summary>
        [JsonProperty("errors")]
        public List<CapabilityFutureRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields that need to be collected assuming all volume thresholds are reached. As they
        /// become required, they appear in <c>currently_due</c> as well.
        /// </summary>
        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// Fields that weren't collected by <c>requirements.current_deadline</c>. These fields need
        /// to be collected to enable the capability on the account. New fields will never appear
        /// here; <c>future_requirements.past_due</c> will always be a subset of
        /// <c>requirements.past_due</c>.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }

        /// <summary>
        /// Fields that might become required depending on the results of verification or review.
        /// It's an empty array unless an asynchronous verification is pending. If verification
        /// fails, these fields move to <c>eventually_due</c> or <c>currently_due</c>. Fields might
        /// appear in <c>eventually_due</c> or <c>currently_due</c> and in
        /// <c>pending_verification</c> if verification fails but another verification is still
        /// pending.
        /// </summary>
        [JsonProperty("pending_verification")]
        public List<string> PendingVerification { get; set; }
    }
}
