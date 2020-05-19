namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DisputeUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("evidence")]
        public DisputeEvidenceOptions Evidence { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("submit")]
        public bool? Submit { get; set; }
    }
}
