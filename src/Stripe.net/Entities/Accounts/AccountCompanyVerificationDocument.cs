// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountCompanyVerificationDocument : StripeEntity<AccountCompanyVerificationDocument>
    {
        #region Expandable Back

        /// <summary>
        /// (ID of the File)
        /// The back of a document returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>additional_verification</c>. Note that
        /// <c>additional_verification</c> files are <a
        /// href="https://stripe.com/file-upload#uploading-a-file">not downloadable</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string BackId
        {
            get => this.InternalBack?.Id;
            set => this.InternalBack = SetExpandableFieldId(value, this.InternalBack);
        }

        /// <summary>
        /// (Expanded)
        /// The back of a document returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>additional_verification</c>. Note that
        /// <c>additional_verification</c> files are <a
        /// href="https://stripe.com/file-upload#uploading-a-file">not downloadable</a>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public File Back
        {
            get => this.InternalBack?.ExpandedObject;
            set => this.InternalBack = SetExpandableFieldObject(value, this.InternalBack);
        }

        [JsonProperty("back")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        [STJS.JsonPropertyName("back")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalBack { get; set; }
        #endregion

        /// <summary>
        /// A user-displayable string describing the verification state of this document.
        /// </summary>
        [JsonProperty("details")]
        [STJS.JsonPropertyName("details")]
        public string Details { get; set; }

        /// <summary>
        /// One of <c>document_corrupt</c>, <c>document_expired</c>, <c>document_failed_copy</c>,
        /// <c>document_failed_greyscale</c>, <c>document_failed_other</c>,
        /// <c>document_failed_test_mode</c>, <c>document_fraudulent</c>,
        /// <c>document_incomplete</c>, <c>document_invalid</c>, <c>document_manipulated</c>,
        /// <c>document_not_readable</c>, <c>document_not_uploaded</c>,
        /// <c>document_type_not_supported</c>, or <c>document_too_large</c>. A machine-readable
        /// code specifying the verification state for this document.
        /// </summary>
        [JsonProperty("details_code")]
        [STJS.JsonPropertyName("details_code")]
        public string DetailsCode { get; set; }

        #region Expandable Front

        /// <summary>
        /// (ID of the File)
        /// The front of a document returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>additional_verification</c>. Note that
        /// <c>additional_verification</c> files are <a
        /// href="https://stripe.com/file-upload#uploading-a-file">not downloadable</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string FrontId
        {
            get => this.InternalFront?.Id;
            set => this.InternalFront = SetExpandableFieldId(value, this.InternalFront);
        }

        /// <summary>
        /// (Expanded)
        /// The front of a document returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>additional_verification</c>. Note that
        /// <c>additional_verification</c> files are <a
        /// href="https://stripe.com/file-upload#uploading-a-file">not downloadable</a>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public File Front
        {
            get => this.InternalFront?.ExpandedObject;
            set => this.InternalFront = SetExpandableFieldObject(value, this.InternalFront);
        }

        [JsonProperty("front")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        [STJS.JsonPropertyName("front")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalFront { get; set; }
        #endregion
    }
}
