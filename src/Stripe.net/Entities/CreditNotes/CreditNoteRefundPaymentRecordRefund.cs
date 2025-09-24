// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditNoteRefundPaymentRecordRefund : StripeEntity<CreditNoteRefundPaymentRecordRefund>
    {
        /// <summary>
        /// ID of the payment record.
        /// </summary>
        [JsonProperty("payment_record")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_record")]
#endif
        public string PaymentRecord { get; set; }

        /// <summary>
        /// ID of the refund group.
        /// </summary>
        [JsonProperty("refund_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_group")]
#endif
        public string RefundGroup { get; set; }
    }
}
