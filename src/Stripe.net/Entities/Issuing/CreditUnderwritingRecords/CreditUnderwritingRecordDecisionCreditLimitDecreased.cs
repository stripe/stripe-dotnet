// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditUnderwritingRecordDecisionCreditLimitDecreased : StripeEntity<CreditUnderwritingRecordDecisionCreditLimitDecreased>
    {
        /// <summary>
        /// Credit amount approved after decrease. An approved credit limit is required before you
        /// can set a amount in the <a
        /// href="https://stripe.com/docs/api/issuing/credit_policy">CreditPolicy API</a>.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
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
