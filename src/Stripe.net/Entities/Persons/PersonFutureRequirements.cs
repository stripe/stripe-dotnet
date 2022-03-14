// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PersonFutureRequirements : StripeEntity<PersonFutureRequirements>
    {
        /// <summary>
        /// Fields that are due and can be satisfied by providing the corresponding alternative
        /// fields instead.
        /// </summary>
        [JsonProperty("alternatives")]
        public List<PersonFutureRequirementsAlternative> Alternatives { get; set; }

        /// <summary>
        /// Fields that need to be collected to keep the person's account enabled. If not collected
        /// by the account's <c>future_requirements[current_deadline]</c>, these fields will
        /// transition to the main <c>requirements</c> hash, and may immediately become
        /// <c>past_due</c>, but the account may also be given a grace period depending on the
        /// account's enablement state prior to transition.
        /// </summary>
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// Fields that are <c>currently_due</c> and need to be collected again because validation
        /// or verification failed.
        /// </summary>
        [JsonProperty("errors")]
        public List<PersonFutureRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields that need to be collected assuming all volume thresholds are reached. As they
        /// become required, they appear in <c>currently_due</c> as well, and the account's
        /// <c>future_requirements[current_deadline]</c> becomes set.
        /// </summary>
        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// Fields that weren't collected by the account's <c>requirements.current_deadline</c>.
        /// These fields need to be collected to enable the person's account. New fields will never
        /// appear here; <c>future_requirements.past_due</c> will always be a subset of
        /// <c>requirements.past_due</c>.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }

        /// <summary>
        /// Fields that may become required depending on the results of verification or review. Will
        /// be an empty array unless an asynchronous verification is pending. If verification fails,
        /// these fields move to <c>eventually_due</c> or <c>currently_due</c>.
        /// </summary>
        [JsonProperty("pending_verification")]
        public List<string> PendingVerification { get; set; }
    }
}
