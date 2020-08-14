namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FileLinkCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A future timestamp after which the link will no longer be usable.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The ID of the file. The file's <c>purpose</c> must be one of the following:
        /// <c>business_icon</c>, <c>business_logo</c>, <c>customer_signature</c>,
        /// <c>dispute_evidence</c>, <c>finance_report_run</c>, <c>pci_document</c>,
        /// <c>sigma_scheduled_query</c>, or <c>tax_document_user_upload</c>.
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
