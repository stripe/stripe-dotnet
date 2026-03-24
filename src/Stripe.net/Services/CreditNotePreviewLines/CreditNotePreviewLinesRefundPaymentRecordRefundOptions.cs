// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditNotePreviewLinesRefundPaymentRecordRefundOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the PaymentRecord with the refund to link to this credit note.
        /// </summary>
        [JsonProperty("payment_record")]
        [STJS.JsonPropertyName("payment_record")]
        public string PaymentRecord { get; set; }

        /// <summary>
        /// The PaymentRecord refund group to link to this credit note. For refunds processed
        /// off-Stripe, this will correspond to the <c>processor_details.custom.refund_reference</c>
        /// field provided when reporting the refund on the PaymentRecord.
        /// </summary>
        [JsonProperty("refund_group")]
        [STJS.JsonPropertyName("refund_group")]
        public string RefundGroup { get; set; }
    }
}
