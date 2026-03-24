// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsAlma : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsAlma>
    {
        [JsonProperty("installments")]
        [STJS.JsonPropertyName("installments")]
        public PaymentAttemptRecordPaymentMethodDetailsAlmaInstallments Installments { get; set; }

        /// <summary>
        /// The Alma transaction ID associated with this payment.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
