namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
