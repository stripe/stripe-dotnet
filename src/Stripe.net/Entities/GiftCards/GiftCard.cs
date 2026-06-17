// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Represents third-party gift cards that can be used as a payment method through Stripe.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GiftCard : StripeEntity<GiftCard>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The brand of the gift card.
        /// One of: <c>fiserv_valuelink</c>, <c>givex</c>, or <c>svs</c>.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The expiration month of the gift card.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// The expiration year of the gift card.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Uniquely identifies this particular gift card number. You can use this attribute to
        /// check whether two gift cards are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        #region Expandable LastOperation

        /// <summary>
        /// (ID of the GiftCardOperation)
        /// The last operation performed on this gift card.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string LastOperationId
        {
            get => this.InternalLastOperation?.Id;
            set => this.InternalLastOperation = SetExpandableFieldId(value, this.InternalLastOperation);
        }

        /// <summary>
        /// (Expanded)
        /// The last operation performed on this gift card.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public GiftCardOperation LastOperation
        {
            get => this.InternalLastOperation?.ExpandedObject;
            set => this.InternalLastOperation = SetExpandableFieldObject(value, this.InternalLastOperation);
        }

        [JsonProperty("last_operation")]
        [JsonConverter(typeof(ExpandableFieldConverter<GiftCardOperation>))]
        [STJS.JsonPropertyName("last_operation")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<GiftCardOperation>))]
        internal ExpandableField<GiftCardOperation> InternalLastOperation { get; set; }
        #endregion

        /// <summary>
        /// The last four digits of the gift card number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }
    }
}
