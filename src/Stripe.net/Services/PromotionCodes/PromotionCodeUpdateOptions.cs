namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PromotionCodeUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
