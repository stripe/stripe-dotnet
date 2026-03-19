// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReleaseSourceTransaction : StripeEntity<ReleaseSourceTransaction>
    {
        #region Expandable Dispute

        /// <summary>
        /// (ID of the Dispute)
        /// The ID of the dispute.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string DisputeId
        {
            get => this.InternalDispute?.Id;
            set => this.InternalDispute = SetExpandableFieldId(value, this.InternalDispute);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the dispute.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Dispute Dispute
        {
            get => this.InternalDispute?.ExpandedObject;
            set => this.InternalDispute = SetExpandableFieldObject(value, this.InternalDispute);
        }

        [JsonProperty("dispute")]
        [JsonConverter(typeof(ExpandableFieldConverter<Dispute>))]
        [STJS.JsonPropertyName("dispute")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Dispute>))]
        internal ExpandableField<Dispute> InternalDispute { get; set; }
        #endregion

        #region Expandable Refund

        /// <summary>
        /// (ID of the Refund)
        /// The ID of the refund.
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
        /// The ID of the refund.
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
        /// The type of source transaction.
        /// One of: <c>dispute</c>, or <c>refund</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
