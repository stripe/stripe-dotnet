// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditGrantAmountMonetaryOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// of the <c>value</c> parameter.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A positive integer representing the amount of the credit grant.
        /// </summary>
        [JsonProperty("value")]
        public long? Value { get; set; }
    }
}
