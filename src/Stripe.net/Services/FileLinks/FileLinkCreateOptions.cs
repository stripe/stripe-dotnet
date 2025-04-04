// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FileLinkCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The link isn't usable after this future timestamp.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The ID of the file. The file's <c>purpose</c> must be one of the following:
        /// <c>business_icon</c>, <c>business_logo</c>, <c>customer_signature</c>,
        /// <c>dispute_evidence</c>, <c>finance_report_run</c>, <c>financial_account_statement</c>,
        /// <c>identity_document_downloadable</c>, <c>issuing_regulatory_reporting</c>,
        /// <c>pci_document</c>, <c>selfie</c>, <c>sigma_scheduled_query</c>,
        /// <c>tax_document_user_upload</c>, or <c>terminal_reader_splashscreen</c>.
        /// </summary>
        [JsonProperty("file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("file")]
#endif
        public string File { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }
    }
}
