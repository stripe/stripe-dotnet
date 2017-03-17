using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSubscriptionItemOption : INestedOptions
    {
        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
}