// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditNoteRefundPaymentRecordRefund : StripeEntity<CreditNoteRefundPaymentRecordRefund>
    {
        /// <summary>
        /// ID of the payment record.
        /// </summary>
        [JsonProperty("payment_record")]
        [STJS.JsonPropertyName("payment_record")]
        public string PaymentRecord { get; set; }

        /// <summary>
        /// ID of the refund group.
        /// </summary>
        [JsonProperty("refund_group")]
        [STJS.JsonPropertyName("refund_group")]
        public string RefundGroup { get; set; }
    }
}
