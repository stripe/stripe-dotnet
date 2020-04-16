namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class Rule : StripeEntity<Rule>, IHasId
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The action taken on the payment.
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The predicate to evaluate the payment against.
        /// </summary>
        [JsonProperty("predicate")]
        public string Predicate { get; set; }
    }
}
