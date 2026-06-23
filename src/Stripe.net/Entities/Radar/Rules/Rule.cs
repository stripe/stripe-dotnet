namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class Rule : StripeEntity<Rule>, IHasId
    {
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        [JsonProperty("predicate")]
        [STJS.JsonPropertyName("predicate")]
        public string Predicate { get; set; }
    }
}
