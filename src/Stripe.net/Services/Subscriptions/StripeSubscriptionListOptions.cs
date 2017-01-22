using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSubscriptionListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// The status of the subscriptions to retrieve. You can specify "all" or one of the <see cref="StripeSubscriptionStatuses"/>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}