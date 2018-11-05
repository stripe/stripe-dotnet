namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FileLink : StripeEntity, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Whether this link is already expired.
        /// </summary>
        [JsonProperty("expired")]
        public bool Expired { get; set; }

        /// <summary>
        /// Time at which the link expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Has the value <code>true</code> if the object exists in live mode or the value
        /// <code>false</code> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable File

        /// <summary>
        /// ID of the file object this link points to.
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// The file object this link points to (if expanded).
        /// </summary>
        [JsonIgnore]
        public File File { get; set; }

        [JsonProperty("file")]
        internal object InternalFile
        {
            set
            {
                StringOrObject<File>.Map(value, s => this.FileId = s, o => this.File = o);
            }
        }
        #endregion

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
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
