namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class File : StripeEntity<File>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A filename for the file, suitable for saving to a filesystem.
        /// </summary>
        [JsonProperty("filename")]
        public string Filename { get; set; }

        /// <summary>
        /// A list of <a href="https://stripe.com/docs/api#file_links">file links</a> that point at
        /// this file.
        /// </summary>
        [JsonProperty("links")]
        public StripeList<FileLink> Links { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/file-upload#uploading-a-file">purpose</a> of the
        /// uploaded file.
        /// One of: <c>additional_verification</c>, <c>business_icon</c>, <c>business_logo</c>,
        /// <c>customer_signature</c>, <c>dispute_evidence</c>, <c>identity_document</c>,
        /// <c>pci_document</c>, or <c>tax_document_user_upload</c>.
        /// </summary>
        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// The size in bytes of the file object.
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; }

        /// <summary>
        /// A user friendly title for the document.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The type of the file returned (e.g., <c>csv</c>, <c>pdf</c>, <c>jpg</c>, or <c>png</c>).
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The URL from which the file can be downloaded using your live secret API key.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
