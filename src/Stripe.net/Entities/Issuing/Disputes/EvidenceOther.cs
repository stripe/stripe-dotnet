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
        public string UncategorizedFileId => this.InternalUncategorizedFile.Id;

        [JsonIgnore]
        public File UncategorizedFile => this.InternalUncategorizedFile.ExpandedObject;

        [JsonProperty("uncategorized_file")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalUncategorizedFile { get; set; }
        #endregion
    }
}
