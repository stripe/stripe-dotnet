using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSubscriptionItemOption : INestedOptions
    {
        /// <summary>
        /// Plan ID for this item.
        /// </summary>
        [JsonProperty("plan")]
        public string PlanId { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
}
