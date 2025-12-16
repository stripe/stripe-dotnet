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

    public class AccountRequirements : StripeEntity<AccountRequirements>
    {
        /// <summary>
        /// Fields that are due and can be resolved by providing the corresponding alternative
        /// fields instead. Many alternatives can list the same <c>original_fields_due</c>, and any
        /// of these alternatives can serve as a pathway for attempting to resolve the fields again.
        /// Re-providing <c>original_fields_due</c> also serves as a pathway for attempting to
        /// resolve the fields again.
        /// </summary>
        [JsonProperty("alternatives")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alternatives")]
#endif
        public List<AccountRequirementsAlternative> Alternatives { get; set; }

        /// <summary>
        /// Date by which the fields in <c>currently_due</c> must be collected to keep the account
        /// enabled. These fields may disable the account sooner if the next threshold is reached
        /// before they are collected.
        /// </summary>
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_deadline")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// Fields that need to be resolved to keep the account enabled. If not resolved by
        /// <c>current_deadline</c>, these fields will appear in <c>past_due</c> as well, and the
        /// account is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currently_due")]
#endif
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// If the account is disabled, this enum describes why. <a
        /// href="https://docs.stripe.com/connect/handling-api-verification">Learn more about
        /// handling verification issues</a>.
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
        /// Details about validation and verification failures for <c>due</c> requirements that must
        /// be resolved.
        /// </summary>
        [JsonProperty("errors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errors")]
#endif
        public List<AccountRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields you must collect when all thresholds are reached. As they become required, they
        /// appear in <c>currently_due</c> as well, and <c>current_deadline</c> becomes set.
        /// </summary>
        [JsonProperty("eventually_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eventually_due")]
#endif
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// Fields that haven't been resolved by <c>current_deadline</c>. These fields need to be
        /// resolved to enable the account.
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
