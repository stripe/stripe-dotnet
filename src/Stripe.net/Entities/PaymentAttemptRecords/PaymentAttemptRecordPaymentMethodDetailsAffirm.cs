// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsAffirm : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsAffirm>
    {
        /// <summary>
        /// ID of the location that this reader is assigned to.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif
        public string Location { get; set; }

        /// <summary>
        /// ID of the reader this transaction was made on.
        /// </summary>
        [JsonProperty("reader")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reader")]
#endif
        public string Reader { get; set; }

        /// <summary>
        /// The Affirm transaction ID associated with this payment.
        /// </summary>
        [JsonProperty("transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_id")]
#endif
        public string TransactionId { get; set; }
    }
}
