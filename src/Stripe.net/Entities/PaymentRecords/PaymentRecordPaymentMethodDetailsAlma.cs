// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsAlma : StripeEntity<PaymentRecordPaymentMethodDetailsAlma>
    {
        [JsonProperty("installments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("installments")]
#endif
        public PaymentRecordPaymentMethodDetailsAlmaInstallments Installments { get; set; }

        /// <summary>
        /// The Alma transaction ID associated with this payment.
        /// </summary>
        [JsonProperty("transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_id")]
#endif
        public string TransactionId { get; set; }
    }
}
