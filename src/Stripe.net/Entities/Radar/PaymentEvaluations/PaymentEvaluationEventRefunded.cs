// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationEventRefunded : StripeEntity<PaymentEvaluationEventRefunded>
    {
        /// <summary>
        /// Amount refunded for this payment. A positive integer representing how much to charge in
        /// <a href="https://docs.stripe.com/currencies#zero-decimal">the smallest currency unit</a>
        /// (for example, 100 cents to charge 1.00 USD or 100 to charge 100 Yen, a zero-decimal
        /// currency).
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Indicates the reason for the refund.
        /// One of: <c>duplicate</c>, <c>fraudulent</c>, <c>other</c>, or
        /// <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
