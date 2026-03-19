// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FileCreateOptions : BaseOptions
    {
        /// <summary>
        /// A file to upload. Make sure that the specifications follow RFC 2388, which defines file
        /// transfers for the <c>multipart/form-data</c> protocol.
        /// </summary>
        [JsonProperty("file")]
        [STJS.JsonPropertyName("file")]
        public MultipartFileContent File { get; set; }

        /// <summary>
        /// Optional parameters that automatically create a <a
        /// href="https://api.stripe.com#file_links">file link</a> for the newly created file.
        /// </summary>
        [JsonProperty("file_link_data")]
        [STJS.JsonPropertyName("file_link_data")]
        public FileFileLinkDataOptions FileLinkData { get; set; }

        /// <summary>
        /// The <a href="https://docs.stripe.com/file-upload#uploading-a-file">purpose</a> of the
        /// uploaded file.
        /// One of: <c>account_requirement</c>, <c>additional_verification</c>,
        /// <c>business_icon</c>, <c>business_logo</c>, <c>customer_signature</c>,
        /// <c>dispute_evidence</c>, <c>identity_document</c>, <c>issuing_regulatory_reporting</c>,
        /// <c>pci_document</c>, <c>platform_terms_of_service</c>, <c>tax_document_user_upload</c>,
        /// <c>terminal_android_apk</c>, <c>terminal_reader_splashscreen</c>,
        /// <c>terminal_wifi_certificate</c>, or <c>terminal_wifi_private_key</c>.
        /// </summary>
        [JsonProperty("purpose")]
        [STJS.JsonPropertyName("purpose")]
        public string Purpose { get; set; }
    }
}
