// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsPix : StripeEntity<PaymentRecordPaymentMethodDetailsPix>
    {
        /// <summary>
        /// Unique transaction id generated by BCB.
        /// </summary>
        [JsonProperty("bank_transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_transaction_id")]
#endif
        public string BankTransactionId { get; set; }
    }
}
