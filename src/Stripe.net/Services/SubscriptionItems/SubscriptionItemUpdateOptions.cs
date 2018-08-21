namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionItemUpdateOptions : SubscriptionItemSharedOptions, ISupportMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
