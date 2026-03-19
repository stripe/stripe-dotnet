// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Reviews can be used to supplement automated fraud detection with human expertise.
    ///
    /// Learn more about <a href="https://stripe.com/radar">Radar</a> and reviewing payments <a
    /// href="https://docs.stripe.com/radar/reviews">here</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Review : StripeEntity<Review>, IHasId, IHasObject
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
        /// The ZIP or postal code of the card used, if applicable.
        /// </summary>
        [JsonProperty("billing_zip")]
        [STJS.JsonPropertyName("billing_zip")]
        public string BillingZip { get; set; }

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// The charge associated with this review.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        [STJS.JsonPropertyName("charge")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        /// <summary>
        /// The reason the review was closed, or null if it has not yet been closed. One of
        /// <c>approved</c>, <c>refunded</c>, <c>refunded_as_fraud</c>, <c>disputed</c>,
        /// <c>redacted</c>, <c>canceled</c>, <c>payment_never_settled</c>, or <c>acknowledged</c>.
        /// One of: <c>acknowledged</c>, <c>approved</c>, <c>canceled</c>, <c>disputed</c>,
        /// <c>payment_never_settled</c>, <c>redacted</c>, <c>refunded</c>, or
        /// <c>refunded_as_fraud</c>.
        /// </summary>
        [JsonProperty("closed_reason")]
        [STJS.JsonPropertyName("closed_reason")]
        public string ClosedReason { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The IP address where the payment originated.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Information related to the location of the payment. Note that this information is an
        /// approximation and attempts to locate the nearest population center - it should not be
        /// used to determine a specific address.
        /// </summary>
        [JsonProperty("ip_address_location")]
        [STJS.JsonPropertyName("ip_address_location")]
        public ReviewLocation IpAddressLocation { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// If <c>true</c>, the review needs action.
        /// </summary>
        [JsonProperty("open")]
        [STJS.JsonPropertyName("open")]
        public bool Open { get; set; }

        /// <summary>
        /// The reason the review was opened. One of <c>rule</c> or <c>manual</c>.
        /// One of: <c>manual</c>, or <c>rule</c>.
        /// </summary>
        [JsonProperty("opened_reason")]
        [STJS.JsonPropertyName("opened_reason")]
        public string OpenedReason { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// The PaymentIntent ID associated with this review, if one exists.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        /// <summary>
        /// The reason the review is currently open or closed. One of <c>rule</c>, <c>manual</c>,
        /// <c>approved</c>, <c>refunded</c>, <c>refunded_as_fraud</c>, <c>disputed</c>,
        /// <c>redacted</c>, <c>canceled</c>, <c>payment_never_settled</c>, or <c>acknowledged</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Information related to the browsing session of the user who initiated the payment.
        /// </summary>
        [JsonProperty("session")]
        [STJS.JsonPropertyName("session")]
        public ReviewSession Session { get; set; }
    }
}
