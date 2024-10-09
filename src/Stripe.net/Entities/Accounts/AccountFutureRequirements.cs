namespace Stripe
{
    using System;
    using System.Collections.Generic;
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif
    using Stripe.Infrastructure;

    public class AccountFutureRequirements : StripeEntity<AccountFutureRequirements>
    {
        /// <summary>
        /// Fields that are due and can be satisfied by providing the corresponding alternative
        /// fields instead.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("alternatives")]
#else
        [JsonProperty("alternatives")]
#endif
        public List<AccountFutureRequirementsAlternative> Alternatives { get; set; }

        /// <summary>
        /// Date on which <c>future_requirements</c> merges with the main <c>requirements</c> hash
        /// and <c>future_requirements</c> becomes empty. After the transition, <c>currently_due</c>
        /// requirements may immediately become <c>past_due</c>, but the account may also be given a
        /// grace period depending on its enablement state prior to transitioning.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#else
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#endif
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// Fields that need to be collected to keep the account enabled. If not collected by
        /// <c>future_requirements[current_deadline]</c>, these fields will transition to the main
        /// <c>requirements</c> hash.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("currently_due")]
#else
        [JsonProperty("currently_due")]
#endif
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// This is typed as a string for consistency with <c>requirements.disabled_reason</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("disabled_reason")]
#else
        [JsonProperty("disabled_reason")]
#endif
        public string DisabledReason { get; set; }

        /// <summary>
        /// Fields that are <c>currently_due</c> and need to be collected again because validation
        /// or verification failed.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("errors")]
#else
        [JsonProperty("errors")]
#endif
        public List<AccountFutureRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields that need to be collected assuming all volume thresholds are reached. As they
        /// become required, they appear in <c>currently_due</c> as well.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("eventually_due")]
#else
        [JsonProperty("eventually_due")]
#endif
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// Fields that weren't collected by <c>requirements.current_deadline</c>. These fields need
        /// to be collected to enable the capability on the account. New fields will never appear
        /// here; <c>future_requirements.past_due</c> will always be a subset of
        /// <c>requirements.past_due</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("past_due")]
#else
        [JsonProperty("past_due")]
#endif
        public List<string> PastDue { get; set; }

        /// <summary>
        /// Fields that might become required depending on the results of verification or review.
        /// It's an empty array unless an asynchronous verification is pending. If verification
        /// fails, these fields move to <c>eventually_due</c> or <c>currently_due</c>. Fields might
        /// appear in <c>eventually_due</c> or <c>currently_due</c> and in
        /// <c>pending_verification</c> if verification fails but another verification is still
        /// pending.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("pending_verification")]
#else
        [JsonProperty("pending_verification")]
#endif
        public List<string> PendingVerification { get; set; }
    }
}
