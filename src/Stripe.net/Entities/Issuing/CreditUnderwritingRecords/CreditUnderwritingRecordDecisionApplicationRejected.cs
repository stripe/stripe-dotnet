// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditUnderwritingRecordDecisionApplicationRejected : StripeEntity<CreditUnderwritingRecordDecisionApplicationRejected>
    {
        /// <summary>
        /// Details about the <c>reasons.other</c> when present.
        /// </summary>
        [JsonProperty("reason_other_explanation")]
        public string ReasonOtherExplanation { get; set; }

        /// <summary>
        /// List of reasons why the application was rejected up to 4 reasons, in order of
        /// importance.
        /// </summary>
        [JsonProperty("reasons")]
        public List<string> Reasons { get; set; }
    }
}
