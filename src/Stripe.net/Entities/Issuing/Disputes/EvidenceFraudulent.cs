namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EvidenceFraudulent : StripeEntity<EvidenceFraudulent>
    {
        [JsonProperty("dispute_explanation")]
        public string DisputeExplanation { get; set; }

        #region Expandable UncategorizedFile
        [JsonIgnore]
        public string UncategorizedFileId
        {
            get => this.InternalUncategorizedFile?.Id;
            set => this.InternalUncategorizedFile = SetExpandableFieldId(value, this.InternalUncategorizedFile);
        }

        [JsonIgnore]
        public File UncategorizedFile
        {
            get => this.InternalUncategorizedFile?.ExpandedObject;
            set => this.InternalUncategorizedFile = SetExpandableFieldObject(value, this.InternalUncategorizedFile);
        }

        [JsonProperty("uncategorized_file")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalUncategorizedFile { get; set; }
        #endregion
    }
}
