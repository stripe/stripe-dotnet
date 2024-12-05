// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemListOptions : ListOptions
    {
        /// <summary>
        /// The ID of the subscription whose items will be retrieved.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
