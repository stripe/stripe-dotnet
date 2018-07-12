using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSubscriptionItemUpdateOptions : SubscriptionItemSharedOptions, ISupportMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
