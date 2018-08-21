namespace Stripe
{
    using Newtonsoft.Json;

    public class OutcomeRule : StripeEntityWithId
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("predicate")]
        public string Predicate { get; set; }
    }
}
