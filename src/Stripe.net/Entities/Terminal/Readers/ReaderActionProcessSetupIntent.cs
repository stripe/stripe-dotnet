// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionProcessSetupIntent : StripeEntity<ReaderActionProcessSetupIntent>
    {
        /// <summary>
        /// ID of a card PaymentMethod generated from the card_present PaymentMethod that may be
        /// attached to a Customer for future transactions. Only present if it was possible to
        /// generate a card PaymentMethod.
        /// </summary>
        [JsonProperty("generated_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("generated_card")]
#endif
        public string GeneratedCard { get; set; }

        /// <summary>
        /// Represents a per-setup override of a reader configuration.
        /// </summary>
        [JsonProperty("process_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("process_config")]
#endif
        public ReaderActionProcessSetupIntentProcessConfig ProcessConfig { get; set; }

        #region Expandable SetupIntent

        /// <summary>
        /// (ID of the SetupIntent)
        /// Most recent SetupIntent processed by the reader.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SetupIntentId
        {
            get => this.InternalSetupIntent?.Id;
            set => this.InternalSetupIntent = SetExpandableFieldId(value, this.InternalSetupIntent);
        }

        /// <summary>
        /// (Expanded)
        /// Most recent SetupIntent processed by the reader.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public SetupIntent SetupIntent
        {
            get => this.InternalSetupIntent?.ExpandedObject;
            set => this.InternalSetupIntent = SetExpandableFieldObject(value, this.InternalSetupIntent);
        }

        [JsonProperty("setup_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupIntent>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("setup_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<SetupIntent>))]
#endif
        internal ExpandableField<SetupIntent> InternalSetupIntent { get; set; }
        #endregion
    }
}
