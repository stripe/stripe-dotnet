// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionProcessSetupIntent : StripeEntity<ReaderActionProcessSetupIntent>
    {
        /// <summary>
        /// ID of a card PaymentMethod generated from the card_present PaymentMethod that may be
        /// attached to a Customer for future transactions. Only present if it was possible to
        /// generate a card PaymentMethod.
        /// </summary>
        [JsonProperty("generated_card")]
        [STJS.JsonPropertyName("generated_card")]
        public string GeneratedCard { get; set; }

        /// <summary>
        /// Represents a per-setup override of a reader configuration.
        /// </summary>
        [JsonProperty("process_config")]
        [STJS.JsonPropertyName("process_config")]
        public ReaderActionProcessSetupIntentProcessConfig ProcessConfig { get; set; }

        #region Expandable SetupIntent

        /// <summary>
        /// (ID of the SetupIntent)
        /// Most recent SetupIntent processed by the reader.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public SetupIntent SetupIntent
        {
            get => this.InternalSetupIntent?.ExpandedObject;
            set => this.InternalSetupIntent = SetExpandableFieldObject(value, this.InternalSetupIntent);
        }

        [JsonProperty("setup_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupIntent>))]
        [STJS.JsonPropertyName("setup_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<SetupIntent>))]
        internal ExpandableField<SetupIntent> InternalSetupIntent { get; set; }
        #endregion
    }
}
