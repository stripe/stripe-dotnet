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

    public class CapabilityFutureRequirements : StripeEntity<CapabilityFutureRequirements>
    {
        /// <summary>
        /// Fields that are due and can be resolved by providing the corresponding alternative
        /// fields instead. Multiple alternatives can reference the same <c>original_fields_due</c>.
        /// When this happens, any of these alternatives can serve as a pathway for attempting to
        /// resolve the fields. Additionally, providing <c>original_fields_due</c> again also serves
        /// as a pathway for attempting to resolve the fields.
        /// </summary>
        [JsonProperty("alternatives")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alternatives")]
#endif
        public List<CapabilityFutureRequirementsAlternative> Alternatives { get; set; }

        /// <summary>
        /// Date on which <c>future_requirements</c> becomes the main <c>requirements</c> hash and
        /// <c>future_requirements</c> becomes empty. After the transition, <c>currently_due</c>
        /// requirements may immediately become <c>past_due</c>, but the account may also be given a
        /// grace period depending on the capability's enablement state prior to transitioning.
        /// </summary>
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_deadline")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// Fields that need to be resolved to keep the capability enabled. If not resolved by
        /// <c>future_requirements[current_deadline]</c>, these fields will transition to the main
        /// <c>requirements</c> hash.
        /// </summary>
        [JsonProperty("currently_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currently_due")]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disabled_reason")]
#endif
        public string DisabledReason { get; set; }

        /// <summary>
        /// Details about validation and verification failures for <c>due</c> requirements that must
        /// be resolved.
        /// </summary>
        [JsonProperty("errors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errors")]
#endif
        public List<CapabilityFutureRequirementsError> Errors { get; set; }

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
        /// Fields that haven't been resolved by <c>requirements.current_deadline</c>. These fields
        /// need to be resolved to enable the capability on the account.
        /// <c>future_requirements.past_due</c> is a subset of <c>requirements.past_due</c>.
        /// </summary>
        [JsonProperty("past_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("past_due")]
#endif
        public List<string> PastDue { get; set; }

        /// <summary>
        /// Fields that are being reviewed, or might become required depending on the results of a
        /// review. If the review fails, these fields can move to <c>eventually_due</c>,
        /// <c>currently_due</c>, <c>past_due</c> or <c>alternatives</c>. Fields might appear in
        /// <c>eventually_due</c>, <c>currently_due</c>, <c>past_due</c> or <c>alternatives</c> and
        /// in <c>pending_verification</c> if one verification fails but another is still pending.
        /// </summary>
        [JsonProperty("pending_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pending_verification")]
#endif
        public List<string> PendingVerification { get; set; }
    }
}
