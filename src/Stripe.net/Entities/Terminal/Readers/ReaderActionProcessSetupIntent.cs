// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReaderActionProcessSetupIntent : StripeEntity<ReaderActionProcessSetupIntent>
    {
        /// <summary>
        /// ID of a card PaymentMethod generated from the card_present PaymentMethod that may be
        /// attached to a Customer for future transactions. Only present if it was possible to
        /// generate a card PaymentMethod.
        /// </summary>
        [JsonProperty("generated_card")]
        public string GeneratedCard { get; set; }

        /// <summary>
        /// Represents a per-setup override of a reader configuration.
        /// </summary>
        [JsonProperty("process_config")]
        public ReaderActionProcessSetupIntentProcessConfig ProcessConfig { get; set; }

        #region Expandable SetupIntent

        /// <summary>
        /// (ID of the SetupIntent)
        /// Most recent SetupIntent processed by the reader.
        /// </summary>
        [JsonIgnore]
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
        public SetupIntent SetupIntent
        {
            get => this.InternalSetupIntent?.ExpandedObject;
            set => this.InternalSetupIntent = SetExpandableFieldObject(value, this.InternalSetupIntent);
        }

        [JsonProperty("setup_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupIntent>))]
        internal ExpandableField<SetupIntent> InternalSetupIntent { get; set; }
        #endregion
    }
}
