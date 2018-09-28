namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanListOptions : ListOptionsWithCreated
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Only return plans for the given product.
        /// </summary>
        [JsonProperty("product")]
        public string ProductId { get; set; }
    }
}
