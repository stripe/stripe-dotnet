// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Reviews can be used to supplement automated fraud detection with human expertise.
    ///
    /// Learn more about <a href="https://stripe.com/radar">Radar</a> and reviewing payments <a
    /// href="https://stripe.com/docs/radar/reviews">here</a>.
    /// </summary>
    public class Review : StripeEntity<Review>, IHasId, IHasObject
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

        /// <summary>
        /// The ZIP or postal code of the card used, if applicable.
        /// </summary>
        [JsonProperty("billing_zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_zip")]
#endif
        public string BillingZip { get; set; }

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// The charge associated with this review.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded)
        /// The charge associated with this review.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("charge")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
#endif
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        /// <summary>
        /// The reason the review was closed, or null if it has not yet been closed. One of
        /// <c>approved</c>, <c>refunded</c>, <c>refunded_as_fraud</c>, <c>disputed</c>, or
        /// <c>redacted</c>.
        /// One of: <c>approved</c>, <c>disputed</c>, <c>redacted</c>, <c>refunded</c>, or
        /// <c>refunded_as_fraud</c>.
        /// </summary>
        [JsonProperty("closed_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("closed_reason")]
#endif
        public string ClosedReason { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The IP address where the payment originated.
        /// </summary>
        [JsonProperty("ip_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_address")]
#endif
        public string IpAddress { get; set; }

        /// <summary>
        /// Information related to the location of the payment. Note that this information is an
        /// approximation and attempts to locate the nearest population center - it should not be
        /// used to determine a specific address.
        /// </summary>
        [JsonProperty("ip_address_location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_address_location")]
#endif
        public ReviewLocation IpAddressLocation { get; set; }

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
        /// If <c>true</c>, the review needs action.
        /// </summary>
        [JsonProperty("open")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("open")]
#endif
        public bool Open { get; set; }

        /// <summary>
        /// The reason the review was opened. One of <c>rule</c> or <c>manual</c>.
        /// One of: <c>manual</c>, or <c>rule</c>.
        /// </summary>
        [JsonProperty("opened_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("opened_reason")]
#endif
        public string OpenedReason { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// The PaymentIntent ID associated with this review, if one exists.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The PaymentIntent ID associated with this review, if one exists.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
#endif
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        /// <summary>
        /// The reason the review is currently open or closed. One of <c>rule</c>, <c>manual</c>,
        /// <c>approved</c>, <c>refunded</c>, <c>refunded_as_fraud</c>, <c>disputed</c>, or
        /// <c>redacted</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        /// <summary>
        /// Information related to the browsing session of the user who initiated the payment.
        /// </summary>
        [JsonProperty("session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("session")]
#endif
        public ReviewSession Session { get; set; }
    }
}
