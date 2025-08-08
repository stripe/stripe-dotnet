// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsSamsungPay : StripeEntity<ChargePaymentMethodDetailsSamsungPay>
    {
        /// <summary>
        /// A unique identifier for the buyer as determined by the local payment processor.
        /// </summary>
        [JsonProperty("buyer_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("buyer_id")]
#endif
        public string BuyerId { get; set; }

        /// <summary>
        /// The Samsung Pay transaction ID associated with this payment.
        /// </summary>
        [JsonProperty("transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_id")]
#endif
        public string TransactionId { get; set; }
    }
}
