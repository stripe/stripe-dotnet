// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsAmazonPay : StripeEntity<PaymentRecordPaymentMethodDetailsAmazonPay>
    {
        [JsonProperty("funding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding")]
#endif
        public PaymentRecordPaymentMethodDetailsAmazonPayFunding Funding { get; set; }

        /// <summary>
        /// The Amazon Pay transaction ID associated with this payment.
        /// </summary>
        [JsonProperty("transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_id")]
#endif
        public string TransactionId { get; set; }
    }
}
