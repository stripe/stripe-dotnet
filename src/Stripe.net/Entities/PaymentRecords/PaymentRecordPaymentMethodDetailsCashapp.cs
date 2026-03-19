// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsCashapp : StripeEntity<PaymentRecordPaymentMethodDetailsCashapp>
    {
        /// <summary>
        /// A unique and immutable identifier assigned by Cash App to every buyer.
        /// </summary>
        [JsonProperty("buyer_id")]
        [STJS.JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// A public identifier for buyers using Cash App.
        /// </summary>
        [JsonProperty("cashtag")]
        [STJS.JsonPropertyName("cashtag")]
        public string Cashtag { get; set; }

        /// <summary>
        /// A unique and immutable identifier of payments assigned by Cash App.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
