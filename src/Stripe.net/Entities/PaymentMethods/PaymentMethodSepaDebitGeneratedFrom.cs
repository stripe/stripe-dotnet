// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodSepaDebitGeneratedFrom : StripeEntity<PaymentMethodSepaDebitGeneratedFrom>
    {
        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// The ID of the Charge that generated this PaymentMethod, if any.
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
        /// The ID of the Charge that generated this PaymentMethod, if any.
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

        #region Expandable SetupAttempt

        /// <summary>
        /// (ID of the SetupAttempt)
        /// The ID of the SetupAttempt that generated this PaymentMethod, if any.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string SetupAttemptId
        {
            get => this.InternalSetupAttempt?.Id;
            set => this.InternalSetupAttempt = SetExpandableFieldId(value, this.InternalSetupAttempt);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the SetupAttempt that generated this PaymentMethod, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public SetupAttempt SetupAttempt
        {
            get => this.InternalSetupAttempt?.ExpandedObject;
            set => this.InternalSetupAttempt = SetExpandableFieldObject(value, this.InternalSetupAttempt);
        }

        [JsonProperty("setup_attempt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_attempt")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<SetupAttempt>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<SetupAttempt>))]
#endif

        internal ExpandableField<SetupAttempt> InternalSetupAttempt { get; set; }
        #endregion
    }
}
