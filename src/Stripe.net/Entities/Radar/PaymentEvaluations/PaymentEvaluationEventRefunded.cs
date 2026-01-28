// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationEventRefunded : StripeEntity<PaymentEvaluationEventRefunded>
    {
        /// <summary>
        /// Amount refunded for this payment. A positive integer representing how much to charge in
        /// <a href="https://docs.stripe.com/currencies#zero-decimal">the smallest currency unit</a>
        /// (for example, 100 cents to charge 1.00 USD or 100 to charge 100 Yen, a zero-decimal
        /// currency).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

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
        /// Indicates the reason for the refund.
        /// One of: <c>duplicate</c>, <c>fraudulent</c>, <c>other</c>, or
        /// <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
