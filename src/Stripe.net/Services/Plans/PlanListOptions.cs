// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return plans that are active or inactive (e.g., pass <c>false</c> to list all
        /// inactive plans).
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Only return plans for the given product.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
