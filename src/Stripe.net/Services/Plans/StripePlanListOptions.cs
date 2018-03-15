using Newtonsoft.Json;

namespace Stripe
{
    public class StripePlanListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        /// <summary>
        /// Only return plans for the given product.
        /// </summary>
        [JsonProperty("product")]
        public string ProductId { get; set; }
    }
}
