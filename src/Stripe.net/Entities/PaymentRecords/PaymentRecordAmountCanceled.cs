// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentRecordAmountCanceled : StripeEntity<PaymentRecordAmountCanceled>
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A positive integer representing the amount in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> e.g.,
        /// 100 cents for $1.00 or 100 for ¥100, a zero-decimal currency).
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; set; }
    }
}
