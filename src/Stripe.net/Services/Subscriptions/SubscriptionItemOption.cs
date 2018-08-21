namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemOption : INestedOptions
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
