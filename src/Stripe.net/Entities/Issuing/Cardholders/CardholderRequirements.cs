namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderRequirements : StripeEntity<CardholderRequirements>
    {
        /// <summary>
        /// If <c>disabled_reason</c> is present, all cards will decline authorizations with
        /// <c>cardholder_verification_required</c> reason.
        /// One of: <c>listed</c>, <c>rejected.listed</c>, or <c>under_review</c>.
        /// </summary>
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        /// <summary>
        /// Array of fields that need to be collected in order to verify and re-enable the
        /// cardholder.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }
    }
}
