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
        public string UncategorizedFileId { get; set; }

        [JsonIgnore]
        public File UncategorizedFile { get; set; }

        [JsonProperty("uncategorized_file")]
        internal object InternalUncategorizedFile
        {
            get
            {
                return this.UncategorizedFile ?? (object)this.UncategorizedFileId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.UncategorizedFileId = s, o => this.UncategorizedFile = o);
            }
        }
        #endregion
    }
}
