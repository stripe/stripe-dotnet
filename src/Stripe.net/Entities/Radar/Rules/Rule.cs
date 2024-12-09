namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class Rule : StripeEntity<Rule>, IHasId
    {
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        [JsonProperty("action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("action")]
#endif
        public string Action { get; set; }

        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif
        public bool? Deleted { get; set; }

        [JsonProperty("predicate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("predicate")]
#endif
        public string Predicate { get; set; }
    }
}
