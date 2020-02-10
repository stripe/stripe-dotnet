namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ValueListCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
