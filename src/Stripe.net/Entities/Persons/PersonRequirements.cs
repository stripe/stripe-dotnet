// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PersonRequirements : StripeEntity<PersonRequirements>
    {
        /// <summary>
        /// Fields that are due and can be resolved by providing the corresponding alternative
        /// fields instead. Many alternatives can list the same <c>original_fields_due</c>, and any
        /// of these alternatives can serve as a pathway for attempting to resolve the fields again.
        /// Re-providing <c>original_fields_due</c> also serves as a pathway for attempting to
        /// resolve the fields again.
        /// </summary>
        [JsonProperty("alternatives")]
        [STJS.JsonPropertyName("alternatives")]
        public List<PersonRequirementsAlternative> Alternatives { get; set; }

        /// <summary>
        /// Fields that need to be resolved to keep the person's account enabled. If not resolved by
        /// the account's <c>current_deadline</c>, these fields will appear in <c>past_due</c> as
        /// well, and the account is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
        [STJS.JsonPropertyName("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// Details about validation and verification failures for <c>due</c> requirements that must
        /// be resolved.
        /// </summary>
        [JsonProperty("errors")]
        [STJS.JsonPropertyName("errors")]
        public List<PersonRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields you must collect when all thresholds are reached. As they become required, they
        /// appear in <c>currently_due</c> as well, and the account's <c>current_deadline</c>
        /// becomes set.
        /// </summary>
        [JsonProperty("eventually_due")]
        [STJS.JsonPropertyName("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// Fields that haven't been resolved by <c>current_deadline</c>. These fields need to be
        /// resolved to enable the person's account.
        /// </summary>
        [JsonProperty("past_due")]
        [STJS.JsonPropertyName("past_due")]
        public List<string> PastDue { get; set; }

        /// <summary>
        /// Fields that are being reviewed, or might become required depending on the results of a
        /// review. If the review fails, these fields can move to <c>eventually_due</c>,
        /// <c>currently_due</c>, <c>past_due</c> or <c>alternatives</c>. Fields might appear in
        /// <c>eventually_due</c>, <c>currently_due</c>, <c>past_due</c> or <c>alternatives</c> and
        /// in <c>pending_verification</c> if one verification fails but another is still pending.
        /// </summary>
        [JsonProperty("pending_verification")]
        [STJS.JsonPropertyName("pending_verification")]
        public List<string> PendingVerification { get; set; }
    }
}
