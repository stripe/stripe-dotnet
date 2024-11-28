// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class DisputeEvidenceNotReceived : StripeEntity<DisputeEvidenceNotReceived>
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
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_documentation")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
#endif
        internal ExpandableField<File> InternalAdditionalDocumentation { get; set; }
        #endregion

        /// <summary>
        /// Date when the cardholder expected to receive the product.
        /// </summary>
        [JsonProperty("expected_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpectedAt { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("explanation")]
#endif
        public string Explanation { get; set; }

        /// <summary>
        /// Description of the merchandise or service that was purchased.
        /// </summary>
        [JsonProperty("product_description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_description")]
#endif
        public string ProductDescription { get; set; }

        /// <summary>
        /// Whether the product was a merchandise or service.
        /// One of: <c>merchandise</c>, or <c>service</c>.
        /// </summary>
        [JsonProperty("product_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_type")]
#endif
        public string ProductType { get; set; }
    }
}
