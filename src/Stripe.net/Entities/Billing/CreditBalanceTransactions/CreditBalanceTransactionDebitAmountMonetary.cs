// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditBalanceTransactionDebitAmountMonetary : StripeEntity<CreditBalanceTransactionDebitAmountMonetary>
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A positive integer representing the amount.
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; set; }
    }
}
