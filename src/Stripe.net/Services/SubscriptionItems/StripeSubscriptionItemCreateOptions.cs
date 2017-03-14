using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSubscriptionItemCreateOptions : SubscriptionItemSharedOptions
    {
        /// <summary>
        /// REQUIRED: The identifier of the subscription to modify.
        /// </summary>
        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }
    }
}