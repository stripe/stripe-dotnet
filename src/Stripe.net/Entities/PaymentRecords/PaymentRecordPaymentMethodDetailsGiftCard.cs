// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsGiftCard : StripeEntity<PaymentRecordPaymentMethodDetailsGiftCard>
    {
        /// <summary>
        /// The balance of the gift card after the transaction.
        /// </summary>
        [JsonProperty("balance")]
        [STJS.JsonPropertyName("balance")]
        public PaymentRecordPaymentMethodDetailsGiftCardBalance Balance { get; set; }

        /// <summary>
        /// The brand of the gift card.
        /// One of: <c>fiserv_valuelink</c>, <c>givex</c>, or <c>svs</c>.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The expiration month of the gift card.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// The expiration year of the gift card.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// The first six digits of the gift card number.
        /// </summary>
        [JsonProperty("first6")]
        [STJS.JsonPropertyName("first6")]
        public string First6 { get; set; }

        /// <summary>
        /// The last four digits of the gift card number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The transaction ID from the gift card processor.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
