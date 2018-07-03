using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOutcomeRule : StripeEntityWithId
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("predicate")]
        public string Predicate { get; set; }
    }
}
