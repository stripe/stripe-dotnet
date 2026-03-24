// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsSamsungPay : StripeEntity<ChargePaymentMethodDetailsSamsungPay>
    {
        /// <summary>
        /// A unique identifier for the buyer as determined by the local payment processor.
        /// </summary>
        [JsonProperty("buyer_id")]
        [STJS.JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// The Samsung Pay transaction ID associated with this payment.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
