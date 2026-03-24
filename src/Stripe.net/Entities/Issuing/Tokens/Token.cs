// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An issuing token object is created when an issued card is added to a digital wallet. As
    /// a <a href="https://docs.stripe.com/issuing">card issuer</a>, you can <a
    /// href="https://docs.stripe.com/issuing/controls/token-management">view and manage these
    /// tokens</a> through Stripe.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Token : StripeEntity<Token>, IHasId, IHasObject
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

        #region Expandable Card

        /// <summary>
        /// (ID of the Card)
        /// Card associated with this token.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CardId
        {
            get => this.InternalCard?.Id;
            set => this.InternalCard = SetExpandableFieldId(value, this.InternalCard);
        }

        /// <summary>
        /// (Expanded)
        /// Card associated with this token.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Card Card
        {
            get => this.InternalCard?.ExpandedObject;
            set => this.InternalCard = SetExpandableFieldObject(value, this.InternalCard);
        }

        [JsonProperty("card")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        [STJS.JsonPropertyName("card")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalCard { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The hashed ID derived from the device ID from the card network associated with the
        /// token.
        /// </summary>
        [JsonProperty("device_fingerprint")]
        [STJS.JsonPropertyName("device_fingerprint")]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// The last four digits of the token.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The token service provider / card network associated with the token.
        /// One of: <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        [JsonProperty("network_data")]
        [STJS.JsonPropertyName("network_data")]
        public TokenNetworkData NetworkData { get; set; }

        /// <summary>
        /// Time at which the token was last updated by the card network. Measured in seconds since
        /// the Unix epoch.
        /// </summary>
        [JsonProperty("network_updated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("network_updated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime NetworkUpdatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The usage state of the token.
        /// One of: <c>active</c>, <c>deleted</c>, <c>requested</c>, or <c>suspended</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The digital wallet for this token, if one was used.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, or <c>samsung_pay</c>.
        /// </summary>
        [JsonProperty("wallet_provider")]
        [STJS.JsonPropertyName("wallet_provider")]
        public string WalletProvider { get; set; }
    }
}
