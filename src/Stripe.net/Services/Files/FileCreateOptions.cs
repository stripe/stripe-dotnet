namespace Stripe
{
    using System.IO;
    using Newtonsoft.Json;

    public class FileCreateOptions : BaseOptions
    {
        /// <summary>
        /// REQUIRED. A file to upload. The file should follow the specifications of RFC 2388
        /// (which defines file transfers for the <c>multipart/form-data</c> protocol).
        /// </summary>
        [JsonProperty("file")]
        public Stream File { get; set; }

        /// <summary>
        /// REQUIRED. The purpose of the uploaded file. Possible values are <c>business_logo</c>,
        /// <c>customer_signature</c>, <c>dispute_evidence</c>, <c>identity_document</c>,
        /// <c>pci_document</c>, or <c>tax_document_user_upload</c>
        /// </summary>
        [JsonProperty("purpose")]
        public string Purpose { get; set; }
    }
}
