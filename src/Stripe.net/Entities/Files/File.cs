// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This object represents files hosted on Stripe's servers. You can upload files with the
    /// <a href="https://stripe.com/docs/api#create_file">create file</a> request (for example,
    /// when uploading dispute evidence). Stripe also creates files independently (for example,
    /// the results of a <a href="https://stripe.com/docs/api#scheduled_queries">Sigma scheduled
    /// query</a>).
    ///
    /// Related guide: <a href="https://stripe.com/docs/file-upload">File upload guide</a>.
    /// </summary>
    public class File : StripeEntity<File>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The file expires and isn't available at this time in epoch seconds.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The suitable name for saving the file to a filesystem.
        /// </summary>
        [JsonProperty("filename")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("filename")]
#endif
        public string Filename { get; set; }

        /// <summary>
        /// A list of <a href="https://stripe.com/docs/api#file_links">file links</a> that point at
        /// this file.
        /// </summary>
        [JsonProperty("links")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("links")]
#endif
        public StripeList<FileLink> Links { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/file-upload#uploading-a-file">purpose</a> of the
        /// uploaded file.
        /// One of: <c>account_requirement</c>, <c>additional_verification</c>,
        /// <c>business_icon</c>, <c>business_logo</c>, <c>customer_signature</c>,
        /// <c>dispute_evidence</c>, <c>document_provider_identity_document</c>,
        /// <c>finance_report_run</c>, <c>financial_account_statement</c>, <c>identity_document</c>,
        /// <c>identity_document_downloadable</c>, <c>issuing_regulatory_reporting</c>,
        /// <c>pci_document</c>, <c>selfie</c>, <c>sigma_scheduled_query</c>,
        /// <c>tax_document_user_upload</c>, or <c>terminal_reader_splashscreen</c>.
        /// </summary>
        [JsonProperty("purpose")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purpose")]
#endif
        public string Purpose { get; set; }

        /// <summary>
        /// The size of the file object in bytes.
        /// </summary>
        [JsonProperty("size")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("size")]
#endif
        public long Size { get; set; }

        /// <summary>
        /// A suitable title for the document.
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }

        /// <summary>
        /// The returned file type (for example, <c>csv</c>, <c>pdf</c>, <c>jpg</c>, or <c>png</c>).
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Use your live secret API key to download the file from this URL.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
