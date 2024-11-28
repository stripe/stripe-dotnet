// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class PersonVerificationDocument : StripeEntity<PersonVerificationDocument>
    {
        #region Expandable Back

        /// <summary>
        /// (ID of the File)
        /// The back of an ID returned by a <a href="https://stripe.com/docs/api#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string BackId
        {
            get => this.InternalBack?.Id;
            set => this.InternalBack = SetExpandableFieldId(value, this.InternalBack);
        }

        /// <summary>
        /// (Expanded)
        /// The back of an ID returned by a <a href="https://stripe.com/docs/api#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public File Back
        {
            get => this.InternalBack?.ExpandedObject;
            set => this.InternalBack = SetExpandableFieldObject(value, this.InternalBack);
        }

        [JsonProperty("back")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("back")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
#endif
        internal ExpandableField<File> InternalBack { get; set; }
        #endregion

        /// <summary>
        /// A user-displayable string describing the verification state of this document. For
        /// example, if a document is uploaded and the picture is too fuzzy, this may say "Identity
        /// document is too unclear to read".
        /// </summary>
        [JsonProperty("details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("details")]
#endif
        public string Details { get; set; }

        /// <summary>
        /// One of <c>document_corrupt</c>, <c>document_country_not_supported</c>,
        /// <c>document_expired</c>, <c>document_failed_copy</c>, <c>document_failed_other</c>,
        /// <c>document_failed_test_mode</c>, <c>document_fraudulent</c>,
        /// <c>document_failed_greyscale</c>, <c>document_incomplete</c>, <c>document_invalid</c>,
        /// <c>document_manipulated</c>, <c>document_missing_back</c>,
        /// <c>document_missing_front</c>, <c>document_not_readable</c>,
        /// <c>document_not_uploaded</c>, <c>document_photo_mismatch</c>, <c>document_too_large</c>,
        /// or <c>document_type_not_supported</c>. A machine-readable code specifying the
        /// verification state for this document.
        /// </summary>
        [JsonProperty("details_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("details_code")]
#endif
        public string DetailsCode { get; set; }

        #region Expandable Front

        /// <summary>
        /// (ID of the File)
        /// The front of an ID returned by a <a href="https://stripe.com/docs/api#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string FrontId
        {
            get => this.InternalFront?.Id;
            set => this.InternalFront = SetExpandableFieldId(value, this.InternalFront);
        }

        /// <summary>
        /// (Expanded)
        /// The front of an ID returned by a <a href="https://stripe.com/docs/api#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public File Front
        {
            get => this.InternalFront?.ExpandedObject;
            set => this.InternalFront = SetExpandableFieldObject(value, this.InternalFront);
        }

        [JsonProperty("front")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("front")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
#endif
        internal ExpandableField<File> InternalFront { get; set; }
        #endregion
    }
}
