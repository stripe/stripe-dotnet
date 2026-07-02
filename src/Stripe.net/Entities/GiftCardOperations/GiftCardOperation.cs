// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A GiftCardOperation represents an operation performed on a third-party gift card, such
    /// as activation, reload, cashout, balance check, or void.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GiftCardOperation : StripeEntity<GiftCardOperation>, IHasId, IHasObject
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
        /// Details about a gift card activation operation.
        /// </summary>
        [JsonProperty("activation")]
        [STJS.JsonPropertyName("activation")]
        public GiftCardOperationActivation Activation { get; set; }

        /// <summary>
        /// Details about a gift card activation void operation.
        /// </summary>
        [JsonProperty("activation_void")]
        [STJS.JsonPropertyName("activation_void")]
        public GiftCardOperationActivationVoid ActivationVoid { get; set; }

        /// <summary>
        /// Details about a gift card balance check operation.
        /// </summary>
        [JsonProperty("balance_check")]
        [STJS.JsonPropertyName("balance_check")]
        public GiftCardOperationBalanceCheck BalanceCheck { get; set; }

        /// <summary>
        /// Details about a gift card cashout operation.
        /// </summary>
        [JsonProperty("cashout")]
        [STJS.JsonPropertyName("cashout")]
        public GiftCardOperationCashout Cashout { get; set; }

        /// <summary>
        /// Details about a gift card cashout void operation.
        /// </summary>
        [JsonProperty("cashout_void")]
        [STJS.JsonPropertyName("cashout_void")]
        public GiftCardOperationCashoutVoid CashoutVoid { get; set; }

        /// <summary>
        /// The timestamp of when this operation was completed.
        /// </summary>
        [JsonProperty("completed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("completed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime CompletedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The failure code of the operation. Only present if the status is failed.
        /// One of: <c>action_not_supported</c>, <c>card_already_activated</c>, <c>card_expired</c>,
        /// <c>card_not_activated</c>, <c>do_not_honor</c>, <c>generic_failure</c>,
        /// <c>insufficient_balance</c>, <c>invalid_amount</c>, <c>invalid_currency</c>,
        /// <c>invalid_number</c>, <c>invalid_pin</c>, <c>invalid_track_data</c>, <c>lost_card</c>,
        /// <c>lost_or_stolen_card</c>, <c>pin_required</c>, <c>pin_tries_exceeded</c>,
        /// <c>processing_error</c>, <c>provider_unavailable</c>, <c>stolen_card</c>,
        /// <c>suspected_fraud</c>, or <c>timeout</c>.
        /// </summary>
        [JsonProperty("failure_code")]
        [STJS.JsonPropertyName("failure_code")]
        public string FailureCode { get; set; }

        #region Expandable GiftCard

        /// <summary>
        /// (ID of the GiftCard)
        /// The gift card this operation was performed on.
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
        /// The gift card this operation was performed on.
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

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// ID of the location that this transaction's reader is assigned to.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// The connected account whose credentials were used to perform this operation.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        [STJS.JsonPropertyName("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// ID of the reader this transaction was made on.
        /// </summary>
        [JsonProperty("reader")]
        [STJS.JsonPropertyName("reader")]
        public string Reader { get; set; }

        /// <summary>
        /// Details about a gift card reload operation.
        /// </summary>
        [JsonProperty("reload")]
        [STJS.JsonPropertyName("reload")]
        public GiftCardOperationReload Reload { get; set; }

        /// <summary>
        /// Details about a gift card reload void operation.
        /// </summary>
        [JsonProperty("reload_void")]
        [STJS.JsonPropertyName("reload_void")]
        public GiftCardOperationReloadVoid ReloadVoid { get; set; }

        /// <summary>
        /// The status of the operation.
        /// One of: <c>failed</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of operation performed.
        /// One of: <c>activation</c>, <c>activation_void</c>, <c>balance_check</c>, <c>cashout</c>,
        /// <c>cashout_void</c>, <c>reload</c>, or <c>reload_void</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
