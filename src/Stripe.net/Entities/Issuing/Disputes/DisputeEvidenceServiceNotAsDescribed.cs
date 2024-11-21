// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidenceServiceNotAsDescribed : StripeEntity<DisputeEvidenceServiceNotAsDescribed>
    {
        #region Expandable AdditionalDocumentation

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string AdditionalDocumentationId
        {
            get => this.InternalAdditionalDocumentation?.Id;
            set => this.InternalAdditionalDocumentation = SetExpandableFieldId(value, this.InternalAdditionalDocumentation);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public File AdditionalDocumentation
        {
            get => this.InternalAdditionalDocumentation?.ExpandedObject;
            set => this.InternalAdditionalDocumentation = SetExpandableFieldObject(value, this.InternalAdditionalDocumentation);
        }

        [JsonProperty("additional_documentation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_documentation")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
#endif

        internal ExpandableField<File> InternalAdditionalDocumentation { get; set; }
        #endregion

        /// <summary>
        /// Date when order was canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Reason for canceling the order.
        /// </summary>
        [JsonProperty("cancellation_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_reason")]
#endif

        public string CancellationReason { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("explanation")]
#endif

        public string Explanation { get; set; }

        /// <summary>
        /// Date when the product was received.
        /// </summary>
        [JsonProperty("received_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? ReceivedAt { get; set; }
    }
}
