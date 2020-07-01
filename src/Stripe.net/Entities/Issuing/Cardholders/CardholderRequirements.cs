namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderRequirements : StripeEntity<CardholderRequirements>
    {
        /// <summary>
        /// If the cardholder is disabled, this string describes why. Can be one of <c>listed</c>,
        /// <c>rejected.listed</c>, or <c>under_review</c>.
        /// </summary>
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        /// <summary>
        /// If not empty, this field contains the list of fields that need to be collected in order
        /// to verify and re-enable the cardholder.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }
    }
}
