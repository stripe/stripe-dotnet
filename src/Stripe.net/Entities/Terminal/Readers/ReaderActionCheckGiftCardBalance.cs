// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionCheckGiftCardBalance : StripeEntity<ReaderActionCheckGiftCardBalance>
    {
        #region Expandable GiftCard

        /// <summary>
        /// (ID of the GiftCard)
        /// The gift card used in this reader action.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string GiftCardId
        {
            get => this.InternalGiftCard?.Id;
            set => this.InternalGiftCard = SetExpandableFieldId(value, this.InternalGiftCard);
        }

        /// <summary>
        /// (Expanded)
        /// The gift card used in this reader action.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public GiftCard GiftCard
        {
            get => this.InternalGiftCard?.ExpandedObject;
            set => this.InternalGiftCard = SetExpandableFieldObject(value, this.InternalGiftCard);
        }

        [JsonProperty("gift_card")]
        [JsonConverter(typeof(ExpandableFieldConverter<GiftCard>))]
        [STJS.JsonPropertyName("gift_card")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<GiftCard>))]
        internal ExpandableField<GiftCard> InternalGiftCard { get; set; }
        #endregion

        #region Expandable GiftCardOperation

        /// <summary>
        /// (ID of the GiftCardOperation)
        /// The GiftCardOperation created for this reader action.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string GiftCardOperationId
        {
            get => this.InternalGiftCardOperation?.Id;
            set => this.InternalGiftCardOperation = SetExpandableFieldId(value, this.InternalGiftCardOperation);
        }

        /// <summary>
        /// (Expanded)
        /// The GiftCardOperation created for this reader action.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public GiftCardOperation GiftCardOperation
        {
            get => this.InternalGiftCardOperation?.ExpandedObject;
            set => this.InternalGiftCardOperation = SetExpandableFieldObject(value, this.InternalGiftCardOperation);
        }

        [JsonProperty("gift_card_operation")]
        [JsonConverter(typeof(ExpandableFieldConverter<GiftCardOperation>))]
        [STJS.JsonPropertyName("gift_card_operation")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<GiftCardOperation>))]
        internal ExpandableField<GiftCardOperation> InternalGiftCardOperation { get; set; }
        #endregion
    }
}
