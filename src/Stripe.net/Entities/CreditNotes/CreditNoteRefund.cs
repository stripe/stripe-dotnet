// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class CreditNoteRefund : StripeEntity<CreditNoteRefund>
    {
        /// <summary>
        /// Amount of the refund that applies to this credit note, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount_refunded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_refunded")]
#endif
        public long AmountRefunded { get; set; }

        #region Expandable Refund

        /// <summary>
        /// (ID of the Refund)
        /// ID of the refund.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Refund Refund
        {
            get => this.InternalRefund?.ExpandedObject;
            set => this.InternalRefund = SetExpandableFieldObject(value, this.InternalRefund);
        }

        [JsonProperty("refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Refund>))]
#endif
        internal ExpandableField<Refund> InternalRefund { get; set; }
        #endregion
    }
}
