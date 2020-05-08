namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("mandate")]
        public SourceMandateOptions Mandate { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("owner")]
        public SourceOwnerOptions Owner { get; set; }

        [JsonProperty("source_order")]
        public SourceSourceOrderOptions SourceOrder { get; set; }
    }
}
