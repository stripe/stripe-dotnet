// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FileListOptions : ListOptions
    {
        /// <summary>
        /// Only return files that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Filter queries by the file purpose. If you don't provide a purpose, the queries return
        /// unfiltered files.
        /// One of: <c>account_requirement</c>, <c>additional_verification</c>,
        /// <c>business_icon</c>, <c>business_logo</c>, <c>customer_signature</c>,
        /// <c>dispute_evidence</c>, <c>document_provider_identity_document</c>,
        /// <c>finance_report_run</c>, <c>financial_account_statement</c>, <c>identity_document</c>,
        /// <c>identity_document_downloadable</c>, <c>issuing_regulatory_reporting</c>,
        /// <c>pci_document</c>, <c>platform_terms_of_service</c>, <c>selfie</c>,
        /// <c>sigma_scheduled_query</c>, <c>tax_document_user_upload</c>,
        /// <c>terminal_android_apk</c>, <c>terminal_reader_splashscreen</c>,
        /// <c>terminal_wifi_certificate</c>, or <c>terminal_wifi_private_key</c>.
        /// </summary>
        [JsonProperty("purpose")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purpose")]
#endif
        public string Purpose { get; set; }
    }
}
