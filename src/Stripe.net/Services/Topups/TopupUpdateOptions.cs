namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TopupUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
