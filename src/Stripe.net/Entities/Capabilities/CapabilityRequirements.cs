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

    public class CapabilityRequirements : StripeEntity<CapabilityRequirements>
    {
        /// <summary>
        /// Fields that are due and can be satisfied by providing the corresponding alternative
        /// fields instead.
        /// </summary>
        [JsonProperty("alternatives")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alternatives")]
#endif

        public List<CapabilityRequirementsAlternative> Alternatives { get; set; }

        /// <summary>
        /// Date by which the fields in <c>currently_due</c> must be collected to keep the
        /// capability enabled for the account. These fields may disable the capability sooner if
        /// the next threshold is reached before they are collected.
        /// </summary>
        [JsonProperty("current_deadline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_deadline")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// Fields that need to be collected to keep the capability enabled. If not collected by
        /// <c>current_deadline</c>, these fields appear in <c>past_due</c> as well, and the
        /// capability is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currently_due")]
#endif

        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// Description of why the capability is disabled. <a
        /// href="https://stripe.com/docs/connect/handling-api-verification">Learn more about
        /// handling verification issues</a>.
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
        /// Fields that are <c>currently_due</c> and need to be collected again because validation
        /// or verification failed.
        /// </summary>
        [JsonProperty("errors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errors")]
#endif

        public List<AccountRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields that need to be collected assuming all volume thresholds are reached. As they
        /// become required, they appear in <c>currently_due</c> as well, and
        /// <c>current_deadline</c> becomes set.
        /// </summary>
        [JsonProperty("eventually_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eventually_due")]
#endif

        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// Fields that weren't collected by <c>current_deadline</c>. These fields need to be
        /// collected to enable the capability on the account.
        /// </summary>
        [JsonProperty("past_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("past_due")]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pending_verification")]
#endif

        public List<string> PendingVerification { get; set; }
    }
}
