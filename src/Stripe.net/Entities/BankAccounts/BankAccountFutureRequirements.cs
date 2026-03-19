// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BankAccountFutureRequirements : StripeEntity<BankAccountFutureRequirements>
    {
        /// <summary>
        /// Fields that need to be resolved to keep the external account enabled. If not resolved by
        /// <c>current_deadline</c>, these fields will appear in <c>past_due</c> as well, and the
        /// account is disabled.
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
        public List<BankAccountFutureRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields that haven't been resolved by <c>current_deadline</c>. These fields need to be
        /// resolved to enable the external account.
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
