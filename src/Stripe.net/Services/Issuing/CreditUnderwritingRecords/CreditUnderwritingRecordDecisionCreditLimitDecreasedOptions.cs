// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditUnderwritingRecordDecisionCreditLimitDecreasedOptions : INestedOptions
    {
        /// <summary>
        /// The credit approved, in the currency of the account and <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The currency of the credit approved, will default to the Account's Issuing currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Details about the <c>reasons.other</c> when present.
        /// </summary>
        [JsonProperty("reason_other_explanation")]
        public string ReasonOtherExplanation { get; set; }

        /// <summary>
        /// List of reasons why the existing credit was decreased, up to 4 reasons, in order of
        /// importance.
        /// </summary>
        [JsonProperty("reasons")]
        public List<string> Reasons { get; set; }
    }
}
