namespace Stripe
{
    using Newtonsoft.Json;

    public class OutcomeRule : StripeEntity<OutcomeRule>, IHasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("predicate")]
        public string Predicate { get; set; }
    }
}
