// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsAlipay : StripeEntity<ChargePaymentMethodDetailsAlipay>
    {
        /// <summary>
        /// Uniquely identifies this particular Alipay account. You can use this attribute to check
        /// whether two Alipay accounts are the same.
        /// </summary>
        [JsonProperty("buyer_id")]
        [STJS.JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// Uniquely identifies this particular Alipay account. You can use this attribute to check
        /// whether two Alipay accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Transaction ID of this particular Alipay transaction.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
