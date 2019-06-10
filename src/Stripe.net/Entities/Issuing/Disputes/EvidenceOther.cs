namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EvidenceOther : StripeEntity<EvidenceOther>
    {
        [JsonProperty("dispute_explanation")]
        public string DisputeExplanation { get; set; }

        #region Expandable UncategorizedFile
        [JsonIgnore]
        public string UncategorizedFileId
        {
            get => this.InternalUncategorizedFile.Id;
            set => this.InternalUncategorizedFile.Id = value;
        }

        [JsonIgnore]
        public File UncategorizedFile
        {
            get => this.InternalUncategorizedFile.ExpandedObject;
            set => this.InternalUncategorizedFile.ExpandedObject = value;
        }

        [JsonProperty("uncategorized_file")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalUncategorizedFile { get; set; }
        #endregion
    }
}
