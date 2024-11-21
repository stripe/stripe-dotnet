// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// An early fraud warning indicates that the card issuer has notified us that a charge may
    /// be fraudulent.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/disputes/measuring#early-fraud-warnings">Early fraud
    /// warnings</a>.
    /// </summary>
    public class EarlyFraudWarning : StripeEntity<EarlyFraudWarning>, IHasId, IHasObject
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
        /// An EFW is actionable if it has not received a dispute and has not been fully refunded.
        /// You may wish to proactively refund a charge that receives an EFW, in order to avoid
        /// receiving a dispute later.
        /// </summary>
        [JsonProperty("actionable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("actionable")]
#endif

        public bool Actionable { get; set; }

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the charge this early fraud warning is for, optionally expanded.
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
        /// ID of the charge this early fraud warning is for, optionally expanded.
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
#endif

        internal ExpandableField<Charge> InternalCharge { get; set; }
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
        /// The type of fraud labelled by the issuer. One of <c>card_never_received</c>,
        /// <c>fraudulent_card_application</c>, <c>made_with_counterfeit_card</c>,
        /// <c>made_with_lost_card</c>, <c>made_with_stolen_card</c>, <c>misc</c>,
        /// <c>unauthorized_use_of_card</c>.
        /// </summary>
        [JsonProperty("fraud_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fraud_type")]
#endif

        public string FraudType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// ID of the Payment Intent this early fraud warning is for, optionally expanded.
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
        /// ID of the Payment Intent this early fraud warning is for, optionally expanded.
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
#endif

        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion
    }
}
