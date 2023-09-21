// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class FileListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Filter queries by the file purpose. If you don't provide a purpose, the queries return
        /// unfiltered files.
        /// One of: <c>account_requirement</c>, <c>additional_verification</c>,
        /// <c>business_icon</c>, <c>business_logo</c>, <c>customer_signature</c>,
        /// <c>dispute_evidence</c>, <c>document_provider_identity_document</c>,
        /// <c>finance_report_run</c>, <c>identity_document</c>,
        /// <c>identity_document_downloadable</c>, <c>pci_document</c>, <c>selfie</c>,
        /// <c>sigma_scheduled_query</c>, <c>tax_document_user_upload</c>, or
        /// <c>terminal_reader_splashscreen</c>.
        /// </summary>
        [JsonProperty("purpose")]
        public string Purpose { get; set; }
    }
}
