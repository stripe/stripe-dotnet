// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupAttemptPaymentMethodDetailsCardPresent : StripeEntity<SetupAttemptPaymentMethodDetailsCardPresent>
    {
        #region Expandable GeneratedCard

        /// <summary>
        /// (ID of the PaymentMethod)
        /// The ID of the Card PaymentMethod which was generated by this SetupAttempt.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string GeneratedCardId
        {
            get => this.InternalGeneratedCard?.Id;
            set => this.InternalGeneratedCard = SetExpandableFieldId(value, this.InternalGeneratedCard);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Card PaymentMethod which was generated by this SetupAttempt.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentMethod GeneratedCard
        {
            get => this.InternalGeneratedCard?.ExpandedObject;
            set => this.InternalGeneratedCard = SetExpandableFieldObject(value, this.InternalGeneratedCard);
        }

        [JsonProperty("generated_card")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("generated_card")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentMethod>))]
#endif
        internal ExpandableField<PaymentMethod> InternalGeneratedCard { get; set; }
        #endregion

        /// <summary>
        /// Details about payments collected offline.
        /// </summary>
        [JsonProperty("offline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("offline")]
#endif
        public SetupAttemptPaymentMethodDetailsCardPresentOffline Offline { get; set; }
    }
}
