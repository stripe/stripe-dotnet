// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountFutureRequirements : StripeEntity<AccountFutureRequirements>
    {
        /// <summary>
        /// Fields that are due and can be satisfied by providing the corresponding alternative
        /// fields instead.
        /// </summary>
        [JsonProperty("alternatives")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alternatives")]
#endif
        public List<AccountFutureRequirementsAlternative> Alternatives { get; set; }

        /// <summary>
        /// Date on which <c>future_requirements</c> becomes the main <c>requirements</c> hash and
        /// <c>future_requirements</c> becomes empty. After the transition, <c>currently_due</c>
        /// requirements may immediately become <c>past_due</c>, but the account may also be given a
        /// grace period depending on its enablement state prior to transitioning.
        /// </summary>
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_deadline")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// Fields that need to be collected to keep the account enabled. If not collected by
        /// <c>future_requirements[current_deadline]</c>, these fields will transition to the main
        /// <c>requirements</c> hash.
        /// </summary>
        [JsonProperty("currently_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currently_due")]
#endif
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// This is typed as an enum for consistency with <c>requirements.disabled_reason</c>.
        /// One of: <c>action_required.requested_capabilities</c>, <c>listed</c>, <c>other</c>,
        /// <c>platform_paused</c>, <c>rejected.fraud</c>, <c>rejected.incomplete_verification</c>,
        /// <c>rejected.listed</c>, <c>rejected.other</c>, <c>rejected.platform_fraud</c>,
        /// <c>rejected.platform_other</c>, <c>rejected.platform_terms_of_service</c>,
        /// <c>rejected.terms_of_service</c>, <c>requirements.past_due</c>,
        /// <c>requirements.pending_verification</c>, or <c>under_review</c>.
        /// </summary>
        [JsonProperty("disabled_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disabled_reason")]
#endif
        public string DisabledReason { get; set; }

        /// <summary>
        /// Fields that are <c>currently_due</c> and need to be collected again because validation
        /// or verification failed.
        /// </summary>
        [JsonProperty("errors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errors")]
#endif
        public List<AccountFutureRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields you must collect when all thresholds are reached. As they become required, they
        /// appear in <c>currently_due</c> as well.
        /// </summary>
        [JsonProperty("eventually_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eventually_due")]
#endif
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// Fields that weren't collected by <c>requirements.current_deadline</c>. These fields need
        /// to be collected to enable the capability on the account. New fields will never appear
        /// here; <c>future_requirements.past_due</c> will always be a subset of
        /// <c>requirements.past_due</c>.
        /// </summary>
        [JsonProperty("past_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("past_due")]
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
        [JsonProperty("pending_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pending_verification")]
#endif
        public List<string> PendingVerification { get; set; }
    }
}
