// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordAmountCanceled : StripeEntity<PaymentRecordAmountCanceled>
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// A positive integer representing the amount in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> for
        /// example, 100 cents for 1 USD or 100 for 100 JPY, a zero-decimal currency.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public long Value { get; set; }
    }
}
