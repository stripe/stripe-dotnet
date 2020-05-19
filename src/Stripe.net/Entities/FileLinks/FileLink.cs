namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FileLink : StripeEntity<FileLink>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("expires_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        #region Expandable File

        [JsonIgnore]
        public string FileId
        {
            get => this.InternalFile?.Id;
            set => this.InternalFile = SetExpandableFieldId(value, this.InternalFile);
        }

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

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
