namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ValueListSharedOptions : BaseOptions
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
