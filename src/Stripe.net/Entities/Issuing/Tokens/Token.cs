// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// An issuing token object is created when an issued card is added to a digital wallet. As
    /// a <a href="https://stripe.com/docs/issuing">card issuer</a>, you can <a
    /// href="https://stripe.com/docs/issuing/controls/token-management">view and manage these
    /// tokens</a> through Stripe.
    /// </summary>
    public class Token : StripeEntity<Token>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        #region Expandable Card

        /// <summary>
        /// (ID of the Card)
        /// Card associated with this token.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Card Card
        {
            get => this.InternalCard?.ExpandedObject;
            set => this.InternalCard = SetExpandableFieldObject(value, this.InternalCard);
        }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Card>))]
#endif

        internal ExpandableField<Card> InternalCard { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The hashed ID derived from the device ID from the card network associated with the
        /// token.
        /// </summary>
        [JsonProperty("device_fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("device_fingerprint")]
#endif

        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// The last four digits of the token.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif

        public string Last4 { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// The token service provider / card network associated with the token.
        /// One of: <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif

        public string Network { get; set; }

        [JsonProperty("network_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_data")]
#endif

        public TokenNetworkData NetworkData { get; set; }

        /// <summary>
        /// Time at which the token was last updated by the card network. Measured in seconds since
        /// the Unix epoch.
        /// </summary>
        [JsonProperty("network_updated_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_updated_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime NetworkUpdatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The usage state of the token.
        /// One of: <c>active</c>, <c>deleted</c>, <c>requested</c>, or <c>suspended</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        /// <summary>
        /// The digital wallet for this token, if one was used.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, or <c>samsung_pay</c>.
        /// </summary>
        [JsonProperty("wallet_provider")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallet_provider")]
#endif

        public string WalletProvider { get; set; }
    }
}
