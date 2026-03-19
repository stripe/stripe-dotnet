// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditNoteRefund : StripeEntity<CreditNoteRefund>
    {
        /// <summary>
        /// Amount of the refund that applies to this credit note, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount_refunded")]
        [STJS.JsonPropertyName("amount_refunded")]
        public long AmountRefunded { get; set; }

        /// <summary>
        /// The PaymentRecord refund details associated with this credit note refund.
        /// </summary>
        [JsonProperty("payment_record_refund")]
        [STJS.JsonPropertyName("payment_record_refund")]
        public CreditNoteRefundPaymentRecordRefund PaymentRecordRefund { get; set; }

        #region Expandable Refund

        /// <summary>
        /// (ID of the Refund)
        /// ID of the refund.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string RefundId
        {
            get => this.InternalRefund?.Id;
            set => this.InternalRefund = SetExpandableFieldId(value, this.InternalRefund);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the refund.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Refund Refund
        {
            get => this.InternalRefund?.ExpandedObject;
            set => this.InternalRefund = SetExpandableFieldObject(value, this.InternalRefund);
        }

        [JsonProperty("refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        [STJS.JsonPropertyName("refund")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Refund>))]
        internal ExpandableField<Refund> InternalRefund { get; set; }
        #endregion

        /// <summary>
        /// Type of the refund, one of <c>refund</c> or <c>payment_record_refund</c>.
        /// One of: <c>payment_record_refund</c>, or <c>refund</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
