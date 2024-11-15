// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BankAccountRequirements : StripeEntity<BankAccountRequirements>
    {
        /// <summary>
        /// Fields that need to be collected to keep the external account enabled. If not collected
        /// by <c>current_deadline</c>, these fields appear in <c>past_due</c> as well, and the
        /// account is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currently_due")]
#endif

        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// Fields that are <c>currently_due</c> and need to be collected again because validation
        /// or verification failed.
        /// </summary>
        [JsonProperty("errors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errors")]
#endif

        public List<BankAccountRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields that weren't collected by <c>current_deadline</c>. These fields need to be
        /// collected to enable the external account.
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
