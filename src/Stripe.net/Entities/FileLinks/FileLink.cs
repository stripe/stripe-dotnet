namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FileLink : StripeEntity<FileLink>, IHasId, IHasMetadata, IHasObject
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
        /// Whether this link is already expired.
        /// </summary>
        [JsonProperty("expired")]
        public bool Expired { get; set; }

        /// <summary>
        /// Time at which the link expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        #region Expandable File

        /// <summary>
        /// (ID of the File)
        /// The file object this link points to.
        /// </summary>
        [JsonIgnore]
        public string FileId
        {
            get => this.InternalFile?.Id;
            set => this.InternalFile = SetExpandableFieldId(value, this.InternalFile);
        }

        /// <summary>
        /// (Expanded)
        /// The file object this link points to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File File
        {
            get => this.InternalFile?.ExpandedObject;
            set => this.InternalFile = SetExpandableFieldObject(value, this.InternalFile);
        }

        [JsonProperty("file")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalFile { get; set; }
        #endregion

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The publicly accessible URL to download the file.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
