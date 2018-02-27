using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeSubscriptionItemUpdateOptions : SubscriptionItemSharedOptions, ISupportMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
