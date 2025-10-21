// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditNotePreviewLinesRefundPaymentRecordRefundOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the PaymentRecord with the refund to link to this credit note.
        /// </summary>
        [JsonProperty("payment_record")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_record")]
#endif
        public string PaymentRecord { get; set; }

        /// <summary>
        /// The PaymentRecord refund group to link to this credit note. For refunds processed
        /// off-Stripe, this will correspond to the <c>processor_details.custom.refund_reference</c>
        /// field provided when reporting the refund on the PaymentRecord.
        /// </summary>
        [JsonProperty("refund_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_group")]
#endif
        public string RefundGroup { get; set; }
    }
}
