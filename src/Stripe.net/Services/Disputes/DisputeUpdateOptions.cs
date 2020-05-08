namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DisputeUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("evidence")]
        public EvidenceOptions Evidence { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("submit")]
        public bool? Submit { get; set; }
    }
}
