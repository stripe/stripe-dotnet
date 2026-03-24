// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordAmountRefunded : StripeEntity<PaymentRecordAmountRefunded>
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A positive integer representing the amount in the currency's <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">minor unit</a>. For example,
        /// <c>100</c> can represent 1 USD or 100 JPY.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public long Value { get; set; }
    }
}
