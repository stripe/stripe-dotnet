using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSubscriptionItemCreateOptions : SubscriptionItemSharedOptions, ISupportMetadata
    {
        /// <summary>
        /// REQUIRED: The identifier of the subscription to modify.
        /// </summary>
        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
