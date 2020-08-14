namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentSingleUseOptions : INestedOptions
    {
        /// <summary>
        /// Amount the customer is granting permission to collect later. A positive integer
        /// representing how much to charge in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum
        /// amount is $0.50 US or <a
        /// href="https://stripe.com/docs/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
