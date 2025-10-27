// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsKrCard : StripeEntity<PaymentRecordPaymentMethodDetailsKrCard>
    {
        /// <summary>
        /// The local credit or debit card brand.
        /// One of: <c>bc</c>, <c>citi</c>, <c>hana</c>, <c>hyundai</c>, <c>jeju</c>,
        /// <c>jeonbuk</c>, <c>kakaobank</c>, <c>kbank</c>, <c>kdbbank</c>, <c>kookmin</c>,
        /// <c>kwangju</c>, <c>lotte</c>, <c>mg</c>, <c>nh</c>, <c>post</c>, <c>samsung</c>,
        /// <c>savingsbank</c>, <c>shinhan</c>, <c>shinhyup</c>, <c>suhyup</c>, <c>tossbank</c>, or
        /// <c>woori</c>.
        /// </summary>
        [JsonProperty("brand")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("brand")]
#endif
        public string Brand { get; set; }

        /// <summary>
        /// A unique identifier for the buyer as determined by the local payment processor.
        /// </summary>
        [JsonProperty("buyer_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("buyer_id")]
#endif
        public string BuyerId { get; set; }

        /// <summary>
        /// The last four digits of the card. This may not be present for American Express cards.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// The Korean Card transaction ID associated with this payment.
        /// </summary>
        [JsonProperty("transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_id")]
#endif
        public string TransactionId { get; set; }
    }
}
