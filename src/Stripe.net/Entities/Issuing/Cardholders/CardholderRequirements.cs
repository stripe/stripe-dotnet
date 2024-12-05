// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardholderRequirements : StripeEntity<CardholderRequirements>
    {
        /// <summary>
        /// If <c>disabled_reason</c> is present, all cards will decline authorizations with
        /// <c>cardholder_verification_required</c> reason.
        /// One of: <c>listed</c>, <c>rejected.listed</c>, <c>requirements.past_due</c>, or
        /// <c>under_review</c>.
        /// </summary>
        [JsonProperty("disabled_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disabled_reason")]
#endif
        public string DisabledReason { get; set; }

        /// <summary>
        /// Array of fields that need to be collected in order to verify and re-enable the
        /// cardholder.
        /// One of: <c>company.tax_id</c>,
        /// <c>individual.card_issuing.user_terms_acceptance.date</c>,
        /// <c>individual.card_issuing.user_terms_acceptance.ip</c>, <c>individual.dob.day</c>,
        /// <c>individual.dob.month</c>, <c>individual.dob.year</c>, <c>individual.first_name</c>,
        /// <c>individual.last_name</c>, or <c>individual.verification.document</c>.
        /// </summary>
        [JsonProperty("past_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("past_due")]
#endif
        public List<string> PastDue { get; set; }
    }
}
