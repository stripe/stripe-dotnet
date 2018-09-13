namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EvidenceFraudulent : StripeEntity
    {
        [JsonProperty("dispute_explanation")]
        public string DisputeExplanation { get; set; }

        #region Expandable UncategorizedFile
        public string UncategorizedFileId { get; set; }

        [JsonIgnore]
        public FileUpload UncategorizedFile { get; set; }

        [JsonProperty("uncategorized_file")]
        internal object InternalUncategorizedFile
        {
            set
            {
                StringOrObject<FileUpload>.Map(value, s => this.UncategorizedFileId = s, o => this.UncategorizedFile = o);
            }
        }
        #endregion
    }
}