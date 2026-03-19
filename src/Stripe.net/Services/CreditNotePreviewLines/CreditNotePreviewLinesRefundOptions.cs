// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditNotePreviewLinesRefundOptions : INestedOptions
    {
        /// <summary>
        /// Amount of the refund that applies to this credit note, in cents (or local equivalent).
        /// Defaults to the entire refund amount.
        /// </summary>
        [JsonProperty("amount_refunded")]
        [STJS.JsonPropertyName("amount_refunded")]
        public long? AmountRefunded { get; set; }

        /// <summary>
        /// The PaymentRecord refund details to link to this credit note. Required when <c>type</c>
        /// is <c>payment_record_refund</c>.
        /// </summary>
        [JsonProperty("payment_record_refund")]
        [STJS.JsonPropertyName("payment_record_refund")]
        public CreditNotePreviewLinesRefundPaymentRecordRefundOptions PaymentRecordRefund { get; set; }

        /// <summary>
        /// ID of an existing refund to link this credit note to. Required when <c>type</c> is
        /// <c>refund</c>.
        /// </summary>
        [JsonProperty("refund")]
        [STJS.JsonPropertyName("refund")]
        public string Refund { get; set; }

        /// <summary>
        /// Type of the refund, one of <c>refund</c> or <c>payment_record_refund</c>. Defaults to
        /// <c>refund</c>.
        /// One of: <c>payment_record_refund</c>, or <c>refund</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
