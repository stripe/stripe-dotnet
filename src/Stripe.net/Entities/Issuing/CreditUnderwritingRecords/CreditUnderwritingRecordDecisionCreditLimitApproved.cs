// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CreditUnderwritingRecordDecisionCreditLimitApproved : StripeEntity<CreditUnderwritingRecordDecisionCreditLimitApproved>
    {
        /// <summary>
        /// Credit amount approved. An approved credit limit is required before you can set a amount
        /// in the <a href="https://stripe.com/docs/api/issuing/credit_policy">CreditPolicy API</a>.
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
    }
}
