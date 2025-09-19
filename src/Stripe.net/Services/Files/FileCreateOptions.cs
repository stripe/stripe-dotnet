// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FileCreateOptions : BaseOptions
    {
        /// <summary>
        /// A file to upload. Make sure that the specifications follow RFC 2388, which defines file
        /// transfers for the <c>multipart/form-data</c> protocol.
        /// </summary>
        [JsonProperty("file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("file")]
#endif
        public MultipartFileContent File { get; set; }

        /// <summary>
        /// Optional parameters that automatically create a <a
        /// href="https://stripe.com/docs/api#file_links">file link</a> for the newly created file.
        /// </summary>
        [JsonProperty("file_link_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("file_link_data")]
#endif
        public FileFileLinkDataOptions FileLinkData { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/file-upload#uploading-a-file">purpose</a> of the
        /// uploaded file.
        /// One of: <c>account_requirement</c>, <c>additional_verification</c>,
        /// <c>business_icon</c>, <c>business_logo</c>, <c>customer_signature</c>,
        /// <c>dispute_evidence</c>, <c>identity_document</c>, <c>issuing_regulatory_reporting</c>,
        /// <c>pci_document</c>, <c>tax_document_user_upload</c>, <c>terminal_android_apk</c>, or
        /// <c>terminal_reader_splashscreen</c>.
        /// </summary>
        [JsonProperty("purpose")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purpose")]
#endif
        public string Purpose { get; set; }
    }
}
