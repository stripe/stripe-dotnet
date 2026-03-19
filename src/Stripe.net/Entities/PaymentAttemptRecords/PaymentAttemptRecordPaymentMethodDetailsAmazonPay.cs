// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsAmazonPay : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsAmazonPay>
    {
        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public PaymentAttemptRecordPaymentMethodDetailsAmazonPayFunding Funding { get; set; }

        /// <summary>
        /// The Amazon Pay transaction ID associated with this payment.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
