// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceAttachPaymentOptions : BaseOptions
    {
        /// <summary>
        /// The portion of the <c>amount</c> on the PaymentIntent or out of band payment to apply to
        /// this invoice. It defaults to the entire amount.
        /// </summary>
        [JsonProperty("amount_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_requested")]
#endif
        public long? AmountRequested { get; set; }

        /// <summary>
        /// The ID of the PaymentIntent to attach to the invoice.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public string PaymentIntent { get; set; }

        /// <summary>
        /// The ID of the PaymentRecord to detach from the invoice.
        /// </summary>
        [JsonProperty("payment_record")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_record")]
#endif
        public string PaymentRecord { get; set; }

        /// <summary>
        /// The PaymentRecord data for attaching an out of band payment to the invoice.
        /// </summary>
        [JsonProperty("payment_record_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_record_data")]
#endif
        public InvoicePaymentRecordDataOptions PaymentRecordData { get; set; }
    }
}
