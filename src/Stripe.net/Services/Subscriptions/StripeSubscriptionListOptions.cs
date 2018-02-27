using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSubscriptionListOptions : StripeListOptions
    {
        /// <summary>
        /// The billing mode of the subscriptions to retrieve. One of <see cref="StripeBilling" />.
        /// </summary>
        [JsonProperty("billing")]
        public StripeBilling? Billing { get; set; }

        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        /// <summary>
        /// The ID of the customer whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// The ID of the plan whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("plan")]
        public string PlanId { get; set; }

        /// <summary>
        /// The status of the subscriptions to retrieve. One of <see cref="StripeSubscriptionStatuses"/> or <c>all</c>. Passing in a value of <c>canceled</c> will return all canceled subscriptions, including those belonging to deleted customers. Passing in a value of <c>all</c> will return subscriptions of all statuses.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
