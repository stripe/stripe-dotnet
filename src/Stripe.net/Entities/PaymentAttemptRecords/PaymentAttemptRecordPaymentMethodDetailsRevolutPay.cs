// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsRevolutPay : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsRevolutPay>
    {
        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public PaymentAttemptRecordPaymentMethodDetailsRevolutPayFunding Funding { get; set; }

        /// <summary>
        /// The Revolut Pay transaction ID associated with this payment.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
