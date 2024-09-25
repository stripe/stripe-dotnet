// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class AlertFilterOptions : INestedOptions
    {
        /// <summary>
        /// Limit the scope to this alert only to this customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Limit the scope of this rated usage alert to this subscription.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// Limit the scope of this rated usage alert to this subscription item.
        /// </summary>
        [JsonProperty("subscription_item")]
        public string SubscriptionItem { get; set; }
    }
}
