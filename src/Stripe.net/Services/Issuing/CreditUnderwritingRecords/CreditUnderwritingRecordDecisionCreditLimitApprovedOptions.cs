// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CreditUnderwritingRecordDecisionCreditLimitApprovedOptions : INestedOptions
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
    }
}
