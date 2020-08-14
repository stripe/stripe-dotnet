namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EarlyFraudWarning : StripeEntity<EarlyFraudWarning>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// An EFW is actionable if it has not received a dispute and has not been fully refunded.
        /// You may wish to proactively refund a charge that receives an EFW, in order to avoid
        /// receiving a dispute later.
        /// </summary>
        [JsonProperty("actionable")]
        public bool Actionable { get; set; }

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the charge this early fraud warning is for, optionally expanded.
        /// </summary>
        [JsonIgnore]
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
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The type of fraud labelled by the issuer. One of <c>card_never_received</c>,
        /// <c>fraudulent_card_application</c>, <c>made_with_counterfeit_card</c>,
        /// <c>made_with_lost_card</c>, <c>made_with_stolen_card</c>, <c>misc</c>,
        /// <c>unauthorized_use_of_card</c>.
        /// </summary>
        [JsonProperty("fraud_type")]
        public string FraudType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }
    }
}
