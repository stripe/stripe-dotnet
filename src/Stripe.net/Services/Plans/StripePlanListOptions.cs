namespace Stripe
{
    using Newtonsoft.Json;

    public class StripePlanListOptions : StripeListOptions
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        /// <summary>
        /// Only return plans for the given product.
        /// </summary>
        [JsonProperty("product")]
        public string ProductId { get; set; }
    }
}
