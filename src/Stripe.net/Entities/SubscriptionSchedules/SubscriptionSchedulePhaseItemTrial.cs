// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseItemTrial : StripeEntity<SubscriptionSchedulePhaseItemTrial>
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
